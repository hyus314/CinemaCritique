namespace CinemaCritique.Controllers
{
    using CinemaCritique.Core.Contracts;
    using CinemaCritique.ViewModels.Review;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using static CinemaCritique.Extensions.ClaimsExtensions;
    using static CinemaCritique.Common.ResultMessages.Review;
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
        [Authorize]

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
        public IActionResult GetUpdatedReviews(string movieId, int page = 1)
        {
            return ViewComponent("ReviewsForMovie", new { movieId = movieId, page = page });
        }

        [HttpPost]
        [Authorize]

        public async Task<IActionResult> DeleteReview(string reviewId)
        {

            try
            {
                var userId = this.User.GetId();
                await this.service.DeleteReviewAsync(reviewId, userId);
               
                return Json(new { success = true });
            }
            catch (Exception e)
            {
                return Json(new { success = false, message = e.Message });
            }
        }
        [HttpGet]
        [Authorize]

        public async Task<IActionResult> GetEditViewModel(string reviewId)
        {
            var userId = this.User.GetId();

            var viewModel = await this.service.GetEditReviewModelAsync(reviewId, userId);
            return Json(viewModel);
        }

        [HttpPost]
        [Authorize]

        public async Task<IActionResult> EditReview([FromBody] EditReviewViewModel model)
        {
            var userId = this.User.GetId();

            if (string.IsNullOrEmpty(userId))
            {
                return Json(new { success = false, message = FailedUserIdNull });
            }

            try
            {
                var message = await this.service.EditReviewAsync(model, userId);


                return Json(new { success = true, message = message });
            }
            catch (Exception e)
            {
                return Json(new { success = false, message = e.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetTotalPages(string movieId)
        {
            var totalPages = await this.service.GetTotalPagesForReviews(movieId);
            return Json(totalPages);
        }
    }
}
