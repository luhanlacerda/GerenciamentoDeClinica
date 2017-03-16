using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.classesBasicas
{
    public abstract class Pessoa
    {
        private String nome;
        private String rg;
        private String cpf;
        private Endereco endereco;
        private String contato;
        private DateTime dtNascimento;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Rg
        {
            get
            {
                return rg;
            }

            set
            {
                rg = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        internal Endereco Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public string Contato
        {
            get
            {
                return contato;
            }

            set
            {
                contato = value;
            }
        }

        public DateTime DtNascimento
        {
            get
            {
                return dtNascimento;
            }

            set
            {
                dtNascimento = value;
            }
        }
    }
}
