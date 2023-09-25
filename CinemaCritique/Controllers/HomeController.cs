using CinemaCritique.Core.Contracts;
using CinemaCritique.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CinemaCritique.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieService service;
        public HomeController(IMovieService service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            var model = await this.service.GetMoviesForHomePageAsync();
            return View(model);
        }

        public async Task<IActionResult> SelectedMovie(string id)
        {
            var model = await this.service.GetSelectedMoviePageAsync(id);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}