namespace CinemaCritique.ViewModels.Review
{
    public class AddReviewViewModel
    {
        public int ReviewId { get; set; }
        public string UserId { get; set; } = null!;
        public string MovieId { get; set; } = null!;
        public string Content { get; set; } = null!;
        public byte Rating { get; set; }
    }
}
