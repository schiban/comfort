﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDGlobal
{
    public class BaseDadosGlobal
    {
        public static SqlConnection AbrirBaseDados(string connectionString)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            return sqlConnection;
        }

        public static DataTable ObterLista(string nomeStoreProcedure, string connectionString, out string erro)
        {
            DataTable dataTable = null;
            erro = string.Empty;
            try
            {
                SqlConnection sqlConnection = BaseDadosGlobal.AbrirBaseDados(connectionString);

                SqlCommand sqlCommand = new SqlCommand(nomeStoreProcedure, sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader dataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult);

                dataTable = new DataTable();
                dataTable.Load(dataReader);

                sqlCommand.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return dataTable;
        }
    }
}
