using GerenciamentoDeClinica.classesBasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeClinica.Paciente
{
    using Convenio;

    class Paciente : Pessoa
    {
        private Convenio convenio;

        public Convenio getConvenio()
        {
            return this.convenio;
        }

        public void setConvenio(Convenio convenio)
        {
            this.convenio = convenio;
        }

        public String toString()
        {
            String retorno;
            retorno = "Nome: " + this.getNome() + "\n";
            retorno += "CPF: " + this.getCpf() + "\n";
            retorno += "Convênio: " + this.getConvenio().getNome() + "\n";
            retorno += "Contato: " + this.getContato();
            return retorno;
        }
    }
}
