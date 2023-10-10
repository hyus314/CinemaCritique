using CinemaCritique.ViewModels.Movie;

namespace CinemaCritique.Core.Contracts
{
    public interface IMovieService
    {
        public Task<ICollection<HomePageMovieViewModel>> GetMoviesForHomePageAsync();
        public Task<ICollection<RecentMovieViewModel>> GetMostRecentFilmsAsync();
        public Task<SelectedMovieViewModel> GetSelectedMoviePageAsync(string id);
        public Task<ICollection<AllMovieViewModel>> GetMoviesForAllPage(int page, Dictionary<string, string> filters);
    }
}
