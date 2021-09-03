"use strict"
$(function () {
    $( "input:text" ).css("border-width","thick")
    $("#pseudo").on("keyup", function (event) {
        if ($(event.target).valid()) {

            $(event.target).css("border-color", "green");
        }
        else {
            $(event.target).css("border-color", "red");
        }
    })
    $("#password").on("keyup", function (event) {
        if ($(event.target).valid()) {

            $(event.target).css("border-color", "green");
        }
        else {
            $(event.target).css("border-color", "red");
        }
    })
    $("#confirm").on("keyup", function (event) {
        if ($(event.target).valid()) {

            $(event.target).css("border-color", "green");
        }
        else {
            $(event.target).css("border-color", "red");
        }
    })
    $("#mail").on("keyup", function (event) {
        if ($(event.target).valid()) {

            $(event.target).css("border-color", "green");
        }
        else {
            $(event.target).css("border-color", "red");
        }
    })
    $("#resetform").on("click",function(event){
        $("form").validate().resetForm();
        $( "input:text" ).css("border-color","")
    })
})

$("form").validate({
    debug: true,
    rules: {
        pseudo: {
            required: true,
            minlength: 5
        },
        password: {
            minlength: 5
        },
        confirm: {
            minlength: 5
        },
        mail:{

        }
    }
})