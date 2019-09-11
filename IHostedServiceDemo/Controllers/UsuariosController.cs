using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IHostedServiceDemo.Contexts;
using IHostedServiceDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IHostedServiceDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ELAVONTESTContext _context;
        private readonly IMapper _mapper;

        public UsuariosController(ELAVONTESTContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        [HttpGet("{id}", Name = "ObtenerUsuario")]
        public async Task<ActionResult<UsuarioDTO>> Get(int id, string param2)
        {
            var usuario = await _context.CUsuarios.FirstOrDefaultAsync(x => x.IdUsuario == id);

            if(usuario == null)
            {
                return NotFound();
            }

            var usuarioDto = _mapper.Map<UsuarioDTO>(usuario);
            return usuarioDto;
        }
    }
}