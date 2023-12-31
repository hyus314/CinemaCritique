﻿namespace CinemaCritique.Common
{
    public static class ResultMessages
    {
        public static class Review
        {
            public const string SuccessfullyAddedReview =
                "Review added successfully!";

            public const string SuccessfullyEditedReview =
                "Review edited successfully!";

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

            public const string FailedContentExceeds300Characters =
                "The content of the review cannot have more than 300 characters!";

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

            public const string FailedReviewContentIsTheSame =
                "Cannot edit review with the same content.";
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

            public const string FailedWatchlistItemDoesNotExist =
                "Cannot remove a Watchlist item that does not exist!";
            public const string FailedRemoveWatchlistItem =
                "Unable to remove from your watchlist. Try again.";
        }

        public static class Account
        {
            public const string SuccessfullyChangedProfilePicture =
                "Changed your profile picture successfully.";

            public const string FailedProfileNotFound =
                "This profile does not exist.";

            public const string FailedUnauthorized =
                "This profile does not belong to you.";

            public const string FailedFormFileIsNull =
                "Please choose a picture to add to your profile.";

            public const string FailedWentWrong =
                "Upload failed. Try again.";
        }
    }
}

