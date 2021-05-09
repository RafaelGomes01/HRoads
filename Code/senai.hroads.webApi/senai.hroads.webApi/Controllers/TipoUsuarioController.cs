using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.hroads.webApi_.Domains;
using senai.hroads.webApi_.Interfaces;
using senai.hroads.webApi_.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TipoUsuarioController : ControllerBase
    {
        private ITipoUsuarioRepository _tipoUsuarioRepository { get; set; }

        public TipoUsuarioController()
        {
            _tipoUsuarioRepository = new TipoUsuarioRepository();
        }

        [HttpGet]
        public IActionResult Read()
        {
            return Ok(_tipoUsuarioRepository.Read());
        }

        [HttpGet("{id}")]
        public IActionResult ReadById(int id)
        {
            return Ok(_tipoUsuarioRepository.ReadById(id));
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Create(TipoUsuario novoTipoUsuario)
        {
            _tipoUsuarioRepository.Create(novoTipoUsuario);
            return StatusCode(200);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, TipoUsuario tipoUsuarioAtualizado)
        {
            _tipoUsuarioRepository.Update(id, tipoUsuarioAtualizado);
            return StatusCode(200);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _tipoUsuarioRepository.Delete(id);
            return StatusCode(200);
        }
    }
}
