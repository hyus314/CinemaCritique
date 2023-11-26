let page = 1; 
let isLoading = false; 
let allMoviesLoaded = false;
let currentSearchTerm = '';
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

    $('#moviesContainer').empty();

    page = 1;

    loadMoreMovies();
})

function loadMoreMovies() {
    if (isLoading) return;
    isLoading = true;

    let selectedGenre = $('#genreDropdown').val();
    let selectedRatingFilter = $('#ratingDropdown').val();
    let selectedDateFilter = $('#dateDropdown').val();


    let filters = {
        genre: selectedGenre,
        rating: selectedRatingFilter,
        date: selectedDateFilter,
        search: currentSearchTerm
    }

    $.get('/Movie/MoviesForAllPage', { page: page, filters: filters }, function (data) {
        let movieList = $('<ul class="home-page-movies"></ul>');

        if (data.length == 0) {
            allMoviesLoaded = true;
        } else {
            allMoviesLoaded = false;
        }

        data.forEach(movie => {
            let movieItem = `
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