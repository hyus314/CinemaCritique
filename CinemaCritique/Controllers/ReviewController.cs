namespace CinemaCritique.Controllers
{
    using CinemaCritique.Core.Contracts;
    using CinemaCritique.ViewModels.Review;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using static CinemaCritique.Extensions.ClaimsExtensions;

    [Authorize]
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
            review.UserId = userId;
            if (!review.IsValid())
            {
                return BadRequest("The review is invalid");
            }
            await this.service.AddReview(review);
            return View();
        }
    }
}
