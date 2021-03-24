using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Classes
{
    class Estoquista : Base
    {

        public Estoquista (string nome, string cpf, string telefone, string endereco, string tipoEstoque)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Telefone = telefone;
            this.Endereco = endereco;
            this.TipoEstoque = tipoEstoque;
        }

        public Estoquista() { }

        public override void Salvar()
        {
            var data = this.Ler();
            data.Add(this);


            StreamWriter sw = new StreamWriter(caminhoDiretorio());
            sw.WriteLine("nome;telefone;cpf;endereco;tipoEstoque");

            foreach (Base d in data)
            {
                var linha = d.Nome + ";" + d.Telefone + ";" + d.CPF + ";" + d.Endereco + ";" + d.TipoEstoque + ";";
                sw.WriteLine(linha);
            }

            sw.Close();

        }

        public override List<IPessoa> Ler()
        {
            var data = new List<IPessoa>();

            if (File.Exists(caminhoDiretorio()))
            {
                using StreamReader arquivo = File.OpenText(caminhoDiretorio());
                string linha;
                int i = 0;
                while ((linha = arquivo.ReadLine()) != null)
                {
                    i++;
                    if (i == 1) continue;

                    var dadoArquivo = linha.Split(";");

                    var d = (IPessoa)Activator.CreateInstance(this.GetType());

                    d.setNome(dadoArquivo[0]);
                    d.setTelefone(dadoArquivo[1]);
                    d.setCPF(dadoArquivo[2]);
                    d.setEndereco(dadoArquivo[3]);
                    d.setTipoEstoque(dadoArquivo[4]);

                    data.Add(d);
                }
            }
            return data;
        }
    }
}
