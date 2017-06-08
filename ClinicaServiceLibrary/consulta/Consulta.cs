using ClinicaServiceLibrary.medico;
using ClinicaServiceLibrary.paciente;
using ClinicaServiceLibrary.secretaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ClinicaServiceLibrary.estado;

namespace ClinicaServiceLibrary.consulta
{
    [DataContract]
    public class Consulta
    {
        [DataMember(IsRequired = true)]
        public DateTime Horario      { get; set; }
        [DataMember(IsRequired = true)]
        public int Duracao           { get; set; }
        [DataMember(IsRequired = true)]
        public string Observacoes    { get; set; }
        [DataMember]
        public Estado Estado         { get; set; }
        [DataMember(IsRequired = true)]
        public int ID_Consulta       { get; set; }
        [DataMember(IsRequired = true)]
        public string Receita        { get; set; }
        [DataMember]
        public Medico Medico         { get; set; }
        [DataMember]
        public Paciente Paciente     { get; set; }
        [DataMember]
        public Secretaria Secretaria { get; set; }
    }
}
