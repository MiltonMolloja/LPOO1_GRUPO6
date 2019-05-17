namespace Vistas
{
    partial class FormUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datosDeUsuario = new System.Windows.Forms.GroupBox();
            this.textBoxApellidoNombre = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.textBoxNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.labelApellidoNombre = new System.Windows.Forms.Label();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.labelNombredeUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.datosDeUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // datosDeUsuario
            // 
            this.datosDeUsuario.Controls.Add(this.textBoxApellidoNombre);
            this.datosDeUsuario.Controls.Add(this.textBoxContraseña);
            this.datosDeUsuario.Controls.Add(this.textBoxNombreDeUsuario);
            this.datosDeUsuario.Controls.Add(this.labelApellidoNombre);
            this.datosDeUsuario.Controls.Add(this.labelContrasena);
            this.datosDeUsuario.Controls.Add(this.labelNombredeUsuario);
            this.datosDeUsuario.Controls.Add(this.label1);
            this.datosDeUsuario.Controls.Add(this.comboBoxRol);
            this.datosDeUsuario.Location = new System.Drawing.Point(36, 44);
            this.datosDeUsuario.Name = "datosDeUsuario";
            this.datosDeUsuario.Size = new System.Drawing.Size(393, 239);
            this.datosDeUsuario.TabIndex = 0;
            this.datosDeUsuario.TabStop = false;
            this.datosDeUsuario.Text = "Datos de Usuario";
            this.datosDeUsuario.Enter += new System.EventHandler(this.datosDeUsuario_Enter);
            // 
            // textBoxApellidoNombre
            // 
            this.textBoxApellidoNombre.Location = new System.Drawing.Point(158, 168);
            this.textBoxApellidoNombre.Name = "textBoxApellidoNombre";
            this.textBoxApellidoNombre.Size = new System.Drawing.Size(199, 20);
            this.textBoxApellidoNombre.TabIndex = 7;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(158, 133);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(199, 20);
            this.textBoxContraseña.TabIndex = 6;
            // 
            // textBoxNombreDeUsuario
            // 
            this.textBoxNombreDeUsuario.Location = new System.Drawing.Point(158, 92);
            this.textBoxNombreDeUsuario.Name = "textBoxNombreDeUsuario";
            this.textBoxNombreDeUsuario.Size = new System.Drawing.Size(199, 20);
            this.textBoxNombreDeUsuario.TabIndex = 5;
            this.textBoxNombreDeUsuario.TextChanged += new System.EventHandler(this.textBoxNombreDeUsuario_TextChanged);
            // 
            // labelApellidoNombre
            // 
            this.labelApellidoNombre.AutoSize = true;
            this.labelApellidoNombre.Location = new System.Drawing.Point(26, 168);
            this.labelApellidoNombre.Name = "labelApellidoNombre";
            this.labelApellidoNombre.Size = new System.Drawing.Size(92, 13);
            this.labelApellidoNombre.TabIndex = 4;
            this.labelApellidoNombre.Text = "Apellido y Nombre";
            // 
            // labelContrasena
            // 
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.Location = new System.Drawing.Point(26, 133);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(61, 13);
            this.labelContrasena.TabIndex = 3;
            this.labelContrasena.Text = "Contraseña";
            // 
            // labelNombredeUsuario
            // 
            this.labelNombredeUsuario.AutoSize = true;
            this.labelNombredeUsuario.Location = new System.Drawing.Point(26, 92);
            this.labelNombredeUsuario.Name = "labelNombredeUsuario";
            this.labelNombredeUsuario.Size = new System.Drawing.Size(100, 13);
            this.labelNombredeUsuario.TabIndex = 2;
            this.labelNombredeUsuario.Text = "Nombre De Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rol";
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Location = new System.Drawing.Point(158, 56);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(199, 21);
            this.comboBoxRol.TabIndex = 0;
            this.comboBoxRol.SelectedIndexChanged += new System.EventHandler(this.comboBoxRol_SelectedIndexChanged);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(318, 311);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 368);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.datosDeUsuario);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.datosDeUsuario.ResumeLayout(false);
            this.datosDeUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox datosDeUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.Label labelNombredeUsuario;
        private System.Windows.Forms.Label labelContrasena;
        private System.Windows.Forms.Label labelApellidoNombre;
        private System.Windows.Forms.TextBox textBoxApellidoNombre;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.TextBox textBoxNombreDeUsuario;
        private System.Windows.Forms.Button buttonGuardar;
    }
}