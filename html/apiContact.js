'use strict'
var dataPlaces;
var ac = new Autocomplete(document.getElementById('city'), {
    maximumItems: 10,
    treshold: 0
});
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
$("#zipcode").on("change", function (event) {
    if (event.target.checkValidity()) {
        acRequest(event.target.value)
    }
})
function acRequest(zip) {
    $.ajax({
        method: "GET",
        url: `https://api.zippopotam.us/fr/${zip}`,
        dataType: "json"
    }).done(function (data) {
        console.log(data);
        dataPlaces = data;
        fillAutocompleteCity();
    }).fail(function () {
        alert("error")
    });
}
function fillAutocompleteCity() {
    let autoCompleteCity = new Array();
    dataPlaces.places.forEach(element => {
        console.log(element)
        autoCompleteCity.push({ label: element['place name'], value: element['place name'] })
    });
    ac.setData(autoCompleteCity)
}
function tot() {
    let fmData = $('form').serializeJSON()
    let coorPlace = dataPlaces.places.find(element => element['place name'] == $("#city").val());
    fmData.geo = {};
    fmData.geo.latitude = coorPlace.latitude;
    fmData.geo.longitude = coorPlace.longitude;
    console.log(fmData);
    $.ajax({
        method: "POST",
        url: "https://localhost:44331/api/users",
        processData: false,
        contentType: 'application/json',
        data: JSON.stringify(fmData)
    }).done(function (data) {
        console.log(data);
    });
}