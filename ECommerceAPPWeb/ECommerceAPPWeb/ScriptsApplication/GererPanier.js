$(document).ready(function () {
    $(".btn.btn-primary.Add").click(function (evt) {
        let url = "https://localhost:44349/GererPanier.hld";
        let data = 'action=add&id=' + encodeURIComponent(evt.currentTarget.dataset.productid);
        $.ajax({
            url: url,
            type: 'GET',
            data: data,
            dataType: "json",
            error: function (resultat, statut, erreur) {
                console.log("Erreur", erreur, statut);
            },
            complete: function (resultat) {
                afficherResultat(resultat.responseJSON);
            }
        });

    });

});

function afficherResultat(ligne) {
    var culture = navigator.language || navigator.userLanguage;
    $('#modDetail1')[0].innerText = "Le produit " + ligne.Name + " d'une valeur de " + (new Intl.NumberFormat(culture, { style: "currency", currency: "EUR" }).format(ligne.Price));
    $('#modDetail2')[0].innerText = "a été ajouté à votre panier.";
    $('#dialogueTransaction').modal('show');
}