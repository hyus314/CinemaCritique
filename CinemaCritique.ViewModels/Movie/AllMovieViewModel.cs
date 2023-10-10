namespace CinemaCritique.ViewModels.Movie
{
    public class AllMovieViewModel
    {
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string CoverPhotoURL { get; set; } = null!;
        public string Rating { get; set; } = null!;
        public string YearPublished { get; set; } = null!;
    }
}
