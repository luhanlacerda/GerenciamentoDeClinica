using Biblioteca.utils;
using Biblioteca.convenio;
using System;
using System.Collections.Generic;

namespace Biblioteca.convenio
{

    public class NegocioConvenio : ConexaoSql, IConvenio
    {
        public void Cadastrar(Convenio especialidade)
        {
            ClinicaUtils.ValidarCodigo(especialidade.ID_Convenio);

            if (VerificaExistencia(especialidade) != false)
            {
                throw new Exception("Código de especialidade já cadastrado");
            }

            ClinicaUtils.ValidarVazio(especialidade.Descricao.Trim(), ClinicaUtils.ERRO_ESPECIALIDADE);
            ClinicaUtils.ValidarExceder(especialidade.Descricao.Trim(), 20, ClinicaUtils.ERRO_ESPECIALIDADE);

            new ConvenioBD().Cadastrar(especialidade);
        }


        public void Atualizar(Convenio especialidade)
        {
            ClinicaUtils.ValidarCodigo(especialidade.ID_Convenio);

            ClinicaUtils.ValidarVazio(especialidade.Descricao.Trim(), ClinicaUtils.ERRO_ESPECIALIDADE);
            ClinicaUtils.ValidarExceder(especialidade.Descricao.Trim(), 20, ClinicaUtils.ERRO_ESPECIALIDADE);

            new ConvenioBD().Atualizar(especialidade);
        }


        public void Remover(Convenio especialidade)
        {
            ClinicaUtils.ValidarCodigo(especialidade.ID_Convenio);

            new ConvenioBD().Remover(especialidade);
        }

        public List<Convenio> Listar(Convenio filtro)
        {
            return new ConvenioBD().Listar(filtro);
        }

        public bool VerificaExistencia(Convenio especialidade)
        {
            ClinicaUtils.ValidarCodigo(especialidade.ID_Convenio);

            return new ConvenioBD().VerificaExistencia(especialidade);
        }

    }
}


