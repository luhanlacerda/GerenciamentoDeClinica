using ClinicaServiceLibrary.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaServiceLibrary.consulta
{
    public class ConsultaBD : ConexaoSql, IConsulta
    {
        

        public void Cadastrar(Consulta consulta)
        {
            try
            {
                //Abrindo conexao
                this.abrirConexao();
                //Instrucao a ser executanda
                string sql = "INSERT INTO Consulta (Horario, Duracao, ID_Medico, ID_Paciente, ID_Secretaria, ID_Estado)" +
                    "VALUES (@Horario, @Duracao, @ID_Medico, @ID_Paciente, @ID_Secretaria, @ID_Estado)";

                SqlCommand scm = new SqlCommand (sql, sqlConn);

                //Recebendo os valores
                #region  Parâmetros 
                scm.Parameters.Add("@Horario", SqlDbType.DateTime);
                scm.Parameters["@Horario"].Value = consulta.Horario;

                scm.Parameters.Add("@Duracao", SqlDbType.Int);
                scm.Parameters["@Duracao"].Value = consulta.Duracao;

                scm.Parameters.Add("@ID_Medico", SqlDbType.Int);
                scm.Parameters["@ID_Medico"].Value = consulta.Medico.ID_Medico;

                scm.Parameters.Add("@ID_Paciente", SqlDbType.Int);
                scm.Parameters["@ID_Paciente"].Value = consulta.Paciente.ID_Paciente;

                scm.Parameters.Add("@ID_Secretaria", SqlDbType.Int);
                scm.Parameters["@ID_Secretaria"].Value = consulta.Secretaria.ID_Secretaria;

                scm.Parameters.Add("@ID_Estado", SqlDbType.Int);
                scm.Parameters["@ID_Estado"].Value = consulta.Estado.ID_Estado;
                #endregion
                //Executando instrucao
                scm.ExecuteNonQuery();
                //Liberando memoria
                scm.Dispose();
                //Fechando conexao
                this.fecharConexao();
            }
            catch (FaultException e)
            {
                throw new FaultException("Erro ao cadastrar consulta." + e);
            }
        }

        public void Atualizar(Consulta consulta)
        {
            try
            {
                //Abrindo conexao
                this.abrirConexao();
                //Instrucao a ser executada
                string sql = "UPDATE Consulta SET Horario = @Horario, Duracao = @Duracao, Observações = @Observações, Receita = @Receita, " +
                    " ID_Medico = @ID_Medico, ID_Paciente = @ID_Paciente, ID_Secretaria = @ID_Secretaria, ID_Estado = @ID_Estado WHERE ID_Consulta = @ID_Consulta)";

                SqlCommand scm = new SqlCommand (sql, sqlConn);

                #region  Parâmetros 

                scm.Parameters.Add("@ID_Consulta", SqlDbType.Int);
                scm.Parameters["@ID_Consulta"].Value = consulta.Estado.ID_Estado;

                scm.Parameters.Add("@Horario", SqlDbType.DateTime);
                scm.Parameters["@Horario"].Value = consulta.Horario;

                scm.Parameters.Add("@Duracao", SqlDbType.Int);
                scm.Parameters["@Duracao"].Value = consulta.Duracao;

                scm.Parameters.Add("@Observacoes", SqlDbType.VarChar);
                scm.Parameters["@Observacoes"].Value = consulta.Observacoes;

                scm.Parameters.Add("@Receita", SqlDbType.VarChar);
                scm.Parameters["@Receita"].Value = consulta.Receita;

                scm.Parameters.Add("@ID_Medico", SqlDbType.Int);
                scm.Parameters["@ID_Medico"].Value = consulta.Medico.ID_Medico;

                scm.Parameters.Add("@ID_Paciente", SqlDbType.Int);
                scm.Parameters["@ID_Paciente"].Value = consulta.Paciente.ID_Paciente;

                scm.Parameters.Add("@ID_Secretaria", SqlDbType.Int);
                scm.Parameters["@ID_Secretaria"].Value = consulta.Secretaria.ID_Secretaria;

                scm.Parameters.Add("@ID_Estado", SqlDbType.Int);
                scm.Parameters["@ID_Estado"].Value = consulta.Estado.ID_Estado;
                #endregion
                //Executando instruçao
                scm.ExecuteNonQuery();
                //Liberando memoria
                scm.Dispose();
                //Fechando conexao 
                this.fecharConexao();
            }
            catch (FaultException)
            {
                throw new FaultException("Erro ao atualizar consulta.");
            }
        }


        public void Remover(Consulta consulta)
        {
            try
            {
                //Abrindo conexao
                this.abrirConexao();
                //Instrucao a ser executada
                string sql = "DELETE FROM Consulta WHERE ID_Consulta = @ID_Consulta";

                SqlCommand scm = new SqlCommand(sql, sqlConn);

                scm.Parameters.Add("@ID_Consulta", SqlDbType.Int);
                scm.Parameters["@ID_Consulta"].Value = consulta.ID_Consulta;

                //Executando instruçao
                scm.ExecuteNonQuery();
                //Liberando memoria
                scm.Dispose();
                //Fechando conexao
                this.fecharConexao();
            }
            catch (FaultException e)
            {
                throw new FaultException("Erro ao remover consulta." + e);
            }
        }


        public List<Consulta> Listar(Consulta filtro)
        {

            List<Consulta> retorno = new List<Consulta>();

            try
            {
                //Conectar ao banco
                this.abrirConexao();
                //Instruçao a ser executada
                string sql = "SELECT Horario, Duracao, Observações, Receita, ID_Consulta, ID_Medico, ID_Paciente, " +
                    " ID_Secretaria, ID_Estado WHERE 1=1";

                SqlCommand scm = new SqlCommand(sql, sqlConn);
                //Se foi passado um ID valido, o mesmo entrara como criterio de filtro.
                #region Modos de pesquisas;
                //Filtro por ID_Consulta
                if (filtro.ID_Consulta > 0)
                {
                    sql += " AND ID_Consulta = @ID_Consulta";

                    scm.Parameters.Add("@ID_Consulta", SqlDbType.Int);
                    scm.Parameters["@ID_Consulta"].Value = filtro.ID_Consulta;
                }

                //Filtro por ID_Medico
                if (filtro.Medico.ID_Medico > 0)
                {
                    sql += " AND ID_Medico = @ID_Medico";

                    scm.Parameters.Add("@ID_Medico", SqlDbType.Int);
                    scm.Parameters["@ID_Medico"].Value = filtro.Medico.ID_Medico;
                }

                //Filtro por ID_Secretaria
                if (filtro.Secretaria.ID_Secretaria > 0)
                {
                    sql += " AND ID_Secretaria = @ID_Secretaria";

                    scm.Parameters.Add("@ID_Secretaria", SqlDbType.Int);
                    scm.Parameters["@ID_Secretaria"].Value = filtro.Secretaria.ID_Secretaria;
                }

                #endregion

                SqlDataReader DbReader = scm.ExecuteReader();

                while (DbReader.Read())
                {
                    Consulta consulta = new Consulta();
                    //Acessando os valores das colunas do resultado
                    #region Columns
                    //Horario, Duracao, Observacoes, Descricao, ID_Receita, ID_Medico, ID_Paciente,
                    //ID_Secretaria

                    consulta.Horario = DbReader.GetDateTime(DbReader.GetOrdinal("Horario"));
                    consulta.Duracao = DbReader.GetInt32(DbReader.GetOrdinal("Duracao"));
                    consulta.Observacoes = DbReader.GetString(DbReader.GetOrdinal("Observacoes"));
                    consulta.Receita = DbReader.GetString(DbReader.GetOrdinal("Receita"));
                    consulta.ID_Consulta = DbReader.GetInt32(DbReader.GetOrdinal("ID_Consulta"));
                    consulta.Medico.ID_Medico = DbReader.GetInt32(DbReader.GetOrdinal("ID_Medico"));
                    consulta.Paciente.ID_Paciente = DbReader.GetInt32(DbReader.GetOrdinal("ID_Paciente"));
                    consulta.Secretaria.ID_Secretaria = DbReader.GetInt32(DbReader.GetOrdinal("ID_Secretaria"));
                    consulta.Estado.ID_Estado = DbReader.GetInt32(DbReader.GetOrdinal("ID_Estado"));

                    retorno.Add(consulta);

                    #endregion
                }
                //Fechando leitor
                DbReader.Close();
                //Liberando memoria
                scm.Dispose();
                //Fechar conexao
                this.fecharConexao();
            }
            catch (FaultException e)
            {
                throw new FaultException("Erro ao conectar e listar" + e);
            }

            return retorno;
        }



        public bool VerificarExistencia(Consulta consulta)
        {
            bool retorno;

            try
            {
                //Conectar ao banco
                this.abrirConexao();
                //Instrução a ser executada
                string sql = "SELECT COUNT(*) FROM Consulta WHERE ID_Consulta = @ID_Consulta";

                SqlCommand scm = new SqlCommand(sql, sqlConn);

                scm.Parameters.Add("@ID_Consulta", SqlDbType.Int);
                scm.Parameters["@ID_Consulta"].Value = consulta.ID_Consulta;

                //Executando uma instrução e colocando o resultado em um leitor
                retorno = (Int32)scm.ExecuteScalar() > 0;
                //Liberando memoria
                scm.Dispose();
                //Fechando conexao
                this.fecharConexao();


            }
            catch (FaultException e)
            {
                throw new FaultException("Erro ao verificar médico." + e);
            }

            return retorno;
        }
    }

}
