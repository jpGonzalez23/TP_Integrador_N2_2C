namespace FrmView
{
    partial class FrmBuscar
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
            lblIngresarDni = new Label();
            txtBuscarDni = new TextBox();
            lstbBuscarDni = new ListBox();
            btnBuscar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblIngresarDni
            // 
            lblIngresarDni.AutoSize = true;
            lblIngresarDni.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblIngresarDni.Location = new Point(12, 9);
            lblIngresarDni.Name = "lblIngresarDni";
            lblIngresarDni.Size = new Size(131, 25);
            lblIngresarDni.TabIndex = 0;
            lblIngresarDni.Text = "Ingrese el DNI";
            // 
            // txtBuscarDni
            // 
            txtBuscarDni.Location = new Point(12, 37);
            txtBuscarDni.MaxLength = 50;
            txtBuscarDni.Name = "txtBuscarDni";
            txtBuscarDni.Size = new Size(240, 23);
            txtBuscarDni.TabIndex = 1;
            // 
            // lstbBuscarDni
            // 
            lstbBuscarDni.FormattingEnabled = true;
            lstbBuscarDni.ItemHeight = 15;
            lstbBuscarDni.Location = new Point(12, 66);
            lstbBuscarDni.Name = "lstbBuscarDni";
            lstbBuscarDni.Size = new Size(509, 94);
            lstbBuscarDni.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(365, 166);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(446, 166);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 195);
            Controls.Add(btnSalir);
            Controls.Add(btnBuscar);
            Controls.Add(lstbBuscarDni);
            Controls.Add(txtBuscarDni);
            Controls.Add(lblIngresarDni);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBuscar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBuscar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngresarDni;
        private TextBox txtBuscarDni;
        private ListBox lstbBuscarDni;
        private Button btnBuscar;
        private Button btnSalir;
    }
}