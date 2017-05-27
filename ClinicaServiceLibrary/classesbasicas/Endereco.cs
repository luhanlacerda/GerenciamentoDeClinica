using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServiceLibrary.classesbasicas
{
    [DataContract]
    public class Endereco
    {
        [DataMember]
        public String Logradouro    { get; set; }
        [DataMember]
        public String Numero        { get; set; }
        [DataMember]
        public String Complemento   { get; set; }
        [DataMember]
        public String Bairro        { get; set; }
        [DataMember]
        public String Cidade        { get; set; }
        [DataMember]
        public String UF            { get; set; }
        [DataMember]
        public String CEP           { get; set; }
        [DataMember]
        public String Pais          { get; set; }
    }
}
