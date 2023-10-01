namespace CinemaCritique.Core.Services
{
    using CinemaCritique.Core.Contracts;
    using CinemaCritique.Data;
    using CinemaCritique.Data.Models;
    using CinemaCritique.Security;
    using CinemaCritique.ViewModels.Review;
    public class ReviewService : IReviewService
    {
        private readonly CritiqueDbContext data;
        private readonly MovieDataProtector dataProtector;
        public ReviewService(CritiqueDbContext data, MovieDataProtector dataProtector)
        {
            this.data = data;
            this.dataProtector = dataProtector;
        }
        public async Task AddReview(AddReviewViewModel model)
        {
            var review = new Review()
            {
                UserId = model.UserId,
                MovieId = dataProtector.Decrypt(model.MovieId),
                Content = model.Content,
                Rating = model.Rating
            };

            await this.data.Reviews.AddAsync(review);
            await this.data.SaveChangesAsync();
        }
    }
}
