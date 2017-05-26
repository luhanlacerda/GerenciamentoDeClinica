using System.Collections.Generic;
using System.ServiceModel;

namespace Biblioteca.convenio
{
    [ServiceContract]
    public interface IConvenio
    {
        [OperationContract]
        //Cadastrar um médico
        void CadastrarConvenio(Convenio convenio);
        [OperationContract]
        //Atualizar um médico
        void AtualizarConvenio(Convenio convenio);
        [OperationContract]
        //Remover um médico
        void RemoverConvenio(Convenio convenio);
        [OperationContract]
        //Selecionar os médicos que se encaixam no filtro de pesquisa
        List<Convenio> ListarConvenio(Convenio filtro);
        [OperationContract]
        //Verificar se um médico já está cadastrado
        bool VerificarExistenciaConvenio(Convenio convenio);
    }
}
