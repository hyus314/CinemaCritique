function showDeleteModal(reviewId) {
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
                        alert('Review deleted successfully!');
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
