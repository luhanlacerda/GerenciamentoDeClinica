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
        public void Cadastrar(Paciente P)
        {
            try
            {
                //abrir conexão
                this.abrirConexao();
                string sql = "insert into Paciente (Pac_Cpf, Pac_Rg, Pac_Nome, Pac_Telefone, Pac_Logradouro, Pac_Numero, Pac_Complemento, Pac_Bairro, Pac_Cep, Pac_Cidade, Pac_Uf, Pac_Pais, Cod_Convenio)"
                    + "values(@cpf, @rg, @nome, @telefone, @logradouro, @numero, @complemento, @bairro, @cep, @cidade, @uf, @pais, @codconvenio)";
                //instrução a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                cmd.Parameters["@cpf"].Value = P.Cpf;

                cmd.Parameters.Add("@rg", SqlDbType.VarChar);
                cmd.Parameters["@rg"].Value = P.Rg;

                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = P.Nome;

                cmd.Parameters.Add("@telefone", SqlDbType.VarChar);
                cmd.Parameters["@telefone"].Value = P.Contato;

                cmd.Parameters.Add("@logradouro", SqlDbType.VarChar);
                cmd.Parameters["@logradouro"].Value = P.Endereco.Logradouro;

                cmd.Parameters.Add("@numero", SqlDbType.VarChar);
                cmd.Parameters["@numero"].Value = P.Endereco.Numero;

                cmd.Parameters.Add("@complemento", SqlDbType.VarChar);
                cmd.Parameters["@complemento"].Value = P.Endereco.Complemento;

                cmd.Parameters.Add("@bairro", SqlDbType.VarChar);
                cmd.Parameters["@bairro"].Value = P.Endereco.Bairro;

                cmd.Parameters.Add("@cep", SqlDbType.VarChar);
                cmd.Parameters["@cep"].Value = P.Endereco.Cep;

                cmd.Parameters.Add("@cidade", SqlDbType.VarChar);
                cmd.Parameters["@cidade"].Value = P.Endereco.Cidade;

                cmd.Parameters.Add("@uf", SqlDbType.VarChar);
                cmd.Parameters["@uf"].Value = P.Endereco.Uf;

                cmd.Parameters.Add("@pais", SqlDbType.VarChar);
                cmd.Parameters["@pais"].Value = P.Endereco.Pais;

                cmd.Parameters.Add("@codconvenio", SqlDbType.Int);
                cmd.Parameters["@codconvenio"].Value = P.Convenio.Id_convenio;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e cadastrar" + ex.Message);
            }
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
