using System;
using AccesoDatos;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class EncargadoDAO
    {
        public Encargado AgregarEncargado(String nombre, String cargo, String telefono, String email)
        {
            ManejadorBD manejadorBD = new ManejadorBD();
            using (SqlConnection connection = manejadorBD.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("ServicioSocial.newEncargdo", connection))
                {
                    command.Parameters["@Nombre"].Value = nombre;
                    command.Parameters["@Cargo"].Value = cargo;
                    command.Parameters["@Telefono"].Value = telefono;
                    command.Parameters["@Email"].Value = email;
                }
            }
            return null;
        }
    }
}
