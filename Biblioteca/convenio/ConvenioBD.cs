using Biblioteca.convenio;
using Biblioteca.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.convenio
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

                string sql = "insert into Convenio (ID_Convenio, Descricao)" +
                    "values (@ID_Convenio,@Descricao)";

                //instrução a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                //Recebendo os valores
                cmd.Parameters.Add("@ID_Convenio", SqlDbType.Int);
                cmd.Parameters["@ID_Convenio"].Value = convenio.ID_Convenio;

                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);
                cmd.Parameters["@Descricao "].Value = convenio.Descricao;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //Fechando conexão
                this.fecharConexao();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao cadastrar convenio." + e);
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
                
                string sql = "UPDATE Convenio SET ID_Convenio = @ID_Convenio, Descricao = @Descricao WHERE ID_Convenio = @ID_Convenio";
                //instrução a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                //Recebendo os valores
                cmd.Parameters.Add("@ID_Convenio", SqlDbType.Int);
                cmd.Parameters["@ID_Convenio"].Value = convenio.ID_Convenio;

                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);
                cmd.Parameters["@Descricao "].Value = convenio.Descricao;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //Fechando conexão
                this.fecharConexao();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao atualizar Convenio." + e);
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
                string sql = "Delete Convenio where ID_Convenio = @ID_Convenio";

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
            catch (Exception e)
            {
                throw new Exception("Erro ao remover Convenio." + e);
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
                string sql = "SELECT ID_Convenio,Descricao FROM Convenio where ID_Convenio = @ID_Convenio";
                //Se foi passado um id_convenio válido, o mesmo entrará como critério de filtro
                if (filtro.ID_Convenio > 0)
                {
                    sql += "and ID_Convenio = @ID_Convenio";
                }
                //Se foi passado uma descrição válida,  o mesmo entrará como critério de filtro
                if (filtro.Descricao != null && filtro.Descricao.Trim().Equals("") == false)
                {
                    sql += " and Descricao like %@Descricao%";
                }
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                //Se foi passado um id_convenio válido, o mesmo entrará como critério de filtro
                if (filtro.ID_Convenio > 0)
                {
                    cmd.Parameters.Add("@ID_Convenio", SqlDbType.Int);
                    cmd.Parameters["@ID_Convenio"].Value = filtro.ID_Convenio;
                }
                //Se foi passado uma descricao válido, o mesmo entrará como critério de filtro
                if (filtro.Descricao != null && filtro.Descricao.Trim().Equals("") == false)
                {
                    cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);
                    cmd.Parameters["@Descricao"].Value = filtro.Descricao;
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
            catch (Exception e)
            {
                throw new Exception("Erro ao conectar e selecionar." + e.Message);
            }
            return retorno;
            
        }

        public bool verificaExistencia(Convenio convenio)
        {
            #region
            bool retorno = false;
            try
            {
                //Conectar ao banco
                this.abrirConexao();
                //instrução a ser executada
                string sql = "Select ID_Convenio, Descricao FROM Convenio Where ID_Convenio = " +
                    "@ID_Convenio";

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
            catch (Exception)
            {
                throw new Exception("Convenio esta ativo.");
            }

            return retorno;
        }

        public bool VerificaExistencia(Convenio convenio)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
