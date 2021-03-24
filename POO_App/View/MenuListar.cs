using Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace View
{
    class MenuListar
    {
        public static void ExibirListaClientes()
        {
            Console.Clear();    

            string menuListagem = "                                                 * Listagem de Clientes *" +
                "\n\n------------------------------------------------------------------------------------------------------------------------";

            Console.WriteLine(menuListagem);


            foreach(Cliente cliente in new Cliente().Ler())
            {
                string listagem = "Nome: " + cliente.Nome + 
                    "\nTelefone: " + cliente.Telefone +
                    "\nCPF: " + cliente.CPF + 
                    "\n---------------------------------------]";
                              
                Console.WriteLine(listagem);
                     
            }
            Console.WriteLine("\n                                     Pressione 'ENTER' para retornar ao menu inicial.");
            Console.ReadLine();
        }

        public static void ExibirListaEstoquistas()
        {
            Console.Clear();

            string menuListagem = "                                                 * Listagem de Estoquistas *" +
                "\n\n------------------------------------------------------------------------------------------------------------------------";

            Console.WriteLine(menuListagem);

            foreach (Estoquista estoquista in new Estoquista().Ler())
            {
                string listagem = "Nome: " + estoquista.Nome +
                    "\nTelefone: " + estoquista.Telefone +
                    "\nCPF: " + estoquista.CPF +
                    "\nEndereço: " + estoquista.Endereco +
                    "\nTipo Estoque: " + estoquista.TipoEstoque +
                    "\n---------------------------------------]";

                Console.WriteLine(listagem);

            }
            Console.WriteLine("\n                                     Pressione 'ENTER' para retornar ao menu inicial.");
            Console.ReadLine();
        }

        public static void ExibirMensagemErro()
        {
            Console.Clear();

            string error = "\n                                                    * OPÇÃO INVÁLIDA *" +
                "\n\n                     Você informou um valor inválido, favor selecionar uma das opções citadas no menu." +
                "\n\n                                     Pressione 'ENTER' para retornar ao menu inicial.";


            Console.WriteLine(error);
            Console.ReadLine();

        }
    }
}
