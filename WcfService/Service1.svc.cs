using Biblioteca.consulta;
using Biblioteca.convenio;
using Biblioteca.especialidade;
using Biblioteca.medico;
using Biblioteca.paciente;
using Biblioteca.secretaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IConsulta, IConvenio, IEspecialidade, IMedico, IPaciente, ISecretaria
    {
        public void AtualizarMedico(Medico medico)
        {
            NegocioMedico negocioMedico = new NegocioMedico();
            negocioMedico.AtualizarMedico(medico);
        }

        public void AtualizarSecretaria(Secretaria secretaria)
        {
            NegocioSecretaria negocioSecretaria = new NegocioSecretaria();
            negocioSecretaria.AtualizarSecretaria(secretaria);
        }

        public void AtualizarEspecialidade(Especialidade especialidade)
        {
            NegocioEspecialidade negocioEspecialidade = new NegocioEspecialidade();
            negocioEspecialidade.AtualizarEspecialidade(especialidade);
        }

        public void AtualizarConsulta(Consulta consulta)
        {
            NegocioConsulta negocioConsulta = new NegocioConsulta();
            negocioConsulta.AtualizarConsulta(consulta);
        }

        public void AtualizarConvenio(Convenio convenio)
        {
            NegocioConvenio negocioConvenio = new NegocioConvenio();
            negocioConvenio.AtualizarConvenio(convenio);
        }

        public void AtualizarPaciente(Paciente paciente)
        {
            NegocioPaciente negocioPaciente = new NegocioPaciente();
            negocioPaciente.AtualizarPaciente(paciente);
        }

        public void CadastrarSecretaria(Secretaria secretaria)
        {
            NegocioSecretaria negocioSecretaria = new NegocioSecretaria();
            negocioSecretaria.CadastrarSecretaria(secretaria);
        }

        public void CadastrarMedico(Medico medico)
        {
            NegocioMedico negocioMedico = new NegocioMedico();
            negocioMedico.CadastrarMedico(medico);
        }

        public void CadastrarEspecialidade(Especialidade especialidade)
        {
            NegocioEspecialidade negocioEspecialidade = new NegocioEspecialidade();
            negocioEspecialidade.CadastrarEspecialidade(especialidade);
        }

        public void CadastrarConsulta(Consulta consulta)
        {
            NegocioConsulta negocioConsulta = new NegocioConsulta();
            negocioConsulta.CadastrarConsulta(consulta);
        }

        public void CadastrarConvenio(Convenio convenio)
        {
            NegocioConvenio negocioConvenio = new NegocioConvenio();
            negocioConvenio.CadastrarConvenio(convenio);
        }

        public void CadastrarPaciente(Paciente paciente)
        {
            NegocioPaciente negocioPaciente = new NegocioPaciente();
            negocioPaciente.CadastrarPaciente(paciente);
        }

        public List<Especialidade> ListarEspecialidade(Especialidade filtro)
        {
            NegocioEspecialidade negocioEspecialidade = new NegocioEspecialidade();
            return negocioEspecialidade.ListarEspecialidade(filtro);
        }

        public List<Secretaria> ListarSecretaria(Secretaria filtro)
        {
            NegocioSecretaria negocioSecretaria = new NegocioSecretaria();
            return negocioSecretaria.ListarSecretaria(filtro);
        }

        public List<Medico> ListarMedico(Medico filtro)
        {
            NegocioMedico negocioMedico = new NegocioMedico();
            return negocioMedico.ListarMedico(filtro);
        }

        public List<Consulta> ListarConsulta(Consulta filtro)
        {
            NegocioConsulta negocioConsulta = new NegocioConsulta();
            return negocioConsulta.ListarConsulta(filtro);
        }

        public List<Convenio> ListarConvenio(Convenio filtro)
        {
            NegocioConvenio negocioConvenio = new NegocioConvenio();
            return negocioConvenio.ListarConvenio(filtro);
        }

        public List<Paciente> ListarPaciente(Paciente filtro)
        {
            NegocioPaciente negocioPaciente = new NegocioPaciente();
            return negocioPaciente.ListarPaciente(filtro);
        }        

        public void RemoverEspecialidade(Especialidade especialidade)
        {
            NegocioEspecialidade negocioEspecialidade = new NegocioEspecialidade();
            negocioEspecialidade.RemoverEspecialidade(especialidade);
        }

        public void RemoverMedico(Medico medico)
        {
            NegocioMedico negocioMedico = new NegocioMedico();
            negocioMedico.RemoverMedico(medico);
        }

        public void RemoverSecretaria(Secretaria secretaria)
        {
            NegocioSecretaria negocioSecretaria = new NegocioSecretaria();
            negocioSecretaria.RemoverSecretaria(secretaria);
        }

        public void RemoverConsulta(Consulta consulta)
        {
            NegocioConsulta negocioConsulta = new NegocioConsulta();
            negocioConsulta.RemoverConsulta(consulta);
        }

        public void RemoverConvenio(Convenio convenio)
        {
            NegocioConvenio negocioConvenio = new NegocioConvenio();
            negocioConvenio.RemoverConvenio(convenio);
        }

        public void RemoverPaciente(Paciente paciente)
        {
            NegocioPaciente negocioPaciente = new NegocioPaciente();
            negocioPaciente.RemoverPaciente(paciente);
        }

        public bool VerificarExistenciaMedico(Medico medico)
        {
            NegocioMedico negocioMedico = new NegocioMedico();
            return negocioMedico.VerificarExistenciaMedico(medico);
        }

        public bool VerificarExistenciaSecretaria(Secretaria secretaria)
        {
            NegocioSecretaria negocioSecretaria = new NegocioSecretaria();
            return negocioSecretaria.VerificarExistenciaSecretaria(secretaria);
        }

        public bool VerificarExistenciaEspecialidade(Especialidade especialidade)
        {
            NegocioEspecialidade negocioEspecialidade = new NegocioEspecialidade();
            return negocioEspecialidade.VerificarExistenciaEspecialidade(especialidade);
        }
    
        public bool VerificarExistenciaPaciente(Paciente paciente)
        {
            NegocioPaciente negocioPaciente = new NegocioPaciente();
            return negocioPaciente.VerificarExistenciaPaciente(paciente);
        }

        public bool VerificarExistenciaConsulta(Consulta consulta)
        {
            NegocioConsulta negocioConsulta = new NegocioConsulta();
            return negocioConsulta.VerificarExistenciaConsulta(consulta);
        }

        public bool VerificarExistenciaConvenio(Convenio convenio)
        {
            NegocioConvenio negocioConvenio = new NegocioConvenio();
            return negocioConvenio.VerificarExistenciaConvenio(convenio);
        }

    }
}
