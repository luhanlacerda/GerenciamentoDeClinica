using classesBasicas;
using classesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesNegocios
{
    public class NegocioPaciente : IPaciente
    {
        public void cadastrar(Paciente p)
        {
            if(p.Cpf.Trim().Length < 14 || p.Cpf.Trim().Length > 14)
            {
                throw new Exception("Número de CPF inválido!");
            }
            /*
            if(verificaExistencia(Paciente p) != false)
            {
                throw new Exception("Paciente já cadastrado no sistema!");
            }
            */
            if (p.Nome.Trim().Equals("") == true || p.Nome == null)
            {
                throw new Exception("Informar nome do paciente");
            }

            if (p.Nome.Trim().Length > 100)
            {
                throw new Exception("O nome do paciente não poderá ter mais de 100 caracteres");
            }

            if (p.Rg.Trim().Equals("") == true || p.Rg == null )
            {
                throw new Exception("Favor informar o RG do paciente");
            }

            if (p.Convenio.Codigo <= 0)
            {
                throw new Exception("Favor informar o convênio");
            }

            if (p.Contato.Trim().Length < 14)
            {
                throw new Exception("Número de telefone inválido");
            }

            if (p.DtNascimento == null)
            {
                throw new Exception("Informar data de nascimento");
            }
            /*
            if (p.Endereco.Logradouro.Trim().Equals("") || p.Endereco.Logradouro == null)
            {
                throw new Exception("Informar nome da rua");
            }

            if (p.Endereco.Numero.Trim().Equals("") || p.Endereco.Numero == null)
            {
                throw new Exception("Informar número da residência");
            }

            if (p.Endereco.Complemento.Trim().Equals("") || p.Endereco.Complemento == null)
            {
                throw new Exception("Informar complemento, caso não tenha, colocar um -");
            }

            if (p.Endereco.Cep.Trim().Equals("") || p.Endereco.Cep == null)
            {
                throw new Exception("Informar número do CEP");
            }

            if (p.Endereco.Cidade.Trim().Equals("") || p.Endereco.Cidade == null)
            {
                throw new Exception("Informar nome da cidade");
            }
            
            if (p.Endereco.Uf.Trim().Equals("") || p.Endereco.getUf() == null)
            {
                throw new Exception("Informar nome da UF(Estado)");
            }
            
            if (p.Endereco.Uf.Trim().Length > 2 || p.Endereco.Uf.Trim().Length < 2)
            {
                throw new Exception("Informar UF com 2 caracteres");
            }
            if (p.Endereco.Pais.Trim().Equals("") || p.Endereco.Pais == null)
            {
                throw new Exception("Informar nome do país");
            }
            */
            //cadastrando
            //colocar o codigo de jogar para a camada de dados

        }

        public void atualizar(Paciente p)
        {
            if (p.Cpf.Trim().Length < 14 || p.Cpf.Trim().Length > 14)
            {
                throw new Exception("Número de CPF inválido!");
            }
            /*
            if (verificaExistencia(Paciente p) != false)
            {
                throw new Exception("Paciente já cadastrado no sistema!");
            }
            */
            if (p.Nome.Trim().Equals("") == true || p.Nome == null)
            {
                throw new Exception("Informar nome do paciente");
            }

            if (p.Nome.Trim().Length > 100)
            {
                throw new Exception("O nome do paciente não poderá ter mais de 100 caracteres");
            }

            if (p.Rg.Trim().Equals("") == true || p.Rg == null)
            {
                throw new Exception("Favor informar o RG do paciente");
            }

            if (p.Convenio.Codigo <= 0)
            {
                throw new Exception("Favor informar o convênio");
            }

            if (p.Contato.Trim().Length < 14)
            {
                throw new Exception("Número de telefone inválido");
            }

            if (p.DtNascimento == null)
            {
                throw new Exception("Informar data de nascimento");
            }

            /*
            if (p.Endereco.Logradouro.Trim().Equals("") || p.Endereco.Logradouro == null)
            {
                throw new Exception("Informar nome da rua");
            }

            if (p.Endereco.Numero.Trim().Equals("") || p.Endereco.Numero == null)
            {
                throw new Exception("Informar número da residência");
            }

            if (p.Endereco.Complemento.Trim().Equals("") || p.Endereco.Complemento == null)
            {
                throw new Exception("Informar complemento, caso não tenha, colocar um -");
            }

            if (p.Endereco.Cep.Trim().Equals("") || p.Endereco.Cep == null)
            {
                throw new Exception("Informar número do CEP");
            }

            if (p.Endereco.Cidade.Trim().Equals("") || p.Endereco.Cidade == null)
            {
                throw new Exception("Informar nome da cidade");
            }

            if (p.Endereco.Uf.Trim().Equals("") || p.Endereco.getUf() == null)
            {
                throw new Exception("Informar nome da UF(Estado)");
            }

            if (p.Endereco.Uf.Trim().Length > 2 || p.Endereco.Uf.Trim().Length < 2)
            {
                throw new Exception("Informar UF com 2 caracteres");
            }
            if (p.Endereco.Pais.Trim().Equals("") || p.Endereco.Pais == null)
            {
                throw new Exception("Informar nome do país");
            }
            */
            //Atualizando
            //colocar o codigo de jogar para a camada de dados

        }

        public List<Paciente> listar(Paciente filtro)
        {
            throw new NotImplementedException();
        }

        public void remover(Paciente p)
        {
            if (p.Cpf.Trim().Length < 14 || p.Cpf.Trim().Length > 14)
            {
                throw new Exception("Número de CPF inválido!");
            }

            if (verificaExistencia(p) == false)
            {
                throw new Exception("Paciente não cadastrado no sistema!");
            }

            //Atualizando
            //colocar o codigo de jogar para a camada de dados
        }

        public Paciente selecionarPaciente(Paciente p)
        {
            throw new NotImplementedException();
        }

        public bool verificaExistencia(Paciente p)
        {
            throw new NotImplementedException();
        }
    }

}
