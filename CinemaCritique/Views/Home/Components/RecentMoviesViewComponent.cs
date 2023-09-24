using CinemaCritique.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CinemaCritique.Views.ViewComponents
{
    public class RecentMoviesViewComponent : ViewComponent
    {
        private readonly IMovieService service;

        public RecentMoviesViewComponent(IMovieService service)
        {
            this.service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var recentMovies = await this.service.GetMostRecentFilmsAsync();
            return View(recentMovies);
        }
    }
}
