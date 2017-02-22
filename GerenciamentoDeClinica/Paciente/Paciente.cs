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
        private Convenio convenio { get; set; }
    }
}
