using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServiceLibrary.convenio
{
    [DataContract]
    public class Convenio
    {
        [DataMember]
        public int ID_Convenio  { get; set; }
        [DataMember]
        public string Descricao { get; set; }
    }
}

