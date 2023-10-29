namespace FrmView
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.cmbHorario.DataSource = new string[] { "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00" };
        }
    }
}