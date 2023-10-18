
$(document).ready(function () {

    $('#addToWatchlist').click(function () {
        var movieId = $("#hiddenMovieId").val();

        $.ajax({
            url: '/Watchlist/AddToWatchlist', 
            method: 'POST',
            headers: {
                "X-CSRF-VERIFICATION-TOKEN-C-Critique": $('#__RequestVerificationWatchlistToken').val()
            },
            data: { 'movieId': movieId },
            success: function (response) {
                updateWatchlistButtonState();
                alert('Added to watchlist successfully!');
            },
            error: function (error) {
                console.error("Error adding to watchlist:", error);
                alert('Failed to add to watchlist. Try again.');
            }
        });
    });
});

$(document).ready(function () {
    updateWatchlistButtonState();
});

function updateWatchlistButtonState() {
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
              
            }
        }
    });
}