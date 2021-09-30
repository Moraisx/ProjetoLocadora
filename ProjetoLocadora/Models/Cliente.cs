using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLocadora.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        // Numero de cadastro unico
        public int Cadastro { get; set; }
    }
}