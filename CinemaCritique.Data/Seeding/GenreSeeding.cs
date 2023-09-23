namespace CinemaCritique.Data.Seeding
{
    using CinemaCritique.Data.Models;
    public class GenreSeeder
    {
        public ICollection<Genre> SeedGenres()
        {
            List<Genre> genres = new List<Genre>();
            Genre current;

            current = new Genre() { Id = 1, Name = "Drama" };
            genres.Add(current);

            current = new Genre() { Id = 2, Name = "Comedy" };
            genres.Add(current);

            current = new Genre() { Id = 3, Name = "Action" };
            genres.Add(current);

            current = new Genre() { Id = 4, Name = "Romance" };
            genres.Add(current);

            current = new Genre() { Id = 5, Name = "Horror" };
            genres.Add(current);

            current = new Genre() { Id = 6, Name = "Science Fiction" };
            genres.Add(current);

            current = new Genre() { Id = 7, Name = "Documentary" };
            genres.Add(current);

            current = new Genre() { Id = 8, Name = "Musical" };
            genres.Add(current);

            current = new Genre() { Id = 9, Name = "Fantasy" };
            genres.Add(current);

            current = new Genre() { Id = 10, Name = "Adventure" };
            genres.Add(current);

            current = new Genre() { Id = 11, Name = "Mystery" };
            genres.Add(current);

            current = new Genre() { Id = 12, Name = "Thriller" };
            genres.Add(current);

            current = new Genre() { Id = 13, Name = "Animation" };
            genres.Add(current);

            current = new Genre() { Id = 14, Name = "Western" };
            genres.Add(current);

            current = new Genre() { Id = 15, Name = "War" };
            genres.Add(current);

            current = new Genre() { Id = 16, Name = "Biography" };
            genres.Add(current);

            return genres;
        }
    }
}
