using Biblioteca.medico;
using Biblioteca.paciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.consulta
{
    //teste2
    public class Consulta
    {
        private int numeroConsulta;
        private DateTime data;
        private DateTime horario;
        private Paciente paciente;
        private Medico medico;
        private String historico;

        public int NumeroConsulta
        {
            get
            {
                return numeroConsulta;
            }

            set
            {
                numeroConsulta = value;
            }
        }

        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public DateTime Horario
        {
            get
            {
                return horario;
            }

            set
            {
                horario = value;
            }
        }

        public Paciente Paciente
        {
            get
            {
                return paciente;
            }

            set
            {
                paciente = value;
            }
        }

        public Medico Medico
        {
            get
            {
                return medico;
            }

            set
            {
                medico = value;
            }
        }

        public string Historico
        {
            get
            {
                return historico;
            }

            set
            {
                historico = value;
            }
        }

        public String toString()
        {
            String retorno;
            retorno = "Nome: " + this.Paciente.Nome + "\n";
            retorno += "Data: " + this.Data + "\n";
            retorno += "Horário: " + this.Horario + "\n";
            retorno += "Médico: " + this.Medico.CRM + "\n";
            return retorno;

        }
    }
}
