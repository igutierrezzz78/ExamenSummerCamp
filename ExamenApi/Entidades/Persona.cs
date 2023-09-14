namespace Entidades
{
    public class Persona
    {
        public int id { get; set; }
        public string Nombre { get; set; }
    
        public string apellido { get; set; }

        public string password { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string? Telefono { get; set; }
    }
}