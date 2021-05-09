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
    public class PersonagemController : ControllerBase
    {
        private IPersonagemRepository _personagemRepository { get; set; }

        public PersonagemController()
        {
            _personagemRepository = new PersonagemRepository();
        }

        [Authorize]
        [HttpGet]
        public IActionResult Read()
        {
            return Ok(_personagemRepository.Read());
        }

        [Authorize]
        [HttpGet("{id}")]
        public IActionResult ReadById(int id)
        {
            return Ok(_personagemRepository.ReadById(id));
        }

        [Authorize(Roles = "2")]
        [HttpPost]
        public IActionResult Create(Personagem novoPersonagem)
        {
            _personagemRepository.Create(novoPersonagem);
            return StatusCode(200);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Personagem personagemAtualizada)
        {
            _personagemRepository.Update(id, personagemAtualizada);
            return StatusCode(200);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personagemRepository.Delete(id);
            return StatusCode(200);
        }
    }
}
