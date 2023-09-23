namespace CinemaCritique.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static CinemaCritique.Common.EntityValidations.Genre;
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;
        public ICollection<Movie> Movies { get; set; } = new HashSet<Movie>();
    }
}
