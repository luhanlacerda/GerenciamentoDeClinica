using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.classesBasicas
{
    public abstract class Endereco
    {
        private String logradouro;
        private String numero;
        private String complemento;
        private String bairro;
        private String cidade;
        private String uf;
        private String cep;
        private String pais;

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public String EnderecoToString()
        {
            String retorno;
            retorno = "Rua: " + this.Logradouro + ", ";
            retorno += "Número: " + this.Numero + ", ";
            retorno += "Complemento: " + this.Complemento + ", ";
            retorno += "CEP: " + this.Cep + ", ";
            retorno += "Bairro: " + this.Bairro + ", ";
            retorno += "Cidade: " + this.Cidade + ", ";
            retorno += "UF: " + this.Uf + ", ";
            retorno += "País: " + this.Pais + ", ";
            return retorno;
        }
    }
}
