namespace CinemaCritique.Core.Contracts
{
    using CinemaCritique.ViewModels.Watchlist;

    public interface IWatchlistService
    {
        public Task<ICollection<WatchlistItemViewModel>> GetAllWatchlistItemsForUserAsync(string userId);
        public Task<string> AddMovieToWatchlistAsync(string userId, string movieId);
        public Task<bool> IsMovieInUsersWatchlistAsync(string userId, string movieId);
    }
}
