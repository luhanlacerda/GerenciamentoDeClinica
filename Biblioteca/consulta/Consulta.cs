using Biblioteca.paciente;
using Biblioteca.secretaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.consulta
{
    public class Consulta
    {

        public DateTime Horario      { get; set; } //DateTime salva a data e o horário indicado
        public int Duracao           { get; set; }
        public string Observacoes    { get; set; }
        public string Descricao      { get; set; }
        public int ID_Consulta       { get; set; }
        public string Receita        { get; set; }
        public Medico Medico         { get; set; }
        public Paciente Paciente     { get; set; }
        public Secretaria Secretaria { get; set; }
    }
}
