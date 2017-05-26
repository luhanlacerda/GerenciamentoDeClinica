using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca.consulta
{
    public class NegocioConsulta : IConsulta
    {
        //Horario, Duracao, Observacao, Descricao, ID_Receita, ID_Medico, ID_Paciente, ID_Secretaria        #region Erros
        #region
        private const string ERRO_NUMERO  = "Número inválido.";
        //private const string ERRO_HORARIO = "Horário inválido"; Como validar horário?
        private const string ERRO_DURACAO = "Duração inválida";
        private const string ERRO_OBSERVACAO = "Observação inválida";
        private const string ERRO_EXCEDER_OBSERVACAO = "A observação não deve exceder 500 caracteres.";
        private const string ERRO_DESCRICAO = "Descrição inválida";
        private const string ERRO_EXCEDER_DESCRICAO = "A descrição não deve exceder 20 caracteres.";
        private const string ERRO_MEDICO= "Médico inválido";
        private const string ERRO_PACIENTE = "Paciente inválido";
        private const string ERRO_SECRETARIA = "Secretária inválida";
        #endregion
        //Verificar validação do tamanho máximo do ENDEREÇO!

        public void CadastrarConsulta(Consulta consulta)
        {
            #region Validações
            if (consulta.Duracao < 1)
            {
                throw new FaultException (ERRO_DURACAO);
            }

            if (string.IsNullOrWhiteSpace(consulta.Observacoes.Trim()))
            {
                throw new FaultException(ERRO_OBSERVACAO);
            }

            if (consulta.Observacoes.Trim().Length < 1 || consulta.Observacoes.Length > 500)
            {
                throw new FaultException(ERRO_EXCEDER_OBSERVACAO);
            }

            if (string.IsNullOrWhiteSpace(consulta.Descricao.Trim()))
            {
                throw new FaultException(ERRO_DESCRICAO);
            }

            if (consulta.Descricao.Trim().Length < 1 || consulta.Descricao.Length > 20)
            {
                throw new FaultException (ERRO_EXCEDER_DESCRICAO);
            }

            if (consulta.ID_Consulta < 1)
            {
                throw new FaultException (ERRO_NUMERO);
            }

            if (consulta.Medico.ID_Medico < 1)
            {
                throw new FaultException (ERRO_MEDICO); 
            }

            if (consulta.Paciente.ID_Paciente < 1)
            {
                throw new FaultException(ERRO_PACIENTE);
            }

            if (consulta.Secretaria.ID_Secretaria < 1)
            {
                throw new FaultException (ERRO_SECRETARIA);
            }
#endregion

            new ConsultaBD().CadastrarConsulta(consulta);
        }

        public void AtualizarConsulta(Consulta consulta)
        {

            new ConsultaBD().AtualizarConsulta(consulta);
        }

        public void RemoverConsulta(Consulta consulta)
        {
            if (consulta.ID_Consulta < 1)
            {
                throw new FaultException (ERRO_NUMERO);
            }

            new ConsultaBD().RemoverConsulta(consulta);

        }

        public List<Consulta> ListarConsulta(Consulta filtro)
        {
            return new ConsultaBD().ListarConsulta(filtro);
        }

        public bool VerificarExistenciaConsulta(Consulta consulta)
        {
            if (consulta.ID_Consulta < 1)
            {
                throw new FaultException(ERRO_NUMERO);
            }

            return new ConsultaBD().VerificarExistenciaConsulta(consulta);
        }
    }
}
