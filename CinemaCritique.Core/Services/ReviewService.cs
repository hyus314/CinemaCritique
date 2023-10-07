namespace CinemaCritique.Core.Services
{
    using CinemaCritique.Core.Contracts;
    using CinemaCritique.Data;
    using CinemaCritique.Data.Models;
    using CinemaCritique.Security;
    using CinemaCritique.ViewModels.Review;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Net;

    using static CinemaCritique.Common.ResultMessages.Review;
    public class ReviewService : IReviewService
    {
        private readonly CritiqueDbContext data;
        private readonly MovieDataProtector dataProtector;
        public ReviewService(CritiqueDbContext data, MovieDataProtector dataProtector)
        {
            this.data = data;
            this.dataProtector = dataProtector;
        }
        public async Task<string> AddReviewAsync(AddReviewViewModel model)
        {
            string message = String.Empty;

            if (string.IsNullOrEmpty(model.Content) || string.IsNullOrWhiteSpace(model.Content))
            {
                throw new InvalidDataException(FailedContentIsNull);
            }

            if (model.Rating == 0)
            {
                throw new InvalidOperationException(FailedRatingIsZero);
            }

            if (model.Rating > 10)
            {
                throw new InvalidOperationException(FailedRatingMoreThanTen);
            }

            if (this.data.Users.FirstOrDefaultAsync(x => x.Id == model.UserId) == null)
            {
                throw new InvalidOperationException(FailedUserIdNull);
            }

            if (string.IsNullOrEmpty(model.MovieId) || string.IsNullOrWhiteSpace(model.MovieId))
            {
                throw new InvalidOperationException(FailedMovieIdNull);
            }

            var content = WebUtility.HtmlEncode(model.Content);

            try
            {
                var review = new Review()
                {
                    UserId = model.UserId,
                    DatePublished = DateTime.Now,
                    MovieId = dataProtector.Decrypt(model.MovieId),
                    Content = content,
                    Rating = model.Rating
                };
                await this.data.Reviews.AddAsync(review);
                await this.data.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception(FailedCannotSaveReview);
            }
            return SuccessfullyAddedReview;
        }

        public async Task<ICollection<MovieReviewViewModel>> GetReviewsForMovie(string movieId)
        {
            var decryptedMovieId = this.dataProtector.Decrypt(movieId);

            ICollection<MovieReviewViewModel> reviews;

            if (this.data.Reviews.Where(x => x.MovieId == decryptedMovieId).Count() >= 5)
            {
                 reviews = await this.data.Reviews
                    .AsNoTracking()
                    .Where(r => r.MovieId == decryptedMovieId)
                    .OrderByDescending(x => x.DatePublished)
                    .Select(x => new MovieReviewViewModel()
                    {
                        Username = x.User.UserName,
                        DatePublished = x.DatePublished.ToString("D"),
                        Rating = x.Rating,
                        Content = x.Content,
                    })
                    .Take(5)
                    .ToArrayAsync();
            }
            else
            {
                 reviews = await this.data.Reviews
                    .AsNoTracking()
                    .Where(r => r.MovieId == decryptedMovieId)
                    .OrderByDescending(x => x.DatePublished)
                    .Select(x => new MovieReviewViewModel()
                    {
                        Username = x.User.UserName,
                        DatePublished = x.DatePublished.ToString("D"),
                        Rating = x.Rating,
                        Content = x.Content,
                    })
                    .ToArrayAsync();

            }

            return reviews;
        }
    }
}
