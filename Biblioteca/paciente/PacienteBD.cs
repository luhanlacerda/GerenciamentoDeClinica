using Biblioteca.conexaoBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.paciente
{
    public class PacienteBD : ConexaoSql, IPaciente
    {
        private const string ERRO_CPF = "CPF inválido, ";

        public void Cadastrar(Paciente P)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Paciente p)
        {
            throw new NotImplementedException();
        }

        public List<Paciente> Listar(Paciente filtro)
        {
            throw new NotImplementedException();
        }

        public void Remover(Paciente p)
        {
            throw new NotImplementedException();
        }

        public Paciente SelecionarPaciente(Paciente p)
        {
            throw new NotImplementedException();
        }

        public bool VerificaExistencia(Paciente p)
        {
            throw new NotImplementedException();
        }
    }
}
