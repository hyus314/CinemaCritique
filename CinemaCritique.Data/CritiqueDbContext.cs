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
        public DbSet<WatchListItem> WatchListItems { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<WatchListItem>()
                .HasKey(x => new { x.UserId, x.MovieId });

            builder.Entity<WatchListItem>()
                .HasOne(x => x.Movie)
                .WithMany(x => x.WatchLists)
                .HasForeignKey(x => x.MovieId);

            builder.Entity<WatchListItem>()
                .HasOne(x => x.User)
                .WithMany(x => x.WatchLists)
                .HasForeignKey(x => x.UserId);

            builder.Entity<Review>()
                .Property(r => r.Rating)
                .HasPrecision(2, 1);

            builder.ApplyConfiguration(new GenreEntityTypeConfiguration());
            builder.ApplyConfiguration(new MovieEntityTypeConfiguration());

            base.OnModelCreating(builder);
        }
    }
}