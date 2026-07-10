$(document).ready(function () {

    $("#eventForm").submit(function (event) {

        event.preventDefault();

        const eventName = $("#eventName").val().trim();

        if (eventName !== "") {

            $("<li>")
                .text(eventName)
                .appendTo("#eventList");

            $("#eventName").val("");

        }

    });

    $("#removeAll").click(function () {

        $("#eventList").empty();

    });

});
