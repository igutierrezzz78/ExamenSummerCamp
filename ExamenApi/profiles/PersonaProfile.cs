using AutoMapper;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DTO;

namespace profiles
{
    public class PersonaProfile : Profile
    {
         public PersonaProfile()
        {
            CreateMap<Persona,PersonaDTO>().ReverseMap();
             CreateMap<Persona, AgregarPersonaDTO>().ReverseMap();
        
        }
    }
}