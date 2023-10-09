var page = 1; // keep track of the current page
var isLoading = false; // to avoid multiple requests

function loadMoreMovies() {
    if (isLoading) return;
    isLoading = true;

    $.get('/Movie/MoviesForAllPage', { page: page }, function (data) {
        // Append movies to your container
        data.forEach(movie => {
            var movieCard = `
                <div class="movie-card">
                    <img src="${movie.coverPhotoURL}" alt="${movie.title}" class="movie-cover">
                    <div class="movie-details">
                        <h3 class="movie-title">${movie.title}</h3>
                        <p class="movie-year">${movie.yearPublished}</p>
                    </div>
                </div>`;
            $('#moviesContainer').append(movieCard);
        });

        page++; // Increment page number
        isLoading = false;
    });
}

$(window).scroll(function () {
    if ($(window).scrollTop() + $(window).height() >= $(document).height() - 100) { // 100 is a threshold, change as required
        loadMoreMovies();
    }
});

// Initial Load
loadMoreMovies();