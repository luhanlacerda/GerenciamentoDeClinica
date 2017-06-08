using System.Runtime.Serialization;
using ClinicaServiceLibrary.classesbasicas;

namespace ClinicaServiceLibrary.usuario
{
    [DataContract]
    public class Usuario : Pessoa
    {
        [DataMember (IsRequired = true)]
        public int ID_Usuario { get; set; }
        [DataMember]
        public string Senha   { get; set; }
     
    }
}
