using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.paciente
{
    public class NegocioMedico : IMedico
    {
        //ID_Medico, CRM, CPF, RG, Nome, Endereco, Email, Celular, Estado_Civil, ID_Especialidade
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
        //Verificar validação do tamanho máximo do ENDEREÇO!

        public void Cadastrar(Medico medico)
        {
            #region Validações
            if (medico.ID_Medico < 1)
            {
                throw new Exception(ERRO_NUMERO);
            }

            if (string.IsNullOrWhiteSpace(medico.Nome.Trim()))
            {
                throw new Exception(ERRO_NOME);
            }

            if (medico.Nome.Trim().Length < 1 || medico.Nome.Trim().Length > 100)
            {
                throw new Exception(ERRO_EXCEDER_NOME);
            }

            if (string.IsNullOrWhiteSpace(medico.CRM.Trim()))
            {
                throw new Exception(ERRO_CRM);
            }

            if (string.IsNullOrWhiteSpace(medico.CPF.Trim()))
            {
                throw new Exception(ERRO_CPF);
            }

            if (medico.CPF.Trim().Length != 14)
            {
                throw new Exception(ERRO_EXCEDER_CPF);
            }

            if (string.IsNullOrWhiteSpace(medico.RG.Trim()))
            {
                throw new Exception(ERRO_RG);
            }

            if (medico.RG.Trim().Length < 1 || medico.RG.Trim().Length > 20)
            {
                throw new Exception(ERRO_EXCEDER_RG);
            }
            
            if (string.IsNullOrWhiteSpace(medico.Endereco.Logradouro.Trim()))
            {
                throw new Exception(ERRO_LOGRADOURO);
            }

            if (string.IsNullOrWhiteSpace(medico.Endereco.Numero.Trim()))
            {
                throw new Exception(ERRO_NUMEROLOGRADOURO);
            }

            if (string.IsNullOrWhiteSpace(medico.Endereco.Complemento.Trim()))
            {
                throw new Exception(ERRO_COMPLEMENTO);
            }

            if (string.IsNullOrWhiteSpace(medico.Endereco.Bairro.Trim()))
            {
                throw new Exception(ERRO_BAIRRO);
            }

            if (string.IsNullOrWhiteSpace(medico.Endereco.Cidade.Trim()))
            {
                throw new Exception(ERRO_CIDADE);
            }

            if (string.IsNullOrWhiteSpace(medico.Endereco.UF.Trim()))
            {
                throw new Exception(ERRO_UF);
            }

            if (string.IsNullOrWhiteSpace(medico.Endereco.CEP.Trim()))
            {
                throw new Exception(ERRO_CEP);
            }

            if (string.IsNullOrWhiteSpace(medico.Endereco.Pais.Trim()))
            {
                throw new Exception(ERRO_PAIS);
            }

            //Como fazer a validação do tamanho do endereço?

            if (string.IsNullOrWhiteSpace(medico.Email.Trim()) || new EmailAddressAttribute().IsValid(medico.Email.Trim()))
            {
                throw new Exception(ERRO_EMAIL);
            }

            if (medico.Email.Trim().Length < 1 || medico.Email.Trim().Length > 30)
            {
                throw new Exception(ERRO_EXCEDER_EMAIL);
            }

            if (string.IsNullOrWhiteSpace(medico.Contato.Trim()))
            {
                throw new Exception(ERRO_CELULAR);
            }

            if (medico.Contato.Length != 14)
            {
                throw new Exception(ERRO_EXCEDER_CELULAR);
            }

            if (string.IsNullOrEmpty(medico.Estado_Civil.Trim()))
            {
                throw new Exception(ERRO_ESTADO_CIVIL);
            }

            if (medico.Estado_Civil.Trim().Length < 0 || medico.Estado_Civil.Trim().Length > 20)
            {
                throw new Exception(ERRO_EXCEDER_ESTADO_CIVIL);
            }

            if (medico.Especialidade.ID_Especialidade <= 0)
            {
                throw new Exception(ERRO_ESPECIALIDADE);
            }
            #endregion

            new MedicoBD().Cadastrar(medico);
        }

        public void Atualizar(Medico medico)
        {
            #region Validações
            if (medico.ID_Medico < 1)
            {
                throw new Exception(ERRO_NUMERO);
            }

            if (string.IsNullOrWhiteSpace(medico.Nome.Trim()))
            {
                throw new Exception(ERRO_NOME);
            }

            if (medico.Nome.Trim().Length < 1 || medico.Nome.Trim().Length > 200)
            {
                throw new Exception(ERRO_EXCEDER_NOME);
            }

            if (string.IsNullOrWhiteSpace(medico.CRM.Trim()))
            {
                throw new Exception(ERRO_CRM);
            }

            if (string.IsNullOrWhiteSpace(medico.CPF.Trim()))
            {
                throw new Exception(ERRO_CPF);
            }

            if (medico.CPF.Trim().Length != 14)
            {
                throw new Exception(ERRO_EXCEDER_CPF);
            }

            if (string.IsNullOrWhiteSpace(medico.RG.Trim()))
            {
                throw new Exception(ERRO_RG);
            }

            if (medico.RG.Trim().Length < 1 || medico.RG.Trim().Length > 20)
            {
                throw new Exception(ERRO_EXCEDER_RG);
            }

            if (string.IsNullOrWhiteSpace(medico.Endereco.Logradouro.Trim()))
            {
                throw new Exception(ERRO_LOGRADOURO);
            }

            if (string.IsNullOrWhiteSpace(medico.Endereco.Numero.Trim()))
            {
                throw new Exception(ERRO_NUMEROLOGRADOURO);
            }

            if (string.IsNullOrWhiteSpace(medico.Endereco.Complemento.Trim()))
            {
                throw new Exception(ERRO_COMPLEMENTO);
            }

            if (string.IsNullOrWhiteSpace(medico.Endereco.Bairro.Trim()))
            {
                throw new Exception(ERRO_BAIRRO);
            }

            if (string.IsNullOrWhiteSpace(medico.Endereco.Cidade.Trim()))
            {
                throw new Exception(ERRO_CIDADE);
            }

            if (string.IsNullOrWhiteSpace(medico.Endereco.UF.Trim()))
            {
                throw new Exception(ERRO_UF);
            }

            if (string.IsNullOrWhiteSpace(medico.Endereco.CEP.Trim()))
            {
                throw new Exception(ERRO_CEP);
            }

            if (string.IsNullOrWhiteSpace(medico.Endereco.Pais.Trim()))
            {
                throw new Exception(ERRO_PAIS);
            }

            //Como fazer a validação do tamanho do endereço?

            if (string.IsNullOrWhiteSpace(medico.Email.Trim()) || new EmailAddressAttribute().IsValid(medico.Email.Trim()))
            {
                throw new Exception(ERRO_EMAIL);
            }

            if (medico.Email.Trim().Length < 1 || medico.Email.Trim().Length > 30)
            {
                throw new Exception(ERRO_EXCEDER_EMAIL);
            }

            if (string.IsNullOrWhiteSpace(medico.Contato.Trim()))
            {
                throw new Exception(ERRO_CELULAR);
            }

            if (medico.Contato.Length != 14)
            {
                throw new Exception(ERRO_EXCEDER_CELULAR);
            }

            if (string.IsNullOrEmpty(medico.Estado_Civil.Trim()))
            {
                throw new Exception(ERRO_ESTADO_CIVIL);
            }

            if (medico.Estado_Civil.Trim().Length < 0 || medico.Estado_Civil.Trim().Length > 20)
            {
                throw new Exception(ERRO_EXCEDER_ESTADO_CIVIL);
            }

            if (medico.Especialidade.ID_Especialidade <= 0)
            {
                throw new Exception(ERRO_ESPECIALIDADE);
            }
            #endregion

            new MedicoBD().Atualizar(medico);
        }

        public void Remover(Medico medico)
        {
            if (medico.ID_Medico < 1)
            {
                throw new Exception(ERRO_NUMERO);
            }
        }

        public List<Medico> Listar(Medico filtro)
        {
            return new MedicoBD().Listar(filtro);
        }

        public bool VerificaExistencia(Medico medico)
        {
            if (medico.ID_Medico < 1)
            {
                throw new Exception(ERRO_NUMERO);
            }

            return new MedicoBD().VerificaExistencia(medico);
        }
    }
}
