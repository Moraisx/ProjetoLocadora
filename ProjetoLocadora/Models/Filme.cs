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

        // Cadastra a data automaticamente na hora de incluir um novo filme no cadastro
        public string DataDoCadastro { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
    }
}
