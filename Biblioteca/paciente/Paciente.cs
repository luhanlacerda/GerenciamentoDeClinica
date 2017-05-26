
using Biblioteca.classesBasicas;
using Biblioteca.convenio;
using Biblioteca.secretaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.paciente
{
    [DataContract]
    public class Paciente : Pessoa
    {
        [DataMember]
        public int      ID_Paciente  { get; set; }
        [DataMember]
        public Convenio Convenio     { get; set; }
    }
}
