
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
                        let currentPageNumberSelected = $('.page-number.selected');
                        let currentPageNumberSelectedValue = currentPageNumberSelected.text();
                        let countOfCurrentPage = $('#reviewsCountOfPage').val();

                        if (countOfCurrentPage == 1) {
                            currentPageNumberSelected.removeClass('selected');
                            currentPageNumberSelected.prev().addClass('selected');
                            currentPageNumberSelectedValue = $('.page-number.selected').text();
                            currentPageNumberSelected.remove(); // Assuming you want to remove the empty page button
                        }

                        fetchUpdatedReviews(movieId, currentPageNumberSelectedValue);
                        var successMessage = response.message;
                        var successBox = document.getElementById('success-message-box');
                        var successBoxText = document.getElementById('success-message-text');

                        successBoxText.textContent = 'Review deleted successfully!';
                        successBox.style.display = 'flex';

                        setTimeout(function () {
                            successBox.style.display = 'none';
                        }, 3000);
                    } else {
                        alert('Error deleting review');
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
