using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.especialidade
{
    [ServiceContract]
    public interface IEspecialidade
    {
        [OperationContract]
        //Cadastrar uma especialidade
        void CadastrarEspecialidade(Especialidade especialidade);
        [OperationContract]
        //Atualizar uma especialidade
        void AtualizarEspecialidade(Especialidade especialidade);
        [OperationContract]
        //Remover uma especialidade
        void RemoverEspecialidade(Especialidade especialidade);
        [OperationContract]
        //Selecionar as especialidades que se encaixam no filtro de pesquisa
        List<Especialidade> ListarEspecialidade(Especialidade filtro);
        [OperationContract]
        //Verificar se uma especialidade já está cadastrado
        bool VerificarExistenciaEspecialidade(Especialidade especialidade);
    }
}
