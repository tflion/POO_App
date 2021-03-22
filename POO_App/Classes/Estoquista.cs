using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Classes
{
    class Estoquista : Cliente
    {
        public string Endereco;
        public string TipoEstoque;

        public Estoquista (string nome, string cpf, string telefone, string endereco, string tipoEstoque)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Telefone = telefone;
            this.Endereco = endereco;
            this.TipoEstoque = tipoEstoque;
        }


        private static string caminhoDatabase()
        {
            return ConfigurationManager.AppSettings["caminho_estoquistas"];
        }

        public static List<Estoquista> LerEstoquistas()
        {
            var estoquistas = new List<Estoquista>();

            if (File.Exists(caminhoDatabase()))
            {
                using StreamReader arquivo = File.OpenText(caminhoDatabase());
                string linha;
                int i = 0;
                while ((linha = arquivo.ReadLine()) != null)
                {
                    i++;
                    if (i == 1) continue;

                    var estoquistaArquivo = linha.Split(";");

                    var estoquista = new Estoquista(estoquistaArquivo[0], estoquistaArquivo[1], estoquistaArquivo[2], estoquistaArquivo[3], estoquistaArquivo[4]);

                    estoquistas.Add(estoquista);
                }
            }
            return estoquistas;
        }

        public override void Salvar()
        {
            var estoquistas = Estoquista.LerEstoquistas();
            estoquistas.Add(this);

            if (File.Exists(caminhoDatabase()))
            {
                StreamWriter w = new StreamWriter(caminhoDatabase());
                w.WriteLine("nome;telefone;cpf;endereço;tipoEstoque");

                foreach (Estoquista e in estoquistas)
                {
                    var linha = e.Nome + ";" + e.Telefone + ";" + e.CPF + ";" + e.Endereco + ";" + e.TipoEstoque + ";";
                    w.WriteLine(linha);
                }

                w.Close();
            }
        }
    }
}
