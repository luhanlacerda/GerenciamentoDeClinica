using Biblioteca.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.medico
{
    public class NegocioMedico : IMedico
    {
        //ID_Medico, CRM, CPF, RG, Nome, Logradouro, Numero, Complemento, 
        //Bairro, CEP, Cidade, UF, Pais, Email, Celular, Estado_Civil, ID_Especialidade
        #region Erros
        private const string ERRO_NUMERO = "Número inválido.";
        private const string ERRO_CPF = "CPF inválido.";
        private const string ERRO_EXCEDER_CPF = "O CPF deve conter 14 caracteres.";
        private const string ERRO_CRM = "CRM inválido";
        private const string ERRO_RG = "RG inválido.";
        private const string ERRO_EXCEDER_RG = "O RG não deve exceder 20 caracteres.";
        private const string ERRO_NOME = "Nome inválido.";
        private const string ERRO_EXCEDER_NOME = "O nome não deve exceder 200 caracteres.";
        private const string ERRO_ENDERECO = "Endereço inválido.";
        private const string ERRO_LOGRADOURO = "Rua inválida.";
        private const string ERRO_NUMEROLOGRADOURO = "Número da rua inválido.";
        private const string ERRO_COMPLEMENTO = "Complemento inválido.";
        private const string ERRO_BAIRRO = "Bairro inválido.";
        private const string ERRO_CIDADE = "Cidade inválida.";
        private const string ERRO_UF = "UF inválido.";
        private const string ERRO_CEP = "CEP inválido.";
        private const string ERRO_PAIS = "País inválido.";
        private const string ERRO_EXCEDER_ENDERECO = "O endereço deve conter entre 10 e 80 caracteres.";
        private const string ERRO_EMAIL = "E-mail inválido.";
        private const string ERRO_EXCEDER_EMAIL = "O e-mail não deve exceder 30 caracteres.";
        private const string ERRO_CELULAR = "Celular inválido.";
        private const string ERRO_EXCEDER_CELULAR = "O celular deve conter 14 caracteres.";
        private const string ERRO_ESTADO_CIVIL = "Estado civil inválido.";
        private const string ERRO_EXCEDER_ESTADO_CIVIL = "O estado civil não deve exceder 20 caracteres.";
        private const string ERRO_ESPECIALIDADE = "Especialidade inválida.";
        #endregion

        public void Cadastrar(Medico medico)
        {
            try
            {
                #region Validações
                ClinicaUtils.ValidarCodigo(medico.ID_Medico);

                ClinicaUtils.ValidarVazio(medico.Nome.Trim(), ClinicaUtils.ERRO_NOME);
                ClinicaUtils.ValidarExceder(medico.Nome.Trim(), 100, ClinicaUtils.ERRO_NOME);

                //Se for vazia não vai possuir 14 caracteres, sendo assim não necessário a validação de vazio
                ClinicaUtils.ValidarTamanho(medico.CPF, 14, ClinicaUtils.ERRO_CPF);

                ClinicaUtils.ValidarVazio(medico.CRM.Trim(), ClinicaUtils.ERRO_CRM);
                ClinicaUtils.ValidarExceder(medico.CRM, 10, ClinicaUtils.ERRO_CRM);

                ClinicaUtils.ValidarVazio(medico.RG.Trim(), ClinicaUtils.ERRO_RG);
                ClinicaUtils.ValidarExceder(medico.RG.Trim(), 20, ClinicaUtils.ERRO_RG);

                ClinicaUtils.ValidarVazio(medico.Endereco.Logradouro.Trim(), ClinicaUtils.ERRO_LOGRADOURO);
                ClinicaUtils.ValidarExceder(medico.Endereco.Logradouro.Trim(), 50, ClinicaUtils.ERRO_LOGRADOURO);

                ClinicaUtils.ValidarVazio(medico.Endereco.Numero.Trim(), ClinicaUtils.ERRO_NUMERO);
                ClinicaUtils.ValidarExceder(medico.Endereco.Numero.Trim(), 10, ClinicaUtils.ERRO_NUMERO);

                ClinicaUtils.ValidarVazio(medico.Endereco.Complemento.Trim(), ClinicaUtils.ERRO_COMPLEMENTO);
                ClinicaUtils.ValidarExceder(medico.Endereco.Complemento.Trim(), 10, ClinicaUtils.ERRO_COMPLEMENTO);

                ClinicaUtils.ValidarVazio(medico.Endereco.Bairro.Trim(), ClinicaUtils.ERRO_BAIRRO);
                ClinicaUtils.ValidarExceder(medico.Endereco.Bairro.Trim(), 20, ClinicaUtils.ERRO_BAIRRO);

                ClinicaUtils.ValidarVazio(medico.Endereco.Cidade.Trim(), ClinicaUtils.ERRO_CIDADE);
                ClinicaUtils.ValidarExceder(medico.Endereco.Cidade.Trim(), 50, ClinicaUtils.ERRO_CIDADE);


                ClinicaUtils.ValidarTamanho(medico.Endereco.UF.Trim(), 2, ClinicaUtils.ERRO_UF);
                   
                ClinicaUtils.ValidarTamanho(medico.Endereco.CEP.Trim(), 9, ClinicaUtils.ERRO_CEP);

                ClinicaUtils.ValidarVazio(medico.Endereco.Pais.Trim(), ClinicaUtils.ERRO_PAIS);
                ClinicaUtils.ValidarExceder(medico.Endereco.Pais.Trim(), 30, ClinicaUtils.ERRO_PAIS);

                ClinicaUtils.ValidarVazio(medico.Email.Trim(), ClinicaUtils.ERRO_EMAIL);
                ClinicaUtils.ValidarExceder(medico.Email.Trim(), 30, ClinicaUtils.ERRO_EMAIL);

                ClinicaUtils.ValidarVazio(medico.Contato.Trim(), ClinicaUtils.ERRO_CONTATO);
                ClinicaUtils.ValidarExceder(medico.Contato.Trim(), 14, ClinicaUtils.ERRO_CONTATO);

                ClinicaUtils.ValidarVazio(medico.Estado_Civil.Trim(), ClinicaUtils.ERRO_ESTADO_CIVIL);
                ClinicaUtils.ValidarExceder(medico.Estado_Civil.Trim(), 10, ClinicaUtils.ERRO_ESTADO_CIVIL);

                ClinicaUtils.ValidarCodigo(medico.Especialidade.ID_Especialidade);
                #endregion

                new MedicoBD().Cadastrar(medico);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Atualizar(Medico medico)
        {
            try
            {
                #region Validações
                ClinicaUtils.ValidarCodigo(medico.ID_Medico);

                ClinicaUtils.ValidarVazio(medico.Nome.Trim(), ClinicaUtils.ERRO_NOME);
                ClinicaUtils.ValidarExceder(medico.Nome.Trim(), 200, ClinicaUtils.ERRO_NOME);

                ClinicaUtils.ValidarTamanho(medico.CPF, 14, ClinicaUtils.ERRO_CPF);

                ClinicaUtils.ValidarVazio(medico.CRM.Trim(), ClinicaUtils.ERRO_CRM);
                ClinicaUtils.ValidarExceder(medico.CRM.Trim(), 10, ClinicaUtils.ERRO_CRM);

                ClinicaUtils.ValidarVazio(medico.RG.Trim(), ClinicaUtils.ERRO_RG);
                ClinicaUtils.ValidarExceder(medico.RG.Trim(), 20, ClinicaUtils.ERRO_RG);

                ClinicaUtils.ValidarVazio(medico.Endereco.Logradouro.Trim(), ClinicaUtils.ERRO_LOGRADOURO);
                ClinicaUtils.ValidarExceder(medico.Endereco.Logradouro.Trim(), 50, ClinicaUtils.ERRO_LOGRADOURO);

                ClinicaUtils.ValidarVazio(medico.Endereco.Numero.Trim(), ClinicaUtils.ERRO_NUMERO);
                ClinicaUtils.ValidarExceder(medico.Endereco.Numero.Trim(), 10, ClinicaUtils.ERRO_NUMERO);

                ClinicaUtils.ValidarVazio(medico.Endereco.Complemento.Trim(), ClinicaUtils.ERRO_COMPLEMENTO);
                ClinicaUtils.ValidarExceder(medico.Endereco.Complemento.Trim(), 10, ClinicaUtils.ERRO_COMPLEMENTO);

                ClinicaUtils.ValidarVazio(medico.Endereco.Bairro.Trim(), ClinicaUtils.ERRO_BAIRRO);
                ClinicaUtils.ValidarExceder(medico.Endereco.Bairro.Trim(), 20, ClinicaUtils.ERRO_BAIRRO);

                ClinicaUtils.ValidarVazio(medico.Endereco.Cidade.Trim(), ClinicaUtils.ERRO_CIDADE);
                ClinicaUtils.ValidarExceder(medico.Endereco.Cidade.Trim(), 50, ClinicaUtils.ERRO_CIDADE);

                ClinicaUtils.ValidarTamanho(medico.Endereco.UF.Trim(), 2, ClinicaUtils.ERRO_UF);

                ClinicaUtils.ValidarTamanho(medico.Endereco.CEP, 9, ClinicaUtils.ERRO_CEP);

                ClinicaUtils.ValidarVazio(medico.Endereco.Pais.Trim(), ClinicaUtils.ERRO_PAIS);
                ClinicaUtils.ValidarExceder(medico.Endereco.Pais.Trim(), 30, ClinicaUtils.ERRO_PAIS);

                ClinicaUtils.ValidarEmail(medico.Email.Trim());

                ClinicaUtils.ValidarVazio(medico.Contato.Trim(), ClinicaUtils.ERRO_CONTATO);
                ClinicaUtils.ValidarExceder(medico.Contato.Trim(), 14, ClinicaUtils.ERRO_CONTATO);

                ClinicaUtils.ValidarVazio(medico.Estado_Civil.Trim(), ClinicaUtils.ERRO_ESTADO_CIVIL);
                ClinicaUtils.ValidarExceder(medico.Estado_Civil.Trim(), 10, ClinicaUtils.ERRO_ESTADO_CIVIL);

                ClinicaUtils.ValidarCodigo(medico.Especialidade.ID_Especialidade);
                #endregion

                new MedicoBD().Atualizar(medico);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Remover(Medico medico)
        {
            try
            {
                ClinicaUtils.ValidarCodigo(medico.ID_Medico);

                new MedicoBD().Remover(medico);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Medico> Listar(Medico filtro)
        {
            return new MedicoBD().Listar(filtro);
        }

        public bool VerificaExistencia(Medico medico)
        {
            try
            {
                ClinicaUtils.ValidarCodigo(medico.ID_Medico);

                return new MedicoBD().VerificaExistencia(medico);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
