namespace CinemaCritique.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using static CinemaCritique.Common.EntityValidations.User;
    public class CritiqueUser : IdentityUser
    {
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;
        public ICollection<Review> Reviews { get; set; } = null!;
        public ICollection<WatchListItem> WatchLists { get; set; } = null!;
        public DateTime JoinedDate { get; set; }
        public ushort CritiquePoints { get; set; } = 0;
        [MaxLength(30)]
        public string FavouriteGenre { get; set; } = "";
        public byte[]? ProfilePicture { get; set; }
    }
}
