using Entidades.Archivo;
using Entidades.BD;
using Entidades.Interfaces;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmView
{
    public partial class FrmBuscar : Form
    {
        /// <summary>
        /// Constructor del formulario FrmBuscar
        /// </summary>
        public FrmBuscar()
        {
            InitializeComponent();
            this.ActualizarListBox();
        }

        /// <summary>
        /// Evento del btnBuscar_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Comensal c = DataBaseManager.BuscarReservaPorDni(int.Parse(this.txtBuscarDni.Text));

            MessageBox.Show(c.ToString(), "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FileManager.Guardar(c.ToString(), "Reserva.txt", false);
        }

        /// <summary>
        /// Evento del btnSalir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarListBox()
        {
            this.lstbBuscarDni.DataSource = null;
            this.lstbBuscarDni.DataSource = DataBaseManager.ObtenerListaDeReserva();
        }
    }
}
