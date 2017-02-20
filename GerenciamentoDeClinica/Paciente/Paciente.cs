using GerenciamentoDeClinica.classesBasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeClinica.Paciente
{
    class Paciente : Pessoa
    {
        private String tipoConsulta { get; set; }
        private String planoDeSaude { get; set; }
        private int numeroCarteira { get; set; } 
    }
}
