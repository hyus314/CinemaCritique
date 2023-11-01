namespace CinemaCritique.Core.Contracts
{
    using CinemaCritique.Data.Models;
    using CinemaCritique.ViewModels.Review;
    public interface IReviewService
    {
        public Task<string> AddReviewAsync(AddReviewViewModel model);
        public Task<ReviewsForMovieViewModel> GetReviewsForMovie(string movieId, int page);
        public Task<bool> DidUserWriteThisReview(string reviewId, CritiqueUser user);

        public Task DeleteReviewAsync(string reviewId, string userId);
        public Task<EditReviewViewModel> GetEditReviewModelAsync(string reviewId, string userId);
        public Task<string> EditReviewAsync(EditReviewViewModel model, string userId);

        public Task<int> GetTotalPagesForReviews(string movieId);
    }
}
