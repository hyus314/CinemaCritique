namespace CinemaCritique.ViewModels.Movie
{
    public class SelectedMovieViewModel
    {
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Director { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string YearPublished { get; set; } = null!;
        public string CoverPhotoURL { get; set; } = null!;
        public string TrailerURL { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public string ScenePhotoURL { get; set; } = null!;
        public string Rating { get; set; } = null!;
        public bool HasReviews { get; set; }
        public string MainRoles { get; set; } = null!;

        

    }
}
