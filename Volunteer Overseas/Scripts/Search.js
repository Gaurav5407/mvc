$(document).ready(function () {
    $('.column').owlCarousel({
        margin: 10,
        navText: ['<img class="arrow-left" src="../Images/left-white-arrow.png"/>', '<img class="arrow-right" src="../Images/right-white-arrow.png" />'],
        //navText: ["<div class='nav-btn prev-slide'></div>", "<div class='nav-btn next-slide'></div>"],
        nav: true,
        dots: false,
        responsiveClass: true,
        responsive: {
            0: {
                items: 1,

            },
            600: {
                items: 1,

            },
            1000: {
                items: 1,

            }
        }
    })
    $('#activity').dropkick();
    $('#age').dropkick();
    $('#sortby').dropkick();
    $('.dropkick-day').dropkick();
    $('.dropkick-month').dropkick();
    $(window).resize(function () {
        if ($(window).width() >= 768 && $(window).width() <= 1023) {
            $("#filter").html("...");
        }
        else {
            $("#filter").html("More Filter");
        }
    });
    if ($(window).width() >= 768 && $(window).width() <= 1023) {
        $("#filter").html("...");
    }
    

});
function myFunction() {
    document.getElementById("myForm").reset();
}
function sliderReset() {
    slider.noUiSlider.reset();
}
function filterApplier() {
    var counter = 0;
    if ($('#customCheck1').is(":checked") || $('#customCheck2').is(":checked") || $('#customCheck3').is(":checked")) {
        counter++;
    }
    if ($('#search-country').val() != "") {
        counter++;
    }
    if ($('#activity').val() != "") {
        counter++;
    }
    if ($('#age').val() != "") {
        counter++;
    }

    var flag = false;
    var str = ["start-year", "start-date", "start-month"]
    for (i = 0; i < str.length; i++) {

        if ($("#" + str[i]).val() == "") {
            flag = false;
            break;
        }
        else {
            flag = true;
        }
    }
    if (flag == true) {
        counter++;
    }

    var str = ["end-year", "end-date", "end-month"]
    for (i = 0; i < str.length; i++) {

        if ($("#" + str[i]).val() == "") {
            flag = false;
            break;
        }
        else {
            flag = true;
        }
    }
    if (flag == true) {
        counter++;
    }

    $('.badge').html(counter);

}
