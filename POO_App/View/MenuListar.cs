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

            var clientes = Cliente.LerClientes();

            foreach(Cliente cli in clientes)
            {
                string listagem = "Nome: " + cli.Nome + 
                    "\nTelefone: " + cli.Telefone +
                    "\nCPF: " + cli.CPF + 
                    "\n---------------------------------------]";
                              
                Console.WriteLine(listagem);
                     
            }
            Console.WriteLine("\n                                     Pressione 'ENTER' para retornar ao menu inicial.");
            Console.ReadLine();
        }
    }
}
