using Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace View
{
    class MenuCadastro
    {
        public static void ExibirCadastroCliente()
        {
            var confirmacao = "";

            while (true)
            {
                Console.Clear();

                string menuCadastro = "                                                | Cadastro de cliente |" +
                "\n" +
                "\n                                  Favor preencher as próximas informações corretamente." +
                "\n\n";

                Console.WriteLine(menuCadastro);
                Console.Write("> Nome do cliente: ");
                string nome = Console.ReadLine();
                Console.Write("> Telefone do cliente: ");
                string telefone = Console.ReadLine();
                Console.Write("> CPF do cliente: ");
                string cpf = Console.ReadLine();

                Console.Clear();

                string menuConfirmacao = "\n                                     Confira se os dados a seguir estão corretos: " +
                    "\n" +
                    "\n> Nome informado: ( " + nome + " )" +
                    "\n> Telefone informado: ( " + telefone + " )" +
                    "\n> CPF informado: ( " + cpf + " )" +
                    "\n" +
                    "\n                      Digite [Sim] caso estiver correto e [Não] caso queira preencher novamente." +
                    "\n";

                Console.WriteLine(menuConfirmacao);
                Console.Write("* Confirmação: ");
                confirmacao = Console.ReadLine();

                if (confirmacao == "s"
                   || confirmacao == "S"
                   || confirmacao == "sim"
                   || confirmacao == "Sim"
                   || confirmacao == "SIm"
                   || confirmacao == "SIM"
                   || confirmacao == "sIM"
                   || confirmacao == "siM"
                   || confirmacao == "sIm")
                {
                    Cliente cliente = new Cliente(nome, telefone, cpf);

                    cliente.Salvar();

                    Console.Clear();
                    Console.WriteLine("\n\n                                            * Cliente adicionado com sucesso! *");
                    Console.WriteLine("\n                                     Pressione 'ENTER' para retornar ao menu inicial.");
                    Console.ReadLine();

                    break;
                }


            }
        }

        public static void ExibirCadastroEstoquista()
        {
            var confirmacao = "";

            while (true)
            {
                Console.Clear();

                string menuCadastro = "                                                | Cadastro de estoquista |" +
                "\n" +
                "\n                                  Favor preencher as próximas informações corretamente." +
                "\n\n";

                Console.WriteLine(menuCadastro);
                Console.Write("> Nome do estoquista: ");
                string nome = Console.ReadLine();
                Console.Write("> Telefone do estoquista: ");
                string telefone = Console.ReadLine();
                Console.Write("> CPF do estoquista: ");
                string cpf = Console.ReadLine();
                Console.Write("> Endereço do estoquista: ");
                string endereco = Console.ReadLine();
                Console.Write("> Qual o produto deste estoquista: ");
                string tipoEstoque = Console.ReadLine();

                Console.Clear();

                string menuConfirmacao = "\n                                     Confira se os dados a seguir estão corretos: " +
                    "\n" +
                    "\n> Nome informado: ( " + nome + " )" +
                    "\n> Telefone informado: ( " + telefone + " )" +
                    "\n> CPF informado: ( " + cpf + " )" +
                    "\n> Endereço informado: ( " + endereco + " )" +
                    "\n> Estoque informado: ( " + tipoEstoque + " )" +
                    "\n" +
                    "\n                      Digite [Sim] caso estiver correto e [Não] caso queira preencher novamente." +
                    "\n";

                Console.WriteLine(menuConfirmacao);
                Console.Write("* Confirmação: ");
                confirmacao = Console.ReadLine();

                if (confirmacao == "s"
                   || confirmacao == "S"
                   || confirmacao == "sim"
                   || confirmacao == "Sim"
                   || confirmacao == "SIm"
                   || confirmacao == "SIM"
                   || confirmacao == "sIM"
                   || confirmacao == "siM"
                   || confirmacao == "sIm")
                {
                    Estoquista estoquista = new Estoquista(nome, telefone, cpf, endereco, tipoEstoque);

                    estoquista.Salvar();

                    Console.Clear();
                    Console.WriteLine("\n\n                                            * Estoquista adicionado com sucesso! *");
                    Console.WriteLine("\n                                     Pressione 'ENTER' para retornar ao menu inicial.");
                    Console.ReadLine();

                    break;
                }


            }
        }
    }
}
