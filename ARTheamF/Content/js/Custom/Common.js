function fnShowLoader() {
    setTimeout(function () {
        $('div.overlay').show();
    }, 500);    
}
function fnHideLoader() {
    setTimeout(function () {
        $('div.overlay').hide();
    }, 500);
}
