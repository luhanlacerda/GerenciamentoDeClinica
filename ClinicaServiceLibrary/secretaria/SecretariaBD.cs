using ClinicaServiceLibrary.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServiceLibrary.secretaria
{
    public class SecretariaBD : ConexaoSql, ISecretaria
    {
        public void Cadastrar(Secretaria secretaria)
        {
            try
            {
                //Abrindo Conexão
                this.abrirConexao();

                string sql = "INSERT INTO Secretaria (CPF, RG, Nome, Email, Logradouro," +
                    "Numero, Complemento, Bairro, CEP, Cidade, UF, Pais, Estado_Civil, Contato, Dt_Nascimento)" +
                    "VALUES (@CPF, @RG, @Nome, @Email, @Logradouro," +
                    "@Numero, @Complemento, @Bairro, @CEP, @Cidade, @UF, @Pais, @Estado_Civil, @Contato, @Dt_Nascimento);";

                //instrução a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                //Recebendo os valores
                #region Parâmetros
                cmd.Parameters.Add("@CPF", SqlDbType.Char);
                cmd.Parameters["@CPF"].Value = secretaria.CPF.Trim();

                cmd.Parameters.Add("@RG", SqlDbType.VarChar);
                cmd.Parameters["@RG"].Value = secretaria.RG.Trim();

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                cmd.Parameters["@Nome"].Value = secretaria.Nome.Trim();

                cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                cmd.Parameters["@Email"].Value = secretaria.Email.Trim();

                cmd.Parameters.Add("@Logradouro", SqlDbType.VarChar);
                cmd.Parameters["@Logradouro"].Value = secretaria.Endereco.Logradouro.Trim();

                cmd.Parameters.Add("@Numero", SqlDbType.VarChar);
                cmd.Parameters["@Numero"].Value = secretaria.Endereco.Numero.Trim();

                cmd.Parameters.Add("@Complemento", SqlDbType.VarChar);
                cmd.Parameters["@Complemento"].Value = secretaria.Endereco.Complemento.Trim();

                cmd.Parameters.Add("@Bairro", SqlDbType.VarChar);
                cmd.Parameters["@Bairro"].Value = secretaria.Endereco.Bairro.Trim();

                cmd.Parameters.Add("@CEP", SqlDbType.VarChar);
                cmd.Parameters["@CEP"].Value = secretaria.Endereco.CEP.Trim();

                cmd.Parameters.Add("@Cidade", SqlDbType.VarChar);
                cmd.Parameters["@Cidade"].Value = secretaria.Endereco.Cidade.Trim();

                cmd.Parameters.Add("@UF", SqlDbType.VarChar);
                cmd.Parameters["@UF"].Value = secretaria.Endereco.UF.Trim();

                cmd.Parameters.Add("@Pais", SqlDbType.VarChar);
                cmd.Parameters["@Pais"].Value = secretaria.Endereco.Pais.Trim();

                cmd.Parameters.Add("@Estado_Civil", SqlDbType.VarChar);
                cmd.Parameters["@Estado_Civil"].Value = secretaria.Estado_Civil.Trim();

                cmd.Parameters.Add("@Contato", SqlDbType.Char);
                cmd.Parameters["@Contato"].Value = secretaria.Contato.Trim();

                cmd.Parameters.Add("@Dt_Nascimento", SqlDbType.DateTime);
                cmd.Parameters["@Dt_Nascimento"].Value = secretaria.Dt_Nascimento;
                #endregion

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //Fechando conexão
                this.fecharConexao();
            }
            catch (FaultException e)
            {
                throw new FaultException("Erro ao cadastrar secretária." + e);
            }
        }

        public void Atualizar(Secretaria secretaria)
        {
            try
            {
                //Abrindo Conexão
                this.abrirConexao();

                string sql = "UPDATE Secretaria CPF = @CPF, RG = @RG, Nome = @Nome, Email = @Email, Logradourod = @Logradouro," +
                    "Numero = @Numero, Complemento = @Complemento, Bairro = @Bairro, CEP = @CEP, Cidade = @Cidade, UF = @UF," +
                    "Pais = @Pais, Estado_Civil = @Estado_Civil, Contato = @Contato, Dt_Nascimento = @Dt_Nascimento WHERE ID_Secretaria = @ID_Secretaria;";

                //instrução a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                //Recebendo os valores
                #region Parâmetros
                cmd.Parameters.Add("@ID_Secretaria", SqlDbType.Int);
                cmd.Parameters["@ID_Secretaria"].Value = secretaria.ID_Secretaria;

                cmd.Parameters.Add("@CPF", SqlDbType.Char);
                cmd.Parameters["@CPF"].Value = secretaria.CPF.Trim();

                cmd.Parameters.Add("@RG", SqlDbType.VarChar);
                cmd.Parameters["@RG"].Value = secretaria.RG.Trim();

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                cmd.Parameters["@Nome"].Value = secretaria.Nome.Trim();

                cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                cmd.Parameters["@Email"].Value = secretaria.Email.Trim();

                cmd.Parameters.Add("@Logradouro", SqlDbType.VarChar);
                cmd.Parameters["@Logradouro"].Value = secretaria.Endereco.Logradouro.Trim();

                cmd.Parameters.Add("@Numero", SqlDbType.VarChar);
                cmd.Parameters["@Numero"].Value = secretaria.Endereco.Numero.Trim();

                cmd.Parameters.Add("@Complemento", SqlDbType.VarChar);
                cmd.Parameters["@Complemento"].Value = secretaria.Endereco.Complemento.Trim();

                cmd.Parameters.Add("@Bairro", SqlDbType.VarChar);
                cmd.Parameters["@Bairro"].Value = secretaria.Endereco.Bairro.Trim();

                cmd.Parameters.Add("@CEP", SqlDbType.VarChar);
                cmd.Parameters["@CEP"].Value = secretaria.Endereco.CEP.Trim();

                cmd.Parameters.Add("@Cidade", SqlDbType.VarChar);
                cmd.Parameters["@Cidade"].Value = secretaria.Endereco.Cidade.Trim();

                cmd.Parameters.Add("@UF", SqlDbType.VarChar);
                cmd.Parameters["@UF"].Value = secretaria.Endereco.UF.Trim();

                cmd.Parameters.Add("@Pais", SqlDbType.VarChar);
                cmd.Parameters["@Pais"].Value = secretaria.Endereco.Pais.Trim();

                cmd.Parameters.Add("@Estado_Civil", SqlDbType.VarChar);
                cmd.Parameters["@Estado_Civil"].Value = secretaria.Estado_Civil.Trim();

                cmd.Parameters.Add("@Contato", SqlDbType.Char);
                cmd.Parameters["@Contato"].Value = secretaria.Contato.Trim();

                cmd.Parameters.Add("@Dt_Nascimento", SqlDbType.DateTime);
                cmd.Parameters["@Dt_Nascimento"].Value = secretaria.Dt_Nascimento;
                #endregion

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //Fechando conexão
                this.fecharConexao();
            }
            catch (FaultException e)
            {
                throw new FaultException("Erro ao atualizar secretária." + e);
            }
        }

        public void Remover(Secretaria secretaria)
        {
            try
            {
                //Abrindo conexao
                this.abrirConexao();
                //Instrucao a ser executada
                string sql = "DELETE Secretaria WHERE ID_Secretaria = @ID_Secretaria;";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@ID_Secretaria", SqlDbType.Int);
                cmd.Parameters["@ID_Secretaria"].Value = secretaria.ID_Secretaria;

                //Executando a instrução
                cmd.ExecuteNonQuery();
                //Liberando a memoria
                cmd.Dispose();
                //Fechando conexao
                this.fecharConexao();
            }
            catch (FaultException e)
            {
                throw new FaultException("Erro ao remover secretária." + e);
            }
        }

        public List<Secretaria> Listar(Secretaria filtro)
        {
            List<Secretaria> retorno = new List<Secretaria>();
            try
            {
                //Abrindo conexao
                this.abrirConexao();
                //Instrução a ser executada
                string sql = "SELECT ID_Secretaria, CPF, RG, Nome, Email, Logradouro, Numero, Complemento, Bairro, CEP, Cidade, UF, Pais," +
                    "Estado_Civil, Contato, Dt_Nascimento FROM Secretaria WHERE TRUE";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                //Se foi passado um id_secretaria válido, o mesmo entrará como critério de filtro
                #region Modos de Pesquisa
                if (filtro.ID_Secretaria > 0)
                {
                    sql += " AND ID_Secretaria = @ID_Secretaria";

                    cmd.Parameters.Add("@ID_Secretaria", SqlDbType.Int);
                    cmd.Parameters["@ID_Secretaria"].Value = filtro.ID_Secretaria;
                }
                //Se foi passado um CPF válido, o mesmo entrará como critério de filtro
                if (string.IsNullOrWhiteSpace(filtro.CPF.Trim()))
                  /*"  Matheus Vasconcelos  " = por isso o trim. Não precisando de IsNullOrWhiteSpace,
                   /apenas de IsNullOrEmpty, mas por precaução houve a utilização*/
                {
                    sql += " AND CPF = @CPF";

                    cmd.Parameters.Add("@CPF", SqlDbType.Char);
                    cmd.Parameters["@CPF"].Value = filtro.CPF.Trim();
                }
                if (string.IsNullOrWhiteSpace(filtro.RG.Trim()))
                {
                    sql += " AND RG = @RG";

                    cmd.Parameters.Add("@RG", SqlDbType.VarChar);
                    cmd.Parameters["@RG"].Value = filtro.CPF.Trim();
                }
                if (string.IsNullOrWhiteSpace(filtro.Nome.Trim()))
                {
                    sql += " AND Nome = @Nome";

                    cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                    cmd.Parameters["@Nome"].Value = filtro.Nome.Trim();
                }
                #endregion

                //Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //Lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Secretaria secretaria = new Secretaria();
                    //Acessando os valores das colunas do resultado
                    #region Colunas
                    //ID_Secretaria, CPF, RG, Nome, Endereco, Email, Celular, Estado_Civil
                    secretaria.ID_Secretaria = DbReader.GetInt32(DbReader.GetOrdinal("ID_Secretaria"));
                    secretaria.CPF = DbReader.GetString(DbReader.GetOrdinal("CPF"));
                    secretaria.RG = DbReader.GetString(DbReader.GetOrdinal("RG"));
                    secretaria.Nome = DbReader.GetString(DbReader.GetOrdinal("Nome"));
                    secretaria.Endereco.Logradouro = DbReader.GetString(DbReader.GetOrdinal("Logradouro"));
                    secretaria.Endereco.Numero = DbReader.GetString(DbReader.GetOrdinal("Numero"));
                    secretaria.Endereco.Complemento = DbReader.GetString(DbReader.GetOrdinal("Complemento"));
                    secretaria.Endereco.Bairro = DbReader.GetString(DbReader.GetOrdinal("Bairro"));
                    secretaria.Endereco.CEP = DbReader.GetString(DbReader.GetOrdinal("CEP"));
                    secretaria.Endereco.Cidade = DbReader.GetString(DbReader.GetOrdinal("Cidade"));
                    secretaria.Endereco.UF = DbReader.GetString(DbReader.GetOrdinal("UF"));
                    secretaria.Endereco.Pais = DbReader.GetString(DbReader.GetOrdinal("Pais"));
                    secretaria.Email = DbReader.GetString(DbReader.GetOrdinal("Email"));
                    secretaria.Contato = DbReader.GetString(DbReader.GetOrdinal("Contato"));
                    secretaria.Estado_Civil = DbReader.GetString(DbReader.GetOrdinal("Estado_Civil"));
                    #endregion
                    retorno.Add(secretaria);
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

        public bool VerificarExistencia(Secretaria secretaria)
        {
            bool retorno;

            try
            {
                //Conectar ao banco
                this.abrirConexao();
                //instrução a ser executada
                string sql = "SELECT COUNT(*) FROM Secretaria WHERE ID_Secretaria = @ID_Secretaria;";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@ID_Secretaria", SqlDbType.Int);
                cmd.Parameters["ID_Secretaria"].Value = secretaria.ID_Secretaria;

                //Executando a instrução e colocando o resultado num leitor
                retorno = (Int32)cmd.ExecuteScalar() > 0;

                //Liberando memoria
                cmd.Dispose();
                //Fechar conexao
                this.fecharConexao();
            }
            catch (FaultException)
            {
                throw new FaultException("Erro ao verificar secretária.");
            }

            return retorno;
        }
    }
}
