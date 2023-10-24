
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

$(document).ready(function () {
    $("#closeEditModal").on('click', function () {
        $("#editModal").hide();
    });
});
