$(document).ready(function () {
    $(window).scroll(function () {

        if ($(window).scrollTop() > 0) {
            $(".navbar-ul li a").addClass('blue');
            $(".navbar-ul li a").removeClass('text-white');
            $('.banner-logo').attr('src', "../Images/logo.png");
            $('nav').addClass('nav-background');
            $('.header').addClass('nav-background');
            $(".header-link .login-form a").removeClass('text-white');
            $(".header-link .login-form a").addClass('blue');
            $(".header-link .login-form").removeClass('login-form');

            $(".header-link form").addClass('navscroll-login');
            $(".fa").addClass('fa-red');
            $(".fa").removeClass('fa-white');

        } else {
            $(".navbar-ul li a").addClass('text-white');
            $(".navbar-ul li a").removeClass('blue');
            $('nav').removeClass('nav-background');
            $('.header').removeClass('nav-background')
            $('.banner-logo').attr('src', "../Images/logo_1.png");
            $(".header-link form").addClass('login-form');
            $(".header-link .login-form a").removeClass('blue');
            $(".header-link .login-form a").addClass('text-white');
            $(".header-link .login-form").removeClass('navscroll-login');

            $(".fa").addClass('fa-white');
            $(".fa").removeClass('fa-red');
        }
    });
});