namespace CinemaCritique.ViewModels.Review
{
    using System.ComponentModel.DataAnnotations;
    using static CinemaCritique.Common.EntityValidations.Review;
    public class AddReviewViewModel
    { 
        /*Error messages for attribute validations must be hardscoded, because they cannot fetch the values needed for validation comparisons
        since attributes run at compile-time and needed values are initiated runtime. */

        [Required(ErrorMessage = "UserId is required")]
        public string UserId { get; set; } = null!;

        [Required(ErrorMessage = "MovieId is required")]
        public string MovieId { get; set; } = null!;

        [Required(ErrorMessage = "Content is required")]
        [StringLength(ContentMaxLength, ErrorMessage = "Content cannot be longer than 300 characters.")]
        public string Content { get; set; } = null!;

        [Range(RatingMinValue, RatingMaxValue, ErrorMessage = "Rating must be between 1 and 10")]
        public byte Rating { get; set; }

        public bool IsValid()
        {
            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(this);
            return Validator.TryValidateObject(this, context, validationResults, true);
        }
    }


}
