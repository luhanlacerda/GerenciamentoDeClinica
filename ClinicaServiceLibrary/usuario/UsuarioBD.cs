using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ClinicaServiceLibrary.utils;

namespace ClinicaServiceLibrary.usuario
{
    public class UsuarioBD : ConexaoSql, IUsuario
    {
        public void Cadastrar(Usuario usuario)
        {
            #region
            try
            {
                //Abrindo Conexão
                this.abrirConexao();

                string sql = "insert into Usuario (Nome, Senha)" +
                             "values (@Nome, @Senha)";

                //instrução a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                //Recebendo os valores
                cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                cmd.Parameters["@Nome"].Value = usuario.Nome;

                cmd.Parameters.Add("@Senha", SqlDbType.VarChar);
                cmd.Parameters["@Senha"].Value = usuario.Senha;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //Fechando conexão
                this.fecharConexao();
            }
            catch (FaultException e)
            {
                throw new FaultException("Erro ao conectar e cadastrar usuário" + e);
            }
            #endregion 
        }

        public void Atualizar(Usuario usuario)
        {
            #region
            try
            {
                //Abrindo Conexão
                this.abrirConexao();

                string sql = "UPDATE Usuario SET Nome = @Nome, Senha = @Senha WHERE ID_Usuario = @ID_Usuario";
                //instrução a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                //Recebendo os valores
                cmd.Parameters.Add("@ID_Usuario", SqlDbType.Int);
                cmd.Parameters["@ID_Usuario"].Value = usuario.ID_Usuario;

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                cmd.Parameters["@Nome"].Value = usuario.Nome;

                cmd.Parameters.Add("@Senha", SqlDbType.VarChar);
                cmd.Parameters["@Senha"].Value = usuario.Senha;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //Fechando conexão
                this.fecharConexao();
            }
            catch (FaultException e)
            {
                throw new FaultException("Erro ao atualizar usuário." + e);
            }
            #endregion
        }

        public void Remover(Usuario usuario)
        {
            #region
            try
            {
                //Abrindo conexao
                this.abrirConexao();
                //Instrucao a ser executada
                string sql = "Delete From Usuario where ID_Usuario = @ID_Usuario";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@ID_Usuario", SqlDbType.Int);
                cmd.Parameters["@ID_Usuario"].Value = usuario.ID_Usuario;

                //Executando a instrução
                cmd.ExecuteNonQuery();
                //Liberando a memoria
                cmd.Dispose();
                //Fechando conexao
                this.fecharConexao();
            }
            catch (FaultException e)
            {
                throw new FaultException("Erro ao remover usuário." + e);
            }
            #endregion
        }

        public List<Usuario> Listar(Usuario filtro)
        {
            List<Usuario> retorno = new List<Usuario>();
            try
            {
                //Abrindo conexão
                this.abrirConexao();
                //Instrução a ser executada
                string sql = "SELECT ID_Usuario, Nome FROM Usuario WHERE1=1"; 

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                #region Modos de Pesquisa
                if (filtro.ID_Usuario > 0)
                {
                    cmd.CommandText += " AND ID_Usuario = @ID_Usuario";

                    cmd.Parameters.Add("@ID_Usuario", SqlDbType.Int);
                    cmd.Parameters["@ID_Usuario"].Value = filtro.ID_Usuario;
                }
                if (!string.IsNullOrWhiteSpace(filtro.Nome))
                {
                    cmd.CommandText += " AND Nome = @Nome";

                    cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                    cmd.Parameters["@Nome"].Value = filtro.Nome.Trim();
                }
               
                if (!string.IsNullOrWhiteSpace(filtro.Nome))
                {
                    cmd.CommandText += " AND Nome LIKE @Nome";

                    cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                    cmd.Parameters["@Nome"].Value = "%" + filtro.Nome.Trim() + "%";
                }
                #endregion

                //Executando a instrução e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //Lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Usuario usuario = new Usuario();
                    
                    usuario.ID_Usuario = DbReader.GetInt32(DbReader.GetOrdinal("ID_Usuario"));
                    usuario.Nome = DbReader.GetString(DbReader.GetOrdinal("Nome"));

                    retorno.Add(usuario);
                }

                //Fechando leitor
                DbReader.Close();
                //Liberando memória
                cmd.Dispose();
                //Fechando conexão
                this.fecharConexao();
            }
            catch (FaultException e)
            {

                throw new FaultException("Erro ao conectar e selecionar usuário." + e.Message);
            }
            return retorno;
        }

        public bool VerificarExistencia(Usuario usuario)
        {
            bool retorno;

            try
            {
                //Conectar ao banco
                this.abrirConexao();
                //Instrução a ser executada
               string sql = "SELECT COUNT(*) FROM Usuario WHERE ID_Usuario = @ID_Usuario;";
                 
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.Add("@ID_Usuario", SqlDbType.Int);
                cmd.Parameters["@ID_Usuario"].Value = usuario.Nome;


                //Executando a instrução e colocando o resultado em um leitor
                retorno = (Int32)cmd.ExecuteScalar() > 0;

                //Liberando memória
                cmd.Dispose();
                //Fechar conexão
                this.fecharConexao();
            }
            catch (FaultException e)
            {
                throw new FaultException("Erro ao verificar usuário." + e);
            }
            return retorno;
        }
    }
}
