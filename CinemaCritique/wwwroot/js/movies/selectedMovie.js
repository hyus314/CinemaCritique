$(document).ready(function () {
    var movieId = $("#hiddenMovieId").val();

    $.ajax({
        url: '/Watchlist/IsMovieInWatchlist',
        type: 'GET',
        data: { movieId: movieId },
        success: function (isInWatchlist) {
            if (isInWatchlist) {
                $("#addToWatchlist")
                    .prop("disabled", true)
                    .text("Added to Watchlist")
                    .css("background-color", "#888") 
                    .css("cursor", "not-allowed");
            } else {

                $("#addToWatchlist")
                    .prop("disabled", false)
                    .text("Add to Watchlist")
                    .css("background-color", "#FFA500") 
                    .css("cursor", "pointer");
            }
        }
    });
});


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
