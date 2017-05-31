
using ClinicaServiceLibrary.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;

namespace ClinicaServiceLibrary.convenio
{
    public class ConvenioBD : ConexaoSql, IConvenio
    {

        public void Cadastrar(Convenio convenio)
        {
            #region
            try
            {
                //Abrindo Conexão
                this.abrirConexao();

                string sql = "insert into Convenio (Descricao)" +
                             "values (@Descricao)";

                //instrução a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                //Recebendo os valores
                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);
                cmd.Parameters["@Descricao"].Value = convenio.Descricao;

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
            #endregion
        }

        public void Atualizar(Convenio convenio)
        {
            #region
            try
            {
                //Abrindo Conexão
                this.abrirConexao();

                string sql = "UPDATE Convenio SET Descricao = @Descricao WHERE ID_Convenio = @ID_Convenio";
                //instrução a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                //Recebendo os valores
                cmd.Parameters.Add("@ID_Convenio", SqlDbType.Int);
                cmd.Parameters["@ID_Convenio"].Value = convenio.ID_Convenio;

                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);
                cmd.Parameters["@Descricao"].Value = convenio.Descricao;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //Fechando conexão
                this.fecharConexao();
            }
            catch (FaultException e)
            {
                throw new FaultException("Erro ao atualizar Convenio." + e);
            }
            #endregion
        }


        public void Remover(Convenio convenio)
        {
            #region
            try
            {
                //Abrindo conexao
                this.abrirConexao();
                //Instrucao a ser executada
                string sql = "Delete From Convenio where ID_Convenio = @ID_Convenio";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@ID_Convenio", SqlDbType.Int);
                cmd.Parameters["@ID_Convenio"].Value = convenio.ID_Convenio;

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
            #endregion
        }

        public List<Convenio> Listar(Convenio filtro)
        {
            
            List<Convenio> retorno = new List<Convenio>();

            try
            {
                //Abrindo conexao
                this.abrirConexao();
                //Instrução a ser executada
                string sql = "SELECT ID_Convenio,Descricao FROM Convenio where 1=1";

                

                //Se foi passado uma descrição válida,  o mesmo entrará como critério de filtro
                if (filtro.ID_Convenio > 0)
                {
                    sql += " AND ID_Convenio = @ID_Convenio";
                }

                //Se foi passado uma descricao válido, o mesmo entrará como critério de filtro
                if(!string.IsNullOrWhiteSpace(filtro.Descricao))
                {
                    sql += " AND Descricao LIKE @Descricao";
                }

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                if (filtro.ID_Convenio > 0)
                {
                    cmd.Parameters.Add("@ID_Convenio", SqlDbType.Int);
                    cmd.Parameters["@ID_Convenio"].Value = filtro.ID_Convenio;
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
                    Convenio convenio = new Convenio();
                    //Acessando os valores das colunas do resultado
                    convenio.ID_Convenio = DbReader.GetInt32(DbReader.GetOrdinal("ID_Convenio"));
                    convenio.Descricao = DbReader.GetString(DbReader.GetOrdinal("Descricao"));
                    retorno.Add(convenio);
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

        public bool VerificarExistencia(Convenio convenio)
        {
            #region
            bool retorno = false;
            try
            {
                //Conectar ao banco
                this.abrirConexao();
                //instrução a ser executada
                string sql = "Select ID_Convenio, Descricao FROM Convenio Where ID_Convenio = @ID_Convenio";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("ID_Convenio", SqlDbType.Int);
                cmd.Parameters["ID_Convenio"].Value = convenio.ID_Convenio;

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
                throw new FaultException("Convenio esta ativo.");
            }

            return retorno;
        }

        #endregion
    }
}
