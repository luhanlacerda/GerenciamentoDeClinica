using ClinicaServiceLibrary.classesbasicas;
using ClinicaServiceLibrary.convenio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServiceLibrary.paciente
{
    [DataContract]
    public class Paciente : Pessoa
    {
        [DataMember (IsRequired=true)]
        public int      ID_Paciente  { get; set; }
        [DataMember]
        public Convenio Convenio     { get; set; }
    }
}
