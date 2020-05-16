using CSharp_Avancado.Controller;
using System;
using System.Windows.Forms;

namespace CSharp_Avancado.View
{
    public partial class Frm_Principal : Form
    {
        public static string nomeInstancia = "";

        public Frm_Principal()
        {
            CarregaNomeInstancia();
            InitializeComponent();

            Uteis.CriarDiretorios();
            new Frm_BOX_Login().ShowDialog();
            SetComponents();
        }

        public void SetComponents()
        {
            // Form
            this.StartPosition = Defaults.frmStartPointAtCenterScreen;
            this.Text = "Tela inicial";
            this.Icon = Defaults.getIconByName("casa1");
            // Menu Strip
            menuStrip1.Font = Defaults.microsoftSansSerif12Bold;
            // Label
            // Text Box
            // Picture Box
            PicBox_Logo.SizeMode = Defaults.stretchImageStyle;
            PicBox_Logo.Image = Defaults.getImageByName("fundo_login");
            // Button
        }

        private static void CarregaNomeInstancia()
        {
            nomeInstancia = Uteis.RecuperarNomeInstancia();
        }

        private void SairToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Frm_CER_Cliente();
            frm.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Frm_CER_Funcionario();
            frm.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Frm_CER_Fornecedor();
            frm.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Frm_CER_Produto();
            frm.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Frm_CER_Venda();
            frm.Show();
        }
    }
}
