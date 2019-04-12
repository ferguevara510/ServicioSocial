using System;
using AccesoDatos;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class DependenciaDAO
    {
        public Dependencia AgregarDependencia(String nombre, String sector, String estado, String ciudad, 
            String colonia, String calle, String numeroInterior, String numeroExterior, String codigoPostal, 
            String telefono, String correoElectronico)
        {
            ManejadorBD manejadorBD = new ManejadorBD();
            using (SqlConnection connection = manejadorBD.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("ServicioSocial.newDependencias", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters["@Nombre"].Value = nombre;
                    command.Parameters["@Sector"].Value = sector;
                    command.Parameters["@Estado"].Value = estado;
                    command.Parameters["@Ciudad"].Value = ciudad;
                    command.Parameters["@Colonia"].Value = colonia;
                    command.Parameters["@Calle"].Value = calle;
                    command.Parameters["@NumeroInterior"].Value = numeroInterior;
                    command.Parameters["@NumeroExterior"].Value = numeroExterior;
                    command.Parameters["@CodigoPostal"].Value = codigoPostal;
                    command.Parameters["@Telefono"].Value = telefono;
                    command.Parameters["@CorreoElectronico"].Value = correoElectronico;

                    command.ExecuteNonQuery();

                }
            }
            return null;
        }
    }
}
