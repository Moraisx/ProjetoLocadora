using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoLocadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLocadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : Controller
    {
        // GET: FilmeController
        [HttpGet]
        [Route("/api/filmes")]
        public ActionResult<List<Filme>> get()
        {
            return Dados.filmes;
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FilmeController>
        [HttpPost]
        public void Post([FromBody] Filme filme)
        {
            Dados.AdicionarFilmes(filme);
        }


        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/filme/
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Dados.RemoverFilme(id);
        }
    }
}