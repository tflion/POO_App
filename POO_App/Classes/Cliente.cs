using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Classes
{
    class Cliente
    {

        public string Nome;
        public string Telefone;
        public string CPF;

        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }

        private static string caminhoDatabase()
        {
            return ConfigurationManager.AppSettings["caminho_db"];
        }
        
        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();

            if (File.Exists(caminhoDatabase()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoDatabase())){
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;

                        var clienteArquivo = linha.Split(";");

                        var cliente = new Cliente(clienteArquivo[0], clienteArquivo[1], clienteArquivo[3]);

                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }

        public void Salvar()
        {
            var clientes = Cliente.LerClientes();
            clientes.Add(this);

            if (File.Exists(caminhoDatabase()))
            {
                StreamWriter w = new StreamWriter(caminhoDatabase());
                w.WriteLine("nome;telefone;cpf;");
                
                foreach(Cliente c in clientes)
                {
                    var linha = c.Nome + ";" + c.Telefone + ";" + c.CPF + ";";
                    w.WriteLine(linha);
                }


                w.Close();
            }


        }


    }
}
