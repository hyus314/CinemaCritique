namespace CinemaCritique.Controllers
{
    using CinemaCritique.Core.Contracts;
    using Microsoft.AspNetCore.Mvc;
    public class MovieController : Controller
    {
        private readonly IMovieService service;

        public MovieController(IMovieService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SelectedMovie(string id)
        {
            var model = await this.service.GetSelectedMoviePageAsync(id);
            return View(model);
        }

    }
}
