using Biblioteca.conexaoBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.especialidade
{
    class NegocioEspecialidade : ConexaoSql, IEspecialidade
    {
        private const string ERRO_ID = "Código da especialidade inválido";
        private const string ERRO_DESCRICAO = "Descrição da especialidade inválida";

        public void Cadastrar(Especialidade especialidade)
        {
            if (especialidade.Id_especialidade <= 0)
            {
                throw new Exception(ERRO_ID);
            }

            if (especialidade.Descricao.Trim().Equals("") == true || especialidade.Descricao == null)
            {
                throw new Exception(ERRO_DESCRICAO);
            }

            if (especialidade.Descricao.Trim().Length > 20)
            {
                throw new Exception("A descrição da especialidade não deverá ter mais de 20 caracteres");
            }

            if (VerificaExistencia(especialidade) != false)
            {
                throw new Exception("Especialidade já cadastrada no sistema");
            }

            //Cadastrando nova especialidade
            Cadastrar(especialidade);
        }

        public void Atualizar(Especialidade especialidade)
        {
            if (especialidade.Id_especialidade <= 0)
            {
                throw new Exception(ERRO_ID);
            }

            if (especialidade.Descricao.Trim().Equals("") == true || especialidade.Descricao == null)
            {
                throw new Exception(ERRO_DESCRICAO);
            }

            if (especialidade.Descricao.Trim().Length > 20)
            {
                throw new Exception("A descrição da especialidade não deverá ter mais de 20 caracteres");
            }

            if (VerificaExistencia(especialidade) != false)
            {
                throw new Exception("Especialidade já cadastrada no sistema");
            }

            //Atualizando nova especialidade
            Atualizar(especialidade);
        }

        public void Remover(Especialidade especialidade)
        {
            if (especialidade.Id_especialidade <= 0)
            {
                throw new Exception(ERRO_ID);
            }

            if (VerificaExistencia(especialidade) == false)
            {
                throw new Exception("Especialidade não cadastrada no sistema");
            }

            //Removendo
            Remover(especialidade);
        }

        public bool VerificaExistencia(Especialidade especialidade)
        {
            if (especialidade.Id_especialidade < 0)
            {
                throw new Exception(ERRO_ID);
            }

            return new EspecialidadeBD().VerificaExistencia(especialidade);
        }

        public List<Especialidade> Listar(Especialidade filtro)
        {
            return new EspecialidadeBD().Listar(filtro);
        }
    }
}
