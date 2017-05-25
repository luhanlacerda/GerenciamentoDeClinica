using Biblioteca.consulta;
using Biblioteca.convenio;
using Biblioteca.especialidade;
using Biblioteca.medico;
using Biblioteca.paciente;
using Biblioteca.secretaria;
using System.Collections.Generic;

namespace Biblioteca.fachada
{
    public class Fachada : IConsulta, IConvenio, IEspecialidade, IMedico, IPaciente, ISecretaria
    {
        public void Atualizar(Convenio convenio)
        {
            NegocioConvenio negocioConvenio = new NegocioConvenio();
            negocioConvenio.Atualizar(convenio);
        }

        public void Atualizar(Medico medico)
        {
            NegocioMedico negocioMedico = new NegocioMedico();
            negocioMedico.Atualizar(medico);
        }

        public void Atualizar(Secretaria secretaria)
        {
            NegocioSecretaria negocioSecretaria = new NegocioSecretaria();
            negocioSecretaria.Atualizar(secretaria);
        }

        public void Atualizar(Especialidade especialidade)
        {
            NegocioEspecialidade negocioEspecialidade = new NegocioEspecialidade();
            negocioEspecialidade.Atualizar(especialidade);
        }

        public void Atualizar(Consulta consulta)
        {
            NegocioConsulta negocioConsulta = new NegocioConsulta();
            negocioConsulta.Atualizar(consulta);
        }

        public void Atualizar(Paciente paciente)
        {
            NegocioPaciente negocioPaciente = new NegocioPaciente();
            negocioPaciente.Atualizar(paciente);
        }

        public void Cadastrar(Secretaria secretaria)
        {
            NegocioSecretaria negocioSecretaria = new NegocioSecretaria();
            negocioSecretaria.Cadastrar(secretaria);
        }

        public void Cadastrar(Medico medico)
        {
            NegocioMedico negocioMedico = new NegocioMedico();
            negocioMedico.Cadastrar(medico);
        }

        public void Cadastrar(Especialidade especialidade)
        {
            NegocioEspecialidade negocioEspecialidade = new NegocioEspecialidade();
            negocioEspecialidade.Cadastrar(especialidade);
        }

        public void Cadastrar(Convenio convenio)
        {
            NegocioConvenio negocioConvenio = new NegocioConvenio();
            negocioConvenio.Cadastrar(convenio);
        }

        public void Cadastrar(Consulta consulta)
        {
            NegocioConsulta negocioConsulta = new NegocioConsulta();
            negocioConsulta.Cadastrar(consulta);
        }

        public void Cadastrar(Paciente paciente)
        {
            NegocioPaciente negocioPaciente = new NegocioPaciente();
            negocioPaciente.Cadastrar(paciente);
        }

        public List<Especialidade> Listar(Especialidade filtro)
        {
            NegocioEspecialidade negocioEspecialidade = new NegocioEspecialidade();
            return negocioEspecialidade.Listar(filtro);
        }

        public List<Secretaria> Listar(Secretaria filtro)
        {
            NegocioSecretaria negocioSecretaria = new NegocioSecretaria();
            return negocioSecretaria.Listar(filtro);
        }

        public List<Medico> Listar(Medico filtro)
        {
            NegocioMedico negocioMedico = new NegocioMedico();
            return negocioMedico.Listar(filtro);
        }

        public List<Convenio> Listar(Convenio filtro)
        {
            NegocioConvenio negocioConvenio = new NegocioConvenio();
            return negocioConvenio.Listar(filtro);
        }

        public List<Consulta> Listar(Consulta filtro)
        {
            NegocioConsulta negocioConsulta = new NegocioConsulta();
            return negocioConsulta.Listar(filtro);
        }

        public List<Paciente> Listar(Paciente filtro)
        {
            NegocioPaciente negocioPaciente = new NegocioPaciente();
            return negocioPaciente.Listar(filtro);
        }

        public void Remover(Convenio convenio)
        {
            NegocioConvenio negocioConvenio = new NegocioConvenio();
            negocioConvenio.Remover(convenio);
        }

        public void Remover(Especialidade especialidade)
        {
            NegocioEspecialidade negocioEspecialidade = new NegocioEspecialidade();
            negocioEspecialidade.Remover(especialidade);
        }

        public void Remover(Medico medico)
        {
            NegocioMedico negocioMedico = new NegocioMedico();
            negocioMedico.Remover(medico);
        }

        public void Remover(Secretaria secretaria)
        {
            NegocioSecretaria negocioSecretaria = new NegocioSecretaria();
            negocioSecretaria.Remover(secretaria);
        }

        public void Remover(Consulta consulta)
        {
            NegocioConsulta negocioConsulta = new NegocioConsulta();
            negocioConsulta.Remover(consulta);
        }

        public void Remover(Paciente paciente)
        {
            NegocioPaciente negocioPaciente = new NegocioPaciente();
            negocioPaciente.Remover(paciente);
        }

        public bool VerificaExistencia(Medico medico)
        {
            NegocioMedico negocioMedico = new NegocioMedico();
            return negocioMedico.VerificaExistencia(medico);
        }

        public bool VerificaExistencia(Secretaria secretaria)
        {
            NegocioSecretaria negocioSecretaria = new NegocioSecretaria();
            return negocioSecretaria.VerificaExistencia(secretaria);
        }

        public bool VerificaExistencia(Especialidade especialidade)
        {
            NegocioEspecialidade negocioEspecialidade = new NegocioEspecialidade();
            return negocioEspecialidade.VerificaExistencia(especialidade);
        }

        public bool VerificaExistencia(Convenio convenio)
        {
            NegocioConvenio negocioConvenio = new NegocioConvenio();
            return negocioConvenio.VerificaExistencia(convenio);
        }

        public bool VerificaExistencia(Paciente paciente)
        {
            NegocioPaciente negocioPaciente = new NegocioPaciente();
            return negocioPaciente.VerificaExistencia(paciente);
        }

        public bool VerificarExistencia(Consulta consulta)
        {
            NegocioConsulta negocioConsulta = new NegocioConsulta();
            return negocioConsulta.VerificarExistencia(consulta);
        }
    }
}
