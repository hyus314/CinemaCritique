
namespace CinemaCritique.Controllers
{
    using CinemaCritique.Core.Contracts;
    using CinemaCritique.Extensions;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    [AutoValidateAntiforgeryToken]
    public class WatchlistController : Controller
    {
        private readonly IWatchlistService service;
        public WatchlistController(IWatchlistService service)
        {
            this.service = service;
        }
        [Authorize]
        public async Task<IActionResult> MyWatchlist()
        {
            var userId = this.User.GetId();
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
            var userId = this.User.GetId();
            try
            {
                await this.service.AddMovieToWatchlistAsync(userId, movieId);
                return Json(new { success = true });

            }
            catch (Exception e)
            {
                return Json(new { e.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> IsMovieInWatchlist(string movieId)
        {
            var userId = this.User.GetId();
            var result = await this.service.IsMovieInUsersWatchlistAsync(userId, movieId);

            return Json(result);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> RemoveFromWatchlist(string movieId)
        {
            var userId = this.User.GetId();
            try
            {
                await this.service.RemoveFromWatchlistAsync(userId, movieId);
                return Json(new { data = "" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}
