using BDGlobal;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{

    #region Metodos
    public class Encomenda
    {
        public bool Gravar(string proforma, DateTime dataCompra, string nomeCliente, string moradaCliente, int contatoCliente, string nomeProduto, float precoProduto, out string erro)
        {
            erro = string.Empty;

            bool resultado = Encomenda.GravarEncomenda(proforma, dataCompra, nomeCliente, moradaCliente, contatoCliente, nomeProduto, precoProduto, out erro);

            return resultado;
        }

        public static bool GravarEncomenda(string proforma, DateTime dataCompra, string nomeCliente, string moradaCliente, int contatoCliente, string nomeProduto, float precoProduto, out string erro)
        {
            bool resultado = false;
            erro = string.Empty;

            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("Gravar_ComFort", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = new SqlParameter("Proforma", System.Data.SqlDbType.NVarChar, 10);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = proforma;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter("DataCompra", System.Data.SqlDbType.DateTime);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = dataCompra;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter("NomeCliente", System.Data.SqlDbType.NVarChar, 50);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = nomeCliente;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter("MoradaCliente", System.Data.SqlDbType.NVarChar, 50);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = moradaCliente;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter("ContatoCliente", System.Data.SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = contatoCliente;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter("NomeProduto", System.Data.SqlDbType.NVarChar, 20);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = nomeProduto;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter("PrecoProduto", System.Data.SqlDbType.Float);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = precoProduto;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                resultado = true;
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return resultado;
        }

        public static bool EliminarEncomenda(string proforma, out string erro)
        {
            bool resultado = false;
            erro = string.Empty;

            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("Eliminar_ComFort", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = new SqlParameter("Proforma", System.Data.SqlDbType.NVarChar, 10);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = proforma;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                resultado = true;
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return resultado;
        }

        public static DataTable ObterLista(out string erro)
        {
            DataTable dataTable = BaseDadosGlobal.ObterLista("Listar_ComFort", Properties.Settings.Default.ConnectionString, out erro);

            return dataTable;
        }

        public static bool ObterEncomenda(string proforma, ref DateTime dataCompra, ref string nomeCliente, ref string moradaCliente, ref int contatoCliente,
                                                                                   ref string nomeProduto, ref float precoProduto, out string erro)
        {
            bool resultado = false;
            erro = string.Empty;

            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("Obter_ComFort", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = new SqlParameter("Proforma", System.Data.SqlDbType.NVarChar, 10);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = proforma;

                sqlCommand.Parameters.Add(sqlParameter);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    if (!sqlDataReader.IsDBNull(1))
                    {
                        dataCompra = sqlDataReader.GetDateTime(1);
                    }
                    if (!sqlDataReader.IsDBNull(2))
                    {
                        nomeCliente = sqlDataReader.GetString(2);
                    }
                    if (!sqlDataReader.IsDBNull(3))
                    {
                        moradaCliente = sqlDataReader.GetString(3);
                    }
                    if (!sqlDataReader.IsDBNull(4))
                    {
                        contatoCliente = sqlDataReader.GetInt32(4);
                    }
                    if (!sqlDataReader.IsDBNull(5))
                    {
                        nomeProduto = sqlDataReader.GetString(5);
                    }
                    if (!sqlDataReader.IsDBNull(6))
                    {
                        precoProduto = sqlDataReader.GetFloat(6);
                    }

                    resultado = true;
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return resultado;
        }
    }

    #endregion

}
