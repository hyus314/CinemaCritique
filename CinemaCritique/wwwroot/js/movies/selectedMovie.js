$(document).ready(function () {

    $('#addToWatchlist').click(function () {
        var movieId = $("#hiddenMovieId").val();

        $.ajax({
            url: '/Watchlist/AddToWatchlist', // Adjust if you have a different route setup.
            method: 'POST',
            data: { 'movieId': movieId },
            success: function (response) {
                // Handle the success - maybe show a message to the user or change the button state.
                alert('Added to watchlist successfully!');
            },
            error: function (error) {
                // Handle the error.
                console.error("Error adding to watchlist:", error);
                alert('Failed to add to watchlist. Try again.');
            }
        });
    });
});
