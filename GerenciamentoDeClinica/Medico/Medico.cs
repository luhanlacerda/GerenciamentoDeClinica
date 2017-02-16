using GerenciamentoDeClinica.classesBasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeClinica.Medico
{
    class Medico : Pessoa
    {
        private int crm { get; set; }
        private String especialidade { get; set; }
    }
}
