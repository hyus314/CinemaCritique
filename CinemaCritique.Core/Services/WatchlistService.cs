using CinemaCritique.Core.Contracts;
using CinemaCritique.Data;
using CinemaCritique.Data.Models;
using CinemaCritique.Security;
using CinemaCritique.ViewModels.Watchlist;
using Microsoft.EntityFrameworkCore;

namespace CinemaCritique.Core.Services
{
    public class WatchlistService : IWatchlistService
    {
        private readonly CritiqueDbContext data;
        private readonly MovieDataProtector movieProtector;

        public WatchlistService(CritiqueDbContext data, MovieDataProtector movieProtector)
        {
            this.data = data;
            this.movieProtector = movieProtector;
        }

        public async Task<ICollection<WatchlistItemViewModel>> GetAllWatchlistItemsForUserAsync(string userId)
        {
            var watchlistItems = await this.data
                .WatchListItems
                .Where(x => x.UserId == userId)
                .Select(x => new WatchlistItemViewModel()
                {
                    MovieId = movieProtector.Encrypt(x.MovieId),
                    MovieTitle = x.Movie.Title,
                    MovieCoverURL = x.Movie.CoverPhotoURL
                }).ToArrayAsync();

            return watchlistItems;
        }
    }
}
