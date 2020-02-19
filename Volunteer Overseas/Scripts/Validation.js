function validateLoginForm() {
    var userName = document.forms["login-form"]["Username"].value;
    var passWord = document.forms["login-form"]["Password"].value;
    if (userName == "gaurav" && passWord == "tatva123") {
        alert("You successfully login");
        return true;
    }
    else {
        alert("Please enter a valid username and password");
        return false;
    }
}
function validateForgotPasswordForm() {
    var newPassword = document.forms["forgot-password"]["New Password"].value;
    var confirmPassword = document.forms["forgot-password"]["Confirm Password"].value;
    if (newPassword != confirmPassword) {
        document.getElementById("New Password").value = "";
        document.getElementById("Confirm Password").value = "";
        alert("Please enter a same new password and confirm password");
        return false;

    }
    else {
        alert("asdsadasd");
        return true;
    }
}
function validateSignUpForm() {
    var email = document.forms["sigun-up"]["email"].value;
    var phoneNo = document.forms["sigun-up"]["phoneno"].value;
    var mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    if (email.match(mailformat)) {
        return true;
    }
    else {
        alert("You have entered an invalid email address!");
        return false;
    }
    var phoneNoFormat = /^\+?([0-9]{2})\)?[-. ]?([0-9]{4})[-. ]?([0-9]{4})$/;
    if (phoneNo.match(phoneNoFormat)) {
        return true;
    }
    else {
        alert("you have entered an invalid phone no!");
        return false;
    }
}

$(document).ready(function () {
    $("#Duration").dropkick();
    $("#datepicker").datepicker({
        dateFormat: "mm-dd-yy"
    })
});

function validateProjectDetail() {
    var min = document.forms["project-detail"]["min-age"].value;
    var max = document.forms["project-detail"]["max-age"].value;
    if (min > max) {
        alert("your min age is greater than max age");
    }
}

function validateInquiry() {
    var message = document.forms["contact"]["message"].value;
    var email = document.forms["contact"]["email_id"].value;
    if (message.length > 2000) {
        alert("Your message length should not greater than 2000");
        return false;
    }
    else {
        return true;
    }
    var mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    if (email.match(mailformat)) {
        return true;
    }
    else {
        alert("You have entered an invalid email address!");
        return false;
    }
}