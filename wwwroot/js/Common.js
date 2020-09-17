
$(document).ready(function () {
    $("tr #userName").each(function (i, val) {
        console.log(i, val, $(this).find("span").html())
        if ($(this).find("span").html() != "") {
            $(this).find("#togglebtn input").prop('checked', true);

            if ($(this).find("span").html() != $("#CurrentUser").val()) {
               // $(this).find(".textareaWidth").css("display", "block");
               // $(this).find("#sendButton").css("display", "block");
            }
            else {
                //$(this).next().hide();
               // $(this).next().next().hide();
            }
        }
        else {
            // $(this).find(".textareaWidth").css("Display", "None");
            //$(this).next().hide();
           // $(this).next().next().hide();
        }
    });


    $("tbody tr #togglebtn input").change(function (i, val) {
        var isActiveS = false;
        var isActiveP = false;
        var userS = "", userP = "";

        console.log(i, val);

        if ($(this).is(":checked")) {
            if ($(this).closest("div").find("span").is("#s_user")) {
                userS = $("#CurrentUser").val();
            }
            else {
                userS = $(this).closest("tr").find("#s_user").html();
            }
            if ($(this).closest("div").find("span").is("#p_user")) {
                userP = $("#CurrentUser").val();
            }
            else {
                userP = $(this).closest("tr").find("#p_user").html();
            }
        }
        else {
            if ($(this).closest("div").find("span").is("#s_user")) {
                userS = "";
            }
            else {
                userS = $(this).closest("tr").find("#s_user").html();
            }

            if ($(this).closest("div").find("span").is("#p_user")) {
                userP = "";
            }
            else {
                userP = $(this).closest("tr").find("#p_user").html();
            }
        }

        if (userS !== null && userS !== "") {
            isActiveS = true;
        }
        
        if (userP !== null && userP !== "") {
            isActiveP = true;
        }

        var data = {
            ID: $(this).closest("tr").data('id'),
            USER_S_ACCESS_BY: userS,
            USER_P_ACCESS_BY: userP,
            ISACTIVE_S: isActiveS,
            ISACTIVE_P: isActiveP,
        }
        var url = "/RemoteServerDetails/UpdateData";

        $.ajax({
            type: 'POST',
            url: url,
            contentType: "application/json; charset=utf-8",
            dataType: 'json',
            data: JSON.stringify(data),
            success: function (data) {
                window.location.href = data;
            }
        });

    })
});