var page = 1; 
var isLoading = false; 
var allMoviesLoaded = false;
var currentSearchTerm = '';
$('#dateDropdown, #genreDropdown, #ratingDropdown').change(function () {
    clearMovies();
    page = 1;
    loadMoreMovies();
});

function clearMovies() {
    $('#moviesContainer').empty();
}

$('#searchButton').on('click', function () {
    currentSearchTerm = $('#movieSearchInput').val().trim();

    $('#moviesContainer').emtpy();

    page = 1;

    loadMoreMovies();
})

function loadMoreMovies() {
    if (isLoading) return;
    isLoading = true;

    var selectedGenre = $('#genreDropdown').val();
    var selectedRatingFilter = $('#ratingDropdown').val();
    var selectedDateFilter = $('#dateDropdown').val();


    var filters = {
        genre: selectedGenre,
        rating: selectedRatingFilter,
        date: selectedDateFilter,
        search: currentSearchTerm
    }

    $.get('/Movie/MoviesForAllPage', { page: page, filters: filters }, function (data) {
        var movieList = $('<ul class="home-page-movies"></ul>');

        if (data.length == 0) {
            allMoviesLoaded = true;
        } else {
            allMoviesLoaded = false;
        }

        data.forEach(movie => {
            var movieItem = `
            <li class="movie-element">
                <a href="/Movie/SelectedMovie/${movie.id}" class="movie-link">
                    <img src="${movie.coverPhotoURL}" alt="${movie.title}" class="movie-cover">
                    <p class="movie-title">${movie.title}</p>
                    <div class="movie-rating">${movie.rating}</div>
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
    if (!allMoviesLoaded && $(window).scrollTop() + $(window).height() >= $(document).height() - 100) {
        loadMoreMovies();
    }
});

// Initial Load
loadMoreMovies();