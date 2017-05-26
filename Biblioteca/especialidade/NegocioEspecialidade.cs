using Biblioteca.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.especialidade
{
    public class NegocioEspecialidade : IEspecialidade
    {
        public void CadastrarEspecialidade(Especialidade especialidade)
        {
            ClinicaUtils.ValidarCodigo(especialidade.ID_Especialidade);

            if (VerificarExistenciaEspecialidade(especialidade) != false)
            {
                throw new FaultException("Código de especialidade já cadastrado");
            }

            ClinicaUtils.ValidarVazio(especialidade.Descricao.Trim(), ClinicaUtils.ERRO_ESPECIALIDADE);
            ClinicaUtils.ValidarExceder(especialidade.Descricao.Trim(), 20, ClinicaUtils.ERRO_ESPECIALIDADE);

            new EspecialidadeBD().CadastrarEspecialidade(especialidade);
        }


        public void AtualizarEspecialidade(Especialidade especialidade)
        {
            ClinicaUtils.ValidarCodigo(especialidade.ID_Especialidade);

            ClinicaUtils.ValidarVazio(especialidade.Descricao.Trim(), ClinicaUtils.ERRO_ESPECIALIDADE);
            ClinicaUtils.ValidarExceder(especialidade.Descricao.Trim(), 20, ClinicaUtils.ERRO_ESPECIALIDADE);

            new EspecialidadeBD().AtualizarEspecialidade(especialidade);
        }


        public void RemoverEspecialidade(Especialidade especialidade)
        {
            ClinicaUtils.ValidarCodigo(especialidade.ID_Especialidade);

            new EspecialidadeBD().RemoverEspecialidade(especialidade);
        }

        public List<Especialidade> ListarEspecialidade(Especialidade filtro)
        {
            return new EspecialidadeBD().ListarEspecialidade(filtro);
        }

        public bool VerificarExistenciaEspecialidade(Especialidade especialidade)
        {
            ClinicaUtils.ValidarCodigo(especialidade.ID_Especialidade);

            return new EspecialidadeBD().VerificarExistenciaEspecialidade(especialidade);
        }

    }
}