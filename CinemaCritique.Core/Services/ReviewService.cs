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

            if (model.Rating <= 0)
            {
                throw new InvalidOperationException(FailedRatingIsZero);
            }

            if (model.Rating > 10)
            {
                throw new InvalidOperationException(FailedRatingMoreThanTen);
            }

            if (await this.data.Users.FirstOrDefaultAsync(x => x.Id == model.UserId) == null)
            {
                throw new InvalidOperationException(FailedUserIdNull);
            }

            if (string.IsNullOrEmpty(model.MovieId) || string.IsNullOrWhiteSpace(model.MovieId))
            {
                throw new InvalidOperationException(FailedMovieIdNull);
            }

            if (model.Content.Length > 300)
            {
                throw new InvalidOperationException(FailedContentExceeds300Characters);
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

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw new InvalidProgramException("When Adding");
            }
            try
            {
                await this.data.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new InvalidProgramException("When saving");
            }
            return SuccessfullyAddedReview;
        }

        public async Task<ReviewsForMovieViewModel> GetReviewsForMovie(string movieId, int page)
        {

            var decryptedMovieId = this.movieDataProtector.Decrypt(movieId);

            int pageSize = 4;

            var reviewsQuery = this.data.Reviews
                .AsNoTracking()
                .Where(r => r.MovieId == decryptedMovieId)
                .OrderByDescending(x => x.DatePublished);

            var totalReviews = await reviewsQuery.CountAsync();
            var totalPages = (int)Math.Ceiling((double)totalReviews / pageSize);

            var reviews = await reviewsQuery
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(x => new MovieReviewViewModel()
                {
                    MovieId = this.movieDataProtector.Encrypt(x.MovieId),
                    ReviewId = this.reviewDataProtector.Encrypt(x.Id),
                    Username = x.User.UserName,
                    DatePublished = x.DatePublished.ToString("D"),
                    Rating = x.Rating,
                    Content = x.Content,
                })
                .ToArrayAsync();

            return new ReviewsForMovieViewModel()
            {
                MovieId = movieId,
                Reviews = reviews
            };
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

        public async Task<EditReviewViewModel> GetEditReviewModelAsync(string reviewId, string userId)
        {
            var decryptedId = this.reviewDataProtector.Decrypt(reviewId);

            var review = await this.data.Reviews.FirstOrDefaultAsync(x => x.Id == decryptedId);

            if (review == null)
            {
                throw new InvalidOperationException(FailedReviewDoesNotExist);
            }

            if (review.UserId != userId)
            {
                throw new InvalidOperationException(FailedReviewDoesNotBelongToUser);
            }

            if (string.IsNullOrEmpty(userId) || string.IsNullOrWhiteSpace(userId))
            {
                throw new InvalidOperationException(FailedUserIdNull);
            }

            return new EditReviewViewModel()
            {
                ReviewId = reviewId,
                ReviewRating = review.Rating,
                ReviewText = review.Content
            };

        }

        public async Task<string> EditReviewAsync(EditReviewViewModel model, string userId)
        {
            var decryptedId = this.reviewDataProtector.Decrypt(model.ReviewId);
            var review = await this.data.Reviews.FirstOrDefaultAsync(x => x.Id == decryptedId);

            if (review == null)
            {
                throw new ArgumentNullException(FailedReviewDoesNotExist);
            }

            if (review.UserId != userId)
            {
                throw new InvalidOperationException(FailedReviewDoesNotBelongToUser);
            }

            if (review.Content == model.ReviewText && review.Rating == model.ReviewRating)
            {
                throw new InvalidOperationException(FailedReviewContentIsTheSame);
            }

            if (model.ReviewRating <= 0)
            {
                throw new InvalidOperationException(FailedRatingIsZero);
            }

            if (model.ReviewRating > 10)
            {
                throw new InvalidOperationException(FailedRatingMoreThanTen);
            }

            if (string.IsNullOrWhiteSpace(model.ReviewText))
            {
                throw new InvalidOperationException(FailedContentIsNull);
            }

            if (model.ReviewText.Length > 300)
            {
                throw new InvalidOperationException(FailedContentExceeds300Characters);
            }

            review.Content = WebUtility.HtmlEncode(model.ReviewText);
            review.Rating = (byte)model.ReviewRating;


            await this.data.SaveChangesAsync();

            return SuccessfullyEditedReview;
        }

        public async Task<int> GetTotalPagesForReviews(string movieId)
        {
            var decryptedMovieId = this.movieDataProtector.Decrypt(movieId);
            var reviews = await this.data.Reviews.Where(x => x.MovieId == decryptedMovieId).ToListAsync();
            var totalReviews = reviews.Count;

            var pageSize = 4;
            var totalPages = (int)Math.Ceiling((double)totalReviews / pageSize);
            return totalPages;

        }
    }
}
