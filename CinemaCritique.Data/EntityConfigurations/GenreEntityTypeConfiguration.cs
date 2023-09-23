namespace CinemaCritique.Data.EntityConfigurations
{
    using CinemaCritique.Data.Models;
    using CinemaCritique.Data.Seeding;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class GenreEntityTypeConfiguration : IEntityTypeConfiguration<Genre>
    {
        private GenreSeeder seeder = new();

        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(this.seeder.SeedGenres());
        }
    }
}
