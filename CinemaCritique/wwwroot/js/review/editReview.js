var reviewText = '';
var reviewIdforEdit = '';

function showEditModal(movieId, reviewId) {
    var modal = document.getElementById('editModal');
    modal.style.display = 'block';

    reviewIdforEdit = reviewId;

    $.ajax({
        url: '/Review/GetEditViewModel',
        type: 'GET',
        data: { reviewId: reviewId },
        success: function (response) {
            document.getElementById('editReviewContent').value = response.reviewText;

            // Set the rating value
            $("#selectedStarValue").val(response.reviewRating);

            // Apply star ratings
            var ratingValue = response.reviewRating;
            $(".edit-star").each(function () {
                var $star = $(this);
                $star.removeClass('selected');
                if ($star.data('value') <= ratingValue) {
                    $star.addClass('selected');
                }
            });
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.error("Error getting EditReviewViewModel:", errorThrown);
        }
    });
}


$(document).ready(function () {
    $("#submitEdit").on('click', function () {
        var reviewText = $("#editReviewContent").val();
        var ratingValue = getLastSelectedStarValue();
        var reviewId = reviewIdforEdit;

        var reviewData = {
            reviewId: reviewId,
            reviewText: reviewText,
            reviewRating: ratingValue
        };

        $.ajax({
            type: 'POST',
            url: '/Review/EditReview',
            contentType: 'application/json;charset=utf-8',
            headers: {
                "X-CSRF-VERIFICATION-TOKEN-C-Critique": $('#__RequestVerificationReviewTokenEdit').val()
            },
            data: JSON.stringify(reviewData),
            success: function (response) {
            },
            error: function (jqXHR, textStatus, errorThrown) {
            }
        });
    });
});

function getLastSelectedStarValue() {
    var lastSelectedStar = $(".edit-star.selected").last();
    return lastSelectedStar.data('value');
}


$(document).ready(function () {
    var selectedRating = 0;
    $('.edit-star').hover(
        function () {
            var index = $(this).index();
            $('.edit-star').each(function (i) {
                if (i <= index) {
                    $(this).addClass('hover');
                }
            });
        },
        function () {
            $('.edit-star').removeClass('hover');
        }
    );

    $('.edit-star').on('click', function () {
        var index = $(this).index();
        selectedRating = index + 1;
        updateStars(selectedRating);
    });

    function updateStars(rating) {
        $('.edit-star').each(function (i) {
            if (i < rating) {
                $(this).removeClass('hover').addClass('selected');
            } else {
                $(this).removeClass('hover selected');
            }
        });
    }
});

$(document).ready(function () {
    $(".edit-star").on('click', function () {
        var value = $(this).data('value');
        $(".edit-star").each(function () {
            var $star = $(this);
            $star.removeClass('selected');
            if ($star.data('value') <= value) {
                $star.addClass('selected');
            }
        });
    });
});

$(document).ready(function () {
    $("#closeEditModal").on('click', function () {
        $("#editModal").hide();
    });
});
