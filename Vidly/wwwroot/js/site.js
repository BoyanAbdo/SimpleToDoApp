// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var $sortable = $('.sortable');

$sortable.on('click', function () {

    var $this = $(this);
    var asc = $this.hasClass('asc');
    var desc = $this.hasClass('desc');
    $sortable.removeClass('asc').removeClass('desc');
    if (desc || (!asc && !desc)) {
        $this.addClass('asc');
    } else {
        $this.addClass('desc');
    }

});