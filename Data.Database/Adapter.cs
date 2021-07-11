using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace Data.Database
{
    public class Adapter
    {
        //Clave por defecto a utlizar para la cadena de conexion
        private const string consKeyDefaultCnnString = "ConnStringLocal";
        private static string connString;
        protected SqlConnection sqlConn;

        protected void OpenConnection()
        {
            connString = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
            sqlConn = new SqlConnection(connString);
            sqlConn.Open();
        }

        protected void CloseConnection()
        {
            sqlConn.Close();
            sqlConn = null;
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }
}
