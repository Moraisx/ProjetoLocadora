using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLocadora.Models
{
    public class Locacao
    {
        public int ID { get; set; }
        public int ClienteID { get; set; }
        public int FilmeID { get; set; }
    }
}
