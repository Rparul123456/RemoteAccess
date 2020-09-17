"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.addEventListener("DOMContentLoaded", function (event) {
    $("tr #userName").each(function (i, val) {
        $(this).find("#sendButton").disabled = true;
    })
});

connection.on("ReceiveMessage", function (message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
   // var encodedMsg = user + " says: ";
    alert(msg);
    Push.create(encodedMsg, {
        body: msg,
        timeout: 4000,
        onClick: function () {
            window.focus();
            this.close();
        }
    }).catch(function (err) {
        return console.log(err.toString());
    });
});


connection.start().then(function () {
    console.log('Connected!');
//    $("tr #userName").each(function (i, val) {
//        $(this).find("#sendButton").disabled = false;
//    })
//}).catch(function (err) {
//    return console.log(err.toString());

    connection.invoke('getConnectionId')
        .then(function (connectionId) {
            sessionStorage.setItem('conectionId', connectionId);
            console.log("aaya mai");
            // Send the connectionId to controller
        }).catch(err => console.error(err.toString()));
});


function getMessage(data) {
    var user = document.getElementById("CurrentUser").value;
    var message = data.previousElementSibling.value;
    var connectionId = sessionStorage.getItem('conectionId');
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.log(err.toString());
    });
    event.preventDefault();
}
// We need an async function in order to use await, but we want this code to run immediately,
// so we use an "immediately-executed async function"
//(async () => {
//    try {
//        await connection.start();
//    }
//    catch (e) {
//        console.log(e.toString());
//    }
//})();
