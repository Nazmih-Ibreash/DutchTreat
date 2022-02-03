$(document).ready(function () {

    var theForm = $("#theForm");
    theForm.hide();

    var button = $("#buybutton");
    button.on("click", function () {
        console.log('Buying Item Done!');
    });

    var productInfo = $(".product-info li");
    productInfo.on("click", function () {
        console.log("you clicked on " + $(this).text());
    });


    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        $popupForm.toggle(1000);
    });
});
