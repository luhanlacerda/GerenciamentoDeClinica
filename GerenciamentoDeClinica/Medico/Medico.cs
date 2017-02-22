using GerenciamentoDeClinica.classesBasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeClinica.Medico
{
    using Especialidade;

    class Medico : Pessoa
    {
        private int crm { get; set; }
        private Especialidade especialidade { get; set; } //vai usar o código da especialidade
    }
}
