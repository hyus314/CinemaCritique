namespace CinemaCritique.Core.Contracts
{
    using CinemaCritique.Data.Models;
    using CinemaCritique.ViewModels.Review;
    public interface IReviewService
    {
        public Task<string> AddReviewAsync(AddReviewViewModel model);
        public Task<ICollection<MovieReviewViewModel>> GetReviewsForMovie(string movieId);
        public Task<bool> DidUserWriteThisReview(string reviewId, CritiqueUser user);
    }
}
