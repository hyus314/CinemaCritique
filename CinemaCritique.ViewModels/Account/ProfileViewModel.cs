namespace CinemaCritique.ViewModels.Account
{
    public class ProfileViewModel
    {
        public string FavouriteGenre { get; set; } = null!;
        public int CritiquePoints { get; set; }
        public int WatchlistItemsCount { get; set; }
        public int NumberOfReviews { get; set; }
        public double AverageStarRating { get; set; }
        public string FullName { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string JoinedDate { get; set; } = null!;

        public string? ProfilePictureBase64 { get; set; }
    }
}
