using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace ClinicaServiceLibrary.consulta
{
    public class NegocioConsulta : IConsulta
    {
        //Horario, Duracao, Observacao, Descricao, ID_Receita, ID_Medico, ID_Paciente, ID_Secretaria        #region Erros
        #region
        private const string ERRO_NUMERO = "Número inválido.";
        //private const string ERRO_HORARIO = "Horário inválido"; Como validar horário?
        private const string ERRO_DURACAO = "Duração inválida";
        private const string ERRO_OBSERVACAO = "Observação inválida";
        private const string ERRO_EXCEDER_OBSERVACAO = "A observação não deve exceder 500 caracteres.";
        private const string ERRO_DESCRICAO = "Descrição inválida";
        private const string ERRO_EXCEDER_DESCRICAO = "A descrição não deve exceder 20 caracteres.";
        private const string ERRO_MEDICO = "Médico inválido";
        private const string ERRO_PACIENTE = "Paciente inválido";
        private const string ERRO_SECRETARIA = "Secretária inválida";
        #endregion

        public void Cadastrar(Consulta consulta)
        {
            new ConsultaBD().Cadastrar(consulta);
        }

        public void Atualizar(Consulta consulta)
        {
            #region Validações
            if (consulta.Duracao < 1)
            {
                throw new FaultException(ERRO_DURACAO);
            }

            if (consulta.Observacoes.Trim().Length < 0 || consulta.Observacoes.Length > 500)
            {
                throw new FaultException(ERRO_EXCEDER_OBSERVACAO);
            }

            if (consulta.Medico.ID_Medico < 1)
            {
                throw new FaultException(ERRO_MEDICO);
            }

            if (consulta.Paciente.ID_Paciente < 1)
            {
                throw new FaultException(ERRO_PACIENTE);
            }

            #endregion
            new ConsultaBD().Atualizar(consulta);
        }

        public void Remover(Consulta consulta)
        {
            if (consulta.ID_Consulta < 1)
            {
                throw new FaultException(ERRO_NUMERO);
            }

            new ConsultaBD().Remover(consulta);

        }

        public List<Consulta> Listar(Consulta filtro)
        {
            return new ConsultaBD().Listar(filtro);
        }

        public bool VerificarExistencia(Consulta consulta)
        {
            if (consulta.ID_Consulta < 1)
            {
                throw new FaultException(ERRO_NUMERO);
            }

            return new ConsultaBD().VerificarExistencia(consulta);
        }
    }
}
