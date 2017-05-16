using Biblioteca.classesBasicas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.utils
{
    public class ClinicaUtils
    {
        public static readonly string[] UF_LIST = { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" };
        public const int CPF_SIZE = 14;

        #region Erros
        //Mensagens de erro
        private const string ERRO_INVALIDO = "%s inválido.";
        private const string ERRO_EXCEDER = "O %s não deve exceder %i caracteres.";
        private const string ERRO_TAMANHO = "O %s deve possuir %i caracteres.";

        //Todos os possíveis tipos
        public const string ERRO_CODIGO = "Código";
        public const string ERRO_CPF = "CPF";
        public const string ERRO_CRM = "CRM";
        public const string ERRO_RG = "RG";
        public const string ERRO_NOME = "Nome";
        public const string ERRO_ENDERECO = "Endereço";
        public const string ERRO_LOGRADOURO = "Rua";
        public const string ERRO_NUMERO = "Número";
        public const string ERRO_COMPLEMENTO = "Complemento";
        public const string ERRO_BAIRRO = "Bairro";
        public const string ERRO_CIDADE = "Cidade";
        public const string ERRO_UF = "UF";
        public const string ERRO_CEP = "CEP";
        public const string ERRO_PAIS = "País";
        public const string ERRO_EMAIL = "E-mail";
        public const string ERRO_CONTATO = "Contato";
        public const string ERRO_ESTADO_CIVIL = "Estado Civil";
        public const string ERRO_ESPECIALIDADE = "Especialidade";

        //Utilizado para a validação de e-mail
        //readonly é muito similar ao const, mas pode ser inicializado (Construtor) posteriormente a sua declaração e pode utilizar referências (classes) 
        private static readonly EmailAddressAttribute EMAIL_VALIDATION = new EmailAddressAttribute();
        #endregion

        //Valida o Código (ID) passado e retorna a frase de inválido
        public static void ValidarCodigo(int value)
        {
            if (value < 1)
                throw new Exception(string.Format(ERRO_INVALIDO, ERRO_CODIGO));
        }

        //Validação de um objeto nulo, vazio ou apenas espaços em branco
        public static void ValidarVazio(string value, string error)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception(string.Format(ERRO_INVALIDO, error));
        }

        //Validação de excedência de um valor máximo mostrado
        public static void ValidarExceder(string value, int maximum, string error)
        {
            if (value.Length > maximum)
                throw new Exception(string.Format(ERRO_EXCEDER, error, maximum));
        }

        //Validação de um tamanho fixo
        public static void ValidarTamanho(string value, int size, string error)
        {
            if (value.Length != size)
                throw new Exception(string.Format(ERRO_TAMANHO, error, size));
        }

        //Validação se o e-mail é válido
        public static void ValidarEmail(string email)
        {
            if (!ClinicaUtils.EMAIL_VALIDATION.IsValid(email))
                throw new Exception(string.Format(ERRO_INVALIDO, ClinicaUtils.ERRO_EMAIL));

        }

        public static void ValidarPessoa(Pessoa pessoa)
        {
            #region Validações
            ClinicaUtils.ValidarVazio(pessoa.Nome.Trim(), ClinicaUtils.ERRO_NOME);
            ClinicaUtils.ValidarExceder(pessoa.Nome.Trim(), 100, ClinicaUtils.ERRO_NOME);

            //Se for vazia não vai possuir 14 caracteres, 
            //sendo assim não necessário a validação de vazio
            ClinicaUtils.ValidarTamanho(pessoa.CPF, 14, ClinicaUtils.ERRO_CPF);

            ClinicaUtils.ValidarVazio(pessoa.RG.Trim(), ClinicaUtils.ERRO_RG);
            ClinicaUtils.ValidarExceder(pessoa.RG.Trim(), 20, ClinicaUtils.ERRO_RG);

            ClinicaUtils.ValidarVazio(pessoa.Endereco.Logradouro.Trim(), ClinicaUtils.ERRO_LOGRADOURO);
            ClinicaUtils.ValidarExceder(pessoa.Endereco.Logradouro.Trim(), 50, ClinicaUtils.ERRO_LOGRADOURO);

            ClinicaUtils.ValidarVazio(pessoa.Endereco.Numero.Trim(), ClinicaUtils.ERRO_NUMERO);
            ClinicaUtils.ValidarExceder(pessoa.Endereco.Numero.Trim(), 10, ClinicaUtils.ERRO_NUMERO);

            ClinicaUtils.ValidarVazio(pessoa.Endereco.Complemento.Trim(), ClinicaUtils.ERRO_COMPLEMENTO);
            ClinicaUtils.ValidarExceder(pessoa.Endereco.Complemento.Trim(), 10, ClinicaUtils.ERRO_COMPLEMENTO);

            ClinicaUtils.ValidarVazio(pessoa.Endereco.Bairro.Trim(), ClinicaUtils.ERRO_BAIRRO);
            ClinicaUtils.ValidarExceder(pessoa.Endereco.Bairro.Trim(), 20, ClinicaUtils.ERRO_BAIRRO);

            ClinicaUtils.ValidarVazio(pessoa.Endereco.Cidade.Trim(), ClinicaUtils.ERRO_CIDADE);
            ClinicaUtils.ValidarExceder(pessoa.Endereco.Cidade.Trim(), 50, ClinicaUtils.ERRO_CIDADE);

            ClinicaUtils.ValidarTamanho(pessoa.Endereco.UF.Trim(), 2, ClinicaUtils.ERRO_UF);

            ClinicaUtils.ValidarTamanho(pessoa.Endereco.CEP.Trim(), 9, ClinicaUtils.ERRO_CEP);

            ClinicaUtils.ValidarVazio(pessoa.Endereco.Pais.Trim(), ClinicaUtils.ERRO_PAIS);
            ClinicaUtils.ValidarExceder(pessoa.Endereco.Pais.Trim(), 30, ClinicaUtils.ERRO_PAIS);

            ClinicaUtils.ValidarEmail(pessoa.Email.Trim());

            ClinicaUtils.ValidarVazio(pessoa.Contato.Trim(), ClinicaUtils.ERRO_CONTATO);
            ClinicaUtils.ValidarExceder(pessoa.Contato.Trim(), 14, ClinicaUtils.ERRO_CONTATO);

            ClinicaUtils.ValidarVazio(pessoa.Estado_Civil.Trim(), ClinicaUtils.ERRO_ESTADO_CIVIL);
            ClinicaUtils.ValidarExceder(pessoa.Estado_Civil.Trim(), 10, ClinicaUtils.ERRO_ESTADO_CIVIL);
            #endregion
        }
    }
}
