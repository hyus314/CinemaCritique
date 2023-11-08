
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
                    var currentPath = window.location.pathname;
                    var currentQueryString = window.location.search;

                    // Check if currentQueryString exists or not
                    var separator = currentQueryString ? "&" : "?";
                    var returnUrl = currentPath + currentQueryString + separator + "fromAddWatchlist=true";

                    var returnPath = "/Identity/Account/Login?fromAddWatchlist=true&returnUrl=" + encodeURIComponent(returnUrl);
                    window.location.href = returnPath;
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
                    .html('<i class="fa fa-check"></i> Added to Watchlist');

                const removeFromWatchlistBtn = document.getElementById('removeFromWatchlist');

                removeFromWatchlistBtn.style.display = 'inline-block';
            } else {

            }
        }
    });
}


$(document).ready(function () {

    $('#removeFromWatchlist').click(function () {
        var movieId = $("#hiddenMovieId").val();

        $.ajax({
            url: '/Watchlist/RemoveFromWatchlist',
            method: 'POST',
            headers: {
                "X-CSRF-VERIFICATION-TOKEN-C-Critique": $('#__RequestVerificationWatchlistRemoveToken').val()
            },
            data: { 'movieId': movieId },
            success: function (response) {
                updateWatchlistButtonState();
            },
            error: function (xhr, textStatus, errorThrown) {
                if (xhr.status == 401) { // Check if status code is 401 Unauthorized
                    var currentPath = window.location.pathname;
                    var currentQueryString = window.location.search;

                    // Check if currentQueryString exists or not
                    var separator = currentQueryString ? "&" : "?";
                    var returnUrl = currentPath + currentQueryString + separator + "fromAddWatchlist=true";

                    var returnPath = "/Identity/Account/Login?fromAddWatchlist=true&returnUrl=" + encodeURIComponent(returnUrl);
                    window.location.href = returnPath;
                } else {
                    console.error("Error adding to watchlist:", errorThrown);
                    alert('Failed to add to watchlist. Try again.');
                }
            }
        });
    });
});