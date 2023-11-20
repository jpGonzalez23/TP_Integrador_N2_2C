using Entidades.Archivo;
using Entidades.BD;
using Entidades.Excepciones;
using Entidades.Modelos;

namespace FrmView
{
    public partial class FrmMenuPrincipal : Form
    {
        Reserva reserva;
        Comensal c;

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            this.reserva = new Reserva ();
            this.reserva.OnReserva += this.MostrarListaReserva;
        }

        /// <summary>
        /// Metodo load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.cmbHorario.DataSource = new string[] { "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00" };
        }

        /// <summary>
        /// Metodo para abrir o Cerrar las reservas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (!this.reserva.AbrirRestaurante)
            {
                this.txtNombre.Enabled = true;
                this.txtDni.Enabled = true;
            }
        }

        /// <summary>
        /// Metodo para realizar las reservas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservar_Click(object sender, EventArgs e)
        {
            Comensal comensal = new Comensal(this.txtNombre.Text, int.Parse(this.txtDni.Text), (int)this.numcCantPersonas.Value, DateTime.Parse(this.cmbHorario.SelectedItem.ToString()));

            if (DataBaseManager.GuardarNuevaReserva(comensal))
            {
                MessageBox.Show($"Se guarado la reserva", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FileManager.Serializar(comensal.ToString(), "ListasDeResevas.json");

                this.MostrarListaReserva();
            }
            else
            {
                MessageBox.Show("No se guardo la reserva", "Informacón", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.MostrarListaReserva();
            }
        }

        /// <summary>
        /// Metodos para cancelar reservas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (this.lstbListadoReserva.SelectedItem != null)
            {
                Comensal c = DataBaseManager.BuscarReservaPorDni(((Comensal)this.lstbListadoReserva.SelectedItem).Dni);

                if (DataBaseManager.EliminarReservaPorDni(c.Dni))
                {
                    MessageBox.Show("Reserva eliminada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.MostrarListaReserva();
                }
            }
            else
            {
                MessageBox.Show("Selecciones un item", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Metodo para actualizar el listBoxs
        /// </summary>
        private void MostrarListaReserva()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(() => MostrarListaReserva());
            }
            else
            {
                this.lstbListadoReserva.DataSource = null;
                this.lstbListadoReserva.DataSource = DataBaseManager.ObtenerListaDeReserva();
            }
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Quieres cerrar la aplicacion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                FileManager.Guardar(ex.Message, "logs.txt", false);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscar buscar = new FrmBuscar();
            buscar.ShowDialog();
        }
    }
}