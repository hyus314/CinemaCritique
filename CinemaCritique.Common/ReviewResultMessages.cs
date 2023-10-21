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

            public const string FailedRatingMoreThanTen =
                "The review cannot have a rating more than ten!";

            public const string FailedContentIsNull =
                "The review cannot have empty content!";

            public const string FailedMovieIdNull =
                "The movie id cannot be null!";

            public const string FailedCannotSaveReview =
                "An unexpected error occured. Try again. Cannot save the review.";

            public const string FailedCannotCreateReview =
                "Cannot create the review.";

            public const string FailedReviewDoesNotExist =
                "This review does not exist in the database!";

            public const string FailedReviewDoesNotBelongToUser =
                "This review does not belong to this user!";

            public const string FailedUserDoesNotExist =
                "This user trying to delete a review does not exist!";
        }

        public static class Watchlist
        {
            public const string SuccessfullyAddedMovieToUsersWatchList =
                "Added to your watchlist.";

            public const string FailedUserDoesNotExistAdding =
                "The user trying to add this item to their watchlist does not exist!";

            public const string FailedUserDoesNotExistWatchlist =
                "The user trying to access their watchlist does not exist!";

            public const string FailedMovieDoesNotExist =
                "The movie with this ID does not exist!";

            public const string FailedCannotCreateWatchlistItem =
                "Cannot create a Watchlist Item with this data!";

            public const string FailedWatchlistItemAlreadyExists =
                "Cannot save this Watchlist Item because it already exists in the database!";

            public const string FailedCannotSaveChanges =
                "Cannot save this Watchlist Item in the database!";
        }

    }
}
