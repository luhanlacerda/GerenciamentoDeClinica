using Biblioteca.conexaoBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.paciente
{
    public class NegocioPaciente : IPaciente
    {
        //ID_Paciente, CPF, RG, Nome, Endereco, Email, Celular, Estado_Civil, ID_Especialidade
        #region Erros
        private const string ERRO_NUMERO = "Número inválido.";
        private const string ERRO_CPF = "CPF inválido.";
        private const string ERRO_EXCEDER_CPF = "O CPF deve conter 14 caracteres.";
        private const string ERRO_CRM = "CRM inválido";
        private const string ERRO_RG = "RG inválido.";
        private const string ERRO_EXCEDER_RG = "O RG não deve exceder 20 caracteres.";
        private const string ERRO_NOME = "Nome inválido.";
        private const string ERRO_EXCEDER_NOME = "O nome não deve exceder 200 caracteres.";
        //private const string ERRO_ENDERECO = "Endereço inválido.";
        //private const string ERRO_LOGRADOURO = "Rua inválida.";
        //private const string ERRO_NUMEROLOGRADOURO = "Número da rua inválido.";
        //private const string ERRO_COMPLEMENTO = "Complemento inválido.";
        //private const string ERRO_BAIRRO = "Bairro inválido.";
        //private const string ERRO_CIDADE = "Cidade inválida.";
        //private const string ERRO_UF = "UF inválido.";
        //private const string ERRO_CEP = "CEP inválido.";
        // private const string ERRO_PAIS = "País inválido.";
        private const string ERRO_EXCEDER_ENDERECO = "O endereço deve conter entre 10 e 80 caracteres.";
        private const string ERRO_EMAIL = "E-mail inválido.";
        private const string ERRO_EXCEDER_EMAIL = "O e-mail não deve exceder 30 caracteres.";
        private const string ERRO_CELULAR = "Celular inválido.";
        private const string ERRO_EXCEDER_CELULAR = "O celular deve conter 14 caracteres.";
        private const string ERRO_ESTADO_CIVIL = "Estado civil inválido.";
        private const string ERRO_EXCEDER_ESTADO_CIVIL = "O estado civil não deve exceder 20 caracteres.";
        private const string ERRO_SECRETARIA = "Secretária inválida.";
        private const string ERRO_CONVENIO = "Convênio inválido.";
        #endregion


        public void Cadastrar(Paciente paciente)
        {
            #region Validações
            if (paciente.ID_Paciente < 1)
            {
                throw new Exception(ERRO_NUMERO);
            }

            if (string.IsNullOrWhiteSpace(paciente.Nome.Trim()))
            {
                throw new Exception(ERRO_NOME);
            }

            if (paciente.Nome.Trim().Length < 1 || paciente.Nome.Trim().Length > 200)
            {
                throw new Exception(ERRO_EXCEDER_NOME);
            }

            if (string.IsNullOrWhiteSpace(paciente.CPF.Trim()))
            {
                throw new Exception(ERRO_CPF);
            }

            if (paciente.CPF.Trim().Length != 14)
            {
                throw new Exception(ERRO_EXCEDER_CPF);
            }

            if (string.IsNullOrWhiteSpace(paciente.RG.Trim()))
            {
                throw new Exception(ERRO_RG);
            }

            if (paciente.RG.Trim().Length < 1 || paciente.RG.Trim().Length > 20)
            {
                throw new Exception(ERRO_EXCEDER_RG);
            }

            /*if (string.IsNullOrWhiteSpace(paciente.Endereco.Trim()))
            {
                throw new Exception(ERRO_ENDERECO);
            }*/

           /* if (paciente.Endereco.Trim().Length < 1 || paciente.Endereco.Trim().Length > 30)
            {
                throw new Exception(ERRO_EXCEDER_ENDERECO);
            }

            if (paciente.Email.Trim().Length < 1 || paciente.Email.Trim().Length > 30)
            {
                throw new Exception(ERRO_EXCEDER_EMAIL);
            }*/

            if (string.IsNullOrWhiteSpace(paciente.Celular.Trim()))
            {
                throw new Exception(ERRO_CELULAR);
            }

            if (paciente.Celular.Length != 14)
            {
                throw new Exception(ERRO_EXCEDER_CELULAR);
            }

            if (string.IsNullOrEmpty(paciente.Estado_Civil.Trim()))
            {
                throw new Exception(ERRO_ESTADO_CIVIL);
            }

            if (paciente.Estado_Civil.Trim().Length < 0 || paciente.Estado_Civil.Trim().Length > 20)
            {
                throw new Exception(ERRO_EXCEDER_ESTADO_CIVIL);
            }
            
            if (paciente.Convenio.ID_Convenio <= 0)
            {
                throw new Exception(ERRO_CONVENIO);
            }
            #endregion

            new PacienteBD().Cadastrar(paciente);
        }

        public void Atualizar(Paciente paciente)
        {
            #region Validações
            if (paciente.ID_Paciente < 1)
            {
                throw new Exception(ERRO_NUMERO);
            }

            if (string.IsNullOrWhiteSpace(paciente.Nome.Trim()))
            {
                throw new Exception(ERRO_NOME);
            }

            if (paciente.Nome.Trim().Length < 1 || paciente.Nome.Trim().Length > 200)
            {
                throw new Exception(ERRO_EXCEDER_NOME);
            }

            if (string.IsNullOrWhiteSpace(paciente.CPF.Trim()))
            {
                throw new Exception(ERRO_CPF);
            }

            if (paciente.CPF.Trim().Length != 14)
            {
                throw new Exception(ERRO_EXCEDER_CPF);
            }

            if (string.IsNullOrWhiteSpace(paciente.RG.Trim()))
            {
                throw new Exception(ERRO_RG);
            }

            if (paciente.RG.Trim().Length < 1 || paciente.RG.Trim().Length > 20)
            {
                throw new Exception(ERRO_EXCEDER_RG);
            }

            /*if (string.IsNullOrWhiteSpace(paciente.Endereco.Trim()))
            {
                throw new Exception(ERRO_ENDERECO);
            }*/

            /*if (paciente.Endereco.Trim().Length < 1 || paciente.Endereco.Trim().Length > 30)
            {
                throw new Exception(ERRO_EXCEDER_ENDERECO);
            }

            if (paciente.Email.Trim().Length < 1 || paciente.Email.Trim().Length > 30)
            {
                throw new Exception(ERRO_EXCEDER_EMAIL);
            }*/

            if (string.IsNullOrWhiteSpace(paciente.Celular.Trim()))
            {
                throw new Exception(ERRO_CELULAR);
            }

            if (paciente.Celular.Length != 14)
            {
                throw new Exception(ERRO_EXCEDER_CELULAR);
            }

            if (string.IsNullOrEmpty(paciente.Estado_Civil.Trim()))
            {
                throw new Exception(ERRO_ESTADO_CIVIL);
            }

            if (paciente.Estado_Civil.Trim().Length < 0 || paciente.Estado_Civil.Trim().Length > 20)
            {
                throw new Exception(ERRO_EXCEDER_ESTADO_CIVIL);
            }
            

            if (paciente.Convenio.ID_Convenio <= 0)
            {
                throw new Exception(ERRO_CONVENIO);
            }
            #endregion

            new PacienteBD().Atualizar(paciente);
        }

        public void Remover(Paciente paciente)
        {
            if (paciente.ID_Paciente < 1)
            {
                throw new Exception(ERRO_NUMERO);
            }
        }

        public List<Paciente> Listar(Paciente filtro)
        {
            return new PacienteBD().Listar(filtro);
        }

        public bool VerificaExistencia(Paciente paciente)
        {
            if (paciente.ID_Paciente < 1)
            {
                throw new Exception(ERRO_NUMERO);
            }

            return new PacienteBD().VerificaExistencia(paciente);
        }
    }



}
