"use strict"
$(function(){
    $("#pseudo").on("keypress",function(event){
        console.log($(event.target))
        if ($(event.target).checkValidity()) {
            
            $(event.target).css("border-color","green")
        }
    })
    $("#password")
    $("#confirm")
    $("#mail")
})
$("form").validate({
    debug: true,
    rules:{
        pseudo:"required",
        password:"required",
    }
  })