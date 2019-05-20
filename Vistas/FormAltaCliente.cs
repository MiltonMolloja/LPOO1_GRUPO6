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
    public partial class FormAltaCliente : Form
    {
        public FormAltaCliente()
        {
            InitializeComponent();
        }

      

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            Cliente oCliente = new Cliente();


            oCliente.Cli_Dni = txtDNICliente.Text;
            oCliente.Cli_Nombre = txtNombreCliente.Text;
            oCliente.Cli_Apellido = txtApellidoCLiente.Text;
            oCliente.Cli_Sexo = txtSexoCliente.Text;
            oCliente.Cli_FechaNacimiento = DateTime.Now; 
            oCliente.Cli_Ingresos = Convert.ToDecimal(txtIngresoCliente.Text);
            oCliente.Cli_Direccion = txtDireccionCliente.Text;
            oCliente.Cli_Telefono = Convert.ToInt32(txtTelefonoCliente.Text);
            
            TrabajarCliente.insert_cliente(oCliente);

            txtDNICliente.Text = "";
            txtNombreCliente.Text = "";
            txtApellidoCLiente.Text = "";
            txtSexoCliente.Text = "";
            txtFecIngCliente.Text = "";
            txtIngresoCliente.Text = "";
            txtDireccionCliente.Text = "";
            txtTelefonoCliente.Text = "";            
        }

        private void btnLimpiarAltaCliente_Click(object sender, EventArgs e)
        {

            txtDNICliente.Text = "";
            txtNombreCliente.Text = "";
            txtApellidoCLiente.Text = "";
            txtSexoCliente.Text = "";
            txtFecIngCliente.Text = "";
            txtIngresoCliente.Text = "";
            txtDireccionCliente.Text = "";
            txtTelefonoCliente.Text = "";            
        }


    }
}
