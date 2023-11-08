
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
                if (xhr.status == 401) {
                    var currentPath = window.location.pathname;
                    var currentQueryString = window.location.search;
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

    // Function to update watchlist button state
    function updateWatchlistButtonState() {
        var movieId = $("#hiddenMovieId").val();
        var watchlistButton = $("#addToWatchlist");

        $.ajax({
            url: '/Watchlist/IsMovieInWatchlist',
            type: 'GET',
            data: { movieId: movieId },
            success: function (isInWatchlist) {
                if (isInWatchlist) {
                    watchlistButton
                        .prop("disabled", false)
                        .html('<i class="fa fa-check"></i> Added to Watchlist')
                        .hover(function () {
                            watchlistButton.html('<i class="fa fa-times"></i> Remove from Watchlist');
                        }, function () {
                            watchlistButton.html('<i class="fa fa-check"></i> Added to Watchlist');
                        });
                } else {
                    watchlistButton
                        .prop("disabled", false)
                        .html('<i id="watchlistIcon" class="fa-solid fa-clapperboard"></i> Add To Watchlist')
                        .hover(function () {
                            watchlistButton.addClass("hover-effect");
                        }, function () {
                            watchlistButton.removeClass("hover-effect");
                        });
                }
            }
        });
    }

    // Call the function to update the button state initially
    updateWatchlistButtonState();
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

$(document).ready(function () {
    $("#addToWatchlist").hover(
        function () {
            var isInWatchlist = $(this).data("isInWatchlist");

            if (isInWatchlist) {
                $(this).html('<i class="fa fa-times"></i> Remove from Watchlist');
            }
        },
        function () {
            var isInWatchlist = $(this).data("isInWatchlist");

            if (isInWatchlist) {
                $(this).html('<i class="fa fa-check"></i> Added to Watchlist');
            }
        }
    );

    // Call the function to update the button state initially
    updateWatchlistButtonState();
});
