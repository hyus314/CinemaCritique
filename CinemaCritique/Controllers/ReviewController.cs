namespace CinemaCritique.Controllers
{
    using CinemaCritique.ViewModels.Review;
    using Microsoft.AspNetCore.Mvc;
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddReview([FromBody] AddReviewViewModel review)
        {
            return View();
        }
    }
}
