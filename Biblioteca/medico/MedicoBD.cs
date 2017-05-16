
using Biblioteca.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.medico
{
    public class MedicoBD : ConexaoSql, IMedico
    {
        public void Cadastrar(Medico medico)
        {
            try
            {
                //Abrindo conexão
                this.abrirConexao();

                string sql = "INSERT INTO Medico (ID_Medico, CRM, CPF, RG, Nome, Logradouro, Numero," +
                    "Complemento, Bairro, CEP, Cidade, UF, Pais, Email, Contato, Estado_Civil, Dt_Nascimento," +
                    "ID_Especialidade)" +
                    "VALUES (@ID_Medico, @CRM, @CPF, @RG, @Nome, @Logradouro, @Numero, @Complemento,"+
                    "@Bairro, @CEP, @Cidade, @UF, @Pais, @Email, @Contato, @Estado_Civil, @Dt_Nascimento," + 
                    "@ID_Especialidade);";

                //Instrução a ser excecutada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                //Recebendo os valores
                #region Parâmetros
                cmd.Parameters.Add("@ID_Medico", SqlDbType.Int);
                cmd.Parameters["@ID_Medico"].Value = medico.ID_Medico;

                cmd.Parameters.Add("@CRM", SqlDbType.VarChar);
                cmd.Parameters["@CRM"].Value = medico.CRM;

                cmd.Parameters.Add("@CPF", SqlDbType.Char);
                cmd.Parameters["@CPF"].Value = medico.CPF;

                cmd.Parameters.Add("@RG", SqlDbType.VarChar);
                cmd.Parameters["@RG"].Value = medico.RG;

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                cmd.Parameters["@Nome"].Value = medico.Nome;

                cmd.Parameters.Add("@Logradouro", SqlDbType.VarChar);
                cmd.Parameters["@Logradouro"].Value = medico.Endereco.Logradouro;

                cmd.Parameters.Add("@Numero", SqlDbType.VarChar);
                cmd.Parameters["@Numero"].Value = medico.Endereco.Numero;

                cmd.Parameters.Add("@Complemento", SqlDbType.VarChar);
                cmd.Parameters["@Complemento"].Value = medico.Endereco.Complemento;

                cmd.Parameters.Add("@Bairro", SqlDbType.VarChar);
                cmd.Parameters["@Bairro"].Value = medico.Endereco.Bairro;

                cmd.Parameters.Add("@CEP", SqlDbType.Char);
                cmd.Parameters["@CEP"].Value = medico.Endereco.CEP;

                cmd.Parameters.Add("@Cidade", SqlDbType.VarChar);
                cmd.Parameters["@Cidade"].Value = medico.Endereco.Cidade;

                cmd.Parameters.Add("@UF", SqlDbType.Char);
                cmd.Parameters["@UF"].Value = medico.Endereco.UF;

                cmd.Parameters.Add("@Pais", SqlDbType.VarChar);
                cmd.Parameters["@Pais"].Value = medico.Endereco.Pais;

                cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                cmd.Parameters["@Email"].Value = medico.Email;

                cmd.Parameters.Add("@Contato", SqlDbType.VarChar);
                cmd.Parameters["@Contato"].Value = medico.Contato;

                cmd.Parameters.Add("@Estado_Civil", SqlDbType.VarChar);
                cmd.Parameters["@Estado_Civil"].Value = medico.Estado_Civil;

                cmd.Parameters.Add("@Dt_Nascimento", SqlDbType.DateTime);
                cmd.Parameters["@Dt_Nascimento"].Value = medico.Dt_Nascimento;

                cmd.Parameters.Add("@ID_Especialidade", SqlDbType.Int);
                cmd.Parameters["@ID_Especialidade"].Value = medico.Especialidade.ID_Especialidade;
                #endregion

                //Executando a instrução
                cmd.ExecuteNonQuery();
                //Liberando memória
                cmd.Dispose();
                //Fechando conexão
                this.fecharConexao();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao cadastrar médico." + e);
            }
        }

        public void Atualizar(Medico medico)
        {
            try
            {
                //Abrindo conexão
                this.abrirConexao();

                string sql = "UPDATE Medico SET ID_Medico = @ID_Medico, CPF = @CPF, RG = @RG, Nome = @Nome, " +
                    "Logradouro = @Logradouro, Numero = @Numero, Complemento = @Complemento, Bairro = @Bairro, " +
                    "CEP = @CEP, Cidade = @Cidade, UF = @UF, Pais = @Pais, Email = @Email, Celular = @Celular, " +
                    "Estado_Civil = @Estado_Civil, ID_Especialidade = @ID_Especialidade WHERE ID_Medico = @ID_Medico;";

                //Instrução a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                //Recebendo os valores
                #region Parâmetros
                cmd.Parameters.Add("@ID_Medico", SqlDbType.Int);
                cmd.Parameters["@ID_Medico"].Value = medico.ID_Medico;

                cmd.Parameters.Add("@CPF", SqlDbType.Char);
                cmd.Parameters["@CPF"].Value = medico.CPF;

                cmd.Parameters.Add("@RG", SqlDbType.VarChar);
                cmd.Parameters["@RG"].Value = medico.RG;

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                cmd.Parameters["@Nome"].Value = medico.Nome;

                cmd.Parameters.Add("@Logradouro", SqlDbType.VarChar);
                cmd.Parameters["@Logradouro"].Value = medico.Endereco.Logradouro;

                cmd.Parameters.Add("@Numero", SqlDbType.VarChar);
                cmd.Parameters["@Numero"].Value = medico.Endereco.Numero;

                cmd.Parameters.Add("@Complemento", SqlDbType.VarChar);
                cmd.Parameters["@Complemento"].Value = medico.Endereco.Complemento;

                cmd.Parameters.Add("@Bairro", SqlDbType.VarChar);
                cmd.Parameters["@Bairro"].Value = medico.Endereco.Bairro;

                cmd.Parameters.Add("@CEP", SqlDbType.Char);
                cmd.Parameters["@CEP"].Value = medico.Endereco.CEP;

                cmd.Parameters.Add("@Cidade", SqlDbType.VarChar);
                cmd.Parameters["@Cidade"].Value = medico.Endereco.Cidade;

                cmd.Parameters.Add("@UF", SqlDbType.Char);
                cmd.Parameters["@UF"].Value = medico.Endereco.UF;

                cmd.Parameters.Add("@Pais", SqlDbType.VarChar);
                cmd.Parameters["@Pais"].Value = medico.Endereco.Pais;

                cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                cmd.Parameters["@Email"].Value = medico.Email;

                cmd.Parameters.Add("@Celular", SqlDbType.VarChar);
                cmd.Parameters["@Estado_Civil"].Value = medico.Estado_Civil;

                cmd.Parameters.Add("@ID_Especialidade", SqlDbType.Int);
                cmd.Parameters["@ID_Especialidade"].Value = medico.Especialidade.ID_Especialidade;
                #endregion

                //Executando a instrução
                cmd.ExecuteNonQuery();
                //Liberando Memória
                cmd.Dispose();
                //Fechando conexão
                this.fecharConexao();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao atualizar médico." + e);
            }

        }

        public void Remover(Medico medico)
        {
            try
            {
                //Abrindo conexão
                this.abrirConexao();
                //Instrução a ser executada
                string sql = "DELETE Medico WHERE ID_Medico = @ID_Medico;";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@ID_Medico", SqlDbType.Int);
                cmd.Parameters["@ID_Medico"].Value = medico.ID_Medico;

                //Executando instrução
                cmd.ExecuteNonQuery();
                //Liberando memória
                cmd.Dispose();
                //Fechando conexão
                this.fecharConexao();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao remover médico." + e);
            }
        }

        public List<Medico> Listar(Medico filtro)
        {
            List<Medico> retorno = new List<Medico>();
            try
            {
                //Abrindo conexão
                this.abrirConexao();
                //Instrução a ser executada
                string sql = "SELECT ID_Medico, CRM, CPF, RG, Nome, Logradouro, Numero, Complemento, Bairro, CEP, " +
                    "Cidade, UF, Pais, Email, Celular, Estado_Civil, ID_Especialidade FROM Medico WHERE TRUE"; //Por que TRUE?

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                //Se foi passado um ID_Medico válido, o mesmo entrará como critério de filtro
                #region Modos de Pesquisa
                if (filtro.ID_Medico > 0)
                {
                    sql += " AND ID_Medico = @ID_Medico";

                    cmd.Parameters.Add("@ID_Medico", SqlDbType.Int);
                    cmd.Parameters["@ID_Medico"].Value = filtro.ID_Medico;
                }
                if (string.IsNullOrWhiteSpace(filtro.CRM.Trim()))
                {
                    sql += " AND CRM = @CRM";

                    cmd.Parameters.Add("@CRM", SqlDbType.VarChar);
                    cmd.Parameters["@CRM"].Value = filtro.CRM;
                }
                //Se foi passado um CPF válido, o mesmo entrará como critério de filtro
                if (string.IsNullOrWhiteSpace(filtro.CPF.Trim()))
                /*"  Matheus Vasconcelos  " = por isso o trim. Não precisando de IsNullOrWhiteSpace,
                   /apenas de IsNullOrEmpty, mas por precaução houve a utilização*/
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
                    Medico medico = new Medico();
                    //Acessando os valores das colunas do resultado
                    #region Colunas
                    //Nome, ID_Medico, RG, Email, CRM, Complemento, CEP, Cidade, Estado_Civil, CPF,
                    //Contato, Logradouro, Numero, Bairro, UF, Pais, Dt_Nascimento, ID_Especialidade 

                    medico.Nome = DbReader.GetString(DbReader.GetOrdinal("Nome"));
                    medico.ID_Medico = DbReader.GetInt32(DbReader.GetOrdinal("ID_Medico"));
                    medico.RG = DbReader.GetString(DbReader.GetOrdinal("RG"));
                    medico.Email = DbReader.GetString(DbReader.GetOrdinal("Email"));
                    medico.CRM = DbReader.GetString(DbReader.GetOrdinal("CRM"));
                    medico.Endereco.Complemento = DbReader.GetString(DbReader.GetOrdinal("Complemento"));
                    medico.Endereco.CEP = DbReader.GetString(DbReader.GetOrdinal("CEP"));
                    medico.Endereco.Cidade = DbReader.GetString(DbReader.GetOrdinal("Cidade"));
                    medico.Estado_Civil = DbReader.GetString(DbReader.GetOrdinal("Estado_Civil"));
                    medico.CPF = DbReader.GetString(DbReader.GetOrdinal("CPF"));
                    medico.Contato = DbReader.GetString(DbReader.GetOrdinal("Celular"));
                    medico.Endereco.Logradouro = DbReader.GetString(DbReader.GetOrdinal("Logradouro"));
                    medico.Endereco.Numero = DbReader.GetString(DbReader.GetOrdinal("Numero"));
                    medico.Endereco.Bairro = DbReader.GetString(DbReader.GetOrdinal("Bairro"));
                    medico.Endereco.UF = DbReader.GetString(DbReader.GetOrdinal("UF"));
                    medico.Endereco.Pais = DbReader.GetString(DbReader.GetOrdinal("Pais"));
                    medico.Dt_Nascimento = DbReader.GetDateTime(DbReader.GetOrdinal("Dt_Nascimento")); 
                    medico.Especialidade.ID_Especialidade = DbReader.GetInt32(DbReader.GetOrdinal("ID_Especialidade"));
                    #endregion

                    retorno.Add(medico);
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

                throw new Exception("Erro ao conectar e selecionar." + e.Message);
            }
            return retorno;
        }

        public bool VerificaExistencia(Medico medico)
        {
            bool retorno;

            try
            {
                //Conectar ao banco
                this.abrirConexao();
                //Instrução a ser executada
                string sql = "SELECT COUNT(*) FROM Medico WHERE ID_Medico = @ID_Medico;";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.Add("@ID_Medico", SqlDbType.Int);
                cmd.Parameters["@ID_Medico"].Value = medico.ID_Medico;

                //Executando a instrução e colocando o resultado em um leitor
                retorno = (Int32)cmd.ExecuteScalar() > 0;

                //Liberando memória
                cmd.Dispose();
                //Fechar conexão
                this.fecharConexao();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao verificar médico." + e);
            }
            return retorno;
        }
    }
}
