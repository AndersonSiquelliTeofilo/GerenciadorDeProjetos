function GetHtml(url) {
    return $.ajax({
        url: url,
        cache: false,
        dataType: "html",
        contentType: "application/html; charset=utf-8"
    });
}

$(document).ready(function () {
    $(".btn-modal").click(function (e) {
        e.preventDefault = true;

        let url = $(".btn-modal").data("target");

        GetHtml(url).done(function (data) {
            $("#btn-modal").children(".modal-dialog").html(data);
            $("#btn-modal").modal("show");

        }).fail(function () {
            alert("Oops... algo deu errado, tente novamente. Se não conseguir, contacte o administrador");

        });

    });
});