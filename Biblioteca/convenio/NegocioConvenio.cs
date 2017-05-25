﻿using Biblioteca.utils;
using System;
using System.Collections.Generic;

namespace Biblioteca.convenio
{

    public class NegocioConvenio : ConexaoSql, IConvenio
    {
        public void Cadastrar(Convenio convenio)
        {
            ClinicaUtils.ValidarCodigo(convenio.ID_Convenio);

            if (VerificaExistencia(convenio) != false)
            {
                throw new Exception("Código de convenio já cadastrado");
            }

            ClinicaUtils.ValidarVazio(convenio.Descricao.Trim(), ClinicaUtils.ERRO_ESPECIALIDADE);
            ClinicaUtils.ValidarExceder(convenio.Descricao.Trim(), 20, ClinicaUtils.ERRO_ESPECIALIDADE);

            new ConvenioBD().Cadastrar(convenio);
        }


        public void Atualizar(Convenio convenio)
        {
            ClinicaUtils.ValidarCodigo(convenio.ID_Convenio);

            ClinicaUtils.ValidarVazio(convenio.Descricao.Trim(), ClinicaUtils.ERRO_ESPECIALIDADE);
            ClinicaUtils.ValidarExceder(convenio.Descricao.Trim(), 20, ClinicaUtils.ERRO_ESPECIALIDADE);

            new ConvenioBD().Atualizar(convenio);
        }


        public void Remover(Convenio convenio)
        {
            ClinicaUtils.ValidarCodigo(convenio.ID_Convenio);

            new ConvenioBD().Remover(convenio);
        }

        public List<Convenio> Listar(Convenio filtro)
        {
            return new ConvenioBD().Listar(filtro);
        }

        public bool VerificaExistencia(Convenio convenio)
        {
            ClinicaUtils.ValidarCodigo(convenio.ID_Convenio);

            return new ConvenioBD().VerificaExistencia(convenio);
        }

    }
}


