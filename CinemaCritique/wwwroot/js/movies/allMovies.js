var page = 1; 
var isLoading = false; 

$('#genreDropdown').change(function () {
    clearMovies();    
    page = 1;         
    loadMoreMovies(); 
});
function clearMovies() {
    $('#moviesContainer').empty();
}
function loadMoreMovies() {
    if (isLoading) return;
    isLoading = true;

    var selectedGenre = $('#genreDropdown').val();

    var filters = {
        genre: selectedGenre
    }

    $.get('/Movie/MoviesForAllPage', { page: page, filters: filters }, function (data) {
        var movieList = $('<ul class="home-page-movies"></ul>');

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
    if ($(window).scrollTop() + $(window).height() >= $(document).height() - 100) { // 100 is a threshold, change as required
        loadMoreMovies();
    }
});

// Initial Load
loadMoreMovies();