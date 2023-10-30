namespace FrmView
{
    partial class FrmBusqueda
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
            lblDniBuscar = new Label();
            txtDniBuscar = new TextBox();
            lstbMostrarBusqueda = new ListBox();
            txtBuscarDni = new Button();
            SuspendLayout();
            // 
            // lblDniBuscar
            // 
            lblDniBuscar.AutoSize = true;
            lblDniBuscar.Location = new Point(12, 9);
            lblDniBuscar.Name = "lblDniBuscar";
            lblDniBuscar.Size = new Size(80, 15);
            lblDniBuscar.TabIndex = 0;
            lblDniBuscar.Text = "Ingrese el DNI";
            // 
            // txtDniBuscar
            // 
            txtDniBuscar.Location = new Point(12, 44);
            txtDniBuscar.MaxLength = 50;
            txtDniBuscar.Name = "txtDniBuscar";
            txtDniBuscar.Size = new Size(309, 23);
            txtDniBuscar.TabIndex = 1;
            // 
            // lstbMostrarBusqueda
            // 
            lstbMostrarBusqueda.FormattingEnabled = true;
            lstbMostrarBusqueda.ItemHeight = 15;
            lstbMostrarBusqueda.Location = new Point(12, 73);
            lstbMostrarBusqueda.Name = "lstbMostrarBusqueda";
            lstbMostrarBusqueda.Size = new Size(309, 169);
            lstbMostrarBusqueda.TabIndex = 2;
            // 
            // txtBuscarDni
            // 
            txtBuscarDni.Location = new Point(12, 254);
            txtBuscarDni.Name = "txtBuscarDni";
            txtBuscarDni.Size = new Size(75, 23);
            txtBuscarDni.TabIndex = 3;
            txtBuscarDni.Text = "Buscar";
            txtBuscarDni.UseVisualStyleBackColor = true;
            // 
            // FrmBusqueda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 299);
            Controls.Add(txtBuscarDni);
            Controls.Add(lstbMostrarBusqueda);
            Controls.Add(txtDniBuscar);
            Controls.Add(lblDniBuscar);
            Name = "FrmBusqueda";
            Text = "FrmBusqueda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDniBuscar;
        private TextBox txtDniBuscar;
        private ListBox lstbMostrarBusqueda;
        private Button txtBuscarDni;
    }
}