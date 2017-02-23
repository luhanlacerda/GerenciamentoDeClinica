using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeClinica.classesBasicas
{
    abstract class Pessoa
    {
        private String nome;
        private String rg;
        private String cpf;
        private Endereco endereco;
        private String contato;
        private DateTime dtNascimento;

        public String getNome() {
            return this.nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public String getRg()
        {
            return this.rg;
        }

        public void setRg(String rg)
        {
            this.rg = rg;
        }

        public String getCpf()
        {
            return this.cpf;
        }

        public void setCpf(String cpf)
        {
            this.cpf = cpf;
        }

        public Endereco getEndereco()
        {
            return this.endereco;
        }

        public void setEndereco(Endereco endereco)
        {
            this.endereco = endereco;
        }

        public String getContato()
        {
            return this.contato;
        }

        public void setContato(String contato)
        {
            this.contato = contato;
        }

        public DateTime getDtNascimento()
        {
            return this.dtNascimento;
        }

        public void setDtNascimento(DateTime dtNascimento)
        {
            this.dtNascimento = dtNascimento;
        }
    }
}
