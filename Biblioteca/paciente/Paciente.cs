using Biblioteca.classesBasicas;
using Biblioteca.convenio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.paciente
{

    public class Paciente : Pessoa
    {
        private Convenio convenio;

        public Convenio Convenio
        {
            get { return convenio; }
            set { convenio = value; }
        }

        public String PacienteToString()
        {
            String retorno;
            retorno = "Nome: " + this.Nome + "\n";
            retorno += "CPF: " + this.Cpf + "\n";
            retorno += "Convênio: " + this.Convenio.Nome + "\n";
            retorno += "Contato: " + this.Contato;
            return retorno;
        }
    }
}
