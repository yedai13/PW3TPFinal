﻿using PW3.TPFinal.Repositorio.Data;
using System.Collections.Generic;

namespace PW3.TPFinal.Servicios.Contratos
{
    public interface IComensalServicio
    {
        List<Evento> ObtenerReservas(int idUsuario);

        IList<Evento> ObtenerEventosDisponibles();
    }
}
