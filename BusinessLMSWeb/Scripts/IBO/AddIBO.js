﻿
$(document).ready(function () {

    $(".date-picker").datepicker({
        yearRange: "-90:+0",
        changeMonth: true,
        changeYear: true
    });

    $('#file_upload').ajaxForm({
        beforeSubmit: function (a, f, o) {
            o.dataType = 'json';
            $('#status').html('Submitting...');
        },
        success: function (data) {
            file = data[0]
            $("#picture").val(file.Location);
            var $out = $('#status');
            $out.html('<img src="' + file.Location + '" style="max-width: 250px;" />');
        }
    });
    
});

function submitform() {
    $("#createIBOForm").submit();
}