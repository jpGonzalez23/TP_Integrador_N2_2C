﻿namespace FrmView
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
            label1 = new Label();
            txtNombre = new TextBox();
            numcCantPersonas = new NumericUpDown();
            lblCantidadPersonas = new Label();
            cmbHorario = new ComboBox();
            lblHorario = new Label();
            lstbListadoReserva = new ListBox();
            btnReservar = new Button();
            txtDni = new TextBox();
            lblDni = new Label();
            btnCancelar = new Button();
            btnBuscar = new Button();
            lblMostrarMesa = new Label();
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
            txtNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(12, 95);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(268, 25);
            txtNombre.TabIndex = 2;
            // 
            // numcCantPersonas
            // 
            numcCantPersonas.Location = new Point(12, 199);
            numcCantPersonas.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numcCantPersonas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numcCantPersonas.Name = "numcCantPersonas";
            numcCantPersonas.Size = new Size(268, 23);
            numcCantPersonas.TabIndex = 4;
            numcCantPersonas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCantidadPersonas
            // 
            lblCantidadPersonas.AutoSize = true;
            lblCantidadPersonas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadPersonas.Location = new Point(12, 175);
            lblCantidadPersonas.Name = "lblCantidadPersonas";
            lblCantidadPersonas.Size = new Size(159, 21);
            lblCantidadPersonas.TabIndex = 6;
            lblCantidadPersonas.Text = "Cantidad de Personas";
            // 
            // cmbHorario
            // 
            cmbHorario.FormattingEnabled = true;
            cmbHorario.Location = new Point(12, 249);
            cmbHorario.Name = "cmbHorario";
            cmbHorario.Size = new Size(268, 23);
            cmbHorario.TabIndex = 5;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHorario.Location = new Point(12, 225);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(63, 21);
            lblHorario.TabIndex = 8;
            lblHorario.Text = "Horario";
            // 
            // lstbListadoReserva
            // 
            lstbListadoReserva.FormattingEnabled = true;
            lstbListadoReserva.HorizontalScrollbar = true;
            lstbListadoReserva.ItemHeight = 15;
            lstbListadoReserva.Location = new Point(299, 95);
            lstbListadoReserva.Name = "lstbListadoReserva";
            lstbListadoReserva.Size = new Size(602, 229);
            lstbListadoReserva.TabIndex = 9;
            // 
            // btnReservar
            // 
            btnReservar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReservar.Location = new Point(12, 279);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(128, 45);
            btnReservar.TabIndex = 10;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = true;
            btnReservar.Click += btnReservar_Click;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(12, 147);
            txtDni.MaxLength = 50;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(268, 25);
            txtDni.TabIndex = 3;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(12, 123);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(37, 21);
            lblDni.TabIndex = 13;
            lblDni.Text = "DNI";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(152, 279);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 45);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(12, 330);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(128, 45);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblMostrarMesa
            // 
            lblMostrarMesa.AutoSize = true;
            lblMostrarMesa.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblMostrarMesa.Location = new Point(299, 333);
            lblMostrarMesa.Name = "lblMostrarMesa";
            lblMostrarMesa.Size = new Size(0, 32);
            lblMostrarMesa.TabIndex = 17;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 384);
            Controls.Add(lblMostrarMesa);
            Controls.Add(btnBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(btnReservar);
            Controls.Add(lstbListadoReserva);
            Controls.Add(lblHorario);
            Controls.Add(cmbHorario);
            Controls.Add(lblCantidadPersonas);
            Controls.Add(numcCantPersonas);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(lblInformacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            FormClosing += FrmMenuPrincipal_FormClosing;
            Load += FrmMenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)numcCantPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInformacion;
        private Label label1;
        private TextBox txtNombre;
        private NumericUpDown numcCantPersonas;
        private Label lblCantidadPersonas;
        private ComboBox cmbHorario;
        private Label lblHorario;
        private ListBox lstbListadoReserva;
        private Button btnReservar;
        private TextBox txtDni;
        private Label lblDni;
        private Button btnCancelar;
        private Button btnBuscar;
        private Label lblMostrarMesa;
    }
}