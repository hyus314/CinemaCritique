namespace CinemaCritique.Core.Services
{
    using CinemaCritique.Core.Contracts;
    using CinemaCritique.Data;
    using CinemaCritique.Data.Models;
    using CinemaCritique.Security;
    using CinemaCritique.ViewModels.Review;
    using System.Net;

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
            var content = WebUtility.HtmlEncode(model.Content);

            var review = new Review()
            {
                UserId = model.UserId,
                DatePublished = DateTime.UtcNow,
                MovieId = dataProtector.Decrypt(model.MovieId),
                Content = content,
                Rating = model.Rating
            };

            await this.data.Reviews.AddAsync(review);
            await this.data.SaveChangesAsync();
        }
    }
}
