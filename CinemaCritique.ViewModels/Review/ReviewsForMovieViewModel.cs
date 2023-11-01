
namespace CinemaCritique.ViewModels.Review
{
    public class ReviewsForMovieViewModel
    {
        public string MovieId { get; set; } = null!;
        public ICollection<MovieReviewViewModel> Reviews { get; set; } = null!;
    }
}
