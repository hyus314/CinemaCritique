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
        //This Context Factory ensures that after every single HTTP request a fresh object of our database is created.
        //This way there are no collisions in the database and one user can submit more than one review without a problem.

        private readonly CritiqueDbContext data;
        private readonly CritiqueDbContextFactory dataFactory;
        private readonly MovieDataProtector dataProtector;
        public ReviewService(CritiqueDbContext data, MovieDataProtector dataProtector, CritiqueDbContextFactory dataFactory)
        {
            this.data = data;
            this.dataProtector = dataProtector;
            this.dataFactory = dataFactory;

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

            Review review;

            try
            {
                review = new Review()
                {
                    UserId = model.UserId,
                    DatePublished = DateTime.Now,
                    MovieId = dataProtector.Decrypt(model.MovieId),
                    Content = content,
                    Rating = model.Rating
                };

            }
            catch (Exception)
            {
                throw new InvalidProgramException(FailedCannotCreateReview);
            }
            try
            {
                using var context = dataFactory.Create();
                await context.Reviews.AddAsync(review);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
                       ReviewId = this.dataProtector.Encrypt(x.Id),
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
                       ReviewId = this.dataProtector.Encrypt(x.Id),
                       Username = x.User.UserName,
                       DatePublished = x.DatePublished.ToString("D"),
                       Rating = x.Rating,
                       Content = x.Content,
                   })
                   .ToArrayAsync();

            }

            return reviews;
        }

        public async Task<bool> DidUserWriteThisReview(string reviewId, CritiqueUser user)
        {
            if (string.IsNullOrWhiteSpace(reviewId) || user == null)
            {
                return false;
            }

            var decryptedId = this.dataProtector.Decrypt(reviewId);

            if (decryptedId == 0 || await this.data.Reviews.FirstOrDefaultAsync(x => x.Id == decryptedId) == null)
            {
                return false;
            }


            if (user.Reviews != null && user.Reviews.Any(x => x.Id == decryptedId))
            {
                return true;
            }

            return false;
        }
    }
}
