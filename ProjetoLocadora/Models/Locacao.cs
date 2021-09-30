using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLocadora.Models
{
    public class Locacao
    {
        public int ID { get; set; }
        public string Cliente { get; set; }
        public string Filme { get; set; }
        
        // Cadastra a data atual da locação
        public string DataDaLocacao { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
    }
}
