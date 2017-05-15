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
    public class PacienteBD : ConexaoSql, IPaciente
    {


        public void Cadastrar(Paciente paciente)
        {
            try
            {
                //Abrir Conexao
                this.abrirConexao();

                string sql = "INSERT INTO Paciente (ID_Paciente, Nome, CPF, Contato, CEP, RG, Email," +
                    "Logradouro,Numero, Complemento, Bairro, Cidade, UF, Pais, Estado_Civil," +
                    "Dt_Nascimento, ID_Convenio)" +
                    "VALUES (@ID_Paciente, @Nome, @CPF, @Contato, @CEP, @RG, @Email, @Logradouro," +
                    "@Numero, @Complemento, @Bairro, @Cidade, @UF, @Pais, @Estado_Civil," +
                    "@Dt_Nascimento, @ID_Convenio)";

                SqlCommand scm = new SqlCommand(sql, this.sqlConn);

                #region Parâmetros
                scm.Parameters.Add("@ID_Paciente", SqlDbType.Int);
                scm.Parameters["@ID_Paciente"].Value = paciente.ID_Paciente;

                scm.Parameters.Add("@Nome", SqlDbType.VarChar);
                scm.Parameters["@Nome"].Value = paciente.Nome;

                scm.Parameters.Add("@CPF", SqlDbType.Char);
                scm.Parameters["@CPF"].Value = paciente.CPF;

                scm.Parameters.Add("@Contato", SqlDbType.VarChar);
                scm.Parameters["@Contato"].Value = paciente.Contato;

                scm.Parameters.Add("@CEP", SqlDbType.Char);
                scm.Parameters["@CEP"].Value = paciente.Endereco.CEP;

                scm.Parameters.Add("@RG", SqlDbType.VarChar);
                scm.Parameters["@RG"].Value = paciente.RG;

                scm.Parameters.Add("@Email", SqlDbType.VarChar);
                scm.Parameters["@Email"].Value = paciente.Email;

                scm.Parameters.Add("@Logradouro", SqlDbType.VarChar);
                scm.Parameters["@Logradouro"].Value = paciente.Endereco.Logradouro;

                scm.Parameters.Add("@Numero", SqlDbType.VarChar);
                scm.Parameters["@Numero"].Value = paciente.Endereco.Numero;

                scm.Parameters.Add("@Complemento", SqlDbType.VarChar);
                scm.Parameters["@Complemento"].Value = paciente.Endereco.Complemento;

                scm.Parameters.Add("@Bairro", SqlDbType.VarChar);
                scm.Parameters["@Bairro"].Value = paciente.Endereco.Bairro;

                scm.Parameters.Add("@Cidade", SqlDbType.VarChar);
                scm.Parameters["@Cidade"].Value = paciente.Endereco.Cidade;

                scm.Parameters.Add("@UF", SqlDbType.Char);
                scm.Parameters["@UF"].Value = paciente.Endereco.UF;

                scm.Parameters.Add("@Pais", SqlDbType.VarChar);
                scm.Parameters["@Pais"].Value = paciente.Endereco.Pais;

                scm.Parameters.Add("@Estado_Civil", SqlDbType.VarChar);
                scm.Parameters["@Estado_Civil"].Value = paciente.Estado_Civil;

                scm.Parameters.Add("@Dt_Nascimento", SqlDbType.DateTime);
                scm.Parameters["@Dt_Nascimento"].Value = paciente.Dt_Nascimento;

                scm.Parameters.Add("@ID_Convenio", SqlDbType.Int);
                scm.Parameters["@ID_Convenio"].Value = paciente.Convenio.ID_Convenio;
                #endregion

                //Executando a instrução
                scm.ExecuteNonQuery();
                //Liberando memória
                scm.Dispose();
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

                string sql = "UPDATE Paciente SET Nome = @Nome, CPF = @CPF, Contato = @Contato, CEP = @CEP," +
                    "RG = @RG, Email = @Email, Logradouro = @Logradouro, Numero = @Numero," +
                    "Complemento = @Complemento, Bairro = @Bairro, Cidade = @Cidade, UF = @UF" +
                    "Pais = @Pais, ID_Paciente = @ID_Paciente, Estado_Civil = @Estado_Civil," +
                    "Dt_Nascimento = @Dt_Nascimento, ID_Convenio = @ID_Convenio" +
                    "WHERE ID_Paciente = @ID_Paciente;";

                //Instrução a ser executada
                SqlCommand scm = new SqlCommand(sql, this.sqlConn);

                //Recebendo os valores
                #region Parâmetros
                scm.Parameters.Add("@Nome", SqlDbType.VarChar);
                scm.Parameters["@Nome"].Value = paciente.Nome;

                scm.Parameters.Add("@CPF", SqlDbType.Char);
                scm.Parameters["@CPF"].Value = paciente.CPF;

                scm.Parameters.Add("@Contato", SqlDbType.VarChar);
                scm.Parameters["@Contato"].Value = paciente.Nome;

                scm.Parameters.Add("@CEP", SqlDbType.Char);
                scm.Parameters["@CEP"].Value = paciente.Endereco.CEP;

                scm.Parameters.Add("@RG", SqlDbType.VarChar);
                scm.Parameters["@RG"].Value = paciente.RG;

                scm.Parameters.Add("@Email", SqlDbType.VarChar);
                scm.Parameters["@Email"].Value = paciente.Email;

                scm.Parameters.Add("@Logradouro", SqlDbType.VarChar);
                scm.Parameters["@Logradouro"].Value = paciente.Endereco.Logradouro;

                scm.Parameters.Add("@Numero", SqlDbType.VarChar);
                scm.Parameters["@Numero"].Value = paciente.Endereco.Numero;

                scm.Parameters.Add("@Complemento", SqlDbType.VarChar);
                scm.Parameters["@Complemento"].Value = paciente.Endereco.Complemento;

                scm.Parameters.Add("@Bairro", SqlDbType.VarChar);
                scm.Parameters["@Bairro"].Value = paciente.Endereco.Bairro;

                scm.Parameters.Add("@Cidade", SqlDbType.VarChar);
                scm.Parameters["@Cidade"].Value = paciente.Endereco.Cidade;

                scm.Parameters.Add("@UF", SqlDbType.Char);
                scm.Parameters["@UF"].Value = paciente.Endereco.UF;

                scm.Parameters.Add("@Pais", SqlDbType.VarChar);
                scm.Parameters["@Pais"].Value = paciente.Endereco.Pais;

                scm.Parameters.Add("@ID_Paciente", SqlDbType.Int);
                scm.Parameters["@ID_Paciente"].Value = paciente.ID_Paciente;

                scm.Parameters.Add("@Estado_Civil", SqlDbType.VarChar);
                scm.Parameters["@Estado_Civil"].Value = paciente.Estado_Civil;

                scm.Parameters.Add("@Dt_Nascimento", SqlDbType.DateTime);
                scm.Parameters["@Dt_Nascimento"].Value = paciente.Dt_Nascimento;

                scm.Parameters.Add("@ID_Convenio", SqlDbType.Int);
                scm.Parameters["@ID_Convenio"].Value = paciente.Convenio.ID_Convenio;
                #endregion

                //Executando a instrução
                scm.ExecuteNonQuery();
                //Liberando memória
                scm.Dispose();
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

                SqlCommand scm = new SqlCommand(sql, this.sqlConn);

                scm.Parameters.Add("@ID_Paciente", SqlDbType.Int);
                scm.Parameters["@ID_Paciente"].Value = paciente.ID_Paciente;

                //Executando instrução
                scm.ExecuteNonQuery();
                //Liberando memória
                scm.Dispose();
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
                string sql = "SELECT Nome, CPF, Contato, CEP, RG, Email, Logradouro, Numero," +
                    "Complemento, Bairro, Cidade, UF, Pais, ID_Paciente, Estado_Civil, Dt_Nascimento," +
                    "ID_Convenio FROM Paciente WHERE TRUE";

                SqlCommand scm = new SqlCommand(sql, sqlConn);

                #region Modos de Pesquisa
                if (filtro.ID_Paciente > 0)
                {
                    sql += " AND ID_Paciente = @ID_Paciente";

                    scm.Parameters.Add("@ID_Paciente", SqlDbType.Int);
                    scm.Parameters["@ID_Paciente"].Value = filtro.ID_Paciente;
                }

                //Se foi passado um CPF válido, o mesmo entrará como critério de filtro
                if (string.IsNullOrWhiteSpace(filtro.CPF.Trim()))
                {
                    sql += " AND CPF = @CPF";

                    scm.Parameters.Add("@CPF", SqlDbType.VarChar);
                    scm.Parameters["@CPF"].Value = filtro.CPF;
                }
                if (string.IsNullOrWhiteSpace(filtro.Nome.Trim()))
                {
                    sql += " AND Nome = @Nome";

                    scm.Parameters.Add("@Nome", SqlDbType.VarChar);
                    scm.Parameters["@Nome"].Value = filtro.Nome;
                }
                #endregion

                //Executando a instrução e colocando o resultado em um leitor
                SqlDataReader DbReader = scm.ExecuteReader();
                //Lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Paciente paciente = new Paciente();
                    /*Nome, CPF, Contato, CEP, RG, Email, Logradouro, Numero, Complemento, Bairro,
                    Cidade, UF, Pais, ID_Paciente, Estado_Civil, Dt_Nascimento, ID_Convenio;*/
                    #region Colunas

                    paciente.Nome = DbReader.GetString(DbReader.GetOrdinal("Nome"));
                    paciente.CPF = DbReader.GetString(DbReader.GetOrdinal("CPF"));
                    paciente.Contato = DbReader.GetString(DbReader.GetOrdinal("Contato"));
                    paciente.Endereco.CEP = DbReader.GetString(DbReader.GetOrdinal("CEP"));
                    paciente.RG = DbReader.GetString(DbReader.GetOrdinal("RG"));
                    paciente.Email = DbReader.GetString(DbReader.GetOrdinal("Email"));
                    paciente.Endereco.Logradouro = DbReader.GetString(DbReader.GetOrdinal("Logradouro"));
                    paciente.Endereco.Numero = DbReader.GetString(DbReader.GetOrdinal("Numero"));
                    paciente.Endereco.Complemento = DbReader.GetString(DbReader.GetOrdinal("Complemento"));
                    paciente.Endereco.Bairro = DbReader.GetString(DbReader.GetOrdinal("Bairro"));
                    paciente.Endereco.Cidade = DbReader.GetString(DbReader.GetOrdinal("Cidade"));
                    paciente.Endereco.UF = DbReader.GetString(DbReader.GetOrdinal("UF"));
                    paciente.Endereco.Pais = DbReader.GetString(DbReader.GetOrdinal("Pais"));
                    paciente.ID_Paciente = DbReader.GetInt32(DbReader.GetOrdinal("ID_Paciente"));
                    paciente.Estado_Civil = DbReader.GetString(DbReader.GetOrdinal("Estado_Civil"));
                    paciente.Dt_Nascimento = DbReader.GetDateTime(DbReader.GetOrdinal("Dt_Nascimento"));
                    paciente.Convenio.ID_Convenio = DbReader.GetInt32(DbReader.GetOrdinal("ID_Convenio"));

                    #endregion

                    retorno.Add(paciente);
                }

                //Fechando leitor
                DbReader.Close();
                //Liberando memória
                scm.Dispose();
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

                SqlCommand scm = new SqlCommand(sql, this.sqlConn);

                scm.Parameters.Add("@ID_Paciente", SqlDbType.Int);
                scm.Parameters["@ID_Paciente"].Value = paciente.ID_Paciente;

                //Executando a instrução e colocando o resultado em um leitor
                retorno = (Int32)scm.ExecuteScalar() > 0;

                //Liberando memória
                scm.Dispose();
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
