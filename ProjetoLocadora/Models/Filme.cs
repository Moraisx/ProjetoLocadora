using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLocadora.Models
{
    public class Filme
    {
        public int ID { get; set; }
        public string NomeFilme { get; set; }
        public string Genero { get; set; }
        public int FaixaEtaria { get; set; }
    }
}
