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
    $("#submitReview").on('click', function () {
        var reviewText = $("#reviewText").val();
        var movieId = $("#movieId").val(); // Assuming you have a hidden input or some other way to get movieId
        var ratingValue = $('.star.selected').last().data('value') || 0; // if no star is selected, defaults to 0

        // Form a JSON object
        var reviewData = {
            movieId: movieId,
            review: reviewText,
            rating: ratingValue
        };

        $.ajax({
            type: 'POST',
            url: '/your-server-endpoint', // replace with your actual server endpoint
            contentType: 'application/json;charset=utf-8',
            data: JSON.stringify(reviewData),
            success: function (response) {
                // handle success, you might want to clear the form, or give user feedback
                alert('Review submitted successfully');
            },
            error: function (response) {
                // handle error, you might want to inform the user that something went wrong
                alert('Error in submitting review');
            }
        });
    });
});
