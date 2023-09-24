namespace CinemaCritique.ViewModels.Movie
{
    public class RecentMovieViewModel
    {
        public string Id { get; set; } = null!;
        public string CoverPhotoURL { get; set; } = null!;
        public string ScenePhotoURL { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string TrailerURL { get; set; } = null!;
    }
}
