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
        //let movieList = $('<ul class="home-page-movies"></ul>');
        
        let movieList = document.createElement('ul');
        movieList.classList.add('home-page-movies');
        let movieContainer = document.getElementById('moviesContainer');
        if (data.length == 0) {
            allMoviesLoaded = true;
        } else {
            allMoviesLoaded = false;
        }

        //data.forEach(movie => {
        //    let movieItem = `
        //    <li class="movie-element">
        //        <a href="/Movie/SelectedMovie/${movie.id}" class="movie-link">
        //            <img src="${movie.coverPhotoURL}" alt="${movie.title}" class="movie-cover">
        //            <p class="movie-title">${movie.title}</p>
        //            <div class="movie-rating">${movie.rating}</div>
        //        </a>
        //    </li>`;
        //    movieList.append(movieItem);
        //});

        for (const movie of data) {
            const movieItem = document.createElement('li');
            movieItem.classList.add('movie-element');
            console.log(movie);

                const movieItemTag = document.createElement('a');
                movieItemTag.classList.add('movie-link');
                movieItemTag.setAttribute('href', `/Movie/SelectedMovie/${movie.id}`);

                    const movieCover = document.createElement('img');
                    movieCover.classList.add('movie-cover');
                    movieCover.setAttribute('src', `../${movie.coverPhotoURL}`);
                    movieCover.setAttribute('alt', movie.title);
                    // example::   link.setAttribute('href', 'https://example.com');

                    const movieTitle = document.createElement('p');
                    movieTitle.classList.add('movie-title');
                    movieTitle.innerHTML = movie.title;

                    const movieRating = document.createElement('div');
                    movieRating.classList.add('movie-rating');
                    movieRating.innerHTML = movie.rating;


                movieItemTag.appendChild(movieCover);
                movieItemTag.appendChild(movieTitle);
                movieItemTag.appendChild(movieRating);

            movieItem.appendChild(movieItemTag);
            movieList.appendChild(movieItem);
        }

        movieContainer.appendChild(movieList);

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