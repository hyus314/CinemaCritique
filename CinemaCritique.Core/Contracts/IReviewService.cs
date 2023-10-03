namespace CinemaCritique.Core.Contracts
{
    using CinemaCritique.ViewModels.Review;
    public interface IReviewService
    {
        public Task AddReviewAsync(AddReviewViewModel model);
    }
}
