
$('.basicAutoSelect').autoComplete();
$('.basicAutoSelect').on('autocomplete.select', function (evt, item) {
    console.log(item);
    /*$('.basicAutoSelectSelected').html(item ? JSON.stringify(item) : 'null');*/
    $('#MainContent_codeRome').val(item.value);

})