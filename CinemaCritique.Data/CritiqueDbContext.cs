namespace CinemaCritique.Data
{
    using CinemaCritique.Data.EntityConfigurations;
    using CinemaCritique.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    public class CritiqueDbContext : IdentityDbContext<CritiqueUser>
    {
        public CritiqueDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Review>()
                .Property(r => r.Rating)
                .HasPrecision(2, 1);

            builder.ApplyConfiguration(new GenreEntityTypeConfiguration());

            base.OnModelCreating(builder);
        }
    }
}