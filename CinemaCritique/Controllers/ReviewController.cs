namespace CinemaCritique.Controllers
{
    using CinemaCritique.Core.Contracts;
    using CinemaCritique.ViewModels.Review;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using static CinemaCritique.Extensions.ClaimsExtensions;
    using static CinemaCritique.Common.ResultMessages.Review;
    [Authorize]
    [AutoValidateAntiforgeryToken]
    public class ReviewController : Controller
    {
        private readonly IReviewService service;

        public ReviewController(IReviewService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddReview([FromBody] AddReviewViewModel review)
        {
            var userId = this.User.GetId();

            if (string.IsNullOrEmpty(userId))
            {
                return Json(new { success = false, message = FailedUserIdNull });
            }

            review.UserId = userId;


            try
            {
                var message = await this.service.AddReviewAsync(review);
                return Json(new { success = true, message = message });
            }
            catch (Exception e)
            {
                return Json(new { success = false, message = e.Message });
            }
        }

        [HttpGet]
        public IActionResult GetUpdatedReviews(string movieId)
        {
            return ViewComponent("ReviewsForMovie", new { movieId = movieId });
        }
    }
}
