

var movieId = $('#hiddenMovieId').val();

document.addEventListener('DOMContentLoaded', function () {
    var previousButton = document.getElementById('previousPage');
    var nextButton = document.getElementById('nextPage');
    var reviewsCount = parseInt(document.getElementById('reviewsCountOfPage').value);
    var paginationContainer = $('.pagination-container');

    function updatePaginationButtons(selectedPage) {
        var previousPage = selectedPage ? selectedPage.previousElementSibling : null;
        var nextPage = selectedPage ? selectedPage.nextElementSibling : null;

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

    function handlePaginationClick(pageNumber) {
        var selectedPage = $(`.page-number:contains('${pageNumber}')`)[0];
        $('.page-number').removeClass('selected');
        $(selectedPage).addClass('selected');

        fetchUpdatedReviewsPagination(movieId, pageNumber);
        updatePaginationButtons(selectedPage);
    }

    previousButton.addEventListener('click', function () {
        var selectedPage = document.querySelector('.pagination-pages .selected');
        var previousPage = selectedPage.previousElementSibling;

        if (previousPage) {
            selectedPage.classList.remove('selected');
            previousPage.classList.add('selected');

            var currentPage = previousPage.textContent;
            handlePaginationClick(currentPage);
        }
    });

    nextButton.addEventListener('click', function () {
        var selectedPage = document.querySelector('.pagination-pages .selected');
        var nextPage = selectedPage.nextElementSibling;

        if (nextPage) {
            selectedPage.classList.remove('selected');
            nextPage.classList.add('selected');

            var currentPage = nextPage.textContent;
            handlePaginationClick(currentPage);
        }
    });

    paginationContainer.on('click', '.page-number', function () {
        var pageNumber = $(this).text();
        handlePaginationClick(pageNumber);
    });

    // Initial button visibility check
    updatePaginationButtons(document.querySelector('.pagination-pages .selected'));
});


$.ajax({
    url: '/Review/GetTotalPages',
    type: 'GET',
    data: { movieId: movieId },
    success: function (response) {
        createPagination(response);
    },
    error: function (error) {
        console.error("Error fetching total pages:", error);
    }
});

let paginationContainer = $('#paginationPages');
function createPagination(totalPages) {

    paginationContainer.empty();

    for (var i = 1; i <= totalPages; i++) {
        let pageButton;
        if (i == 1) {
            pageButton = $('<button class="page-number selected">' + i + '</button>');
        }
        else {
            pageButton = $('<button class="page-number">' + i + '</button>');
        }
        paginationContainer.append(pageButton);
    }

}

function fetchUpdatedReviewsPagination(movieId, currentPage) {
    $.ajax({
        type: 'GET',
        url: '/Review/GetUpdatedReviews',
        data: { movieId: movieId, page: currentPage },
        success: function (response) {
            $('#reviewsContainer').html(response);
        },
        error: function (error) {
            console.error("Error fetching updated reviews:", error);
        }
    });
}