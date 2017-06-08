using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServiceLibrary.estado
{
    [DataContract]
    public class Estado
    {
            [DataMember(IsRequired = true)]
            public int ID_Estado { get; set; }
            [DataMember]
            public string Descricao { get; set; }
    }
}
