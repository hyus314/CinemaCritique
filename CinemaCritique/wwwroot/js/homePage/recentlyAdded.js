document.addEventListener('DOMContentLoaded', function () {
    const carousel = document.getElementById('movieCarousel');
    const items = carousel.getElementsByClassName('carousel-item');
    let currentIndex = 0;

    function activateItem(index) {
        items[currentIndex].classList.remove('active');
        currentIndex = index;
        items[currentIndex].classList.add('active');
    }

    document.getElementById('nextBtn').addEventListener('click', function () {
        activateItem((currentIndex + 1) % items.length);
    });

    document.getElementById('prevBtn').addEventListener('click', function () {
        activateItem((currentIndex - 1 + items.length) % items.length);
    });

    if (items.length > 0) {
        items[0].classList.add('active');
    }
});