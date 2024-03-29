﻿using System.ComponentModel.DataAnnotations;

namespace PW3.TPFinal.Negocio.Modelos
{
    public class IngresarUsuarioModel
    {       
        [Required(ErrorMessage = "Email es requerido.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "El Email debe ser valido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password es requerido.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }    
    }
}
