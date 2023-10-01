using System.ComponentModel.DataAnnotations;

namespace CinemaCritique.ViewModels.Review
{
    public class AddReviewViewModel
    {
        [Required(ErrorMessage = "UserId is required")]
        public string UserId { get; set; } = null!;

        [Required(ErrorMessage = "MovieId is required")]
        public string MovieId { get; set; } = null!;

        [Required(ErrorMessage = "Content is required")]
        public string Content { get; set; } = null!;

        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10")]
        public byte Rating { get; set; }

        public bool IsValid()
        {
            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(this);
            return Validator.TryValidateObject(this, context, validationResults, true);
        }
    }


}
