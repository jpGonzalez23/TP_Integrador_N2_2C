using Entidades.BD;
using Entidades.Modelos;

namespace FrmView
{
    public partial class FrmMenuPrincipal : Form
    {
        Reserva<Comensal> reserva;

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            this.reserva = new Reserva<Comensal> ("La Hmaburgeseria") ;
        }

        /// <summary>
        /// Metodo load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.cmbHorario.DataSource = new string[] { "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00" };
            this.ActualizarListBox();
        }

        /// <summary>
        /// Metodo para abrir o Cerrar las reservas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (!this.reserva.HabiliatarReserva)
            {
                this.reserva.HabiliatarReserva = true;
                this.btnAbrir.Text = "Cerrar";
            }
            else
            {
                this.reserva.HabiliatarReserva = false;
                this.btnAbrir.Text = "Abrir";
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
                MessageBox.Show("Se guarado la reserva", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ActualizarListBox();
            }
            else
            {
                MessageBox.Show("No se guardo la reserva", "Informacón", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ActualizarListBox();
            }
        }

        /// <summary>
        /// Metodos para cancelar reservas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Metodo para actualizar el listBoxs
        /// </summary>
        private void ActualizarListBox()
        {
            this.lstbListadoReserva.DataSource = null;
            this.lstbListadoReserva.DataSource = DataBaseManager.ObtenerListaDeReserva();
        }
    }
}