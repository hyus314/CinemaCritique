
namespace CinemaCritique.Core.Services
{
    using CinemaCritique.Core.Contracts;
    using CinemaCritique.Data;
    using CinemaCritique.Data.Models;
    using CinemaCritique.Security;
    using CinemaCritique.ViewModels.Watchlist;
    using Microsoft.EntityFrameworkCore;
    using static Common.ResultMessages.Watchlist;
    public class WatchlistService : IWatchlistService
    {
        private readonly CritiqueDbContext data;
        private readonly MovieDataProtector movieProtector;

        public WatchlistService(CritiqueDbContext data, MovieDataProtector movieProtector)
        {
            this.data = data;
            this.movieProtector = movieProtector;
        }

        public async Task<string> AddMovieToWatchlistAsync(string userId, string movieId)
        {
            var movieIdDecrypted = this.movieProtector.Decrypt(movieId);

            if (movieIdDecrypted == 0 ||
                await this.data.Movies.FirstOrDefaultAsync(x => x.Id == movieIdDecrypted) == null)
            {
                throw new InvalidOperationException(FailedMovieDoesNotExist);
            }

            if (await this.data.Users.FirstOrDefaultAsync(x => x.Id == userId) == null)
            {
                throw new InvalidOperationException(FailedUserDoesNotExistAdding);
            }

            if (await this.data.WatchListItems.FirstOrDefaultAsync(x => x.MovieId == movieIdDecrypted && x.UserId == userId) != null)
            {
                throw new InvalidOperationException(FailedWatchlistItemAlreadyExists);
            }

            WatchListItem watchlistItem;

            try
            {
                watchlistItem = new WatchListItem()
                {
                    UserId = userId,
                    MovieId = this.movieProtector.Decrypt(movieId)
                };

            }
            catch (Exception)
            {
                throw new InvalidOperationException(FailedCannotCreateWatchlistItem);
            }

            try
            {
                await this.data.WatchListItems.AddAsync(watchlistItem);
                await this.data.SaveChangesAsync();

                return SuccessfullyAddedMovieToUsersWatchList;
            }
            catch (Exception)
            {
                throw new InvalidOperationException(FailedCannotSaveChanges);
            }

        }

        public async Task<ICollection<WatchlistItemViewModel>> GetAllWatchlistItemsForUserAsync(string userId)
        {
            if (userId == null || await this.data.Users.FirstOrDefaultAsync(x => x.Id == userId) == null)
            {
                throw new InvalidOperationException(FailedUserDoesNotExistWatchlist);
            }
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

        public async Task<bool> IsMovieInUsersWatchlistAsync(string userId, string movieId)
        {
            var decryptedMovieId = this.movieProtector.Decrypt(movieId);
            if (await this.data.WatchListItems.FirstOrDefaultAsync(x => x.UserId == userId && x.MovieId == decryptedMovieId) != null)
            {
                return true;
            }

            return false;
        }

        public async Task RemoveFromWatchlistAsync(string userId, string movieId)
        {
            var user = await this.data.Users.FirstOrDefaultAsync(x => x.Id == userId)
                ?? throw new InvalidOperationException(FailedUserDoesNotExistWatchlist);
            
            var decryptedMovieId = this.movieProtector.Decrypt(movieId);

            var movie = await this.data.Movies.FirstOrDefaultAsync(x => x.Id == decryptedMovieId)
                ?? throw new InvalidOperationException(FailedMovieDoesNotExist);
            
            var watchlistItem = await this.data.WatchListItems.FirstOrDefaultAsync(x => x.MovieId == decryptedMovieId && x.UserId == userId) 
                ?? throw new InvalidOperationException(FailedWatchlistItemDoesNotExist);

            try
            {
                this.data.WatchListItems.Remove(watchlistItem);
                await this.data.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new InvalidOperationException(FailedRemoveWatchlistItem);
            }
        }
    }
}
