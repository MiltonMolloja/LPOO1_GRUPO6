namespace Vistas
{
    partial class FormLIstaCliente
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
            this.dgvListaCliente = new System.Windows.Forms.DataGridView();
            this.btnCrearListaCliente = new System.Windows.Forms.Button();
            this.btnCancelarListaCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaCliente
            // 
            this.dgvListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCliente.Location = new System.Drawing.Point(34, 91);
            this.dgvListaCliente.Name = "dgvListaCliente";
            this.dgvListaCliente.Size = new System.Drawing.Size(943, 222);
            this.dgvListaCliente.TabIndex = 0;
            //this.dgvListaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCliente_CellContentClick);
            // 
            // btnCrearListaCliente
            // 
            this.btnCrearListaCliente.Location = new System.Drawing.Point(830, 336);
            this.btnCrearListaCliente.Name = "btnCrearListaCliente";
            this.btnCrearListaCliente.Size = new System.Drawing.Size(147, 23);
            this.btnCrearListaCliente.TabIndex = 1;
            this.btnCrearListaCliente.Text = "Crear";
            this.btnCrearListaCliente.UseVisualStyleBackColor = true;
            // 
            // btnCancelarListaCliente
            // 
            this.btnCancelarListaCliente.Location = new System.Drawing.Point(34, 336);
            this.btnCancelarListaCliente.Name = "btnCancelarListaCliente";
            this.btnCancelarListaCliente.Size = new System.Drawing.Size(147, 23);
            this.btnCancelarListaCliente.TabIndex = 2;
            this.btnCancelarListaCliente.Text = "Cancelar";
            this.btnCancelarListaCliente.UseVisualStyleBackColor = true;
            // 
            // FormLIstaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 380);
            this.Controls.Add(this.btnCancelarListaCliente);
            this.Controls.Add(this.btnCrearListaCliente);
            this.Controls.Add(this.dgvListaCliente);
            this.Name = "FormLIstaCliente";
            this.Text = "FormLIstaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaCliente;
        private System.Windows.Forms.Button btnCrearListaCliente;
        private System.Windows.Forms.Button btnCancelarListaCliente;
    }
}