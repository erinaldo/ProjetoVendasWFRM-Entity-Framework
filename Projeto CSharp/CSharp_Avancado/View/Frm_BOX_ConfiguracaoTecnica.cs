using CSharp_Avancado.Controller;
using System;
using System.IO;
using System.Windows.Forms;

namespace CSharp_Avancado.View
{
    public partial class Frm_BOX_ConfiguracaoTecnica : Form
    {
        public Frm_BOX_ConfiguracaoTecnica()
        {
            InitializeComponent();
            SetComponents();
            CarregaNomeInstancia();
        }

        private void CarregaNomeInstancia()
        {
            TxtBox_Instancia.Text = Uteis.RecuperarNomeInstancia();
        }

        public void SetComponents()
        {
            // Form
            this.StartPosition = Defaults.frmStartPointAtCenterScreen;
            this.Font = Defaults.microsoftSansSerif10Bold;
            // TabPages
            this.tabPage1.Text = "Config. Instância";
            this.tabPage2.Text = "Novo Usuário";
            // Label
            Lbl_Titulo.Text = "Configurações Técnicas";
            Lbl_Usuario.Text = "Usuário";
            Lbl_Senha.Text = "Senha";
            Lbl_ConfirmarSenha.Text = "Confirmar Senha";
            Lbl_Instancia.Text = "Digite abaixo o nome da instância";
            Lbl_Login.Text = "Dados de acesso";

            Lbl_SenhaConfere.Text = "OK";
            Lbl_SenhaConfere.ForeColor = System.Drawing.Color.Green;
            Lbl_SenhaConfere.Visible = false;

            Lbl_SenhaIncorreta.Text = "Senha inválida, ou não confere.";
            Lbl_SenhaIncorreta.ForeColor = System.Drawing.Color.Red;
            Lbl_SenhaIncorreta.Visible = false;
            // Masked Text Box
            MskTxtBox_Senha.PasswordChar = Defaults.senhaMask;
            MskTxtBox_ConfirmarSenha.PasswordChar = Defaults.senhaMask;
            // Button
            Btn_Confirmar.Text = "Confirmar";
            Btn_Instancia.Text = "Salvar";
        }

        private void Btn_Instancia_Click(object sender, EventArgs e)
        {
            var frm = new Frm_BOX_DialogBox();

            try
            {
                Uteis.CriarArquivoDeConfiguracao(TxtBox_Instancia.Text);
                frm.DialogBox(Defaults.getImageByName("arquivo"), "Informação", "Instância definida com sucesso!", true, false);
            }
            catch (FileNotFoundException)
            {
                frm.DialogBox(Defaults.getImageByName("arquivo"), "Informação", "Instância definida com sucesso!", true, false);
            }
            finally
            {
                frm.Show();
            }
        }

        private bool validaSenha()
        {
            if (MskTxtBox_Senha.Text != MskTxtBox_ConfirmarSenha.Text)
                return false;
            else
                return true;
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (!validaSenha())
            {
                MessageBox.Show("Senha inválida, verifique!", "Error");
            }
            else
            {
                DBC dbc = new DBC();
                string nomeUsuario = dbc.RecuperarUsuario(TxtBox_Usuario.Text);

                if (!nomeUsuario.Equals(TxtBox_Usuario.Text))
                    dbc.InserirUsuario(new Usuario { usuario = TxtBox_Usuario.Text, senha = MskTxtBox_Senha.Text });
                else
                    MessageBox.Show($"Usuário '{nomeUsuario}' já cadastrado, utilize outro nome.");
            }
        }

        private void MskTxtBox_ConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            if (validaSenha())
            {
                Lbl_SenhaConfere.Visible = true;
                Lbl_SenhaIncorreta.Visible = false;
            }
            else
            {
                Lbl_SenhaConfere.Visible = false;
                Lbl_SenhaIncorreta.Visible = true;
            }
        }
    }
}
