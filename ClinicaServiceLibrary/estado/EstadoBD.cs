using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ClinicaServiceLibrary.utils;

namespace ClinicaServiceLibrary.estado
{
    public class EstadoBD : ConexaoSql, IEstado
    {
        public void Atualizar(Estado estado)
        {
            try
            {
                //Abrindo Conexão
                this.abrirConexao();

                string sql = "UPDATE Estado SET Descricao = @Descricao WHERE ID_Estado = @ID_Estado";
                //instrução a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                //Recebendo os valores
                cmd.Parameters.Add("@ID_Estado", SqlDbType.Int);
                cmd.Parameters["@ID_Estado"].Value = estado.ID_Estado;

                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);
                cmd.Parameters["@Descricao"].Value = estado.Descricao;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //Fechando conexão
                this.fecharConexao();
            }
            catch (FaultException e)
            {
                throw new FaultException("Erro ao atualizar Estado." + e);
            }
        }

        public void Cadastrar(Estado estado)
        {
            try
            {
                //Abrindo Conexão
                this.abrirConexao();

                string sql = "INSERT INTO Estado (Descricao)" +
                             "VALUES (@Descricao)";

                //instrução a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                //Recebendo os valores
                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);
                cmd.Parameters["@Descricao"].Value = estado.Descricao;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //Fechando conexão
                this.fecharConexao();
            }
            catch (FaultException e)
            {
                throw new FaultException("Erro ao conectar e cadastrar " + e);
            }
        }

        public List<Estado> Listar(Estado filtro)
        {

            List<Estado> retorno = new List<Estado>();

            try
            {
                //Abrindo conexao
                this.abrirConexao();
                //Instrução a ser executada
                string sql = "SELECT ID_Estado, Descricao FROM Estado where 1=1";



                //Se foi passado uma descrição válida,  o mesmo entrará como critério de filtro
                if (filtro.ID_Estado > 0)
                {
                    sql += " AND ID_Estado = @ID_Estado";
                }

                //Se foi passado uma descricao válido, o mesmo entrará como critério de filtro
                if (!string.IsNullOrWhiteSpace(filtro.Descricao))
                {
                    sql += " AND Descricao LIKE @Descricao";
                }

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                if (filtro.ID_Estado > 0)
                {
                    cmd.Parameters.Add("@ID_Estado", SqlDbType.Int);
                    cmd.Parameters["@ID_Estado"].Value = filtro.ID_Estado;
                }

                if (!string.IsNullOrWhiteSpace(filtro.Descricao))
                {
                    cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);
                    cmd.Parameters["@Descricao"].Value = "%" + filtro.Descricao + "%";
                }
                //Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //Lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Estado estado = new Estado();
                    //Acessando os valores das colunas do resultado
                    estado.ID_Estado = DbReader.GetInt32(DbReader.GetOrdinal("ID_Estado"));
                    estado.Descricao = DbReader.GetString(DbReader.GetOrdinal("Descricao"));
                    retorno.Add(estado);
                }
                //Fechando o leitor de resultados
                DbReader.Close();
                //Liberando memoria
                cmd.Dispose();
                //Fechando a conexão
                this.fecharConexao();
            }
            catch (FaultException e)
            {
                throw new FaultException("Erro ao conectar e selecionar." + e.Message);
            }
            return retorno;
        }

        public void Remover(Estado estado)
        {
            try
            {
                //Abrindo conexao
                this.abrirConexao();
                //Instrucao a ser executada
                string sql = "Delete From Estado where ID_Estado = @ID_Estado";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@ID_Estado", SqlDbType.Int);
                cmd.Parameters["@ID_Estado"].Value = estado.ID_Estado;

                //Executando a instrução
                cmd.ExecuteNonQuery();
                //Liberando a memoria
                cmd.Dispose();
                //Fechando conexao
                this.fecharConexao();
            }
            catch (FaultException e)
            {
                throw new FaultException("Erro ao remover Convenio." + e);
            }
        }

        public bool VerificarExistencia(Estado estado)
        {
            bool retorno = false;
            try
            {
                //Conectar ao banco
                this.abrirConexao();
                //instrução a ser executada
                string sql = "Select ID_Estado, Descricao FROM Estado Where ID_Estado = @ID_Estado";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("ID_Estado", SqlDbType.Int);
                cmd.Parameters["ID_Estado"].Value = estado.ID_Estado;

                //Executando a instrução e colocando o resultado num leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    retorno = true;
                    break;
                }

                //fechando o leitor de resultados
                DbReader.Close();
                //Liberando memoria
                cmd.Dispose();
                //Fechar conexao
                this.fecharConexao();
            }
            catch (FaultException)
            {
                throw new FaultException("Estado esta ativo.");
            }

            return retorno;
        }
    }

}
