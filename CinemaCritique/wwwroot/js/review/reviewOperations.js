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
