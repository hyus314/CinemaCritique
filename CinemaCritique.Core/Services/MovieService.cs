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
                       Id = this.dataProtector.Encrypt(x.Id.ToString()),
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
                       Id = this.dataProtector.Encrypt(x.Id.ToString()),
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
                    Id = this.dataProtector.Encrypt(x.Id.ToString()),
                    Title = x.Title,
                    CoverPhotoUrl = x.CoverPhotoURL
                })
                .Take(10)
                .ToArrayAsync();

            return model;
        }
    }
}
