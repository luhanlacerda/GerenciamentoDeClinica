using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.consulta
{
    [ServiceContract]
    public interface IConsulta
    {
        [OperationContract]
        //Cadastrar Consulta
        void CadastrarConsulta (Consulta consulta);
        [OperationContract]
        //Atualizar Consulta
        void AtualizarConsulta(Consulta consulta);
        [OperationContract]
        //Remover Consulta
        void RemoverConsulta(Consulta consulta);
        [OperationContract]
        //Selecionando as consultas que se encaixam no filtro
        List<Consulta> ListarConsulta(Consulta filtro);
        [OperationContract]
        //Vereficar se uma consulta ja está cadastrado
        bool VerificarExistenciaConsulta(Consulta consulta);
    }
}
