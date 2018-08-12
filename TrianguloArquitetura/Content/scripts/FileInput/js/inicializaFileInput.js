$(document).ready(function () {
    $("#input-id").fileinput({ 'showUpload': false, 'previewFileType': 'any' });
}); 

$("#input-id").fileinput({
    theme: 'fa',
    language: 'pt-BR',
    showUpload: false,
    showCaption: false,
    browseClass: "btn btn-primary btn-lg",
    fileType: "any",
    previewFileIcon: "<i class='glyphicon glyphicon-king'></i>",
    overwriteInitial: false,
    initialPreviewAsData: true,
    slugCallback: function (filename) {
        return filename.replace('(', '_').replace(']', '_');
    }
});
