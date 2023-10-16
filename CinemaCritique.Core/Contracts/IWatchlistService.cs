namespace CinemaCritique.Core.Contracts
{
    using CinemaCritique.ViewModels.Watchlist;

    public interface IWatchlistService
    {
        public Task<ICollection<WatchlistItemViewModel>> GetAllWatchlistItemsForUserAsync(string userId);
    }
}
