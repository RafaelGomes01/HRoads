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
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult Read()
        {
            return Ok(_usuarioRepository.Read());
        }

        [HttpGet("{id}")]
        public IActionResult ReadById(int id)
        {
            return Ok(_usuarioRepository.ReadById(id));
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Create(Usuario novoUsuario)
        {
            _usuarioRepository.Create(novoUsuario);
            return StatusCode(200);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Usuario usuarioAtualizada)
        {
            _usuarioRepository.Update(id, usuarioAtualizada);
            return StatusCode(200);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _usuarioRepository.Delete(id);
            return StatusCode(200);
        }
    }
}
