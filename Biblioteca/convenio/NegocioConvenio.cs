using Biblioteca.utils;
using Biblioteca.convenio;
using System;
using System.Collections.Generic;

namespace Biblioteca.convenio
{

    public class NegocioConvenio : ConexaoSql, IConvenio
    {
        #region Erros
        //ID_Convenio, descricao
        private const string ERRO_ID = "Número de convenio inválido.";
        private const string ERRO_DESCRICAO = "Descrição de convenio inválido.";
        private const string ERRO_EXECER_DESCRICAO = "A descrição deve conter 20 caracteres.";
        #endregion
        public void Atualizar(Convenio convenio)
        {
            #region Validações
            if (convenio.ID_Convenio < 0)
            {
                throw new Exception(ERRO_ID);
            }

            if (string.IsNullOrWhiteSpace(convenio.Descricao.Trim()))
            {
                throw new Exception(ERRO_DESCRICAO);
            }

            if (convenio.Descricao.Trim().Length < 1 || convenio.Descricao.Trim().Length > 20)
            {
                throw new Exception(ERRO_EXECER_DESCRICAO);
            }

            if (convenio.Descricao.Trim().Length != 20)
            {
                throw new Exception(ERRO_EXECER_DESCRICAO);
            }

            new ConvenioBD().Atualizar(convenio);
            #endregion
        }


        public void Cadastrar(Convenio convenio)
        {
            #region Validações
            if (convenio.ID_Convenio < 0)
            {
                throw new Exception(ERRO_ID);
            }

            if (string.IsNullOrWhiteSpace(convenio.Descricao.Trim()))
            {
                throw new Exception(ERRO_DESCRICAO);
            }

            if (convenio.Descricao.Trim().Length < 1 || convenio.Descricao.Trim().Length > 20)
            {
                throw new Exception(ERRO_EXECER_DESCRICAO);
            }

            if (convenio.Descricao.Trim().Length != 20)
            {
                throw new Exception(ERRO_EXECER_DESCRICAO);
            }
            new ConvenioBD().Cadastrar(convenio);
            #endregion
        }


        public void Remover(Convenio convenio)
        {
            #region Validações

            if (convenio.ID_Convenio < 1)
            {
                throw new Exception(ERRO_ID);
            }
            new ConvenioBD().Remover(convenio);
            #endregion
        }


        public List<Convenio> Listar(Convenio filtro)
        {
            return new ConvenioBD().Listar(filtro);
        }


        public bool VerificaExistencia(Convenio convenio)
        {

            if (convenio.ID_Convenio < 1)
            {
                throw new Exception(ERRO_ID);
            }

            return new ConvenioBD().VerificaExistencia(convenio);

        }
    }
}


