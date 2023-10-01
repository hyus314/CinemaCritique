namespace CinemaCritique.Core.Contracts
{
    using CinemaCritique.ViewModels.Review;
    public interface IReviewService
    {
        public Task AddReview(AddReviewViewModel model);
    }
}
