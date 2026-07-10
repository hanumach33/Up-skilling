$(document).ready(function () {

    $("#eventBox").click(function () {
        $(this).css("background-color", "lightgreen");
        $("#message").text("Box Clicked");
    });

    $("#eventBox").dblclick(function () {
        $(this).css("background-color", "lightcoral");
        $("#message").text("Box Double Clicked");
    });

    $("#eventBox").mouseenter(function () {
        $(this).css("background-color", "lightblue");
        $("#message").text("Mouse Entered");
    });

    $("#eventBox").mouseleave(function () {
        $(this).css("background-color", "lightgray");
        $("#message").text("Mouse Left");
    });

    $("#name").keypress(function () {
        $("#message").text("Key Pressed: " + $(this).val());
    });

});
