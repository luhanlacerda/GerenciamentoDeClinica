using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeClinica.Consulta
{
    using GerenciamentoDeClinica.Paciente;
    using GerenciamentoDeClinica.Medico;

    class Consulta
    {
        private int numeroConsulta;
        private DateTime data;
        private DateTime horario;
        private Paciente paciente;
        private Medico medico;
        private String historico;

        public int getNumeroConsulta()
        {
            return this.numeroConsulta;
        }

        public void setNumeroConsulta(int numeroConsulta)
        {
            this.numeroConsulta = numeroConsulta;
        }

        public DateTime getData()
        {
            return this.data;
        }

        public void setData(DateTime data)
        {
            this.data = data;
        }

        public DateTime getHorario()
        {
            return this.horario;
        }

        public Paciente getPaciente()
        {
            return this.paciente;
        }

        public void setPaciente(Paciente paciente)
        {
            this.paciente = paciente;
        }

        public Medico getMedico()
        {
            return this.medico;
        }

        public void setMedico(Medico medico)
        {
            this.medico = medico;
        }

        public String getHistorico()
        {
            return this.historico;
        }

        public void setHistorico(String historico)
        {
            this.historico = historico;
        }

        public String toString()
        {
            String retorno;
            retorno = "Nome: " + this.getPaciente().getNome() + "\n";
            retorno += "Data: " + this.getData() + "\n";
            retorno += "Horário: " + this.getHorario() + "\n";
            retorno += "Médico: " + this.getMedico().getNome() + "\n";
            return retorno;

        }
    }
}
