namespace FrmView
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblInformacion = new Label();
            btnAbrir = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            numcCantPersonas = new NumericUpDown();
            lblCantidadPersonas = new Label();
            cmbHorario = new ComboBox();
            lblHorario = new Label();
            lstbListadoReserva = new ListBox();
            btnReservar = new Button();
            btnCancelarReserva = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)numcCantPersonas).BeginInit();
            SuspendLayout();
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblInformacion.Location = new Point(12, 9);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(191, 45);
            lblInformacion.TabIndex = 0;
            lblInformacion.Text = "Bienvenidos";
            // 
            // btnAbrir
            // 
            btnAbrir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbrir.Location = new Point(448, 9);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(128, 45);
            btnAbrir.TabIndex = 1;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(12, 95);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(268, 29);
            txtNombre.TabIndex = 3;
            // 
            // numcCantPersonas
            // 
            numcCantPersonas.Location = new Point(12, 168);
            numcCantPersonas.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numcCantPersonas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numcCantPersonas.Name = "numcCantPersonas";
            numcCantPersonas.Size = new Size(159, 23);
            numcCantPersonas.TabIndex = 5;
            numcCantPersonas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCantidadPersonas
            // 
            lblCantidadPersonas.AutoSize = true;
            lblCantidadPersonas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadPersonas.Location = new Point(12, 137);
            lblCantidadPersonas.Name = "lblCantidadPersonas";
            lblCantidadPersonas.Size = new Size(159, 21);
            lblCantidadPersonas.TabIndex = 6;
            lblCantidadPersonas.Text = "Cantidad de Personas";
            // 
            // cmbHorario
            // 
            cmbHorario.FormattingEnabled = true;
            cmbHorario.Location = new Point(12, 239);
            cmbHorario.Name = "cmbHorario";
            cmbHorario.Size = new Size(121, 23);
            cmbHorario.TabIndex = 7;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHorario.Location = new Point(12, 206);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(63, 21);
            lblHorario.TabIndex = 8;
            lblHorario.Text = "Horario";
            // 
            // lstbListadoReserva
            // 
            lstbListadoReserva.FormattingEnabled = true;
            lstbListadoReserva.ItemHeight = 15;
            lstbListadoReserva.Location = new Point(340, 95);
            lstbListadoReserva.Name = "lstbListadoReserva";
            lstbListadoReserva.Size = new Size(236, 124);
            lstbListadoReserva.TabIndex = 9;
            // 
            // btnReservar
            // 
            btnReservar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReservar.Location = new Point(12, 279);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(128, 45);
            btnReservar.TabIndex = 10;
            btnReservar.Text = "Rervar";
            btnReservar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarReserva
            // 
            btnCancelarReserva.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarReserva.Location = new Point(146, 279);
            btnCancelarReserva.Name = "btnCancelarReserva";
            btnCancelarReserva.Size = new Size(128, 45);
            btnCancelarReserva.TabIndex = 11;
            btnCancelarReserva.Text = "Cancelar";
            btnCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(280, 279);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(128, 45);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 337);
            Controls.Add(btnModificar);
            Controls.Add(btnCancelarReserva);
            Controls.Add(btnReservar);
            Controls.Add(lstbListadoReserva);
            Controls.Add(lblHorario);
            Controls.Add(cmbHorario);
            Controls.Add(lblCantidadPersonas);
            Controls.Add(numcCantPersonas);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnAbrir);
            Controls.Add(lblInformacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += FrmMenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)numcCantPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInformacion;
        private Button btnAbrir;
        private Label label1;
        private TextBox txtNombre;
        private NumericUpDown numcCantPersonas;
        private Label lblCantidadPersonas;
        private ComboBox cmbHorario;
        private Label lblHorario;
        private ListBox lstbListadoReserva;
        private Button btnReservar;
        private Button btnCancelarReserva;
        private Button btnModificar;
    }
}