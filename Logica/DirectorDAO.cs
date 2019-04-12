using System;
using AccesoDatos;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class DirectorDAO
    {
        public Director AgregarDirector(String usuario, String contraseña)
        {
            ManejadorBD manejadorBD = new ManejadorBD();
            using (SqlConnection connection = manejadorBD.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("ServicioSocial.newDirector", connection))
                {
                    command.Parameters["@Usuario"].Value = usuario;
                    command.Parameters["@Contraseña"].Value = contraseña;
                }
            }
                return null;
        }
    }
}
