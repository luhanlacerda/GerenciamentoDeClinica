using Biblioteca.conexaoBD;
using System;
using System.Collections.Generic;

namespace Biblioteca.convenio
{

    public class NegocioConvenio : ConexaoSql, IConvenio
    {
        private const string ERRO_NUMERO = "Número de convenio inválido.";
        private const string ERRO_NOME = "Descrição de convenio inválido.";

        public void Atualizar(Convenio convenio)
        {
            if (convenio.Id_convenio < 0)
            {
                throw new Exception(ERRO_NUMERO);
            }

            if (convenio.Descricao == null && convenio.Descricao.Trim().Equals(""))
            {
                throw new Exception(ERRO_NOME);
            }
        }

        public void Cadastrar(Convenio convenio)
        {
            if (convenio.Id_convenio < 0)
            {
                throw new Exception(ERRO_NUMERO);
            }

            if (convenio.Descricao == null && convenio.Descricao.Trim().Equals(""))
            {
                throw new Exception(ERRO_NOME);
            }
        }

        public List<Convenio> Listar(Convenio filtro)
        {
            throw new NotImplementedException();
        }

        public void Remover(Convenio c)
        {
            if (c.Descricao.Trim().Length > 20)
            {
                throw new Exception("A descrição deve conter apenas 20 caracteres.");
            }

            if (VerificaExistencia(c) == false)
            {
                throw new Exception("Convenio não cadastrado no sistema.");
            }
        }

        public bool VerificaExistencia(Convenio c)
        {
            throw new NotImplementedException();
        }

    }
}
