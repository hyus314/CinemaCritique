namespace CinemaCritique.Controllers
{
    using CinemaCritique.Core.Contracts;
    using CinemaCritique.ViewModels.Review;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using static CinemaCritique.Extensions.ClaimsExtensions;

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
            string message = string.Empty;
            var userId = this.User.GetId();
            review.UserId = userId;
            if (!review.IsValid())
            {
                return Json(new { success = false, message = "The review is not in a valid format!" });
            }
            await this.service.AddReviewAsync(review);
            return View();

        }
    }
}
