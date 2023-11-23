
namespace CinemaCritique.Core.Services
{
    using CinemaCritique.Core.Contracts;
    using CinemaCritique.Data;
    using CinemaCritique.ViewModels.Account;
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore;

    using static CinemaCritique.Common.ResultMessages.Account;
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
                ProfilePictureBase64 = profilePicture,
                UserId = userId,
            };

            return viewModel;
        }

        public async Task<string> UpdateProfilePictureAsync(IFormFile photoData, string profileUserId, string currentUserId)
        {
            var user = await this.data.Users.FindAsync(currentUserId);
            if (await this.data.Users.FindAsync(profileUserId) == null ||
                user == null) 
            {
                throw new ArgumentNullException(FailedProfileNotFound);
            }

            if (profileUserId != currentUserId)
            {
                throw new InvalidOperationException(FailedUnauthorized);
            }

            if (photoData == null || photoData.Length == 0)
            {
                throw new InvalidOperationException(FailedFormFileIsNull);
            }

            byte[] photoByteArray = new byte[photoData.Length];

            using (var memoryStream = new MemoryStream())
            {
                photoData.CopyTo(memoryStream);
                photoByteArray = memoryStream.ToArray();
            }

            user.ProfilePicture = photoByteArray;

            try
            {
                await this.data.SaveChangesAsync();

                return SuccessfullyChangedProfilePicture;
            }
            catch (Exception)
            {
                throw new Exception(FailedWentWrong);
            }
        }
    }
}
