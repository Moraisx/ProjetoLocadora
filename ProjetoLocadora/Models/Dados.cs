using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLocadora.Models
{
    public static class Dados
    {
        public static List<Cliente> clientes = new List<Cliente>();
        public static List<Filme> filmes = new List<Filme>();
        public static List<Locacao> locacoes = new List<Locacao>();
        

        /*
        public static void Inicializar()
        {
            clientes = new List<Cliente>();
            clientes.Add(new Cliente() { ID = 1, Nome = "Tiago Morais" });
            clientes.Add(new Cliente() { ID = 2, Nome = "Monique Morais" });

            filmes.Add(new Filme() { ID = 1, NomeFilme = "Vingadores", FaixaEtaria = 16 });
            filmes.Add(new Filme() { ID = 2, NomeFilme = "Monstros SA", FaixaEtaria = 0 });
        }
        */

        public static void AdicionarCliente(Cliente cliente)
        {

           clientes.Add(cliente);
        }

        public static void RemoverCliente(int clienteID)
        {
            foreach (var cli in clientes)
            {
                if (cli.ID == clienteID)
                {
                    clientes.Remove(cli);
                    break;
                }
            }
        }
        public static void AdicionarFilmes(Filme filme)
        {
            filmes.Add(filme);
        }
        public static void RemoverFilme(int filmeID)
        {
            foreach (var fil in filmes)
            {
                if (fil.ID == filmeID)
                {
                    filmes.Remove(fil);
                    break;
                }
            }
        }

    }
}
