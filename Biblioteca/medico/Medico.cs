using Biblioteca.classesBasicas;
using Biblioteca.especialidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.paciente
{

    public class Medico : Pessoa
    {
        public int ID_Medico { get; set; }
        public string CRM { get; set; }
        public Especialidade Especialidade { get; set; }
    }
}
