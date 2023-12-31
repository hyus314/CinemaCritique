﻿namespace CinemaCritique.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static CinemaCritique.Common.EntityValidations.Movie;
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;
        [MaxLength(DirectorMaxLength)]
        public string Director { get; set; } = null!;
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;
        [Range(YearPublishedMin, YearPublishedMax)]
        public ushort YearPublished { get; set; }
        [MaxLength(URLMaxLength)]
        public string CoverPhotoURL { get; set; } = null!;
        [MaxLength(URLMaxLength)]
        public string TrailerURL { get; set; } = null!;
        [ForeignKey(nameof(Genre))]
        public int GenreId { get; set; }
        public Genre Genre { get; set; } = null!;
        public DateTime DateAdded { get; set; }
        [MaxLength(URLMaxLength )]
        public string ScenePhotoUrl { get; set; } = null!;
        [MaxLength(MainRolesMaxLength)]
        public string MainRoles { get; set; } = null!;
        public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
        public ICollection<WatchListItem> WatchLists { get; set; } = new HashSet<WatchListItem>();
    }
}