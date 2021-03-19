using Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace View
{
    class Menu
    {
        public const int SAIR = 3;
        

        public static void Exibir()
        {

            while (true)
            {
                Console.Clear();

                string textoMenu = "\n                                      Bem vindo ao software de gestão de clientes!" +
                    "\n                                         Favor escolher uma das opções abaixo." +
                    "\n" +
                    "\n                                                   O que deseja fazer?" +
                    "\n" +
                    "\n                                         [1]     Cadastrar um novo cliente. " + 
                    "\n                                         [2]  Listar os clientes cadastrados." +
                    "\n                                         [3]         Sair do programa." +
                    "\n\n";

                Console.WriteLine(textoMenu);
                Console.Write("--> Sua escolha: ");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:

                        MenuCadastro.ExibirCadastroCliente();

                        break;
                }

                if(escolha == SAIR)
                {
                    break;
                }

            }
        }
            


    }
}
