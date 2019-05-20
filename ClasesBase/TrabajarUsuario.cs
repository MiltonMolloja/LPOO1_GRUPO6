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

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionStringDB);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecutar la Consutal
            SqlDataAdapter da = new SqlDataAdapter(cmd); 

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void insert_usuario(Usuario user) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionStringDB);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuarios(rol_codigo,usu_nombreUsuario,usu_contraseña,usu_apellidonombre) values(@rol,@nomUsu,@pass,@apeynom)";
            //cmd.CommandText = "INSERT INTO Usuario(rol_codigo,usu_nombreUsuario,usu_contraseña,usu_apellidonombre) values(@rol,@nomUsu,@pass,@apeynom)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@rol",user.Rol_Codigo);
            cmd.Parameters.AddWithValue("@nomUsu", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pass", user.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@apeynom", user.Usu_ApellidoNombre);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
           
        }

        public static DataTable list_usuarios() {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionStringDB);

            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " rol_descripcion as 'Rol', ";
            cmd.CommandText += " usu_nombreUsuario as 'Usuario', usu_contraseña as 'Contraseña', ";
            cmd.CommandText += " usu_apellidonombre as 'ApellidoNombre', usu_id, U.rol_codigo ";
            cmd.CommandText += " FROM Usuarios as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_codigo=U.rol_codigo)";


            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            
            //Ejecutar la Consutal
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable search_usuarios(string sPattern)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionStringDB);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT ";
            cmd.CommandText += " rol_descripcion as 'Rol', ";
            cmd.CommandText += " usu_nombreUsuario as 'Usuario', usu_contraseña as 'Contraseña', ";
            cmd.CommandText += " usu_apellidonombre as 'ApellidoNombre', usu_id, U.rol_codigo ";
            cmd.CommandText += " FROM Usuarios as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_codigo=U.rol_codigo)";

            cmd.CommandText += " WHERE";
            cmd.CommandText += " usu_nombreUsuario LIKE @pattern ";


            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%"+sPattern+"%");


            //Ejecutar la Consutal
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
