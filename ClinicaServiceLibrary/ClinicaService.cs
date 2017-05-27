using ClinicaServiceLibrary.classesbasicas;
using ClinicaServiceLibrary.convenio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ClinicaServiceLibrary.consulta;
using ClinicaServiceLibrary.especialidade;
using ClinicaServiceLibrary.medico;
using ClinicaServiceLibrary.paciente;
using ClinicaServiceLibrary.secretaria;

namespace ClinicaServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ClinicaService : IClinicaService
    {
        public void AtualizarConsulta(Consulta consulta)
        {
            throw new NotImplementedException();
        }

        public void AtualizarConvenio(Convenio convenio)
        {
            throw new NotImplementedException();
        }

        public void AtualizarEspecialidade(Especialidade especialidade)
        {
            throw new NotImplementedException();
        }

        public void AtualizarMedico(Medico medico)
        {
            throw new NotImplementedException();
        }

        public void AtualizarPaciente(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public void AtualizarSecretaria(Secretaria secretaria)
        {
            throw new NotImplementedException();
        }

        public void CadastrarConsulta(Consulta consulta)
        {
            throw new NotImplementedException();
        }

        public void CadastrarConvenio(Convenio convenio)
        {
            NegocioConvenio negocioConvenio = new NegocioConvenio();
            negocioConvenio.Cadastrar(convenio);
        }

        public void CadastrarEspecialidade(Especialidade especialidade)
        {
            throw new NotImplementedException();
        }

        public void CadastrarMedico(Medico medico)
        {
            throw new NotImplementedException();
        }

        public void CadastrarPaciente(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public void CadastrarSecretaria(Secretaria secretaria)
        {
            throw new NotImplementedException();
        }

        public List<Consulta> ListarConsulta(Consulta filtro)
        {
            throw new NotImplementedException();
        }

        public List<Convenio> ListarConvenio(Convenio filtro)
        {
            throw new NotImplementedException();
        }

        public List<Especialidade> ListarEspecialidade(Especialidade filtro)
        {
            throw new NotImplementedException();
        }

        public List<Medico> ListarMedico(Medico filtro)
        {
            throw new NotImplementedException();
        }

        public List<Paciente> ListarPaciente(Paciente filtro)
        {
            throw new NotImplementedException();
        }

        public List<Secretaria> ListarSecretaria(Secretaria filtro)
        {
            throw new NotImplementedException();
        }

        public void RemoverConsulta(Consulta consulta)
        {
            throw new NotImplementedException();
        }

        public void RemoverConvenio(Convenio convenio)
        {
            throw new NotImplementedException();
        }

        public void RemoverEspecialidade(Especialidade especialidade)
        {
            throw new NotImplementedException();
        }

        public void RemoverMedico(Medico medico)
        {
            throw new NotImplementedException();
        }

        public void RemoverPaciente(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public void RemoverSecretaria(Secretaria secretaria)
        {
            throw new NotImplementedException();
        }
    }
}
