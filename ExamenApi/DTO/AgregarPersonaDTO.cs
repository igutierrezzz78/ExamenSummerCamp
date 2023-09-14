using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AgregarPersonaDTO
    {
        [Required(ErrorMessage = "El UserName de usuario es obligatorio.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [MinLength(6, ErrorMessage = "La contraseña debe tener al menos 6 caracteres.")]


        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden.")]
        public string ConfirmarPassword { get; set; }
        [Required(ErrorMessage = "El Nombre de usuario es obligatorio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Apellido de usuario es obligatorio.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento del usuario es obligatorio.")]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "El telefono del usuario es obligatorio.")]
        public string Telefono{ get; set; }
    }
}
