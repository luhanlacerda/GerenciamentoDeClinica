using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeClinica.Paciente
{
    class NegocioPaciente : InterfacePaciente
    {
        public void atualizar(Paciente p)
        {
            if(p.getCpf().Trim().Length < 14 || p.getCpf().Trim().Length > 14)
            {
                throw new Exception("Número de CPF inválido!");
            }

            if(verificaExistencia(p) != false)
            {
                throw new Exception("Paciente já cadastrado no sistema!");
            }

            if (p.getNome().Trim().Equals("") == true || p.getNome() == null)
            {
                throw new Exception("Informar nome do paciente");
            }

            if (p.getNome().Trim().Length > 100)
            {
                throw new Exception("O nome do paciente não poderá ter mais de 100 caracteres");
            }

            if (p.getRg().Trim().Equals("") == true || p.getRg() == null )
            {
                throw new Exception("Favor informar o RG do paciente");
            }

            if (p.getContato().Trim().Length < 14)
            {
                throw new Exception("Número de telefone inválido");
            }

            if (p.getDtNascimento() == null)
            {
                throw new Exception("Informar data de nascimento");
            }

            if (p.getEndereco().getLogradouro().Trim().Equals("") || p.getEndereco().getLogradouro() == null)
            {
                throw new Exception("Informar nome da rua");
            }

            if (p.getEndereco().getNumero().Trim().Equals("") || p.getEndereco().getNumero() == null)
            {
                throw new Exception("Informar número da residência");
            }

            if (p.getEndereco().getComplemento().Trim().Equals("") || p.getEndereco().getComplemento() == null)
            {
                throw new Exception("Informar complemento, caso não tenha, colocar um -");
            }

            if (p.getEndereco().getCep().Trim().Equals("") || p.getEndereco().getCep() == null)
            {
                throw new Exception("Informar número do CEP");
            }

            if (p.getEndereco().getCidade().Trim().Equals("") || p.getEndereco().getCidade() == null)
            {
                throw new Exception("Informar nome da cidade");
            }
            
            if (p.getEndereco().getUf().Trim().Equals("") || p.getEndereco().getUf() == null)
            {
                throw new Exception("Informar nome da UF(Estado)");
            }
            
            if (p.getEndereco().getUf().Trim().Length > 2 || p.getEndereco().getUf().Trim().Length < 2)
            {
                throw new Exception("Informar UF com 2 caracteres");
            }
            if (p.getEndereco().getPais().Trim().Equals("") || p.getEndereco().getPais() == null)
            {
                throw new Exception("Informar nome do país");
            }

        }

        public void cadastrar(Paciente p)
        {
            throw new NotImplementedException();
        }

        public List<Paciente> listar(Paciente filtro)
        {
            throw new NotImplementedException();
        }

        public void remover(Paciente p)
        {
            throw new NotImplementedException();
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
