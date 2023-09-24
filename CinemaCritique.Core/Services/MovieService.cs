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
