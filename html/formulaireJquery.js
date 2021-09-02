var selectPays = document.getElementById("selPays");

var mapPays = new Map
mapPays.set("fr",{"regnumero": /^[0-9]{11}$/,"regpostal": /^[0-9]{5}$/,"indPays": 33,"label":"France","id":"fr"});
mapPays.set("us",{"regnumero": /^[0-9]{11}$/,"regpostal": /^[0-9]{5}$/,"indPays": 1,"label":"US","id":"us"});
mapPays.forEach(function(item){
    var newElement = document.createElement("option")
    newElement.id = item.id;
    newElement.label = item.label;
    newElement.value = item.id;
    selectPays.appendChild(newElement);
})
$("#frmCoordonnees").validate({
    debug: true,
    rules:{
        nom:"required",
        prenom:"required",
        tel:{
            required: true,
            number:true,
            pattern: mapPays.get(selectPays.value).regnumero
        },
        codepostal:{
            required: true,
            number:true,
            pattern: mapPays.get(selectPays.value).regpostal
        }
    }
  })