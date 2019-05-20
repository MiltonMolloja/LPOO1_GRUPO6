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
    public partial class FormLIstaCliente : Form
    {
        public FormLIstaCliente()
        {
            InitializeComponent();
            load_Clientes();
        }

        private void FormLIstaCliente_Load(object sender, EventArgs e)
        {
            
            load_Clientes();
        }


        private void load_Clientes()
        {
            dgvListaCliente.DataSource = TrabajarCliente.list_clientes();
        }
    }
}
