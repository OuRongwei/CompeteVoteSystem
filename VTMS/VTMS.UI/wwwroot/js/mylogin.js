$(function () {
    $("#create").click(function () {
        check_register();
        return false;
    })
    //$("#login").click(function () {
    //    check_login();
    //    return false;
    //})
    $('.message a').click(function () {
        $('form').animate({
            height: 'toggle',
            opacity: 'toggle'
        }, 'slow');
    });
})