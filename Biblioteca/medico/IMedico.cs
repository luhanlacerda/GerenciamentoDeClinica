using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.medico
{
    [ServiceContract]
    public interface IMedico
    {
        [OperationContract]
        //Cadastrar um médico
        void CadastrarMedico(Medico medico);
        [OperationContract]
        //Atualizar um médico
        void AtualizarMedico(Medico medico);
        [OperationContract]
        //Remover um médico
        void RemoverMedico(Medico medico);
        [OperationContract]
        //Selecionar os médicos que se encaixam no filtro de pesquisa
        List<Medico> ListarMedico(Medico filtro);
        [OperationContract]
        //Verificar se um médico já está cadastrado
        bool VerificarExistenciaMedico(Medico medico); //Qual a diferença de bool para Boolean?
    }
}
