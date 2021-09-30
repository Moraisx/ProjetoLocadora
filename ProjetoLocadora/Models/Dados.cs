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
        
        //Verifica se o ID e o Numero de Cadastro são diferente para adiconar um novo cliente
        public static void AdicionarCliente(Cliente cliente)
        {
            bool idExisteNaLista = false;

            foreach(var cli in clientes)
            {
                if((cli.ID == cliente.ID) || (cli.Cadastro == cliente.Cadastro))
                {
                    idExisteNaLista = true;
                }
            }
            if(idExisteNaLista == false)
            {
                clientes.Add(cliente);
            } 
        }

        //Retirado pois "Não é permitido excluir fisicamente um registro"

        /*public static void RemoverCliente(int clienteID)
        {
            foreach (var cli in clientes)
            {
                if (cli.ID == clienteID)
                {
                    clientes.Remove(cli);
                    break;
                }
            }
        }*/

        //  Verifica se o ID é diferente para adiconar um novo filme
        public static void AdicionarFilmes(Filme filme)
        {
            bool idExisteNaLista = false;

            foreach (var fil in filmes)
            {
                if (fil.ID == filme.ID)
                {
                    idExisteNaLista = true;
                }
            }
            if (idExisteNaLista == false)
            {
                filmes.Add(filme);
            }
        }

        //Retirado pois "Não é permitido excluir fisicamente um registro"

        /*public static void RemoverFilme(int filmeID)
        {
            foreach (var fil in filmes)
            {
                if (fil.ID == filmeID)
                {
                    filmes.Remove(fil);
                    break;
                }
            }
        }*/

        // Adiciona uma nova locação, verificando se o ID e o Filme já foram locados anteriomente.
        public static void AdicionarLocacao(Locacao locacao)
        {
            bool idExisteNaLista = false;

            foreach (var loc in locacoes)
            {
                if (loc.ID == locacao.ID || loc.Filme == locacao.Filme)
                {
                    idExisteNaLista = true;
                }
            }
            if (idExisteNaLista == false)
            {
                locacoes.Add(locacao);
            }
        }
    }
}
