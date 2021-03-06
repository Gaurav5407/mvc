﻿$(document).ready(function () {
    // Add minus icon for collapse element which is open by default
    $(".collapse.show").each(function () {
        $(this).prev(".card-header").find(".arrow").addClass("flip").removeClass("arrow-down");
    });

    // Toggle plus minus icon on show hide of collapse element
    $(".collapse").on('show.bs.collapse', function () {
        $(this).prev(".card-header").find(".arrow").removeClass("arrow-down").addClass("flip");
    }).on('hide.bs.collapse', function () {
        $(this).prev(".card-header").find(".arrow").removeClass("flip").addClass("arrow-down");
    });
});