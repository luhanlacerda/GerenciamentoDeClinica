using System.Collections.Generic;
using System.ServiceModel;

namespace Biblioteca.paciente
{
    [ServiceContract]
    public interface IPaciente
    {
        [OperationContract]
        //Cadastrar um paciente
        void CadastrarPaciente(Paciente paciente);
        [OperationContract]
        //Atualizar um paciente
        void AtualizarPaciente(Paciente paciente);
        [OperationContract]
        //Remover um paciente
        void RemoverPaciente(Paciente paciente);
        [OperationContract]
        //Selecionar os paciente que se encaixam no filtro de pesquisa
        List<Paciente> ListarPaciente(Paciente filtro);
        [OperationContract]
        //Verificar se um paciente já está cadastrado
        bool VerificarExistenciaPaciente(Paciente paciente); 
    }
}
