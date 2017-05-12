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
    public class MedicoBD : ConexaoSql, IMedico
    {
        public void Cadastrar(Medico medico)
        {
            try
            {
                //Abrindo conexão
                this.abrirConexao();

                string sql = "INSERT INTO Medico (ID_Medico, CRM, CPF, RG, Nome, Endereco, Email, Celular, " +
                    "Estado_Civil, ID_Especialidade" +
                    " VALUES (@ID_Medico, @CRM, @CPF, @RG, @Nome, @Endereco, @Email, @Celular, " +
                    "@Estado_Civil, @ID_Especialidade);";

                //Instrução a ser excecutada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                //Recebendo os valores
                #region Parâmetros
                cmd.Parameters.Add("@ID_Medico", SqlDbType.Int);
                cmd.Parameters["@ID_Medico"].Value = medico.ID_Medico;

                cmd.Parameters.Add("@CRM", SqlDbType.VarChar);
                cmd.Parameters["@CRM"].Value = medico.CRM;

                cmd.Parameters.Add("@CPF", SqlDbType.VarChar);
                cmd.Parameters["@CPF"].Value = medico.CPF;

                cmd.Parameters.Add("@RG", SqlDbType.VarChar);
                cmd.Parameters["@RG"].Value = medico.RG;

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                cmd.Parameters["@Nome"].Value = medico.Nome;

                cmd.Parameters.Add("@Endereco", SqlDbType.VarChar);
                cmd.Parameters["@Endereco"].Value = medico.Endereco;

                cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                cmd.Parameters["@Email"].Value = medico.Email;

                cmd.Parameters.Add("@Celular", SqlDbType.VarChar);
                cmd.Parameters["@Celular"].Value = medico.Contato;

                cmd.Parameters.Add("@Estado_Civil", SqlDbType.VarChar);
                cmd.Parameters["@Estado_Civil"].Value = medico.Estado_Civil;

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
                    "Endereco = @Endereco, Email = @Email, Celular = @Celular, Estado_Civil = @Estado_Civil " +
                    "ID_Especialidade = @ID_Especialidade WHERE ID_Medico = @ID_Medico;";

                //Instrução a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                //Recebendo os valores
                #region Parâmetros
                cmd.Parameters.Add("@ID_Medico", SqlDbType.Int);
                cmd.Parameters["@ID_Medico"].Value = medico.ID_Medico;

                cmd.Parameters.Add("@CPF", SqlDbType.VarChar);
                cmd.Parameters["@CPF"].Value = medico.CPF;

                cmd.Parameters.Add("@RG", SqlDbType.VarChar);
                cmd.Parameters["@RG"].Value = medico.RG;

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                cmd.Parameters["@Nome"].Value = medico.Nome;

                cmd.Parameters.Add("@Endereco", SqlDbType.VarChar);
                cmd.Parameters["@Endereco"].Value = medico.Endereco;

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

            new MedicoBD().Atualizar(medico);
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
                string sql = "SELECT ID_Medico, CRM, CPF, RG, Nome, Endereco, Email, Celular, Estado_Civil, ID_Especialidade " +
                    "FROM Medico WHERE TRUE"; //Por que TRUE?

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
                    //ID_Medico, CRM, CPF, RG, Nome, Endereco, Email, Celular, Estado_Civil, ID_Especialidade
                    medico.ID_Medico = DbReader.GetInt32(DbReader.GetOrdinal("ID_Medico"));
                    medico.CRM = DbReader.GetString(DbReader.GetOrdinal("CRM"));
                    medico.CPF = DbReader.GetString(DbReader.GetOrdinal("CPF"));
                    medico.RG = DbReader.GetString(DbReader.GetOrdinal("RG"));
                    medico.Nome = DbReader.GetString(DbReader.GetOrdinal("Nome"));
                    //medico.Endereco = DbReader.GetString(DbReader.GetOrdinal("Endereco"));
                    medico.Email = DbReader.GetString(DbReader.GetOrdinal("Email"));
                    medico.Contato = DbReader.GetString(DbReader.GetOrdinal("Celular"));
                    medico.Estado_Civil = DbReader.GetString(DbReader.GetOrdinal("Estado_Civil"));
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
