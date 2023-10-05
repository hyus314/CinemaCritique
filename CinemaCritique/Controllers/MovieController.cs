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
            var reviewText = HttpContext.Request.Query["reviewText"].ToString();
            var ratingValue = HttpContext.Request.Query["ratingValue"] != 0 ? HttpContext.Request.Query["ratingValue"].ToString() : null;
            ViewData["InitialReviewText"] = reviewText;
            ViewData["InitialRatingValue"] = ratingValue;


            var model = await this.service.GetSelectedMoviePageAsync(id);
            return View(model);
        }

    }
}
