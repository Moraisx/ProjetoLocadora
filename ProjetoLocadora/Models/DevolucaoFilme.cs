using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLocadora.Models
{
    public class DevolucaoFilme
    {
        public int ID { get; set; }
        public string Cliente { get; set; }
        public string Filme { get; set; }

        // Cadastra a data atual de Devolucao
        public string DataDeDevolucao { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
    }
}
