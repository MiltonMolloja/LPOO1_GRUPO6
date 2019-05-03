using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

    }
}
