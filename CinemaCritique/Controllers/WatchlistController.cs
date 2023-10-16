using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CinemaCritique.Controllers
{
    [Authorize]
    public class WatchlistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
