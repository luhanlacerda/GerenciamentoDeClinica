using Biblioteca.utils;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Biblioteca.convenio
{

    public class NegocioConvenio : ConexaoSql, IConvenio
    {
        public void CadastrarConvenio(Convenio convenio)
        {
            if (VerificarExistenciaConvenio(convenio) != false)
            {
                throw new FaultException("Código de convenio já cadastrado");
            }

            ClinicaUtils.ValidarVazio(convenio.Descricao.Trim(), ClinicaUtils.ERRO_ESPECIALIDADE);
            ClinicaUtils.ValidarExceder(convenio.Descricao.Trim(), 20, ClinicaUtils.ERRO_ESPECIALIDADE);

            new ConvenioBD().CadastrarConvenio(convenio);
        }


        public void AtualizarConvenio(Convenio convenio)
        {
            ClinicaUtils.ValidarCodigo(convenio.ID_Convenio);

            ClinicaUtils.ValidarVazio(convenio.Descricao.Trim(), ClinicaUtils.ERRO_ESPECIALIDADE);
            ClinicaUtils.ValidarExceder(convenio.Descricao.Trim(), 20, ClinicaUtils.ERRO_ESPECIALIDADE);

            new ConvenioBD().AtualizarConvenio(convenio);
        }


        public void RemoverConvenio(Convenio convenio)
        {
            ClinicaUtils.ValidarCodigo(convenio.ID_Convenio);

            new ConvenioBD().RemoverConvenio(convenio);
        }

        public List<Convenio> ListarConvenio(Convenio filtro)
        {
            return new ConvenioBD().ListarConvenio(filtro);
        }

        public bool VerificarExistenciaConvenio(Convenio convenio)
        {
            return new ConvenioBD().VerificarExistenciaConvenio(convenio);
        }

    }
}


