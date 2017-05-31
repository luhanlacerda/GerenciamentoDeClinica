using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServiceLibrary.classesbasicas
{
    [DataContract]
    public abstract class Pessoa
    {
        [DataMember]
        public String Nome            { get; set; }
        [DataMember]
        public String RG              { get; set; }
        [DataMember]
        public String CPF             { get; set; }
        [DataMember]
        public Endereco Endereco      { get; set; }
        [DataMember]
        public String Contato         { get; set; }
        [DataMember]
        public DateTime Dt_Nascimento { get; set; }
        [DataMember]
        public String Email           { get; set; }
        [DataMember]
        public String Estado_Civil    { get; set; }
    }
}
