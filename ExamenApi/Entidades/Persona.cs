using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Persona
    {
        public int id { get; set; }
        public string UserName { get; set; }

        [MaxLength(50)]
        public string Nombre { get; set; }
    
        public string apellido { get; set; }

        public string password { get; set; }

        public DateTime FechaNacimiento { get; set; }
        [MaxLength(25)]
        public string? Telefono { get; set; }
    }
}