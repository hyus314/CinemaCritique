document.addEventListener('DOMContentLoaded', function () {
    const carousel = document.getElementById('movieCarousel');
    const items = carousel.getElementsByClassName('carousel-item');
    const movieList = document.getElementById('movieList');
    const movieTitles = movieList.getElementsByClassName('movie-item');
    let currentIndex = 0;

    function activateItem(index) {
        items[currentIndex].classList.remove('active');
        movieTitles[currentIndex].classList.remove('selected');
        currentIndex = index;
        items[currentIndex].classList.add('active');
        movieTitles[currentIndex].classList.add('selected');
    }

    function handleMovieTitleClick(i) {
        activateItem(i);
    }

    document.getElementById('nextBtn').addEventListener('click', function () {
        activateItem((currentIndex + 1) % items.length);
    });

    document.getElementById('prevBtn').addEventListener('click', function () {
        activateItem((currentIndex - 1 + items.length) % items.length);
    });

    for (let i = 0; i < movieTitles.length; i++) {
        movieTitles[i].addEventListener('click', function () {
            handleMovieTitleClick(i);
        });
    }

    if (items.length > 0) {
        items[0].classList.add('active');
        movieTitles[0].classList.add('selected');
    }
});

