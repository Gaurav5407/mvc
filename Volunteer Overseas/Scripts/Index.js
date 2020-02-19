$(document).ready(function () {
    $(".datepicker").datepicker({

        dateFormat: "mm-dd-yy"
    });
    $('.duration1').dropkick();
    $('.duration2').dropkick();

    $(window).resize(function () {
        $("#myscrollspy").css("width", $('.col-lg-8').width());

    });
    var navScroll = $("#myscrollspy").offset().top - $('.header').height();
    var formScroll = $("#form").offset().top - $('.header').height();
    $(".fa").addClass('fa-white');
    $(window).scroll(function () {
        if ($(window).scrollTop() > navScroll) {
            $('#myscrollspy').addClass('fixednav2');
            $('#myscrollspy').addClass('shadow');

            $("#myscrollspy").css("top", $('.header').height());
        }
        else {
            $('#myscrollspy').removeClass('fixednav2');
            $("#myscrollspy").removeAttr("top");
            $('#myscrollspy').removeClass('shadow');
        }
        if ($(window).scrollTop() > formScroll) {
            $('#form').addClass('formsticky');
            $("#form").css("top", $('.header').height());
        } else {
            $('#form').removeClass('formsticky');
            $("#form").removeAttr("top");
        }

    });

    $("#trending").owlCarousel({
        loop: false,
        dots: false,
        nav: true,
        navText: ["<div class='nav-btn1 prev-slide'></div>", "<div class='nav-btn2 next-slide'></div>"],
        navClass: ['owl-prev', 'owl-next'],
        mouseDrag: false,
        pagination: false,
        paginationNumbers: false,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 2
            },
            1000: {
                items: 4
            }
        }
    })



});

