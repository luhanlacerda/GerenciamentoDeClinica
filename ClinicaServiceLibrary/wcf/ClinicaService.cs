using ClinicaServiceLibrary.consulta;
using ClinicaServiceLibrary.convenio;
using ClinicaServiceLibrary.especialidade;
using ClinicaServiceLibrary.medico;
using ClinicaServiceLibrary.paciente;
using ClinicaServiceLibrary.secretaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace ClinicaServiceLibrary.wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ClinicaService : IClinicaService
    {
        public void AtualizarConsulta(Consulta consulta)
        {
            NegocioConsulta negocioConsulta = new NegocioConsulta();
            negocioConsulta.Atualizar(consulta);
        }

        public void AtualizarConvenio(Convenio convenio)
        {
            NegocioConvenio negocioConvenio = new NegocioConvenio();
            negocioConvenio.Atualizar(convenio);
        }

        public void AtualizarEspecialidade(Especialidade especialidade)
        {
            NegocioEspecialidade negocioEspecialidade = new NegocioEspecialidade();
            negocioEspecialidade.Atualizar(especialidade);
        }

        public void AtualizarMedico(Medico medico)
        {
            NegocioMedico negocioMedico = new NegocioMedico();
            negocioMedico.Atualizar(medico);
        }

        public void AtualizarPaciente(Paciente paciente)
        {
            NegocioPaciente negocioPaciente = new NegocioPaciente();
            negocioPaciente.Atualizar(paciente);
        }

        public void AtualizarSecretaria(Secretaria secretaria)
        {
            NegocioSecretaria negocioSecretaria = new NegocioSecretaria();
            negocioSecretaria.Atualizar(secretaria);
        }

        public void CadastrarConsulta(Consulta consulta)
        {
            NegocioConsulta negocioConsulta = new NegocioConsulta();
            negocioConsulta.Cadastrar(consulta);
        }

        public void CadastrarConvenio(Convenio convenio)
        {
            NegocioConvenio negocioConvenio = new NegocioConvenio();
            negocioConvenio.Cadastrar(convenio);
        }

        public void CadastrarEspecialidade(Especialidade especialidade)
        {
            NegocioEspecialidade negocioEspecialidade = new NegocioEspecialidade();
            negocioEspecialidade.Cadastrar(especialidade);
        }

        public void CadastrarMedico(Medico medico)
        {
            NegocioMedico negocioMedico = new NegocioMedico();
            negocioMedico.Cadastrar(medico);
        }

        public void CadastrarPaciente(Paciente paciente)
        {
            NegocioPaciente negocioPaciente = new NegocioPaciente();
            negocioPaciente.Cadastrar(paciente);
        }

        public void CadastrarSecretaria(Secretaria secretaria)
        {
            NegocioSecretaria negocioSecretaria = new NegocioSecretaria();
            negocioSecretaria.Cadastrar(secretaria);
        }

        public List<Consulta> ListarConsulta(Consulta filtro)
        {
            NegocioConsulta negocioConsulta = new NegocioConsulta();
            return negocioConsulta.Listar(filtro);
        }

        public List<Convenio> ListarConvenio(Convenio filtro)
        {
            NegocioConvenio negocioConvenio = new NegocioConvenio();
            return negocioConvenio.Listar(filtro);
        }

        public List<Especialidade> ListarEspecialidade(Especialidade filtro)
        {
            NegocioEspecialidade negocioEspecialidade = new NegocioEspecialidade();
            return negocioEspecialidade.Listar(filtro);
        }

        public List<Medico> ListarMedico(Medico filtro)
        {
            NegocioMedico negocioMedico = new NegocioMedico();
            return negocioMedico.Listar(filtro);
        }

        public List<Paciente> ListarPaciente(Paciente filtro)
        {
            NegocioPaciente negocioPaciente = new NegocioPaciente();
            return negocioPaciente.Listar(filtro);
        }

        public List<Secretaria> ListarSecretaria(Secretaria filtro)
        {
            NegocioSecretaria negocioSecretaria = new NegocioSecretaria();
            return negocioSecretaria.Listar(filtro);
        }

        public void RemoverConsulta(Consulta consulta)
        {
            NegocioConsulta negocioConsulta = new NegocioConsulta();
            negocioConsulta.Remover(consulta);
        }

        public void RemoverConvenio(Convenio convenio)
        {
            NegocioConvenio negocioConvenio = new NegocioConvenio();
            negocioConvenio.Remover(convenio);
        }

        public void RemoverEspecialidade(Especialidade especialidade)
        {
            NegocioEspecialidade negocioEspecialidade = new NegocioEspecialidade();
            negocioEspecialidade.Remover(especialidade);
        }

        public void RemoverMedico(Medico medico)
        {
            NegocioMedico negocioMedico = new NegocioMedico();
            negocioMedico.Remover(medico);
        }

        public void RemoverPaciente(Paciente paciente)
        {
            NegocioPaciente negocioPaciente = new NegocioPaciente();
            negocioPaciente.Remover(paciente);
        }

        public void RemoverSecretaria(Secretaria secretaria)
        {
            NegocioSecretaria negocioSecretaria = new NegocioSecretaria();
            negocioSecretaria.Remover(secretaria);
        }
    }
}
