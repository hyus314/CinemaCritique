
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaCritique.Data.Models
{
    public class WatchListItem
    {
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;
        public CritiqueUser User { get; set; } = null!;
        [ForeignKey(nameof(Movie))]
        public int MovieId { get; set; }
        public Movie Movie { get; set; } = null!;
    }
}
