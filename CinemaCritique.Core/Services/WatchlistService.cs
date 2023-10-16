using CinemaCritique.Core.Contracts;
using CinemaCritique.Data;
using CinemaCritique.Data.Models;

namespace CinemaCritique.Core.Services
{
    public class WatchlistService : IWatchlistService
    {
        private readonly CritiqueDbContext data;

        public WatchlistService(CritiqueDbContext data)
        {
            this.data = data;
        }

        public Task<ICollection<WatchListItem>> GetAllWatchlistItemsForUserAsync(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
