jQuery.validator.unobtrusive.adapters.add
("dateinferieurea", ["dateverif", "datereference"], function (options) {
    options.rules["dateinferieurea"] = options.params;
    options.messages["dateinferieurea"] = options.message;
});

jQuery.validator.
    addMethod("dateinferieurea", function (value, element, params) {
        if ($.trim(value) == '') { return true; }
        // Transformation date jj/mm/aaaa... en aaaa/mm/jj borne Inf
        // Mois en base 0 - Elimination des portions de temps
        var partiesDate = value.split("/");
        var dateInf = new Date(partiesDate[2].substring(0, 4), partiesDate[1] - 1, partiesDate[0]);
        var dateInf2 = Date.parse(value);
        // Transformation date jj/mm/aaaa... en aaaa/mm/jj borne Sup
        partiesDate = $("#" + params.datereference).val().split("/");
        var dateSup = new Date(partiesDate[2].substring(0, 4), partiesDate[1] - 1, partiesDate[0]);
        return dateInf <= dateSup;
    });

jQuery.validator.methods.date = function (value, element) {  
    if ($.trim(value) == '') { return true; }
    var partiesDate = value.split("/");
    var d = parseInt(partiesDate[0], 10);
    var m = parseInt(partiesDate[1], 10);
    var y = parseInt(partiesDate[2], 10);
    var dateTest = new Date(y,m-1,d);
    if (!Date.parse(dateTest)) { return false; }
    // éviter 32/01/--> 01/02
    return (dateTest.getFullYear() == y && dateTest.getMonth() + 1 == m && dateTest.getDate() == d);
}
$.validator.unobtrusive.adapters.add(
    'siretvalidation', [], function (options) {
        options.rules['siretvalidation'] = options.params;
        options.messages['siretvalidation'] = options.message;
    });

$.validator.addMethod("siretvalidation", function (value, element, params) {
    if ($.trim(value) == '') { return true; }
    var calcul = 0;
    var chiffre = 0;
    var impair = value.Length & 1;
    
    if (value.length < 14)
        return false;
    for (var i = 0; i < value.length; i++) {
        chiffre = parseInt(value[i]) * (2 - (i + impair) % 2);
        calcul += chiffre >= 10 ? chiffre - 9 : chiffre;
    }
    return (calcul % 10 == 0);
});
