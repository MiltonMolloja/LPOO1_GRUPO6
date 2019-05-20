using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCliente
    {

        public static void insert_cliente(Cliente cli) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionStringDB);

            SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "INSERT INTO Clientes(cli_dni,cli_nombre,cli_apellido,cli_sexo,cli_ingresos,cli_direccion,cli_telefono) values(@dni,@nombre,@apellido,@sexo,@ingreso,@direccion,@telefono)";
            cmd.CommandText = "INSERT INTO Clientes(cli_dni,cli_nombre,cli_apellido,cli_sexo,cli_fechaNacimiento,cli_ingresos,cli_direccion,cli_telefono) values(@dni,@nombre,@apellido,@sexo,@FecNac,@ingreso,@direccion,@telefono)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", cli.Cli_Dni);
            cmd.Parameters.AddWithValue("@nombre", cli.Cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", cli.Cli_Apellido);
            cmd.Parameters.AddWithValue("@sexo", cli.Cli_Sexo);
            
            cmd.Parameters.AddWithValue("@FecNac", cli.Cli_FechaNacimiento);
            
            cmd.Parameters.AddWithValue("@ingreso", cli.Cli_Ingresos);
            cmd.Parameters.AddWithValue("@direccion", cli.Cli_Direccion);
            cmd.Parameters.AddWithValue("@telefono", cli.Cli_Telefono);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
           
        }

        public static DataTable list_clientes()
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionStringDB);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT ";
            cmd.CommandText += "cli_dni as 'DNI', ";
            cmd.CommandText += "cli_nombre as 'Nombre', cli_apellido as 'Apellido', ";
            cmd.CommandText += "cli_sexo as 'Sexo', cli_fechaNacimiento as 'FechaDeNacimiento', ";
            cmd.CommandText += "cli_ingresos as 'Ingreso', cli_direccion as 'Direccion', ";
            cmd.CommandText += "cli_telefono as 'Telefono' ";
            //cmd.CommandText += " cli_sexo as 'ApellidoNombre', usu_id, U.rol_codigo ";
            cmd.CommandText += " FROM Clientes as C";
            //cmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_codigo=C.rol_codigo)";


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
