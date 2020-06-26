using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LocadoraAPI.Models
{
    public class Conexao
    {
        SqlConnection cnn = new SqlConnection();

        private string stringDeConexao
        {
            get
            {
                ConnectionStringSettings conn = System.Configuration.ConfigurationManager.ConnectionStrings["Locadora"];
                if (conn != null)
                    return conn.ConnectionString;
                else
                    return string.Empty;
            }
        }

        public Conexao()
        {
            cnn = new SqlConnection(stringDeConexao);
        }

        // Método conectar
        public SqlConnection Conectar()
        {
            if (cnn.State == System.Data.ConnectionState.Closed)
            {
                cnn.Open();
            }

            return cnn;
        }


        // Método desconectar
        public void Desconectar()
        {
            if (cnn.State == System.Data.ConnectionState.Open)
            {
                cnn.Close();
            }
        }
    }
}