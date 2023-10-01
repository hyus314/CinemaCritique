$(document).ready(function () {
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
    $("#submit-review").on('click', function () {
        var reviewText = $("#review-text").val();
        var movieId = $("#movie-id").data("value"); 
        var ratingValue = $('.star.selected').last().data('value') || 0; // if no star is selected, defaults to 0

        // Form a JSON object
        var reviewData = {
            movieId: movieId,
            content: reviewText,
            rating: ratingValue
        };

        $.ajax({
            type: 'POST',
            url: '/ReviewController/AddReview', 
            contentType: 'application/json;charset=utf-8',
            data: JSON.stringify(reviewData),
            success: function (response) {
                alert('Review submitted successfully');
            },
            error: function (response) {
                alert('Error in submitting review');
            }
        });
    });
});
