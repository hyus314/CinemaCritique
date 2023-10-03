namespace CinemaCritique.Core.Contracts
{
    using CinemaCritique.ViewModels.Review;
    public interface IReviewService
    {
        public Task<string> AddReviewAsync(AddReviewViewModel model);
    }
}
