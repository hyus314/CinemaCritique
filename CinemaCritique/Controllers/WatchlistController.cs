
namespace CinemaCritique.Controllers
{
    using CinemaCritique.Core.Contracts;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    [Authorize]
    public class WatchlistController : Controller
    {
        private readonly IWatchlistService service;
        public WatchlistController(IWatchlistService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
