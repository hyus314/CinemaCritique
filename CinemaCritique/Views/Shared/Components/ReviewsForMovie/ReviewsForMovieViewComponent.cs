namespace CinemaCritique.Views.Shared.Components.ReviewsForMovie
{
    using CinemaCritique.Core.Contracts;
    using Microsoft.AspNetCore.Mvc;

    public class ReviewsForMovieViewComponent : ViewComponent
    {
        private readonly IReviewService service;
        public ReviewsForMovieViewComponent(IReviewService service)
        {
            this.service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync(string movieId, int page = 1)
        {
            var model = await service.GetReviewsForMovie(movieId, page);

            return View(model);
        }
    }
}
