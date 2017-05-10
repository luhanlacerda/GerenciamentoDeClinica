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

    }
}
