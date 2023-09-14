using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Entidades;
using Repositorios;
using AutoMapper;
using DTO;

namespace ExamenApi.Controllers
{
    [Route("api/personas")]
    [ApiController]
    public class PersonasController : Controller
    {
        private readonly IRepositorio repodb;
        private readonly IMapper _mapper;
        private IConfiguration _configuration;

        public PersonasController(IRepositorio repodb, IMapper mapper, IConfiguration configuration)
        {
            this.repodb = repodb;
            _mapper = mapper ??
            throw new ArgumentNullException(nameof(mapper));
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<ActionResult<List<PersonaDTO>>> GetMonedas()
        {
           
            IEnumerable<Persona> monedasFromRepo = await repodb
                .GetMonedasAsync();

            // return them
            //! STATUS = 200
            return Ok(_mapper.Map<List<PersonaDTO>>(monedasFromRepo));
        }
        [HttpGet("mayores-de-21")]
        public ActionResult<List<PersonaDTO>> GetMayoresDe21()
        {
            List<Persona> personasMayoresDe21 = repodb.MostrarPersonasMayoresDe21();
            return Ok(_mapper.Map<List<PersonaDTO>>(personasMayoresDe21));
        }
        [HttpPost("registro")]
        public async Task<ActionResult> Register([FromBody] AgregarPersonaDTO parametros)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            parametros.Password = Operaciones.Utilidades.HashearMD5(parametros.Password);
            var UserRepo = _mapper.Map<Persona>(parametros);
            var findUser = await repodb.FindUsuarioPoruserNameAsync(UserRepo.UserName);
            if (findUser == null)
            {

                await repodb.RegistrarUsuario(UserRepo);
                return NoContent();
            }

            return BadRequest("UserName ya existe prueba con otro");


        }
    }
}
