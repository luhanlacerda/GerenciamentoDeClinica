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

namespace ClinicaServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IClinicaService
    {
        // TODO: Add your service operations here

        [OperationContract]
        void CadastrarConsulta(Consulta consulta);

        [OperationContract]
        void AtualizarConsulta(Consulta consulta);

        [OperationContract]
        void RemoverConsulta(Consulta consulta);

        [OperationContract]
        List<Consulta> ListarConsulta(Consulta filtro);

        [OperationContract]
        void CadastrarConvenio(Convenio convenio);

        [OperationContract]
        void AtualizarConvenio(Convenio convenio);

        [OperationContract]
        void RemoverConvenio(Convenio convenio);

        [OperationContract]
        List<Convenio> ListarConvenio(Convenio filtro);

        [OperationContract]
        void CadastrarEspecialidade(Especialidade especialidade);

        [OperationContract]
        void AtualizarEspecialidade(Especialidade especialidade);

        [OperationContract]
        void RemoverEspecialidade(Especialidade especialidade);

        [OperationContract]
        List<Especialidade> ListarEspecialidade(Especialidade filtro);

        [OperationContract]
        void CadastrarMedico(Medico medico);

        [OperationContract]
        void AtualizarMedico(Medico medico);

        [OperationContract]
        void RemoverMedico(Medico medico);

        [OperationContract]
        List<Medico> ListarMedico(Medico filtro);

        [OperationContract]
        void CadastrarPaciente(Paciente paciente);

        [OperationContract]
        void AtualizarPaciente(Paciente paciente);

        [OperationContract]
        void RemoverPaciente(Paciente paciente);

        [OperationContract]
        List<Paciente> ListarPaciente(Paciente filtro);

        [OperationContract]
        void CadastrarSecretaria(Secretaria secretaria);

        [OperationContract]
        void AtualizarSecretaria(Secretaria secretaria);

        [OperationContract]
        void RemoverSecretaria(Secretaria secretaria);

        [OperationContract]
        List<Secretaria> ListarSecretaria(Secretaria filtro);
    }
}
