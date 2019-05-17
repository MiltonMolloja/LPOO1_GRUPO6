using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClasesBase;

namespace Vistas
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(labelApellidoNombre.Text);
        }

        private void FrmUsuario_Load() {
            load_combo_roles();
        }

        private void load_combo_roles() {
            comboBoxRol.DisplayMember = "rol_Descripcion";
            comboBoxRol.ValueMember = "rol_Codigo";
            comboBoxRol.DataSource = TrabajarUsuario.list_roles();
        }

        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNombreDeUsuario.Text = comboBoxRol.SelectedItem.ToString();
            textBoxNombreDeUsuario.Refresh();
            textBoxContraseña.Text = comboBoxRol.SelectedItem.
        }

        private void datosDeUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            //Realiza la Conexion con la Base de Datos
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename='D:\\Documents\\01 - Proyectos From\\LPOO1_GRUPO6\\prestamosDB.mdf';Integrated Security=True;Connect Timeout=30;User Instance=True");
            //SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename='D:\\Documents\\01 - Proyectos From\\LPOO1_GRUPO6\\SistemaAlumnosDB.mdf';Integrated Security=True;Connect Timeout=30;User Instance=True");
            //Crear el Comando
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente", cn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM CLIENTES", cn);
            

            //Crear el DataReader
            SqlDataReader dr;

            //Abrir la Comexion
            cn.Open();
            //cn2.Open();

            //Cargar el DataReader con el resultado de la consulta
            dr = cmd.ExecuteReader();
            //dr = cmd2.ExecuteReader();

            //Cargar el Control (ComboBOX) con el contenido del DataReader
            while (dr.Read())
	        {
                //comboBoxRol.Items.Add(dr["ALU_Nombre"]);
                comboBoxRol.Items.Add(dr["cli_nombre"]);         

                
	        }

            // Cerrar el DataReader
            dr.Close();

            // Cerrar la Base de Datos
            cn.Close();
            //cn2.Close();
        }

        private void textBoxNombreDeUsuario_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
