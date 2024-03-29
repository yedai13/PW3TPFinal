﻿using PW3.TPFinal.Repositorio.Data;
using System.Collections.Generic;

namespace PW3.TPFinal.Repositorio.Contratos
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario, int>
    {
        Usuario ObtenerPorEmail(string email);
    }
}
