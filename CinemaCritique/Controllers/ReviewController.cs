namespace CinemaCritique.Controllers
{
    using CinemaCritique.ViewModels.Review;
    using Microsoft.AspNetCore.Mvc;
    using static CinemaCritique.Extensions.ClaimsExtensions;
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddReview([FromBody] AddReviewViewModel review)
        {
            var userId = this.User.GetId();
            review.UserId = userId;
            return View();
        }
    }
}
