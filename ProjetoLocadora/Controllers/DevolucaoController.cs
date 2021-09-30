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
    public class DevolucaoController : Controller
    {
        // GET: DevolucoesController
        [HttpGet]
        [Route("/api/devolucoes")]
        public ActionResult<List<DevolucaoFilme>> Get()
        {
            return Dados.devolucoes;
        }

        // GET api/<FilmeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DevolucoesController>
        [HttpPost]
        public void Post([FromBody] DevolucaoFilme devolucao)
        {
            Dados.AdicionarDevolucao(devolucao);
        }

        // PUT api/<DevolucoesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
