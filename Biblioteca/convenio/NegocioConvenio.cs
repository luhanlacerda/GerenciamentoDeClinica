using Biblioteca.utils;
using System;
using System.Collections.Generic;

namespace Biblioteca.convenio
{

    public class NegocioConvenio : ConexaoSql, IConvenio
    {
        public void Cadastrar(Convenio paciente)
        {
            ClinicaUtils.ValidarCodigo(paciente.ID_Convenio);

            if (VerificaExistencia(paciente) != false)
            {
                throw new Exception("Código de convenio já cadastrado");
            }

            ClinicaUtils.ValidarVazio(paciente.Descricao.Trim(), ClinicaUtils.ERRO_ESPECIALIDADE);
            ClinicaUtils.ValidarExceder(paciente.Descricao.Trim(), 20, ClinicaUtils.ERRO_ESPECIALIDADE);

            new ConvenioBD().Cadastrar(paciente);
        }


        public void Atualizar(Convenio paciente)
        {
            ClinicaUtils.ValidarCodigo(paciente.ID_Convenio);

            ClinicaUtils.ValidarVazio(paciente.Descricao.Trim(), ClinicaUtils.ERRO_ESPECIALIDADE);
            ClinicaUtils.ValidarExceder(paciente.Descricao.Trim(), 20, ClinicaUtils.ERRO_ESPECIALIDADE);

            new ConvenioBD().Atualizar(paciente);
        }


        public void Remover(Convenio paciente)
        {
            ClinicaUtils.ValidarCodigo(paciente.ID_Convenio);

            new ConvenioBD().Remover(paciente);
        }

        public List<Convenio> Listar(Convenio filtro)
        {
            return new ConvenioBD().Listar(filtro);
        }

        public bool VerificaExistencia(Convenio paciente)
        {
            ClinicaUtils.ValidarCodigo(paciente.ID_Convenio);

            return new ConvenioBD().VerificaExistencia(paciente);
        }

    }
}


