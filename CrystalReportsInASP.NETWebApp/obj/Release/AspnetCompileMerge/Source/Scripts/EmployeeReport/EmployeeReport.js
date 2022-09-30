

$(document).ready(function () {

    $("#btnLoadReport").click(function () {

        ReportManager.LoadReport();

    });

});

var ReportManager = {

    LoadReport: function () {

        var jsonParam = "";
        var serviveUrl = "../Employee/GenerateEmployeeReport";

        ReportManager.GetReport(serviveUrl, jsonParam, onFailed);

        function onFailed(error) {
            alert("Found Error");
        }
    },

    GetReport: function (serviceUrl, jsonParams, errorCallback) {

        jQuery.ajax({

            url: serviceUrl,
            asyn: false,
            type: "POST",
            data: "{" + jsonParams + "}",
            contentType: "application/json;charset-utf-8",
            success: function () {
                window.open('../Report/EmployeeReportViewer.aspx', '_newtab');
            },
            error: errorCallback
        });

    }
}