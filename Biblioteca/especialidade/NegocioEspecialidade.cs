using Biblioteca.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.especialidade
{
    public class NegocioEspecialidade : IEspecialidade
    {
        public void Cadastrar(Especialidade especialidade)
        {
            try
            {
                ClinicaUtils.ValidarCodigo(especialidade.ID_Especialidade);

                ClinicaUtils.ValidarVazio(especialidade.Descricao.Trim(), ClinicaUtils.ERRO_ESPECIALIDADE);
                ClinicaUtils.ValidarTamanho(especialidade.Descricao.Trim(), 20, ClinicaUtils.ERRO_ESPECIALIDADE);

                new EspecialidadeBD().Cadastrar(especialidade);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Atualizar(Especialidade especialidade)
        {
            try
            {
                ClinicaUtils.ValidarCodigo(especialidade.ID_Especialidade);

                ClinicaUtils.ValidarVazio(especialidade.Descricao.Trim(), ClinicaUtils.ERRO_ESPECIALIDADE);
                ClinicaUtils.ValidarTamanho(especialidade.Descricao.Trim(), 20, ClinicaUtils.ERRO_ESPECIALIDADE);

                new EspecialidadeBD().Atualizar(especialidade);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Remover(Especialidade especialidade)
        {
            try
            {
                ClinicaUtils.ValidarCodigo(especialidade.ID_Especialidade);

                new EspecialidadeBD().Remover(especialidade);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Especialidade> Listar(Especialidade filtro)
        {
            return new EspecialidadeBD().Listar(filtro);
        }

        public bool VerificaExistencia(Especialidade especialidade)
        {
            try
            {
                ClinicaUtils.ValidarCodigo(especialidade.ID_Especialidade);

                return new EspecialidadeBD().VerificaExistencia(especialidade);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
