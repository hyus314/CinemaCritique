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

        public IActionResult AllMovies()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> MoviesForAllPage(int page = 1, int pageSize = 10)
        {
            var movies = await this.service.GetMoviesForAllPage(page, pageSize);
            return Json(movies);
        }

        public async Task<IActionResult> SelectedMovie(string id)
        {
            var reviewText = HttpContext.Request.Query["reviewText"].ToString();
            var ratingValue = HttpContext.Request.Query["ratingValue"] != 0 ? HttpContext.Request.Query["ratingValue"].ToString() : null;
            ViewData["InitialReviewText"] = reviewText;
            ViewData["InitialRatingValue"] = ratingValue;


            var model = await this.service.GetSelectedMoviePageAsync(id);
            return View(model);
        }

    }
}
