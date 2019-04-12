using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccesoDatos
{
   public class ManejadorBD
    {
        private SqlConnection ConexionABD;
        private String ConexionString;

        public ManejadorBD()
        {
            ConexionString = ConfigurationManager.ConnectionStrings["ConnectionToSQL"].ConnectionString;
            ConexionABD = new SqlConnection(ConexionString);
        }

        public SqlConnection GetConnection()
        {
            return ConexionABD;
        }

        public void CloseConnection()
        {
            if (ConexionABD != null)
            {
                if (ConexionABD.State == System.Data.ConnectionState.Open)
                {
                    ConexionABD.Close();
                }
            }
        }

    }
}
