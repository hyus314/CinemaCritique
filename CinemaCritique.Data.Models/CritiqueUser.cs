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
    }
}
