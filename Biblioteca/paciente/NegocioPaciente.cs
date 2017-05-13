using Biblioteca.utils;
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
        #region Erros
        private const string ERRO_NUMERO = "Número inválido.";
        private const string ERRO_CPF = "CPF inválido.";
        private const string ERRO_EXCEDER_CPF = "O CPF deve conter 14 caracteres.";
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

        public void Cadastrar(Paciente paciente)
        {
            try
            {
                #region Validações
                ClinicaUtils.ValidarCodigo(paciente.ID_Paciente);

                ClinicaUtils.ValidarVazio(paciente.Nome.Trim(), ClinicaUtils.ERRO_NOME);
                ClinicaUtils.ValidarExceder(paciente.Nome.Trim(), 200, ClinicaUtils.ERRO_NOME);

                //Se for vazia não vai possuir 14 caracteres, 
                //sendo assim não necessário a validação de vazio
                ClinicaUtils.ValidarTamanho(paciente.CPF, 14, ClinicaUtils.ERRO_CPF);
               
                ClinicaUtils.ValidarVazio(paciente.RG.Trim(), ClinicaUtils.ERRO_RG);
                ClinicaUtils.ValidarExceder(paciente.RG.Trim(), 20, ClinicaUtils.ERRO_RG);

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

                ClinicaUtils.ValidarTamanho(paciente.Endereco.UF.Trim(), 2, ClinicaUtils.ERRO_UF);

                ClinicaUtils.ValidarTamanho(paciente.Endereco.CEP.Trim(), 9, ClinicaUtils.ERRO_CEP);

                ClinicaUtils.ValidarVazio(paciente.Endereco.Pais.Trim(), ClinicaUtils.ERRO_PAIS);
                ClinicaUtils.ValidarExceder(paciente.Endereco.Pais.Trim(), 30, ClinicaUtils.ERRO_PAIS);

                ClinicaUtils.ValidarEmail(paciente.Email.Trim());

                ClinicaUtils.ValidarVazio(paciente.Contato.Trim(), ClinicaUtils.ERRO_CONTATO);
                ClinicaUtils.ValidarExceder(paciente.Contato.Trim(), 14, ClinicaUtils.ERRO_CONTATO);

                ClinicaUtils.ValidarVazio(paciente.Estado_Civil.Trim(), ClinicaUtils.ERRO_ESTADO_CIVIL);
                ClinicaUtils.ValidarExceder(paciente.Estado_Civil.Trim(), 10, ClinicaUtils.ERRO_ESTADO_CIVIL);
                #endregion

                new PacienteBD().Cadastrar(paciente);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Atualizar(Paciente paciente)
        {
            try
            {
                #region Validações
                ClinicaUtils.ValidarCodigo(paciente.ID_Paciente);

                ClinicaUtils.ValidarVazio(paciente.Nome.Trim(), ClinicaUtils.ERRO_NOME);
                ClinicaUtils.ValidarExceder(paciente.Nome.Trim(), 200, ClinicaUtils.ERRO_NOME);

                //Se for vazia não vai possuir 14 caracteres, 
                //sendo assim não necessário a validação de vazio
                ClinicaUtils.ValidarTamanho(paciente.CPF, 14, ClinicaUtils.ERRO_CPF);

                ClinicaUtils.ValidarVazio(paciente.RG.Trim(), ClinicaUtils.ERRO_RG);
                ClinicaUtils.ValidarExceder(paciente.RG.Trim(), 20, ClinicaUtils.ERRO_RG);

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

                ClinicaUtils.ValidarTamanho(paciente.Endereco.UF.Trim(), 2, ClinicaUtils.ERRO_UF);

                ClinicaUtils.ValidarTamanho(paciente.Endereco.CEP.Trim(), 9, ClinicaUtils.ERRO_CEP);

                ClinicaUtils.ValidarVazio(paciente.Endereco.Pais.Trim(), ClinicaUtils.ERRO_PAIS);
                ClinicaUtils.ValidarExceder(paciente.Endereco.Pais.Trim(), 30, ClinicaUtils.ERRO_PAIS);

                ClinicaUtils.ValidarEmail(paciente.Email.Trim());

                ClinicaUtils.ValidarVazio(paciente.Contato.Trim(), ClinicaUtils.ERRO_CONTATO);
                ClinicaUtils.ValidarExceder(paciente.Contato.Trim(), 14, ClinicaUtils.ERRO_CONTATO);

                ClinicaUtils.ValidarVazio(paciente.Estado_Civil.Trim(), ClinicaUtils.ERRO_ESTADO_CIVIL);
                ClinicaUtils.ValidarExceder(paciente.Estado_Civil.Trim(), 10, ClinicaUtils.ERRO_ESTADO_CIVIL);
                #endregion

                new PacienteBD().Atualizar(paciente);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Remover(Paciente paciente)
        {
            try
            {
                ClinicaUtils.ValidarCodigo(paciente.ID_Paciente);
                new PacienteBD().Remover(paciente);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Paciente> Listar(Paciente filtro)
        {
            return new PacienteBD().Listar(filtro);
        }

        public bool VerificaExistencia(Paciente paciente)
        {
            try
            {
                ClinicaUtils.ValidarCodigo(paciente.ID_Paciente);
                return new PacienteBD().VerificaExistencia(paciente);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }



}
