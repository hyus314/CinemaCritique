
namespace CinemaCritique.Controllers
{
    using CinemaCritique.Core.Contracts;
    using CinemaCritique.Extensions;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    public class WatchlistController : Controller
    {
        private readonly IWatchlistService service;
        public WatchlistController(IWatchlistService service)
        {
            this.service = service;
        }
        [Authorize]
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
        [Authorize]
        public async Task<IActionResult> AddToWatchlist(string movieId)
        {
            return Json(new { success = true });
        }

        [HttpGet]
        public async Task<IActionResult> IsMovieInWatchlist(string movieId)
        {
            var userId = this.User.GetId();
            var result = await this.service.IsMovieInUsersWatchlistAsync(userId, movieId);

            return Json(result);
        }
    }
}
