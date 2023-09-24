using CinemaCritique.ViewModels.Movie;

namespace CinemaCritique.Core.Contracts
{
    public interface IMovieService
    {
        public Task<ICollection<HomePageMovieViewModel>> GetMoviesForHomePageAsync();
    }
}
