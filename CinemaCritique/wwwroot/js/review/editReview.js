
let reviewIdforEdit = '';
let movieIdForEdit = '';
function showEditModal(movieId, reviewId) {
    let modal = document.getElementById('editModal');
    modal.style.display = 'block';

    reviewIdforEdit = reviewId;
    movieIdForEdit = movieId;

    $.ajax({
        url: '/Review/GetEditViewModel',
        type: 'GET',
        data: { reviewId: reviewId },
        success: function (response) {
            document.getElementById('editReviewContent').value = response.reviewText;

            // Set the rating value
            $("#selectedStarValue").val(response.reviewRating);

            // Apply star ratings
            let ratingValue = response.reviewRating;
            $(".edit-star").each(function () {
                let $star = $(this);
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
        let reviewText = $("#editReviewContent").val();
        let ratingValue = getLastSelectedStarValue();
        let reviewId = reviewIdforEdit;

        let reviewData = {
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
                if (response.success == true) {
                    let successMessage = response.message;
                    let successBox = document.getElementById('success-message-box');
                    let successBoxText = document.getElementById('success-message-text');

                    successBoxText.textContent = successMessage;
                    successBox.style.display = 'flex';

                    setTimeout(function () {
                        successBox.style.display = 'none';
                    }, 3000);
                    let currentPageNumberSelected = $('.page-number.selected').text();
                    let modal = document.getElementById('editModal');
                    modal.style.display = 'none';
                    fetchUpdatedReviews(movieIdForEdit, currentPageNumberSelected);
                }
                else {
                    let errorMessage = response.message;
                    let errorMessageBox = document.getElementById('error-message-box');
                    let errorMessageText = document.getElementById('error-message-text');

                    errorMessageText.textContent = errorMessage;
                    errorMessageBox.style.display = 'flex';

                    setTimeout(function () {
                        errorMessageBox.style.display = 'none';
                    }, 3000);
                }
            }
            
        });
    });
});

function fetchUpdatedReviews(movieId, pageNumber) {
    $.ajax({
        type: 'GET',
        url: '/Review/GetUpdatedReviews',
        data: { movieId: movieId, page: pageNumber },
        success: function (response) {
            $('#reviewsContainer').html(response);
        },
        error: function (error) {
            console.error("Error fetching updated reviews:", error);
        }
    });
}
function getLastSelectedStarValue() {
    let lastSelectedStar = $(".edit-star.selected").last();
    return lastSelectedStar.data('value');
}


$(document).ready(function () {
    let selectedRating = 0;
    $('.edit-star').hover(
        function () {
            let index = $(this).index();
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
        let index = $(this).index();
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
        let value = $(this).data('value');
        $(".edit-star").each(function () {
            let $star = $(this);
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
