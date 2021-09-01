"use strict"
var mapPays = new Map;
mapPays.set("fr",{"regnumero": /[0-9]{10}/,"regpostal": /[0-9]{5}/});
var newPays = document.createElement("option");
newPays.setAttribute("id","fr");
newPays.setAttribute("label","France");
newPays.setAttribute("value","fr");
var codePostal = document.getElementById("txtCodePostal")
codePostal.addEventListener("blur",checkTxt)
function checkTxt(){
    console.log(codePostal.checkValidity())
    ;
};