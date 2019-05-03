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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
       
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

              
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Boolean bUserFound = false;
            Usuario oUser1 = new Usuario("adm", "123");
            Usuario oUser2 = new Usuario("pepe", "456");
            FormUsuario oFormUsuario = new FormUsuario();
 

            if (oUser1.Usu_NombreUsuario == textUserName.Text && oUser1.Usu_Contraseña == textUserContraseña.Text)
            {
                bUserFound = true;
            }
            else if (oUser2.Usu_NombreUsuario == textUserName.Text && oUser2.Usu_Contraseña == textUserContraseña.Text)
            {
                bUserFound = true;

            }

            if (bUserFound == true){
                MessageBox.Show("Bienvenido Sr/a: " + textUserName.Text);
                oFormUsuario.Show();
                
            }else{
                MessageBox.Show("Datos de Aceso Invalidos.");
            }
                           
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
    }
}
