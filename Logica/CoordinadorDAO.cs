using System;
using AccesoDatos;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class CoordinadorDAO
    {
        public Coordinador AgregarCoordinador(String nombre, String numeroDePersonal, String carrera, String contraseña, String horario, String telefono, String ubicacion)
        {
            ManejadorBD manejadorBD = new ManejadorBD();
            using (SqlConnection connection = manejadorBD.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("ServicioSocial.newCoordinador", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters["@Nombre"].Value = nombre;
                    command.Parameters["@NumeroPersonal"].Value = numeroDePersonal;
                    command.Parameters["@Contraseña"].Value = contraseña;
                    command.Parameters["@Horario"].Value = horario;
                    command.Parameters["@Telefono"].Value = telefono;
                    command.Parameters["@Ubiacion"].Value = ubicacion;

                    command.ExecuteNonQuery();

                }
            }
                return null;
        }
    }
}
