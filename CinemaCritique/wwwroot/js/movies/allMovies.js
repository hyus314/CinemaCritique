var page = 1; // keep track of the current page
var isLoading = false; // to avoid multiple requests

function loadMoreMovies() {
    if (isLoading) return;
    isLoading = true;

    var selectedGenre = $('#genreDropdown').val();

    $.get('/Movie/MoviesForAllPage', { page: page, genre: selectedGenre }, function (data) {
        var movieList = $('<ul class="home-page-movies"></ul>');

        data.forEach(movie => {
            var movieItem = `
            <li class="movie-element">
                <a href="/Movie/SelectedMovie/${movie.id}" class="movie-link">
                    <img src="${movie.coverPhotoURL}" alt="${movie.title}" class="movie-cover">
                    <p class="movie-title">${movie.title}</p>
                </a>
            </li>`;
            movieList.append(movieItem);
        });

        $('#moviesContainer').append(movieList);

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