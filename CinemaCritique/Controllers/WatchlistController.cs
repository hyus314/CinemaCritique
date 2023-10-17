
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

        public async Task<IActionResult> MyWatchlist(string userId)
        {
            try
            {
                var watchlist = await this.service.GetAllWatchlistItemsForUserAsync(userId);
                return View(watchlist);
            }
            catch (Exception)
            {
                throw;
            }

        }
        [HttpPost]
        public async Task<IActionResult> AddToWatchlist(string movieId)
        {
            return Json(new { success = true});
        }
    }
}
