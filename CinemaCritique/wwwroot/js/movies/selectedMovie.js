
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
            },
            error: function (xhr, textStatus, errorThrown) {
                if (xhr.status == 401) { // Check if status code is 401 Unauthorized
                    window.location.href = '/Account/Login?message=' + encodeURIComponent('You need an account to add movies to your watchlist');
                } else {
                    console.error("Error adding to watchlist:", errorThrown);
                    alert('Failed to add to watchlist. Try again.');
                }
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
                    .html('<i class="fa fa-check"></i> Added to Watchlist')
            } else {

            }
        }
    });
}