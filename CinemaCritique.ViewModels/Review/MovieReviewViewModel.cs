namespace CinemaCritique.ViewModels.Review
{
    public class MovieReviewViewModel
    {
        public string ReviewId { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string DatePublished { get; set; } = null!;
        public string Content { get; set; } = null!;
        public byte Rating { get; set; }
    }
}
