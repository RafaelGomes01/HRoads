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
    public class TipoDeHabilidadeController : ControllerBase
    {
        private ITipoDeHabilidadeRepository _tipoDeHabilidadeRepository { get; set; }

        public TipoDeHabilidadeController()
        {
            _tipoDeHabilidadeRepository = new TipoDeHabilidadeRepository();
        }

        [HttpGet]
        public IActionResult Read()
        {
            return Ok(_tipoDeHabilidadeRepository.Read());
        }

        [HttpGet("{id}")]
        public IActionResult ReadById(int id)
        {
            return Ok(_tipoDeHabilidadeRepository.ReadById(id));
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Create(TipoDeHabilidade novoTipoDeHabilidade)
        {
            _tipoDeHabilidadeRepository.Create(novoTipoDeHabilidade);
            return StatusCode(200);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, TipoDeHabilidade tipoDeHabilidadeAtualizada)
        {
            _tipoDeHabilidadeRepository.Update(id, tipoDeHabilidadeAtualizada);
            return StatusCode(200);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _tipoDeHabilidadeRepository.Delete(id);
            return StatusCode(200);
        }
    }
}
