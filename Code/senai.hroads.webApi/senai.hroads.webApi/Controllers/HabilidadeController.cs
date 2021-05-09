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
    public class HabilidadeController : ControllerBase
    {
        private IHabilidadeRepository _habilidade { get; set; }

        public HabilidadeController()
        {
            _habilidade = new HabilidadeRepository();
        }

        [HttpGet]
        public IActionResult Read()
        {
            return Ok(_habilidade.Read());
        }

        [HttpGet("{id}")]
        public IActionResult ReadById(int id)
        {
            return Ok(_habilidade.ReadById(id));
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Create(Habilidade novaHabilidade)
        {
            _habilidade.Create(novaHabilidade);
            return StatusCode(200);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Habilidade habilidadeAtualizada)
        {
            _habilidade.Update(id, habilidadeAtualizada);
            return StatusCode(200);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _habilidade.Delete(id);
            return StatusCode(200);
        }
    }
}
