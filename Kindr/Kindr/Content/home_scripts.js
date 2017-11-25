function upButtonSlideUp() {
    $('html, body').animate({
        scrollTop: ($("#about-us").offset().top - 100)
    }, 1000);
}