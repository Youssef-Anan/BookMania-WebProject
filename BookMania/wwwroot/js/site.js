// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//---------------------------------------------BOOKS------------------------------------------------------------//
$(document).ready(function () {
    // Show all books initially
    $(".custombook").show();

    // Show books based on the selected checkboxes
    $(".type-checkbox").change(function () {
        var type = $(this).data("type");

        // Hide all books
        $(".custombook").hide();

        // Show books based on the selected checkboxes
        $(".type-checkbox:checked").each(function () {
            var type = $(this).data("type");
            if (type === "all") {
                $(".custombook").show();
                return false; // Exit the loop if "Show All" is selected
            }
            else if (type == "none") {
                $(".custombook").hide();
            }
            else {
                $(".custombook[data-type='" + type + "']").show();
            }
        });
    });
});
//------------------------------------------------------------------------------------------------------------//


