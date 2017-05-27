using ClinicaServiceLibrary.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServiceLibrary.especialidade
{
    public class EspecialidadeBD : ConexaoSql, IEspecialidade
    {

        public void Cadastrar(Especialidade especialidade)
        {
            try
            {
                //abrir conexão
                this.abrirConexao();
                string sql = "INSERT INTO Especialidade (Descricao) VALUES(@Descricao)";
                //string sql = "INSERT INTO Especialidade (ID_Especialidade, Descricao) VALUES(@ID_Especialidade, @Descricao)";
                //instrução a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                //cmd.Parameters.Add("@ID_Especialidade", SqlDbType.Int);
                //cmd.Parameters["@ID_Especialidade"].Value = especialidade.ID_Especialidade;

                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);
                cmd.Parameters["@Descricao"].Value = especialidade.Descricao;

                //executando a instrução
                cmd.ExecuteNonQuery();
                //liberando memória
                cmd.Dispose();
                //fechando conexão
                this.fecharConexao();
            }
            catch (FaultException ex)
            {
                throw new FaultException("Erro ao conectar e cadastrar " + ex.Message);
            }
        }

        public void Atualizar(Especialidade especialidade)
        {
            try
            {
                //abrir conexão
                this.abrirConexao();
                string sql = "UPDATE Especialidade SET Descricao = @Descricao WHERE ID_Especialidade = @ID_Especialidade";
                //instrução a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@ID_Especialidade", SqlDbType.Int);
                cmd.Parameters["@ID_Especialidade"].Value = especialidade.ID_Especialidade;

                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);
                cmd.Parameters["@Descricao"].Value = especialidade.Descricao;

                //executando a instrução
                cmd.ExecuteNonQuery();
                //liberando memória
                cmd.Dispose();
                //fechando conexão
                this.fecharConexao();
            }
            catch (FaultException ex)
            {
                throw new FaultException("Erro ao conectar e atualizar " + ex.Message);
            }
        }

        public void Remover(Especialidade especialidade)
        {
            try
            {
                //abrir conexão
                this.abrirConexao();
                string sql = "DELETE FROM Especialidade WHERE ID_Especialidade = @Id_Especialidade";
                //instrução a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Id_Especialidade", SqlDbType.Int);
                cmd.Parameters["@Id_Especialidade"].Value = especialidade.ID_Especialidade;

                //executando
                cmd.ExecuteNonQuery();
                //liberando memória
                cmd.Dispose();
                //fechando conexão
                this.fecharConexao();
            }
            catch (FaultException ex)
            {
                throw new FaultException("Erro ao conectar e remover " + ex.Message);
            }
        }

        public List<Especialidade> Listar(Especialidade filtro)
        {
            List<Especialidade> retorno = new List<Especialidade>();
            try
            {
                //abrir conexão
                this.abrirConexao();
                string sql = "SELECT ID_Especialidade, Descricao FROM Especialidade WHERE ID_Especialidade = ID_Especialidade";
                //se foi passada um id válido, este id entrará como critério de filtro
                if (filtro.ID_Especialidade > 0)
                {
                    sql += "AND ID_Especialidade = @ID_Especialidade";
                }
                //se foi passada uma descrição válida, esta descrição entrará como critério de filtro
                if (filtro.Descricao != null && filtro.Descricao.Trim().Equals("") == false)
                {
                    sql += "AND Descricao LIKE '%@Descricao%'";
                }
                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                //se foi passada um id válido, este id entrará como critério de filtro
                if (filtro.ID_Especialidade > 0)
                {
                    cmd.Parameters.Add("@Id_Especialidade", SqlDbType.Int);
                    cmd.Parameters["@ID_Especialidade"].Value = filtro.Descricao;
                }
                //se foi passada uma descrição válida, esta descrição entrará como critério de filtro
                if (filtro.Descricao != null && filtro.Descricao.Trim().Equals("") == false)
                {
                    cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);
                    cmd.Parameters["@Descricao"].Value = filtro.Descricao;
                }

                //executando a instrução e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo uma consulta
                while (DbReader.Read())
                {
                    Especialidade especialidade = new Especialidade();
                    //acessando os valores das colunas do resultado
                    especialidade.ID_Especialidade = DbReader.GetInt32(DbReader.GetOrdinal("ID_Especialidade"));
                    especialidade.Descricao = DbReader.GetString(DbReader.GetOrdinal("Descricao"));
                    retorno.Add(especialidade);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando memória
                cmd.Dispose();
                //fechando conexão
                this.fecharConexao();
            }
            catch (FaultException ex)
            {
                throw new FaultException("Erro ao conectar e listar " + ex.Message);
            }
            return retorno;
        }

        public bool VerificarExistencia(Especialidade especialidade)
        {
            bool retorno = false;

            try
            {
                this.abrirConexao();
                string sql = "SELECT ID_Especialidade, Descricao FROM Especialidade WHERE ID_Especialidade = @ID_Especialidade";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.Add("@ID_Especialidade", SqlDbType.Int);
                cmd.Parameters["@ID_Especialidade"].Value = especialidade.ID_Especialidade;
                //executando a instrução
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado
                while (DbReader.Read())
                {
                    retorno = true;
                    break;
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando memória
                cmd.Dispose();
                //fechando conexão
                this.fecharConexao();
            }
            catch (FaultException ex)
            {
                throw new FaultException("Erro ao conectar e selecionar " + ex.Message);
            }
            return retorno;
        }
    }
}
