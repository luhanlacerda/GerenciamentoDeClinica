using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ClinicaServiceLibrary.especialidade
{
    [DataContract]
    public class Especialidade
    {
        [DataMember(IsRequired = true)]
        public int ID_Especialidade { get; set; }
        [DataMember]
        public String Descricao { get; set; }
    }

}
