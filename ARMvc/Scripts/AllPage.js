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

$(document).ready(function () {
    //Mobile Menu
    $('.MobTopMenu').click(function () {
        if (!$('html').hasClass('show_menu')) {
            $('html').addClass('show_menu');
        } else {
            $('html').removeClass('show_menu');
        }
    });

    $('.MenuOverlay').click(function () {
        if ($('html').hasClass('show_menu')) {
            $('html').removeClass('show_menu');
        }
    });
});