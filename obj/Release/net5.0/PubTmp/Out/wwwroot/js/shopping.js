"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/shopping").build();
connection.start().then(function () {
}).catch(function (err) {
    return console.error(err.toString());
});

var cartId = document.querySelector("#cart-id");
var value = cartId.value;
connection.on("UserConnected", function (connectionId) {
    connection.invoke("AddToGroup", value, connectionId);
});

connection.on("ShoppingListUpdated", function (container) {
    var newList = document.querySelector("newList");
    $.ajax({
        type: "POST",
        url:`@Url.Action`
    })
})