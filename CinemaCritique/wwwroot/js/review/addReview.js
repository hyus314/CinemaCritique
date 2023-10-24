﻿$(document).ready(function () {
    var selectedRating = 0;
    $('.star').hover(
        function () {
            var index = $(this).index();
            $('.star').each(function (i) {
                if (i <= index) {
                    $(this).addClass('hover');
                }
            });
        },
        function () {
            $('.star').removeClass('hover');
        }
    );

    $('.star').on('click', function () {
        var index = $(this).index();
        selectedRating = index + 1;
        updateStars(selectedRating);
    });

    function updateStars(rating) {
        $('.star').each(function (i) {
            if (i < rating) {
                $(this).removeClass('hover').addClass('selected');
            } else {
                $(this).removeClass('hover selected');
            }
        });
    }
});

$(document).ready(function () {
    $('#review-text').on('input', function () {
        var maxLength = 300;
        var length = $(this).val().length;
        var charactersRemaining = maxLength - length;

        $('#char-counter').text(charactersRemaining + ' characters remaining');
    });
});

function updateCharacterCount() {
    var maxLength = 300;
    var length = $('#review-text').val().length;
    var charactersRemaining = maxLength - length;
    $('#char-counter').text(charactersRemaining + ' characters remaining');
}

$(document).ready(function () {
    $('#review-text').on('input', updateCharacterCount);
});

$(document).ready(function () {
    $("#submit-review").on('click', function () {
        var reviewText = $("#review-text").val();
        var movieId = $("#movie-id").data("value"); 
        var ratingValue = $('.star.selected').last().data('value') || 0; 

        $("#submit-review").prop("disabled", true);

        // Form a JSON object
        var reviewData = {
            movieId: movieId,
            content: reviewText,
            rating: ratingValue
        };

        console.log('Started Adding review');

        $.ajax({
            type: 'POST',
            url: '/Review/AddReview',
            contentType: 'application/json;charset=utf-8',
            headers: {
                "X-CSRF-VERIFICATION-TOKEN-C-Critique": $('#__RequestVerificationReviewToken').val()
            },
            data: JSON.stringify(reviewData),
            success: function (response) {
                var messageBox = $("#message-box");
                if (response.success) {
                    messageBox.text('Review submitted successfully').removeClass('error').addClass('success').fadeIn();
                    $("#review-text").val('');
                    updateCharacterCount();
                    fetchUpdatedReviews(movieId);
                    $(".star").removeClass('selected');
                } else {
                    messageBox.text(response.message).removeClass('success').addClass('error').fadeIn();
                }
                setTimeout(function () {
                    messageBox.fadeOut();9876543
                }, 3000);  

                $("#submit-review").prop("disabled", false);

            },
            error: function (jqXHR, textStatus, errorThrown) {
                if (jqXHR.status === 401) { // if unauthorized
                    var reviewText = $("#review-text").val();
                    var ratingValue = $('.star.selected').last().data('value') || 0;
                    var currentPath = window.location.pathname; // gets the path of the current URL.
                    var currentQueryString = window.location.search; // gets the query string of the current URL.
                    var newQueryString = currentQueryString
                        ? currentQueryString + "&reviewText=" + encodeURIComponent(reviewText) + "&ratingValue=" + ratingValue
                        : "?reviewText=" + encodeURIComponent(reviewText) + "&ratingValue=" + ratingValue;
                    var returnUrl = currentPath + newQueryString + "&fromReview=true"; // This will be a local URL.
                    var url = "/Identity/Account/Login?fromReview=true&returnUrl=" + encodeURIComponent(returnUrl);
                    window.location.href = url;
                } else {
                    $("#message-box").text('An unexpected error occurred.').removeClass('success').addClass('error').fadeIn();
                    setTimeout(function () {
                        $("#message-box").fadeOut();
                    }, 3000);
                }
                $("#submit-review").prop("disabled", false);
            }

        });
    });
});

$(document).ready(function () {
    $(".star").on('click', function () {
        var value = $(this).data('value');
        $(".star").each(function () {
            var $star = $(this);
            $star.removeClass('selected');
            if ($star.data('value') <= value) {
                $star.addClass('selected');
            }
        });
    });
});

function fetchUpdatedReviews(movieId) {
    $.ajax({
        type: 'GET',
        url: '/Review/GetUpdatedReviews',
        data: { movieId: movieId },
        success: function (response) {
            $('#reviewsContainer').html(response); // Inject the updated reviews into the container
        },
        error: function (error) {
            console.error("Error fetching updated reviews:", error);
        }
    });
}
