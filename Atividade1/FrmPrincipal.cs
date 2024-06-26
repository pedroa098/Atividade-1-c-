using Microsoft.EntityFrameworkCore;

namespace Atividade1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            BancoDeDados();
        }

        private void BancoDeDados()
        {
            using (var BancoDeDados = new AppDbContext())
            {
                BancoDeDados.Database.Migrate();
            }
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.Show();
        }

        private void BtnChamado_Click(object sender, EventArgs e)
        {
            FrmChamado frmChamado = new FrmChamado();
            frmChamado.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
