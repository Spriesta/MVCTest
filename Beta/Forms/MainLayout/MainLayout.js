//'use strict';

$("#myButton").click(function () {
    var Id = $("#kisiID").val();
        $.ajax({
            url: '/Main/getList/' + Id,
            type: 'POST',
            dataType: 'json',
            success: function (data) {
                $("#kisiAdi").html(data[0].sName);
                $("#kisiTC").html(data[0].sTC);

            }
        });
});



























//$("p").hide(); // jquery çalışıyor

////isc.IButton.create({
////    title: "heyy",
////    left:50,top:30,
////    click: "isc.say('Hello world..!')"
////})

//isc.ListGrid.create({
//    ID: "countryList",
//    width: 500, height: 224, top: 50,left: 30, alternateRecordStyles: true,
//    fields: [
//        { name: "countryCode", title: "Flag", width: 60, type: "image", imageURLPrefix: "flags/16/", imageURLSuffix: ".png" },
//        { name: "countryName", title: "Country" },
//        { name: "capital", title: "Capital" },
//        { name: "continent", title: "Continent" }
//    ],
//    showEmptyMessage: true,
//    emptyMessage: "Click the <b>Set data</b> button to populate this grid."
//})