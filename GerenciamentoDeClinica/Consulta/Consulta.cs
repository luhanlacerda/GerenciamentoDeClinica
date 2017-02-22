using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeClinica.Consulta
{
    using GerenciamentoDeClinica.Paciente;
    using GerenciamentoDeClinica.Medico;

    class Consulta
    {
        private int numeroConsulta { get; set; }
        private DateTime data { get; set; }
        private DateTime horario { get; set; }
        private Paciente paciente { get; set; }
        private Medico medico { get; set; }
        private String historico { get; set; }
    }
}
