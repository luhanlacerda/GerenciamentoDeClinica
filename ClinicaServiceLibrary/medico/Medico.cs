using ClinicaServiceLibrary.classesbasicas;
using ClinicaServiceLibrary.especialidade;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ClinicaServiceLibrary.medico
{
    [DataContract]
    public class Medico : Pessoa
    {
        [DataMember(IsRequired = true)]
        public int ID_Medico { get; set; }
        [DataMember]
        public string CRM { get; set; }
        [DataMember]
        public Especialidade Especialidade { get; set; }
    }
}
