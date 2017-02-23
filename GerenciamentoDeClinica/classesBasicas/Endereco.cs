using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeClinica.classesBasicas
{
    abstract class Endereco
    {
        private String logradouro;
        private String numero;
        private String complemento;
        private String bairro;
        private String cidade;
        private String uf;
        private String cep;
        private String pais;

        public String getLogradouro()
        {
            return logradouro;
        }

        public void setLogradouro(String logradouro)
        {
            this.logradouro = logradouro;
        }

        public String getNumero()
        {
            return numero;
        }

        public void setNumero(String numero)
        {
            this.numero = numero;
        }

        public String getComplemento()
        {
            return complemento;
        }

        public void setComplemento(String complemento)
        {
            this.complemento = complemento;
        }

        public String getBairro()
        {
            return bairro;
        }

        public void setBairro(String bairro)
        {
            this.bairro = bairro;
        }

        public String getCidade()
        {
            return cidade;
        }

        public void setCidade(String cidade)
        {
            this.cidade = cidade;
        }

        public String getUf()
        {
            return uf;
        }

        public void setUf(String uf)
        {
            this.uf = uf;
        }

        public String getCep()
        {
            return cep;
        }

        public void setCep(String cep)
        {
            this.cep = cep;
        }

        public String getPais()
        {
            return pais;
        }

        public void setPais(String pais)
        {
            this.pais = pais;
        }

        public String toString()
        {
            String retorno;
            retorno = "Rua: " + this.getLogradouro() + ", ";
            retorno += "Número: " + this.getNumero() + ", ";
            retorno += "Complemento: " + this.getComplemento() + ", ";
            retorno += "CEP: " + this.getCep() + ", ";
            retorno += "Bairro: " + this.getBairro() + ", ";
            retorno += "Cidade: " + this.getCidade() + ", ";
            retorno += "UF: " + this.getUf() + ", ";
            retorno += "País: " + this.getPais() + ", ";
            return retorno;
        }
    }
}
