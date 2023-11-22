
using CinemaCritique.ViewModels.Account;

namespace CinemaCritique.Core.Contracts
{
    public interface IAccountService
    {
        public Task<ProfileViewModel> GetProfileViewModelAsync(string userId);
    }
}
