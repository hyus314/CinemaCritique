using CinemaCritique.Core.Contracts;
using CinemaCritique.Data;
using CinemaCritique.ViewModels.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace CinemaCritique.Core.Services
{
    public class AccountService : IAccountService
    {
        private readonly CritiqueDbContext data;
        public AccountService(CritiqueDbContext data)
        {
            this.data = data;
        }
        public async Task<ProfileViewModel> GetProfileViewModelAsync(string userId)
        {
            var user = await this.data.Users.FindAsync(userId) ?? throw new InvalidOperationException("User is invalid");


            var userFullName = $"{user.FirstName} {user.LastName}";

            var watchlistItemsCount = this.data.WatchListItems
                .Where(x => x.UserId == userId)
                .Count();

            var numberOfReviews = this.data.Reviews
                .Where(x => x.UserId == userId)
                .Count();

            var averageStarRating = Math.Round(this.data.Reviews
                .Where(x => x.UserId == userId)
                .Average(x => x.Rating), 1);

            var profilePicture = user.ProfilePicture == null ? string.Empty : Convert.ToBase64String(user.ProfilePicture);

            var genres = await this.data.WatchListItems
                .Where(x => x.UserId == userId)
                .Select(x => x.Movie.Genre.Name)
                .ToArrayAsync();

            var mostCommonGenre = genres
                .GroupBy(x => x)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault();

            var mostCommonGenreName = mostCommonGenre == null ? "None" : mostCommonGenre.Key;

            var viewModel = new ProfileViewModel()
            {
                FavouriteGenre = mostCommonGenreName,
                CritiquePoints = user.CritiquePoints,
                WatchlistItemsCount = watchlistItemsCount,
                NumberOfReviews = numberOfReviews,
                AverageStarRating = averageStarRating,
                FullName = userFullName,
                UserName = user.UserName,
                JoinedDate = user.JoinedDate.ToString("dd MMMM yyyy"),
                ProfilePictureBase64 = profilePicture
            };

            return viewModel;
        }

        public Task<string> UpdateProfilePictureAsync(IFormFile photoData)
        {
            throw new NotImplementedException();
        }
    }
}
