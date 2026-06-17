using SistemaDulceriaCine;

namespace SimulacionCine
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCine_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDulceria cine = new FrmDulceria();
            cine.ShowDialog();
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
