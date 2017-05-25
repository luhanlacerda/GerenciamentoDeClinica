using Biblioteca.utils;
using System;
using System.Collections.Generic;

namespace Biblioteca.paciente
{
    public class NegocioPaciente : IPaciente
    {

        public void Cadastrar(Paciente paciente)
        {
            ClinicaUtils.ValidarCodigo(paciente.ID_Paciente);

            if (VerificaExistencia(paciente) != false)
            {
                throw new Exception("Código de paciente já cadastrado");
            }

            ClinicaUtils.ValidarVazio(paciente.Nome.Trim(), ClinicaUtils.ERRO_NOME);
            ClinicaUtils.ValidarExceder(paciente.Nome.Trim(), 100, ClinicaUtils.ERRO_NOME);

            ClinicaUtils.ValidarVazio(paciente.CPF.Trim(), ClinicaUtils.ERRO_CPF);
            ClinicaUtils.ValidarExceder(paciente.CPF.Trim(), 14, ClinicaUtils.ERRO_CPF);

            ClinicaUtils.ValidarVazio(paciente.Contato.Trim(), ClinicaUtils.ERRO_CONTATO);
            ClinicaUtils.ValidarExceder(paciente.Contato.Trim(), 14, ClinicaUtils.ERRO_CONTATO);

            ClinicaUtils.ValidarVazio(paciente.Endereco.CEP.Trim(), ClinicaUtils.ERRO_CEP);
            ClinicaUtils.ValidarExceder(paciente.Endereco.CEP.Trim(), 14, ClinicaUtils.ERRO_CEP);

            ClinicaUtils.ValidarVazio(paciente.RG.Trim(), ClinicaUtils.ERRO_RG);
            ClinicaUtils.ValidarExceder(paciente.RG.Trim(), 20, ClinicaUtils.ERRO_RG);

            ClinicaUtils.ValidarVazio(paciente.Email.Trim(), ClinicaUtils.ERRO_EMAIL);
            ClinicaUtils.ValidarExceder(paciente.Email.Trim(), 30, ClinicaUtils.ERRO_EMAIL);

            ClinicaUtils.ValidarVazio(paciente.Endereco.Logradouro.Trim(), ClinicaUtils.ERRO_LOGRADOURO);
            ClinicaUtils.ValidarExceder(paciente.Endereco.Logradouro.Trim(), 50, ClinicaUtils.ERRO_LOGRADOURO);

            ClinicaUtils.ValidarVazio(paciente.Endereco.Numero.Trim(), ClinicaUtils.ERRO_NUMERO);
            ClinicaUtils.ValidarExceder(paciente.Endereco.Numero.Trim(), 10, ClinicaUtils.ERRO_NUMERO);

            ClinicaUtils.ValidarVazio(paciente.Endereco.Complemento.Trim(), ClinicaUtils.ERRO_COMPLEMENTO);
            ClinicaUtils.ValidarExceder(paciente.Endereco.Complemento.Trim(), 10, ClinicaUtils.ERRO_COMPLEMENTO);

            ClinicaUtils.ValidarVazio(paciente.Endereco.Bairro.Trim(), ClinicaUtils.ERRO_BAIRRO);
            ClinicaUtils.ValidarExceder(paciente.Endereco.Bairro.Trim(), 20, ClinicaUtils.ERRO_BAIRRO);

            ClinicaUtils.ValidarVazio(paciente.Endereco.Cidade.Trim(), ClinicaUtils.ERRO_CIDADE);
            ClinicaUtils.ValidarExceder(paciente.Endereco.Cidade.Trim(), 50, ClinicaUtils.ERRO_CIDADE);

            ClinicaUtils.ValidarVazio(paciente.Endereco.UF.Trim(), ClinicaUtils.ERRO_UF);
            ClinicaUtils.ValidarExceder(paciente.Endereco.UF.Trim(), 2, ClinicaUtils.ERRO_UF);

            ClinicaUtils.ValidarVazio(paciente.Endereco.Pais.Trim(), ClinicaUtils.ERRO_PAIS);
            ClinicaUtils.ValidarExceder(paciente.Endereco.Pais.Trim(), 30, ClinicaUtils.ERRO_PAIS);

            ClinicaUtils.ValidarVazio(paciente.Estado_Civil, ClinicaUtils.ERRO_ESTADO_CIVIL);
            ClinicaUtils.ValidarExceder(paciente.Estado_Civil, 10, ClinicaUtils.ERRO_ESTADO_CIVIL);

            // ClinicaUtils.ValidarVazio(paciente.ID_Paciente, ClinicaUtils.ERRO_ESTADO_CIVIL);
            // ClinicaUtils.ValidarExceder(paciente.ID_Paciente, 100, ClinicaUtils.ERRO_ESTADO_CIVIL);

            // ClinicaUtils.ValidarVazio(paciente.Dt_Nascimento, ClinicaUtils.ERRO_ESTADO_CIVIL);
            // ClinicaUtils.ValidarExceder(paciente.Dt_Nascimento, 10, ClinicaUtils.ERRO_ESTADO_CIVIL);

            // ClinicaUtils.ValidarVazio(paciente.Convenio.ID_Convenio, ClinicaUtils.ERRO_ESTADO_CIVIL);
            // ClinicaUtils.ValidarExceder(paciente.Convenio.ID_Convenio, 10, ClinicaUtils.ERRO_ESTADO_CIVIL);



            new PacienteBD().Cadastrar(paciente);
        }


        public void Atualizar(Paciente paciente)
        {
            ClinicaUtils.ValidarCodigo(paciente.ID_Paciente);

            ClinicaUtils.ValidarVazio(paciente.Nome.Trim(), ClinicaUtils.ERRO_NOME);
            ClinicaUtils.ValidarExceder(paciente.Nome.Trim(), 100, ClinicaUtils.ERRO_NOME);

            ClinicaUtils.ValidarVazio(paciente.CPF.Trim(), ClinicaUtils.ERRO_CPF);
            ClinicaUtils.ValidarExceder(paciente.CPF.Trim(), 14, ClinicaUtils.ERRO_CPF);

            ClinicaUtils.ValidarVazio(paciente.Contato.Trim(), ClinicaUtils.ERRO_CONTATO);
            ClinicaUtils.ValidarExceder(paciente.Contato.Trim(), 14, ClinicaUtils.ERRO_CONTATO);

            ClinicaUtils.ValidarVazio(paciente.Endereco.CEP.Trim(), ClinicaUtils.ERRO_CEP);
            ClinicaUtils.ValidarExceder(paciente.Endereco.CEP.Trim(), 14, ClinicaUtils.ERRO_CEP);

            ClinicaUtils.ValidarVazio(paciente.RG.Trim(), ClinicaUtils.ERRO_RG);
            ClinicaUtils.ValidarExceder(paciente.RG.Trim(), 20, ClinicaUtils.ERRO_RG);

            ClinicaUtils.ValidarVazio(paciente.Email.Trim(), ClinicaUtils.ERRO_EMAIL);
            ClinicaUtils.ValidarExceder(paciente.Email.Trim(), 30, ClinicaUtils.ERRO_EMAIL);

            ClinicaUtils.ValidarVazio(paciente.Endereco.Logradouro.Trim(), ClinicaUtils.ERRO_LOGRADOURO);
            ClinicaUtils.ValidarExceder(paciente.Endereco.Logradouro.Trim(), 50, ClinicaUtils.ERRO_LOGRADOURO);

            ClinicaUtils.ValidarVazio(paciente.Endereco.Numero.Trim(), ClinicaUtils.ERRO_NUMERO);
            ClinicaUtils.ValidarExceder(paciente.Endereco.Numero.Trim(), 10, ClinicaUtils.ERRO_NUMERO);

            ClinicaUtils.ValidarVazio(paciente.Endereco.Complemento.Trim(), ClinicaUtils.ERRO_COMPLEMENTO);
            ClinicaUtils.ValidarExceder(paciente.Endereco.Complemento.Trim(), 10, ClinicaUtils.ERRO_COMPLEMENTO);

            ClinicaUtils.ValidarVazio(paciente.Endereco.Bairro.Trim(), ClinicaUtils.ERRO_BAIRRO);
            ClinicaUtils.ValidarExceder(paciente.Endereco.Bairro.Trim(), 20, ClinicaUtils.ERRO_BAIRRO);

            ClinicaUtils.ValidarVazio(paciente.Endereco.Cidade.Trim(), ClinicaUtils.ERRO_CIDADE);
            ClinicaUtils.ValidarExceder(paciente.Endereco.Cidade.Trim(), 50, ClinicaUtils.ERRO_CIDADE);

            ClinicaUtils.ValidarVazio(paciente.Endereco.UF.Trim(), ClinicaUtils.ERRO_UF);
            ClinicaUtils.ValidarExceder(paciente.Endereco.UF.Trim(), 2, ClinicaUtils.ERRO_UF);

            ClinicaUtils.ValidarVazio(paciente.Endereco.Pais.Trim(), ClinicaUtils.ERRO_PAIS);
            ClinicaUtils.ValidarExceder(paciente.Endereco.Pais.Trim(), 30, ClinicaUtils.ERRO_PAIS);

            ClinicaUtils.ValidarVazio(paciente.Estado_Civil, ClinicaUtils.ERRO_ESTADO_CIVIL);
            ClinicaUtils.ValidarExceder(paciente.Estado_Civil, 10, ClinicaUtils.ERRO_ESTADO_CIVIL);

            new PacienteBD().Atualizar(paciente);
        }


        public void Remover(Paciente paciente)
        {
            ClinicaUtils.ValidarCodigo(paciente.ID_Paciente);

            new PacienteBD().Remover(paciente);
        }

        public List<Paciente> Listar(Paciente filtro)
        {
            return new PacienteBD().Listar(filtro);
        }

        public bool VerificaExistencia(Paciente paciente)
        {
            ClinicaUtils.ValidarCodigo(paciente.ID_Paciente);

            return new PacienteBD().VerificaExistencia(paciente);
        }

    }

}
