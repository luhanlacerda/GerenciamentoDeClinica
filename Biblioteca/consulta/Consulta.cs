using Biblioteca.medico;
using Biblioteca.paciente;
using Biblioteca.secretaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.consulta
{
    [DataContract]
    public class Consulta
    {
        [DataMember]
        public DateTime Horario      { get; set; } //DateTime salva a data e o horário indicado
        [DataMember]
        public int Duracao           { get; set; }
        [DataMember]
        public string Observacoes    { get; set; }
        [DataMember]
        public string Descricao      { get; set; }
        [DataMember]
        public int ID_Consulta       { get; set; }
        [DataMember]
        public string Receita        { get; set; }
        [DataMember]
        public Medico Medico         { get; set; }
        [DataMember]
        public Paciente Paciente     { get; set; }
        [DataMember]
        public Secretaria Secretaria { get; set; }
    }
}
