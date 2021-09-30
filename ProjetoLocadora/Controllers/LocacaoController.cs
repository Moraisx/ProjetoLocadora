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
    public class LocacaoController : ControllerBase
    {
        // GET: api/<LocacaoController>
        [HttpGet]
        [Route("/api/locacoes")]
        public ActionResult<List<Locacao>> Get()
        {
            return Dados.locacoes;
        }

        // GET api/<LocacaoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LocacaoController>
        [HttpPost]
        public void Post([FromBody] Locacao locacao)
        {
            Dados.AdicionarLocacao(locacao);
        }

        // PUT api/<LocacaoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /*
        // DELETE api/locacao/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}