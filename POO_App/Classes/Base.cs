using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Classes
{
    class Base : IPessoa
    {

        public string Nome;
        public string Telefone;
        public string CPF;
        public string Endereco;
        public string TipoEstoque;

        public void setNome(string nome) { this.Nome = nome; }
        public void setTelefone(string telefone) { this.Telefone = telefone; }
        public void setCPF(string cpf) { this.CPF = cpf; }
        public void setEndereco (string endereco) { this.Endereco = endereco; }
        public void setTipoEstoque(string tipoEstoque) { this.TipoEstoque = tipoEstoque; }


        public Base(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
            
        }

        public Base() { }


        public string caminhoDiretorio()
        {
            return ConfigurationManager.AppSettings["diretorioArquivos"] + this.GetType().Name + ".csv";
        }

        public virtual List<IPessoa> Ler()
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

                    data.Add(d);
                }
            }
            return data;
        }

        public virtual void Salvar()
        {
            var data = this.Ler();
            data.Add(this);

            
            StreamWriter sw = new StreamWriter(caminhoDiretorio());
            sw.WriteLine("nome;telefone;cpf;");

            foreach (Base d in data)
            {
                var linha = d.Nome + ";" + d.Telefone + ";" + d.CPF + ";";
                sw.WriteLine(linha);
            }

            sw.Close();
            
        }
    }
}
