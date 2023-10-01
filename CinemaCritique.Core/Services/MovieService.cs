using CinemaCritique.Core.Contracts;
using CinemaCritique.Data;
using CinemaCritique.Security;
using CinemaCritique.ViewModels.Movie;
using Microsoft.EntityFrameworkCore;

namespace CinemaCritique.Core.Services
{
    public class MovieService : IMovieService
    {
        private readonly CritiqueDbContext data;
        private readonly MovieDataProtector dataProtector;

        public MovieService(CritiqueDbContext data, MovieDataProtector dataProtector)
        {
            this.data = data;
            this.dataProtector = dataProtector;
        }

        public async Task<ICollection<RecentMovieViewModel>> GetMostRecentFilmsAsync()
        {
            ICollection<RecentMovieViewModel> model = new HashSet<RecentMovieViewModel>();

            if (this.data.Movies.Count() >= 5)
            {
                model = await this.data.Movies
                   .AsNoTracking()
                   .OrderByDescending(x => x.DateAdded)
                   .Select(x => new RecentMovieViewModel()
                   {
                       Id = this.dataProtector.Encrypt(x.Id),
                       CoverPhotoURL = x.CoverPhotoURL,
                       ScenePhotoURL = x.ScenePhotoUrl,
                       Title = x.Title,
                       TrailerURL = x.TrailerURL
                   })
                   .Take(5)
                   .ToArrayAsync();
            }
            else
            {
                model = await this.data.Movies
                   .AsNoTracking()
                   .OrderByDescending(x => x.DateAdded)
                   .Select(x => new RecentMovieViewModel()
                   {
                       Id = this.dataProtector.Encrypt(x.Id),
                       CoverPhotoURL = x.CoverPhotoURL,
                       ScenePhotoURL = x.ScenePhotoUrl,
                       Title = x.Title,
                       TrailerURL = x.TrailerURL
                   })
                   .ToArrayAsync();

            }
            return model;
        }

        public async Task<ICollection<HomePageMovieViewModel>> GetMoviesForHomePageAsync()
        {
            var model = await this.data.Movies
                .AsNoTracking()
                .Select(x => new HomePageMovieViewModel()
                {
                    Id = this.dataProtector.Encrypt(x.Id),
                    Title = x.Title,
                    CoverPhotoUrl = x.CoverPhotoURL
                })
                .Take(10)
                .ToArrayAsync();

            return model;
        }

        public async Task<SelectedMovieViewModel> GetSelectedMoviePageAsync(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("Such movie does not exist!");
            }

            var decryptedId = this.dataProtector.Decrypt(id);

            var entity = await this.data.Movies.FindAsync(decryptedId);

            var genre = await this.data.Genres.FindAsync(entity!.GenreId);

            if (entity == null)
            {
                throw new ArgumentNullException("There is no movie with this id!");
            }

            var model = new SelectedMovieViewModel()
            {
                Id = dataProtector.Encrypt(entity.Id),
                Title = entity.Title,
                Director = entity.Director,
                Description = entity.Description,
                YearPublished = entity.YearPublished.ToString(),
                CoverPhotoURL = entity.CoverPhotoURL,
                TrailerURL = entity.TrailerURL,
                Genre = genre!.Name,
                ScenePhotoURL = entity.ScenePhotoUrl,
                MainRoles = entity.MainRoles
            };

            if (!model.IsValid())
            {
                throw new InvalidOperationException("This movie has an invalid state!");
            }

            return model;
        }
    }
}
