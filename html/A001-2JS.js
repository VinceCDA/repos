var el = document.getElementById("btnChoix");
el.addEventListener("click",showTxt);
var btnRad = document.getElementsByName("btnRadChoix");
var txtChoix = document.getElementById("txtChoix");
btnRad.forEach(item => console.log(item.checked));
function showTxt(){
    btnRad.forEach(item => {
        if (item.checked == true) txtChoix.value = item.value
    });
}
(function(){
    btnRad.forEach(item => {
        if (item.checked == true) txtChoix.value = item.value
    });
}());