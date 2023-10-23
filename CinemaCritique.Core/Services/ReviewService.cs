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
        private readonly MovieDataProtector movieDataProtector;
        private readonly ReviewDataProtector reviewDataProtector;

        public ReviewService(CritiqueDbContext data, MovieDataProtector movieDataProtector, ReviewDataProtector reviewDataProtector)
        {
            this.data = data;
            this.movieDataProtector = movieDataProtector;
            this.reviewDataProtector = reviewDataProtector;
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
                Review review = new Review()
                {
                    UserId = model.UserId,
                    DatePublished = DateTime.Now,
                    MovieId = movieDataProtector.Decrypt(model.MovieId),
                    Content = content,
                    Rating = model.Rating
                };

                await this.data.Reviews.AddAsync(review);
                await this.data.SaveChangesAsync();

            }
            catch (Exception)
            {
                throw new InvalidProgramException(FailedCannotCreateReview);
            }
            return SuccessfullyAddedReview;
        }

        public async Task<ICollection<MovieReviewViewModel>> GetReviewsForMovie(string movieId)
        {
            var decryptedMovieId = this.movieDataProtector.Decrypt(movieId);

            ICollection<MovieReviewViewModel> reviews;

            if (this.data.Reviews.Where(x => x.MovieId == decryptedMovieId).Count() >= 5)
            {
                reviews = await this.data.Reviews
                   .AsNoTracking()
                   .Where(r => r.MovieId == decryptedMovieId)
                   .OrderByDescending(x => x.DatePublished)
                   .Select(x => new MovieReviewViewModel()
                   {
                       MovieId = this.movieDataProtector.Encrypt(x.Id),
                       ReviewId = this.reviewDataProtector.Encrypt(x.Id),
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
                       MovieId = this.movieDataProtector.Encrypt(x.Id),
                       ReviewId = this.reviewDataProtector.Encrypt(x.Id),
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

            var decryptedId = this.movieDataProtector.Decrypt(reviewId);

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

        public async Task DeleteReviewAsync(string reviewId, string userId)
        {
            var decryptedReviewId = this.reviewDataProtector.Decrypt(reviewId);
            var review = await this.data.Reviews.FirstOrDefaultAsync(x => x.Id == decryptedReviewId);
            var user = await this.data.Users.FirstOrDefaultAsync(x => x.Id == userId);

            if (review == null)
            {
                throw new InvalidOperationException(FailedReviewDoesNotExist);
            }

            if (user == null)
            {
                throw new InvalidOperationException(FailedUserDoesNotExist);
            }

            if (review.UserId != user.Id)
            {
                throw new InvalidOperationException(FailedReviewDoesNotBelongToUser);
            }

            this.data.Reviews.Remove(review);
            await this.data.SaveChangesAsync();
        }
    }
}
