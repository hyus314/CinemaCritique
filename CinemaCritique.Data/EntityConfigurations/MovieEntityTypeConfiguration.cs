
namespace CinemaCritique.Data.EntityConfigurations
{
    using CinemaCritique.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using static Seeding.MovieSeeder;
    public class MovieEntityTypeConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasData(SeedMovies());
        }
    }
}
