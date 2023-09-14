namespace DTO
{
    public class PersonaDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; } //Has de meter con formato año-mes-dia
        public string? Telefono { get; set; }

    }
}