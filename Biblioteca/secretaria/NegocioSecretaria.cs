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
        //ID_Secretaria, CPF, RG, Nome, Endereco, Email, Celular, Estado_Civil
        #region Erros
        private const string ERRO_NUMERO = "Número inválido.";
        private const string ERRO_CPF = "CPF inválido.";
        private const string ERRO_EXCEDER_CPF = "O CPF deve conter 14 caracteres.";
        private const string ERRO_RG = "RG inválido.";
        private const string ERRO_EXCEDER_RG = "O RG não deve exceder 20 caracteres.";
        private const string ERRO_NOME = "Nome inválido.";
        private const string ERRO_EXCEDER_NOME = "O nome não deve exceder 200 caracteres.";
        private const string ERRO_ENDERECO = "Endereço inválido.";
        private const string ERRO_EXCEDER_ENDERECO = "O endereço deve conter entre 10 e 80 caracteres.";
        private const string ERRO_EMAIL = "E-mail inválido.";
        private const string ERRO_EXCEDER_EMAIL = "O e-mail não deve exceder 30 caracteres.";
        private const string ERRO_CELULAR = "Celular inválido.";
        private const string ERRO_EXCEDER_CELULAR = "O celular deve conter 14 caracteres.";
        private const string ERRO_ESTADO_CIVIL = "Estado civil inválido.";
        private const string ERRO_EXCEDER_ESTADO_CIVIL = "O estado civil não deve exceder 20 caracteres.";
        #endregion

        public void Atualizar(Secretaria secretaria)
        {
            #region Validações
            if (secretaria.ID_Secretaria < 1)
            {
                throw new Exception(ERRO_NUMERO);
            }

            if (string.IsNullOrWhiteSpace(secretaria.Nome.Trim()))
            {
                throw new Exception(ERRO_NOME);
            }

            if (secretaria.Nome.Trim().Length < 1 || secretaria.Nome.Trim().Length > 200)
            {
                throw new Exception(ERRO_EXCEDER_NOME);
            }

            if (string.IsNullOrWhiteSpace(secretaria.CPF.Trim()))
            {
                throw new Exception(ERRO_CPF);
            }

            if (secretaria.CPF.Trim().Length != 14)
            {
                throw new Exception(ERRO_EXCEDER_CPF);
            }

            if (string.IsNullOrWhiteSpace(secretaria.RG.Trim()))
            {
                throw new Exception(ERRO_RG);
            }

            if (secretaria.RG.Trim().Length < 1 || secretaria.RG.Trim().Length > 20)
            {
                throw new Exception(ERRO_EXCEDER_RG);
            }

            if (string.IsNullOrWhiteSpace(secretaria.Endereco.Trim()))
            {
                throw new Exception(ERRO_ENDERECO);
            }

            if (secretaria.RG.Trim().Length < 1 || secretaria.Endereco.Trim().Length > 80)
            {
                throw new Exception(ERRO_EXCEDER_ENDERECO);
            }

            if (string.IsNullOrWhiteSpace(secretaria.Email.Trim()) || new EmailAddressAttribute().IsValid(secretaria.Email.Trim()))
            {
                throw new Exception(ERRO_EMAIL);
            }

            if (secretaria.Endereco.Trim().Length < 1 || secretaria.Endereco.Trim().Length > 30)
            {
                throw new Exception(ERRO_EXCEDER_EMAIL);
            }

            if (string.IsNullOrWhiteSpace(secretaria.Celular.Trim()))
            {
                throw new Exception(ERRO_CELULAR);
            }

            if (secretaria.Celular.Trim().Length != 14)
            {
                throw new Exception(ERRO_EXCEDER_CELULAR);
            }

            if (string.IsNullOrWhiteSpace(secretaria.Estado_Civil.Trim()))
            {
                throw new Exception(ERRO_ESTADO_CIVIL);
            }

            if (secretaria.Estado_Civil.Trim().Length < 1 || secretaria.Estado_Civil.Trim().Length > 20)
            {
                throw new Exception(ERRO_EXCEDER_ESTADO_CIVIL);
            }
            #endregion

            new SecretariaBD().Atualizar(secretaria);
        }

        public void Cadastrar(Secretaria secretaria)
        {
            #region Validações
            if (secretaria.ID_Secretaria < 1)
            {
                throw new Exception(ERRO_NUMERO);
            }

            if (string.IsNullOrWhiteSpace(secretaria.Nome.Trim()))
            {
                throw new Exception(ERRO_NOME);
            }

            if (secretaria.Nome.Trim().Length < 1 || secretaria.Nome.Trim().Length > 200)
            {
                throw new Exception(ERRO_EXCEDER_NOME);
            }

            if (string.IsNullOrWhiteSpace(secretaria.CPF.Trim()))
            {
                throw new Exception(ERRO_CPF);
            }

            if (secretaria.CPF.Trim().Length != 14)
            {
                throw new Exception(ERRO_EXCEDER_CPF);
            }

            if (string.IsNullOrWhiteSpace(secretaria.RG.Trim()))
            {
                throw new Exception(ERRO_RG);
            }

            if (secretaria.RG.Trim().Length < 1 || secretaria.RG.Trim().Length > 20)
            {
                throw new Exception(ERRO_EXCEDER_RG);
            }

            if (string.IsNullOrWhiteSpace(secretaria.Endereco.Trim()))
            {
                throw new Exception(ERRO_ENDERECO);
            }

            if (secretaria.RG.Trim().Length < 1 || secretaria.Endereco.Trim().Length > 80)
            {
                throw new Exception(ERRO_EXCEDER_ENDERECO);
            }

            if (string.IsNullOrWhiteSpace(secretaria.Email.Trim()) || new EmailAddressAttribute().IsValid(secretaria.Email.Trim()))
            {
                throw new Exception(ERRO_EMAIL);
            }

            if (secretaria.Endereco.Trim().Length < 1 || secretaria.Endereco.Trim().Length > 30)
            {
                throw new Exception(ERRO_EXCEDER_EMAIL);
            }

            if (string.IsNullOrWhiteSpace(secretaria.Celular.Trim()))
            {
                throw new Exception(ERRO_CELULAR);
            }

            if (secretaria.Celular.Trim().Length != 14)
            {
                throw new Exception(ERRO_EXCEDER_CELULAR);
            }

            if (string.IsNullOrWhiteSpace(secretaria.Estado_Civil.Trim()))
            {
                throw new Exception(ERRO_ESTADO_CIVIL);
            }

            if (secretaria.Estado_Civil.Trim().Length < 1 || secretaria.Estado_Civil.Trim().Length > 20)
            {
                throw new Exception(ERRO_EXCEDER_ESTADO_CIVIL);
            }
            #endregion

            new SecretariaBD().Cadastrar(secretaria);
        }

        public List<Secretaria> Listar(Secretaria filtro)
        {
            return new SecretariaBD().Listar(filtro);
        }

        public void Remover(Secretaria secretaria)
        {
            if (secretaria.ID_Secretaria < 1)
            {
                throw new Exception(ERRO_NUMERO);
            }

            new SecretariaBD().Remover(secretaria);
        }

        public bool VerificaExistencia(Secretaria secretaria)
        {
            if (secretaria.ID_Secretaria < 1)
            {
                throw new Exception(ERRO_NUMERO);
            }

            return new SecretariaBD().VerificaExistencia(secretaria);
        }
    }
}
