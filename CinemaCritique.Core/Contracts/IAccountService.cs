
using CinemaCritique.ViewModels.Account;
using Microsoft.AspNetCore.Http;

namespace CinemaCritique.Core.Contracts
{
    public interface IAccountService
    {
        public Task<ProfileViewModel> GetProfileViewModelAsync(string userId);
        public Task<string> UpdateProfilePictureAsync(IFormFile photoData, string profileUserId, string currentUserId);
    }
}
