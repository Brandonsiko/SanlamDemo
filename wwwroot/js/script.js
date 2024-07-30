
document.addEventListener('DOMContentLoaded', function () {
var swiper = new Swiper('.swiper-container', {
slidesPerView: 1,
spaceBetween: 10,
pagination: {
    el: '.swiper-pagination',
clickable: true,
        },
effect: 'fade', // This will create a fading effect between slides
fadeEffect: {
    crossFade: true,
        },
    });
});

