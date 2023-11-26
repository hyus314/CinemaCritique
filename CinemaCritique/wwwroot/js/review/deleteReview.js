
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
                        let successMessage = response.message;
                        let successBox = document.getElementById('success-message-box');
                        let successBoxText = document.getElementById('success-message-text');
                        getPagesAfterDelete();
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

function getPagesAfterDelete() {
    $.ajax({
        url: '/Review/GetTotalPages',
        type: 'GET',
        data: { movieId: movieId },
        success: async function (response) {
            createPagination(response);
            let selectedPage = document.querySelector('.pagination-pages .selected');
            await updatePaginationButtons(selectedPage);
        },
        error: function (error) {
            console.error("Error fetching total pages:", error);
        }
    });
}

function createPagination(totalPages) {
    let currentPageNumberSelected = document.querySelector('.page-number.selected');

    let selectedPageNumber = null;
    if (currentPageNumberSelected) {
        selectedPageNumber = currentPageNumberSelected.textContent;
    }

    paginationContainer.empty();

    for (let i = 1; i <= totalPages; i++) {
        let pageButton;
        if (i == selectedPageNumber) { 
            pageButton = $('<button class="page-number selected">' + i + '</button>');
        } else {
            pageButton = $('<button class="page-number">' + i + '</button>');
        }
        paginationContainer.append(pageButton);
    }
}

async function updatePaginationButtons(selectedPage) {
    let previousButton = document.getElementById('previousPage');
    let nextButton = document.getElementById('nextPage');
    let previousPage = selectedPage ? selectedPage.previousElementSibling : null;
    let nextPage = selectedPage ? selectedPage.nextElementSibling : null;

    if (!previousPage) {
        previousButton.classList.add('hidden');
    } else {
        previousButton.classList.remove('hidden');
    }

    if (!nextPage || nextPage.classList.contains('disabled')) {
        nextButton.classList.add('hidden');
    } else {
        nextButton.classList.remove('hidden');
    }
}