"use strict"
var formValid = document.getElementById("btnEnvoyer");
var selectPays = document.getElementById("selPays");
var newPaysFr = document.createElement("option");
newPaysFr.setAttribute("id","fr");
newPaysFr.setAttribute("label","France");
newPaysFr.setAttribute("value","fr");
var newPaysUs = document.createElement("option");
newPaysUs.setAttribute("id","us");
newPaysUs.setAttribute("label","US");
newPaysUs.setAttribute("value","us");
selectPays.appendChild(newPaysFr);
selectPays.appendChild(newPaysUs);
var regNom = /[a-zA-Z]{3}/
var regNumero = /[0-9]{10}/
var regPostal = /[0-9]{5}/
var mapPays = new Map
mapPays.set("fr",{"regnumero": /^[0-9]{11}$/,"regpostal": /^[0-9]{5}$/,"indPays": 33});
mapPays.set("us",{"regnumero": /^[0-9]{11}$/,"regpostal": /^[0-9]{5}$/,"indPays": 1});
var info = mapPays.get(fr);
//formValid.addEventListener("click",validation);
var nom = document.getElementById("txtNom");
var codePostal = document.getElementById("txtCodePostal");
var numero = document.getElementById("txtTelephone");
numero.addEventListener("focus",eleFocus);
numero.addEventListener("blur",eleBlur);
nom.addEventListener("focus",eleFocus);
nom.addEventListener("blur",eleBlur);

function eleFocus(e){
    e.target.style.backgroundColor = 'red';
}
function eleBlur(e){
    let reg = mapPays.get(selectPays.value)
    e.target.value = e.target.value.replace(/[^0-9]/g,"")
    e.target.value = e.target.value.replace(/^0/g,reg.indPays)
    if (e.target.value.match(reg.regnumero)) 
    {
        e.target.value = "+"+e.target.value;
        removeOldAlert();
    }
    else
    {
        addAlert(e);
    }
}
function addAlert(e)
{
    removeOldAlert();
    var newAlert = document.createElement("p");
    newAlert.setAttribute("role", "alert");
    newAlert.setAttribute("id", "alert");
    var msg = document.createTextNode("ERREUR");
    newAlert.appendChild(msg);
    //e.currentTarget.appendChild(newAlert);
    e.target.insertAdjacentElement('afterend',newAlert);
}
function removeOldAlert()
{
    var oldAlert = document.getElementById("alert");
    if (oldAlert)
        oldAlert.remove();
}