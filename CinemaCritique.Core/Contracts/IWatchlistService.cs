namespace CinemaCritique.Core.Contracts
{
    using CinemaCritique.Data.Models;
    public interface IWatchlistService
    {
        public Task<ICollection<WatchListItem>> GetAllWatchlistItemsForUserAsync(string userId);
    }
}
