"use strict"
var tableDataImport;

$("#xmlhttp").click(createTable);
$("#jquery").on("click",{dataset: jQueryRequest},createTable)
// $("#fetch").on("click",createTable(fetchRequest));

function getXMLHttpRequest() {
    var xmlHttpR = new XMLHttpRequest();
    xmlHttpR.open("GET", "https://jsonplaceholder.typicode.com/posts?userid=1");
    xmlHttpR.onreadystatechange = function () {
        if (xmlHttpR.readyState == 4 && xmlHttpR.status == 200) {
            console.log(xmlHttpR.responseText);
            return JSON.parse(xmlHttpR.responseText);
        }
    }
    xmlHttpR.send(null);
}
function jQueryRequest() {
    $.ajax({
        method: "GET",
        url: "https://jsonplaceholder.typicode.com/posts?userid=1",
    }).done(function (data) {
        console.log(data);
        return data;
    });
}
function fetchRequest() {
    fetch("https://jsonplaceholder.typicode.com/posts")
        .then(function (res) {
            if (res.ok) {
                return res.json();
            }
        })
        .then(data => console.log(data));
}
function createTable(event) {
    console.log(event.data.dataset);
    $('#table_id').DataTable({
        data: event.data.dataset,
        "columns": [
            { data: "userId" },
            { data: "id" },
            { data: "title" },
            { data: "body" }
        ]
    });
}
function createTable2() {
    $('#table_id').DataTable({
        "ajax": {
            url: "https://jsonplaceholder.typicode.com/posts?userid=1",
            "dataSrc": ""
        },
        "columns": [
            { data: "userId" },
            { data: "id" },
            { data: "title" },
            { data: "body" }
        ]
    });
}

