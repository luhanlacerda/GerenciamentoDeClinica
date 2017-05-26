using Biblioteca.classesBasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.secretaria
{
    [DataContract]
    public class Secretaria : Pessoa
    {
        [DataMember]
        public int ID_Secretaria { get; set; }
    }
}
