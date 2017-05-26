using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.secretaria
{
    [ServiceContract]
    public interface ISecretaria
    {
        [OperationContract]
        //Cadastrar uma secretaria
        void CadastrarSecretaria(Secretaria secretaria);
        [OperationContract]
        //Atualizar uma secretaria
        void AtualizarSecretaria(Secretaria secretaria);
        [OperationContract]
        //Remover uma secretaria
        void RemoverSecretaria(Secretaria secretaria);
        [OperationContract]
        //Selecionar as secretarias que se encaixam no filtro de pesquisa
        List<Secretaria> ListarSecretaria(Secretaria filtro);
        [OperationContract]
        //Verificar se uma secretaria já está cadastrada
        bool VerificarExistenciaSecretaria(Secretaria secretaria);
    }
}
