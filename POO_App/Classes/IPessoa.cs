using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public interface IPessoa
    {
        void setNome(string nome);
        void setTelefone(string telefone);
        void setCPF(string cpf);
        void setEndereco(string endereco);
        void setTipoEstoque(string tipoEstoque);


        void Salvar();
    }
}
