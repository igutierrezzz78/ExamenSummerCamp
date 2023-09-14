using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelos;


namespace Repositorios
{
    public interface IRepositorio
    {
        List<Persona> MostrarPersonasMayoresDe21();
        Task<IEnumerable<Persona>> GetMonedasAsync();
        Task RegistrarUsuario(Persona user);
         Task<Persona> FindUsuarioPoruserNameAsync(string username);
    }
}
