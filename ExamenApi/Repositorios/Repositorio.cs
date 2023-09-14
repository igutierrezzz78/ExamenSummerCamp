using System.Threading.Tasks;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelos;

namespace Repositorios
{
    public class Repositorio : IRepositorio
    {
         private readonly ContextoConversor db;
        public Repositorio(ContextoConversor db)
        {
            this.db = db;
        }
        public List<Persona> MostrarPersonas()
        {

            List<Persona> lista = new List<Persona>();
            lista = db.Persona.ToList();//Devuelve la tabla de Monedas en formato lista
            return lista;
        }
        public List<Persona> MostrarPersonasMayoresDe21()
        {
            List<Persona> listaMayoresDe21 = db.Persona
                .AsEnumerable()
                .Where(p => CalcularEdad(p.FechaNacimiento) > 21)
                .OrderBy(n => n.Nombre)
                .Take(10)
                .ToList();
            return listaMayoresDe21;
        }



        private int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;
            if (fechaActual.Month < fechaNacimiento.Month || (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day))
            {
                edad--;
            }
            return edad;
        }
        public async Task<Persona> FindUsuarioPoruserNameAsync(string username)
        {
            username = username.ToUpper(); // Normalizar el nombre de usuario
            return await db.Persona.FirstOrDefaultAsync(p => p.UserName.ToUpper() == username);
        }


        public async Task RegistrarUsuario(Persona user)
        {

            db.Add(user);
            await db.SaveChangesAsync();

        }
        public async Task<IEnumerable<Persona>> GetMonedasAsync()
        {
            return await db.Persona.ToListAsync();
        }
    }
}