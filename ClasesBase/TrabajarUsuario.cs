using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuario
    {
        public static DataTable list_roles() {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecutar la Consutal
            SqlDataAdapter da = new SqlDataAdapter(cmd); 

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        } 
    }
}
