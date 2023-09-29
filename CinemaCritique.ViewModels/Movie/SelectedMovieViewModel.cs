namespace CinemaCritique.ViewModels.Movie
{
    public class SelectedMovieViewModel
    {
        public string Title { get; set; } = null!;
        public string Director { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string YearPublished { get; set; } = null!;
        public string CoverPhotoURL { get; set; } = null!;
        public string TrailerURL { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public string ScenePhotoURL { get; set; } = null!;

        public string MainRoles { get; set; } = null!;

        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(Title)) return false;
            if (string.IsNullOrWhiteSpace(Director)) return false;
            if (string.IsNullOrWhiteSpace(Description)) return false;
            if (string.IsNullOrWhiteSpace(YearPublished)) return false;
            if (!int.TryParse(YearPublished, out int year) || year < 1888 || year > DateTime.Now.Year) return false;
            if (string.IsNullOrWhiteSpace(Genre)) return false;
            if (string.IsNullOrWhiteSpace(MainRoles)) return false;


            if (!string.IsNullOrWhiteSpace(CoverPhotoURL) && !Uri.IsWellFormedUriString(CoverPhotoURL, UriKind.Absolute)) return false;
            if (!string.IsNullOrWhiteSpace(TrailerURL) && !Uri.IsWellFormedUriString(TrailerURL, UriKind.Absolute)) return false;
            if (!string.IsNullOrWhiteSpace(ScenePhotoURL) && !Uri.IsWellFormedUriString(ScenePhotoURL, UriKind.Absolute)) return false;

            return true;
        }

    }
}
