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
    public class ClassController : ControllerBase
    {

        private IClassRepository _classRepository { get; set; }

        public ClassController()
        {
            _classRepository = new ClassRepository();
        }

        [HttpGet]
        public IActionResult Read()
        {
            return Ok(_classRepository.Read());
        }

        [HttpGet("{id}")]
        public IActionResult ReadById(int id)
        {
            return Ok(_classRepository.ReadById(id));
        }

        [Authorize (Roles = "1")]
        [HttpPost]
        public IActionResult Create(Class novaClass)
        {
            _classRepository.Create(novaClass);
            return StatusCode(200);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Class classeAtualizada)
        {
            _classRepository.Update(id, classeAtualizada);
            return StatusCode(200);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _classRepository.Delete(id);
            return StatusCode(200);
        }
    }
}
