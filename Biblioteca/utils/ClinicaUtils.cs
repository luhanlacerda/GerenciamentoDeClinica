using Biblioteca.classesBasicas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.utils
{
    public class ClinicaUtils
    {
        public static readonly string[] UF_LIST = { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" };

        #region Tamanhos Pré-Definidos
        public const int CPF_SIZE = 14;
        public const int NOME_SIZE = 100;
        public const int RG_SIZE = 20;
        public const int ENDERECO_SIZE = 50;
        public const int NUMERO_SIZE = 10;
        public const int COMPLEMENTO_SIZE = 10;
        public const int BAIRRO_SIZE = 20;
        public const int CIDADE_SIZE = 50;
        public const int UF_SIZE = 2;
        public const int CEP_SIZE = 9;
        public const int PAIS_SIZE = 30;
        public const int CONTATO_SIZE = 14;
        public const int ESTADO_CIVIL_SIZE = 10;
        #endregion

        #region Erros
        //Mensagens de erro
        private const string ERRO_INVALIDO = "{0} inválido.";
        private const string ERRO_EXCEDER = "O {0} não deve exceder {1:D} caracteres.";
        private const string ERRO_TAMANHO = "O {0} deve possuir {1:D} caracteres.";

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
                throw new FaultException(string.Format(ERRO_INVALIDO, ERRO_CODIGO));
        }

        //Validação de um objeto nulo, vazio ou apenas espaços em branco
        public static void ValidarVazio(string value, string error)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new FaultException(string.Format(ERRO_INVALIDO, error));
        }

        //Validação de excedência de um valor máximo mostrado
        public static void ValidarExceder(string value, int maximum, string error)
        {
            if (value.Length > maximum)
                throw new FaultException(string.Format(ERRO_EXCEDER, error, maximum));
        }

        //Validação de um tamanho fixo
        public static void ValidarTamanho(string value, int size, string error)
        {
            if (value.Length != size)
                throw new FaultException(string.Format(ERRO_TAMANHO, error, size));
        }

        //Validação se o e-mail é válido
        public static void ValidarEmail(string email)
        {
            if (!EMAIL_VALIDATION.IsValid(email))
                throw new FaultException(string.Format(ERRO_INVALIDO, ERRO_EMAIL));

        }

        public static void ValidarPessoa(Pessoa pessoa)
        {
            ValidarVazio(pessoa.Nome.Trim(), ERRO_NOME);
            ValidarExceder(pessoa.Nome.Trim(), NOME_SIZE, ERRO_NOME);

            //Se for vazia não vai possuir 14 caracteres, 
            //sendo assim não necessário a validação de vazio
            ValidarTamanho(pessoa.CPF, CPF_SIZE, ERRO_CPF);

            ValidarVazio(pessoa.RG.Trim(), ERRO_RG);
            ValidarExceder(pessoa.RG.Trim(), RG_SIZE, ERRO_RG);

            ValidarVazio(pessoa.Endereco.Logradouro.Trim(), ERRO_LOGRADOURO);
            ValidarExceder(pessoa.Endereco.Logradouro.Trim(), ENDERECO_SIZE, ERRO_LOGRADOURO);

            ValidarVazio(pessoa.Endereco.Numero.Trim(), ERRO_NUMERO);
            ValidarExceder(pessoa.Endereco.Numero.Trim(), NUMERO_SIZE, ERRO_NUMERO);

            ValidarVazio(pessoa.Endereco.Complemento.Trim(), ERRO_COMPLEMENTO);
            ValidarExceder(pessoa.Endereco.Complemento.Trim(), COMPLEMENTO_SIZE, ERRO_COMPLEMENTO);

            ValidarVazio(pessoa.Endereco.Bairro.Trim(), ERRO_BAIRRO);
            ValidarExceder(pessoa.Endereco.Bairro.Trim(), BAIRRO_SIZE, ERRO_BAIRRO);

            ValidarVazio(pessoa.Endereco.Cidade.Trim(), ERRO_CIDADE);
            ValidarExceder(pessoa.Endereco.Cidade.Trim(), CIDADE_SIZE, ERRO_CIDADE);

            ValidarTamanho(pessoa.Endereco.UF.Trim(), UF_SIZE, ERRO_UF);

            ValidarTamanho(pessoa.Endereco.CEP.Trim(), CEP_SIZE, ERRO_CEP);

            ValidarVazio(pessoa.Endereco.Pais.Trim(), ERRO_PAIS);
            ValidarExceder(pessoa.Endereco.Pais.Trim(), PAIS_SIZE, ERRO_PAIS);

            ValidarEmail(pessoa.Email.Trim());

            ValidarVazio(pessoa.Contato.Trim(), ERRO_CONTATO);
            ValidarExceder(pessoa.Contato.Trim(), CONTATO_SIZE, ERRO_CONTATO);

            ValidarVazio(pessoa.Estado_Civil.Trim(), ERRO_ESTADO_CIVIL);
            ValidarExceder(pessoa.Estado_Civil.Trim(), ESTADO_CIVIL_SIZE, ERRO_ESTADO_CIVIL);
        }
    }
}
