using Biblioteca.classesBasicas;
using Biblioteca.convenio;
using Biblioteca.secretaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.paciente
{

    public class Paciente : Pessoa
    {
        public int      ID_Paciente  { get; set; }
        public Secretaria Secretaria { get; set; }
        public Convenio Convenio     { get; set; }
    }
}
