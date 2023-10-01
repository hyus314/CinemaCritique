namespace CinemaCritique.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static CinemaCritique.Common.EntityValidations.Review;
    public class Review
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; } = null!;
        public DateTime DatePublished { get; set; }
        [Range(RatingMinValue, RatingMaxValue)]
        public byte Rating { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;
        public CritiqueUser User { get; set; } = null!;
        [ForeignKey(nameof(Movie))]
        public int MovieId { get; set; }
        public Movie Movie { get; set; } = null!;
    }
}
