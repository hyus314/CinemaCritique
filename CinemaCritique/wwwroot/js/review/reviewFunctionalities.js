

let movieId = $('#hiddenMovieId').val();

$(document).ready(function () {
    setTimeout(function () {
        console.log('2 seconds have passed.');
        let previousButton = $('#previousPage');
        let nextButton = $('#nextPage');
        let paginationContainer = $('.pagination-container');

        console.log('the javascript loaded first');

        previousButton.off();
        nextButton.off();
        paginationContainer.off();

        function updatePaginationButtons(selectedPage) {
            let previousPage = selectedPage ? selectedPage.prev() : null;
            let nextPage = selectedPage ? selectedPage.next() : null;

            if (!previousPage.length) {
                previousButton.addClass('hidden');
            } else {
                previousButton.removeClass('hidden');
            }

            if (!nextPage || !nextPage.length || nextPage.hasClass('disabled')) {
                nextButton.addClass('hidden');
            } else {
                nextButton.removeClass('hidden');
            }
        }
        function handlePaginationClick(pageNumber) {
            let selectedPage = $(`.page-number:contains('${pageNumber}')`);
            $('.page-number').removeClass('selected');
            selectedPage.addClass('selected');

            fetchUpdatedReviewsPagination(movieId, pageNumber);
            updatePaginationButtons(selectedPage);
        }

        previousButton.on('click', function () {
            let selectedPage = $('.pagination-pages .selected');
            let previousPage = selectedPage.prev();

            if (previousPage.length) {
                selectedPage.removeClass('selected');
                previousPage.addClass('selected');

                let currentPage = previousPage.text();
                handlePaginationClick(currentPage);
            }
        });

        nextButton.on('click', function () {
            let selectedPage = $('.pagination-pages .selected');
            let nextPage = selectedPage.next();

            if (nextPage.length) {
                selectedPage.removeClass('selected');
                nextPage.addClass('selected');

                let currentPage = nextPage.text();
                handlePaginationClick(currentPage);
            }
        });

        paginationContainer.on('click', '.page-number', function () {
            let pageNumber = $(this).text();
            handlePaginationClick(pageNumber);
        });

        // Initial button visibility check
        updatePaginationButtons($('.pagination-pages .selected'));
        // Place your subsequent code here...
    }, 2000);


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

    for (let i = 1; i <= totalPages; i++) {
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