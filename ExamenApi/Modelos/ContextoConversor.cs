using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelos
{
    public class ContextoConversor : DbContext
    {
        public ContextoConversor(DbContextOptions<ContextoConversor> opciones) : base(opciones)
        {

        }

        public DbSet<Persona> Persona { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Persona>().HasData(
               new Persona()
               {
                   id = 1,
                   UserName = "Sandra",
                   Nombre = "Sandra",
                   apellido = "Jimenez",
                   FechaNacimiento = new DateTime(2003, 09, 23),
                   Telefono = "638354533",
                   password = "1234567"
               },
                     new Persona()
                     {
                         id = 2,
                         UserName = "Pepe",
                         Nombre = "pepe",
                         apellido = "Jimenez",
                         FechaNacimiento = new DateTime(1990, 09, 23),
                         Telefono = "63234233",
                         password = "1234567"
                     },
                           new Persona()
                           {
                               id = 3,
                               UserName = "Juan",
                               Nombre = "Juan",
                               apellido = "Jimenez",
                               FechaNacimiento = new DateTime(1945, 09, 23),
                               Telefono = "638234533",
                               password = "1234567"
                           },
                                 new Persona()
                                 {
                                     id = 4,
                                     UserName = "Andres",
                                     Nombre = "Andres",
                                     apellido = "Jimenez",
                                     FechaNacimiento = new DateTime(2006, 09, 23),
                                     Telefono = "63567533",
                                     password = "1234567"
                                 },
                                       new Persona()
                                       {
                                           id = 5,
                                           UserName = "Fernando",
                                           Nombre = "Fernando",
                                           apellido = "Jimenez",
                                           FechaNacimiento = new DateTime(2008, 09, 23),
                                           Telefono = "632344533",
                                           password = "1234567"
                                       },
                                             new Persona()
                                             {
                                                 id = 6,
                                                 UserName = "Jose",
                                                 Nombre = "Jose",
                                                 apellido = "Jimenez",
                                                 FechaNacimiento = new DateTime(2001, 09, 23),
                                                 Telefono = "634324533",
                                                 password = "1234567"
                                             },
                                                   new Persona()
                                                   {
                                                       id = 7,
                                                       UserName = "Dani",
                                                       Nombre = "Dani",
                                                       apellido = "Jimenez",
                                                       FechaNacimiento = new DateTime(1983, 09, 23),
                                                       Telefono = "634324533",
                                                       password = "1234567"
                                                   },
                                                    new Persona()
                                                    {
                                                        id = 8,
                                                        UserName = "Laura",
                                                        Nombre = "Laura",
                                                        apellido = "Gomez",
                                                        FechaNacimiento = new DateTime(1995, 06, 15),
                                                        Telefono = "631234567",
                                                        password = "1234567"
                                                    },
               new Persona()
               {
                   id = 9,
                   UserName = "Carlos",
                   Nombre = "Carlos",
                   apellido = "Perez",
                   FechaNacimiento = new DateTime(1987, 02, 10),
                   Telefono = "636789012",
                   password = "1234567"
               },
               new Persona()
               {
                   id = 10,
                   UserName = "Isabel",
                   Nombre = "Isabel",
                   apellido = "Lopez",
                   FechaNacimiento = new DateTime(1993, 11, 30),
                   Telefono = "639567890",
                   password = "1234567"
               }
               );
        }
    }
}
