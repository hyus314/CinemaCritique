
$(document).ready(function () {
    $('#loadMoreReviews').on('click', function () {
        var movieId = $(this).data('movieid');
        let currentPage = 1;
        currentPage++;
        fetchUpdatedReviews(movieId, currentPage);
    });
});

function fetchUpdatedReviews(movieId, currentPage) {
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

var movieId = $('#hiddenMovieId').val();

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

function createPagination(totalPages) {
    var paginationContainer = $('#paginationPages');

    paginationContainer.empty(); 

    for (var i = 1; i <= totalPages; i++) {
        var pageButton = $('<button class="page-number">' + i + '</button>');
        paginationContainer.append(pageButton);
    }

    paginationContainer.on('click', '.page-number', function () {
        $(this).addClass('active'); 

        var pageNumber = $(this).text();
        fetchUpdatedReviews(movieId, pageNumber);
    });
}
