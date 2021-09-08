'use strict'
var dataPlaces;
var autoCompleteCity;
$(function () {
    

    // Fetch all the forms we want to apply custom Bootstrap validation styles to
    var forms = $(".needs-validation")

    // Loop over them and prevent submission
    Array.prototype.slice.call(forms)
        .forEach(function (form) {
            form.addEventListener('submit', function (event) {
                if (!form.checkValidity()) {
                    event.preventDefault()
                    event.stopPropagation()
                }

                form.classList.add('was-validated')
            }, false)
        })


})
function jQueryRequest() {
    $.ajax({
        method: "GET",
        url: `https://api.zippopotam.us/fr/36200`,
        dataType: "json"
    }).done(function (data) {
        console.log(data);
        dataPlaces = data;
    }).fail(function(){
        alert("error")
    });
}
function tot(){
    dataPlaces.Places.forEach(element => {
        console.log(element)
    });
}