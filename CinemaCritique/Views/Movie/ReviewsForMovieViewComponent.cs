namespace CinemaCritique.Views.Movie
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

        public async Task<IViewComponentResult> InvokeAsync(string movieId)
        {
            var reviews = await this.service.GetReviewsForMovie(movieId);

            return View(reviews);
        }
    }
}
