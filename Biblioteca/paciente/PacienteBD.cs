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


        public void Cadastrar(Paciente paciente)
        {
            try
            {
                //Abrir Conexao
                this.abrirConexao();

                string sql = "INSERT INTO Paciente (ID_Paciente, CPF, RG, Nome, Endereco, Email, " +
                    "Celular, Estado_Civil, ID_Convenio" +
                    "VALUES ID_Paciente, @CPF, @RG, @Nome, @Endereco, @Email, @Celular, @Estado_Civil, " +
                    "@ID_Convenio";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                #region Parâmetros
                /* Não está mostrando o ID_Paciente, rever!
                cmd.Parameters.Add("@ID_Paciente", SqlDbType.Int);
                cmd.Parameters["@ID_Paciente"].Value = paciente.*/

                cmd.Parameters.Add("@CPF", SqlDbType.VarChar);
                cmd.Parameters["@CPF"].Value = paciente.CPF;

                cmd.Parameters.Add("@RG", SqlDbType.VarChar);
                cmd.Parameters["@RG"].Value = paciente.CPF;

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                cmd.Parameters["@Nome"].Value = paciente.Nome;

                cmd.Parameters.Add("@Endereco", SqlDbType.VarChar);
                cmd.Parameters["@Endereco"].Value = paciente.Endereco;

                cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                cmd.Parameters["@Email"].Value = paciente.Email;

                cmd.Parameters.Add("@Celular", SqlDbType.VarChar);
                cmd.Parameters["@Celular"].Value = paciente.Celular;

                cmd.Parameters.Add("@Estado_Civil", SqlDbType.VarChar);
                cmd.Parameters["@Estado_Civil"].Value = paciente.Estado_Civil;
                
                cmd.Parameters.Add("@ID_Convenio", SqlDbType.Int);
                cmd.Parameters["@ID_Convenio"].Value = paciente.Convenio.ID_Convenio;
                #endregion

                //Executando a instrução
                cmd.ExecuteNonQuery();
                //Liberando memória
                cmd.Dispose();
                //Fechar Conexão
                this.fecharConexao();

            }
            catch (Exception e)
            {
                throw new Exception("Erro ao cadastrar Paciente." + e);
            }
        }

        public void Atualizar(Paciente paciente)
        {
            try
            {
                //Abri Conexao
                this.abrirConexao();

                string sql = "UPDATE Paciente SET ID_Paciente = @ID_Paciente, CPF = @CPF, RG = @RG," +
                    "Nome = @Nome, Endereco = @Endereco, Email = @Email, Celular = @Celular" +
                    "Estado_Civil = @Estado_Civil ID_Secretaria = @ID_Secretaria" +
                    "WHERE ID_Paciente = @ID_Paciente;";

                //Instrução a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                //Recebendo os valores
                #region Parâmetros
                cmd.Parameters.Add("ID_Paciente", SqlDbType.VarChar);
                cmd.Parameters["@ID_Paciente"].Value = paciente.ID_Paciente;

                cmd.Parameters.Add("@CPF", SqlDbType.VarChar);
                cmd.Parameters["@CPF"].Value = paciente.CPF;

                cmd.Parameters.Add("@RG", SqlDbType.VarChar);
                cmd.Parameters["@RG"].Value = paciente.RG;

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                cmd.Parameters["@Nome"].Value = paciente.Nome;

                cmd.Parameters.Add("@Endereco", SqlDbType.VarChar);
                cmd.Parameters["@Endereco"].Value = paciente.Endereco;

                cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                cmd.Parameters["@Email"].Value = paciente.Email;

                cmd.Parameters.Add("@Celular", SqlDbType.VarChar);
                cmd.Parameters["@Estado_Civil"].Value = paciente.Estado_Civil; 

                cmd.Parameters.Add("@ID_Convenio", SqlDbType.Int);
                cmd.Parameters["@ID_Convenio"].Value = paciente.Convenio.ID_Convenio;
                #endregion

                //Executando a instrução
                cmd.ExecuteNonQuery();
                //Liberando memória
                cmd.Dispose();
                //Fechar Conexao
                this.fecharConexao();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao pesquisar Médico." + e);
            }
            
        }

        public void Remover(Paciente paciente)
        {
            try
            {
                //Abrir conexão
                this.abrirConexao();
                //Instrução a ser executada
                string sql = "DELETE Paciente WHERE ID_Paciente = @ID_Paciente";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@ID_Paciente", SqlDbType.Int);
                cmd.Parameters["@ID_Paciente"].Value = paciente.ID_Paciente;

                //Executando instrução
                cmd.ExecuteNonQuery();
                //Liberando memória
                cmd.Dispose();
                //Fechar conexão
                this.fecharConexao();

            }
            catch (Exception e)
            {
                throw new Exception("Erro ao remover Paciente." + e);
            }
        }

        public List<Paciente> Listar(Paciente filtro)
        {
            List<Paciente> retorno = new List<Paciente>();

            try
            {
                //Abrindo conexão
                this.abrirConexao();
                //Instrução a ser executada
                string sql = "SELECT ID_Paciente, CPF, RG, Nome, Endereco, Email, Celular," +
                    "Estado_Civil, ID_Secretaria, ID_Convenio FROM Paciente WHERE TRUE";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                #region Modos de Pesquisa
                if (filtro.ID_Paciente > 0)
                {
                    sql += " AND ID_Paciente = @ID_Paciente";

                    cmd.Parameters.Add("@ID_Paciente", SqlDbType.Int);
                    cmd.Parameters["@ID_Paciente"].Value = filtro.ID_Paciente;
                }

                //Se foi passado um CPF válido, o mesmo entrará como critério de filtro
                if (string.IsNullOrWhiteSpace(filtro.CPF.Trim()))
                {
                    sql += " AND CPF = @CPF";

                    cmd.Parameters.Add("@CPF", SqlDbType.VarChar);
                    cmd.Parameters["@CPF"].Value = filtro.CPF;
                }
                if (string.IsNullOrWhiteSpace(filtro.Nome.Trim()))
                {
                    sql += " AND Nome = @Nome";

                    cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                    cmd.Parameters["@Nome"].Value = filtro.Nome;
                }
                #endregion

                //Executando a instrução e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //Lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Paciente paciente = new Paciente();
                    //Acessando os valores das colunas do resultado
                    //ID_Medico, CPF, RG, Nome, Endereco, Email, Celular, Estado_Civil, 
                    //ID_Secretaria, ID_Convenio;
                    #region Colunas
                    paciente.ID_Paciente = DbReader.GetInt32(DbReader.GetOrdinal("ID_Paciente"));
                    paciente.CPF = DbReader.GetString(DbReader.GetOrdinal("CPF"));
                    paciente.RG = DbReader.GetString(DbReader.GetOrdinal("RG"));
                    paciente.Nome = DbReader.GetString(DbReader.GetOrdinal("Nome"));
                    //paciente.Endereco = DbReader.GetString(DbReader.GetOrdinal("Endereco"));
                    paciente.Email = DbReader.GetString(DbReader.GetOrdinal("Email"));
                    paciente.Contato = DbReader.GetString(DbReader.GetOrdinal("Contato");
                    paciente.Estado_Civil = DbReader.GetString(DbReader.GetOrdinal("Estado_Civil"));
                    paciente.Convenio.ID_Convenio = DbReader.GetInt32(DbReader.GetOrdinal("ID_Convenio"));
                    #endregion

                    retorno.Add(paciente);
                }

                //Fechando leitor
                DbReader.Close();
                //Liberando memória
                cmd.Dispose();
                //Fechando conexão
                this.fecharConexao();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao conectar e selecionar." + e);
            }
            return retorno;
        }

        public bool VerificaExistencia(Paciente paciente)
        {
            bool retorno;

            try
            {
                //Conectar ao banco
                this.abrirConexao();
                //Instrução a ser executada
                string sql = "SELECT COUNT(*) FROM Paciente WHERE ID_Paciente = @ID_Paciente";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@ID_Paciente", SqlDbType.Int);
                cmd.Parameters["@ID_Paciente"].Value = paciente.ID_Paciente;

                //Executando a instrução e colocando o resultado em um leitor
                retorno = (Int32)cmd.ExecuteScalar() > 0;

                //Liberando memória
                cmd.Dispose();
                //Fechar conexão
                this.fecharConexao();

            }
            catch (Exception e)
            {
                throw new Exception("Erro ao verificar paciente." + e);
            }

            return retorno;
        }
    }
}
