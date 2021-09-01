// demoDOM.js : utilisation du DOM en jQuery
//  
//  ajout en fin de zone de test
function onBtnClickFin() {
    $("#divtest").append($("#nouveau").val());
}
function onBtnClickAvant() {
    $("#pcible").before($(`<span>${$("#nouveau").val()}</span>`));
}
function onBtnClickApres() {
    $("#pcible").after($(`<span>${$("#nouveau").val()}</span>`));
}

// cette fonction crée ou initialise tous les composants
// du document et leur associe des méthodes événementielles
function initComponents() {
    $("#btnAjoutFin").click(onBtnClickFin);
    $("#btnAjoutAvant").on("click",onBtnClickAvant)
    $("#btnAjoutApres").on("click",onBtnClickApres)
}
// appelle la fonction d’initialisation après chargement du document
$(document).ready(initComponents);
var tttt = $("#p2")
//$("#p2").text(tttt[0].outerHTML)
console.log(tttt[0])
$("p").on({
    click: function () {
        //alert("cliqué");
        $("p").toggleClass("big");
    }, mouseover: function () {
        $(this).toggleClass("blue red");
    }, mouseout: function () {
        $(this).toggleClass("blue red");
    }
});
$("*").on({mouseenter: function (e) {
    $("#trace").text("=> entre dans :" + e.relatedTarget);
    }, mousemove: function(e){
        $("#axisX").text("( event.pageX, event.clientX ) : " + e.pageX +","+ e.clientX+":" + e.buttons );
        $("#axisY").text("( event.pageY, event.clientY ) : " + e.pageY +","+ e.clientY );
    }, keypress: function(e){
        console.log(e);
        $("#axisY").append("Key :"+ e.key)
    }
});
