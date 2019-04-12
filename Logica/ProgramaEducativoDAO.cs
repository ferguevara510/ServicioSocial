using System;
using AccesoDatos;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class ProgramaEducativoDAO
    {
        public ProgramaEducativo AgregarProgramaEducativo(String nombre, String area, String modalidad, String region, 
            int creditosTotales)
        {
            ManejadorBD manejadorBD = new ManejadorBD();
            using (SqlConnection connection = manejadorBD.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("ServicioSocial.newProgramaEducativo", connection))
                {
                    command.Parameters["@Nombre"].Value = nombre;
                    command.Parameters["@Area"].Value = area;
                    command.Parameters["@Modalidad"].Value = modalidad;
                    command.Parameters["@Region"].Value = region;
                    command.Parameters["@CreditosTotales"].Value = creditosTotales;
                }
            }
            return null;
        }

        public ProgramaEducativo consultarProgramaEducativo()
        {
            Contact contact = new Contact();
            DBManager dBManager = new DBManager();
            using (SqlConnection connection = dBManager.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("Select * from users where userid=@contactID", connection))
                {

                    command.Parameters.Add(new SqlParameter("contactID", userID));
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        contact.FirstName = reader["firstName"].ToString();
                        contact.LastName = reader["lastname"].ToString();
                        contact.UserID = reader["userid"].ToString();
                    }
                }
                dBManager.CloseConnection();

            }
            return contact;

        }
    }

        


}
