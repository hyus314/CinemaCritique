namespace CinemaCritique.Common
{
    public static class ResultMessages
    {
        public static class Review
        {
            public const string SuccessfullyAddedReview =
                "Review added successfully!";

            public const string FailedReviewIsInvalid =
                "The review is not in a valid format!";
            
            public const string FailedUserIdDoesNotExist =
                "The user trying to submit this review does not exist!";

            public const string FailedUserIdNull =
                "The user id cannot be null!";

            public const string FailedRatingIsZero =
                "The review cannot have a rating with the value of 0!";

            public const string FailedContentIsNull =
                "The review cannot have empty content!";

            public const string FailedMovieIdNull =
                "The movie id cannot be null!";

            public const string FailedCannotSaveReview =
                "An unexpected error occured. Try again.";
        }

    }
}
