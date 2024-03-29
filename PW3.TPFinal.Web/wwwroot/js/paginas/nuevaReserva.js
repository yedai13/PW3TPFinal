﻿var abrirNuevaReservaModal = function (evento) {
    $("#nuevaReservaModal").modal('show');

    let idEventoElement = $("#IdEvento");
    let nombreEventoElement = $("#nombreEvento");
    let selectElement = $("#RecetaElegida");

    nombreEventoElement.text(evento.Nombre);
    idEventoElement.val(evento.IdEvento);

    selectElement.empty();

    if (evento.Recetas && evento.Recetas.length > 0) {
        evento.Recetas.forEach(x => selectElement.append(new Option(x.Nombre, x.IdReceta)));
    }
    else {
        selectElement.append(new Option('Error', 0));
    }
};

$(document).ready(function () {

});