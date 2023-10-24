function showDeleteModal(movieId, reviewId) {
    $(document).ready(function () {
        $("#removeButton").click(function () {
            $("#deleteModal").show();
        });


        $("#confirmDelete").click(function () {
            $.ajax({
                url: '/Review/DeleteReview',
                type: 'POST',
                dataType: 'json',
                headers: {
                    "X-CSRF-VERIFICATION-TOKEN-C-Critique": $('#__RequestVerificationReviewToken').val()
                },
                data: { reviewId: reviewId },
                success: function (response) {
                    if (response.success) {
                        fetchUpdatedReviews(movieId);
                    } else {
                        alert('Error deleting review: ' + response.message);
                    }
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    alert('An unexpected error occurred: ' + errorThrown);
                }
            });
            $("#deleteModal").hide();
        });

        $("#cancelDelete").click(function () {
            $("#deleteModal").hide();
        });
    });

    document.getElementById("deleteModal").style.display = "block";
}

function fetchUpdatedReviews(movieId) {
    $.ajax({
        type: 'GET',
        url: '/Review/GetUpdatedReviews',
        data: { movieId: movieId },
        success: function (response) {
            $('#reviewsContainer').html(response); 
        },
        error: function (error) {
            console.error("Error fetching updated reviews:", error);
        }
    });
}

function showEditModal(movieId, reviewId) {
    var modal = document.getElementById('editModal');
    modal.style.display = 'block';

    document.getElementById('editMovieId').value = movieId;
    document.getElementById('editReviewId').value = reviewId;
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
