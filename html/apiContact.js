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
                else{
                    event.preventDefault()
                    submitForm()
                }

                form.classList.add('was-validated')
            }, false)
        });
        $("#zipcode").on("change", function (event) {
            if (event.target.checkValidity()) {
                acRequest(event.target.value)
            }
        });
        $("#imginput").on("change",function(event){
            $("#previewImg").attr("src",URL.createObjectURL(event.target.files[0]))
            //if (isValidFile(event.target.files[0].name)) {
            //    $("#previewImg").attr("src",URL.createObjectURL(event.target.files[0]))
            //    event.target.validity.valid = true;
            //}
            //else{
            //    event.target.validity.valid = false;
            //}
            
            //document.getElementById('previewImg').src = URL.createObjectURL(event.target.files[0])
        })
        $("#resetButton").on("click",function(event){
            $("#previewImg").attr("src","http://placehold.jp/150x150.png");
            $("#contactForm").removeClass("was-validated");
        })


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
function submitForm() {
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
        console.log(data.userId);
        var dataImg = new FormData()
        dataImg.append('files', $('#imginput')[0].files[0]);
        for (var value of dataImg.values()) {
            console.log(value);}
        $.ajax({
            method: "POST",
            url: `https://localhost:44331/api/Upload/${data.userId}`,
            cache: false,
            processData: false,
            contentType: false,
            data: dataImg
        }).done(function(){
            alert("reussi")
        }).fail(function(){
            alert("error")
        })
    });
}
function isValidFile(file) {
    var extension = file.substr((file.lastIndexOf('.') +1));
    if (/(png|jpg|jpeg|gif)$/ig.test(extension)) {
      return true;
    }
    else{
        return false;
    }
  }