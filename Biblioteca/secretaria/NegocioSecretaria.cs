using Biblioteca.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.secretaria
{
    public class NegocioSecretaria : ISecretaria
    {
        public void Atualizar(Secretaria secretaria)
        {
            try
            {
                #region Validações
                ClinicaUtils.ValidarCodigo(secretaria.ID_Secretaria);

                ClinicaUtils.ValidarVazio(secretaria.Nome.Trim(), ClinicaUtils.ERRO_NOME);
                ClinicaUtils.ValidarExceder(secretaria.Nome.Trim(), 200, ClinicaUtils.ERRO_NOME);

                //Se for vazia não vai possuir 14 caracteres, sendo assim não necessário a validação de vazio
                ClinicaUtils.ValidarTamanho(secretaria.CPF.Trim(), 14, ClinicaUtils.ERRO_CPF);

                ClinicaUtils.ValidarVazio(secretaria.RG.Trim(), ClinicaUtils.ERRO_RG);
                ClinicaUtils.ValidarExceder(secretaria.RG.Trim(), 20, ClinicaUtils.ERRO_RG);

                ClinicaUtils.ValidarVazio(secretaria.Endereco.Logradouro.Trim(), ClinicaUtils.ERRO_LOGRADOURO);
                ClinicaUtils.ValidarExceder(secretaria.Endereco.Logradouro.Trim(), 50, ClinicaUtils.ERRO_LOGRADOURO);

                ClinicaUtils.ValidarVazio(secretaria.Endereco.Numero.Trim(), ClinicaUtils.ERRO_NUMERO);
                ClinicaUtils.ValidarExceder(secretaria.Endereco.Numero.Trim(), 10, ClinicaUtils.ERRO_NUMERO);

                ClinicaUtils.ValidarVazio(secretaria.Endereco.Complemento.Trim(), ClinicaUtils.ERRO_COMPLEMENTO);
                ClinicaUtils.ValidarExceder(secretaria.Endereco.Complemento.Trim(), 10, ClinicaUtils.ERRO_COMPLEMENTO);

                ClinicaUtils.ValidarVazio(secretaria.Endereco.Bairro.Trim(), ClinicaUtils.ERRO_BAIRRO);
                ClinicaUtils.ValidarExceder(secretaria.Endereco.Numero.Trim(), 20, ClinicaUtils.ERRO_NUMERO);

                ClinicaUtils.ValidarVazio(secretaria.Endereco.Cidade.Trim(), ClinicaUtils.ERRO_CIDADE);
                ClinicaUtils.ValidarExceder(secretaria.Endereco.Cidade.Trim(), 50, ClinicaUtils.ERRO_CIDADE);

                ClinicaUtils.ValidarTamanho(secretaria.Endereco.UF.Trim(), 2, ClinicaUtils.ERRO_UF);

                ClinicaUtils.ValidarTamanho(secretaria.Endereco.CEP.Trim(), 14, ClinicaUtils.ERRO_CEP);

                ClinicaUtils.ValidarVazio(secretaria.Endereco.Pais.Trim(), ClinicaUtils.ERRO_PAIS);
                ClinicaUtils.ValidarExceder(secretaria.Endereco.Pais.Trim(), 30, ClinicaUtils.ERRO_PAIS);

                ClinicaUtils.ValidarEmail(secretaria.Email.Trim());

                ClinicaUtils.ValidarVazio(secretaria.Contato.Trim(), ClinicaUtils.ERRO_CONTATO);
                ClinicaUtils.ValidarExceder(secretaria.Contato.Trim(), 14, ClinicaUtils.ERRO_CONTATO);

                ClinicaUtils.ValidarVazio(secretaria.Estado_Civil.Trim(), ClinicaUtils.ERRO_ESTADO_CIVIL);
                ClinicaUtils.ValidarExceder(secretaria.Estado_Civil.Trim(), 10, ClinicaUtils.ERRO_ESTADO_CIVIL);
                #endregion

                new SecretariaBD().Atualizar(secretaria);
            }
            catch (Exception)
            {
                //Excemplo o throws do java, passa o throw recebido para quem o chamou
                throw;
            }
        }

        public void Cadastrar(Secretaria secretaria)
        {
            try
            {
                #region Validações
                ClinicaUtils.ValidarCodigo(secretaria.ID_Secretaria);

                ClinicaUtils.ValidarVazio(secretaria.Nome.Trim(), ClinicaUtils.ERRO_NOME);
                ClinicaUtils.ValidarExceder(secretaria.Nome.Trim(), 200, ClinicaUtils.ERRO_NOME);

                //Se for vazia não vai possuir 14 caracteres, sendo assim não necessário a validação de vazio
                ClinicaUtils.ValidarTamanho(secretaria.CPF.Trim(), 14, ClinicaUtils.ERRO_CPF);

                ClinicaUtils.ValidarVazio(secretaria.RG.Trim(), ClinicaUtils.ERRO_RG);
                ClinicaUtils.ValidarExceder(secretaria.RG.Trim(), 20, ClinicaUtils.ERRO_RG);

                ClinicaUtils.ValidarVazio(secretaria.Endereco.Logradouro.Trim(), ClinicaUtils.ERRO_LOGRADOURO);
                ClinicaUtils.ValidarExceder(secretaria.Endereco.Logradouro.Trim(), 50, ClinicaUtils.ERRO_LOGRADOURO);

                ClinicaUtils.ValidarVazio(secretaria.Endereco.Numero.Trim(), ClinicaUtils.ERRO_NUMERO);
                ClinicaUtils.ValidarExceder(secretaria.Endereco.Numero.Trim(), 10, ClinicaUtils.ERRO_NUMERO);

                ClinicaUtils.ValidarVazio(secretaria.Endereco.Complemento.Trim(), ClinicaUtils.ERRO_COMPLEMENTO);
                ClinicaUtils.ValidarExceder(secretaria.Endereco.Complemento.Trim(), 10, ClinicaUtils.ERRO_COMPLEMENTO);

                ClinicaUtils.ValidarVazio(secretaria.Endereco.Bairro.Trim(), ClinicaUtils.ERRO_BAIRRO);
                ClinicaUtils.ValidarExceder(secretaria.Endereco.Numero.Trim(), 20, ClinicaUtils.ERRO_NUMERO);

                ClinicaUtils.ValidarVazio(secretaria.Endereco.Cidade.Trim(), ClinicaUtils.ERRO_CIDADE);
                ClinicaUtils.ValidarExceder(secretaria.Endereco.Cidade.Trim(), 50, ClinicaUtils.ERRO_CIDADE);

                ClinicaUtils.ValidarTamanho(secretaria.Endereco.UF.Trim(), 2, ClinicaUtils.ERRO_UF);

                ClinicaUtils.ValidarTamanho(secretaria.Endereco.CEP.Trim(), 14, ClinicaUtils.ERRO_CEP);

                ClinicaUtils.ValidarVazio(secretaria.Endereco.Pais.Trim(), ClinicaUtils.ERRO_PAIS);
                ClinicaUtils.ValidarExceder(secretaria.Endereco.Pais.Trim(), 30, ClinicaUtils.ERRO_PAIS);

                ClinicaUtils.ValidarEmail(secretaria.Email.Trim());

                ClinicaUtils.ValidarVazio(secretaria.Contato.Trim(), ClinicaUtils.ERRO_CONTATO);
                ClinicaUtils.ValidarExceder(secretaria.Contato.Trim(), 14, ClinicaUtils.ERRO_CONTATO);

                ClinicaUtils.ValidarVazio(secretaria.Estado_Civil.Trim(), ClinicaUtils.ERRO_ESTADO_CIVIL);
                ClinicaUtils.ValidarExceder(secretaria.Estado_Civil.Trim(), 10, ClinicaUtils.ERRO_ESTADO_CIVIL);
                #endregion

                new SecretariaBD().Cadastrar(secretaria);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Secretaria> Listar(Secretaria filtro)
        {
            return new SecretariaBD().Listar(filtro);
        }

        public void Remover(Secretaria secretaria)
        {
            try
            {
                ClinicaUtils.ValidarCodigo(secretaria.ID_Secretaria);

                new SecretariaBD().Remover(secretaria);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool VerificaExistencia(Secretaria secretaria)
        {
            try
            {
                ClinicaUtils.ValidarCodigo(secretaria.ID_Secretaria);

                return new SecretariaBD().VerificaExistencia(secretaria);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
