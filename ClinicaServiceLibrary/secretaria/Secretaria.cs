using ClinicaServiceLibrary.classesbasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServiceLibrary.secretaria
{
    [DataContract, KnownType(typeof(Pessoa))]
    public class Secretaria : Pessoa
    {
        [DataMember(IsRequired = true)]
        public int ID_Secretaria { get; set; }
    }
}
