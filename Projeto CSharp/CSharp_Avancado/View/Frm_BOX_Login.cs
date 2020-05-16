using CSharp_Avancado.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Avancado.View
{
    public partial class Frm_BOX_Login : Form
    {
        public Frm_BOX_Login()
        {
            InitializeComponent();
            SetComponents();
        }

        public void SetComponents()
        {
            // Form
            this.StartPosition = Defaults.frmStartPointAtCenterScreen;
            this.Text = "Login";
            this.Font = Defaults.microsoftSansSerif10;
            // Label
            Lbl_Titulo.Font = Defaults.fontPadraoTituloJanelas16Bold;
            Lbl_Titulo.Text = "Login";
            Lbl_Usuario.Text = "Usuário";
            Lbl_Senha.Text = "Senha";
            // Text Box
            // Masked Text Box
            MskTxtBox_Senha.PasswordChar = Defaults.senhaMask;
            // Picture Box
            PicBox_Usuario.SizeMode = Defaults.stretchImageStyle;
            PicBox_Senha.SizeMode = Defaults.stretchImageStyle;
            PicBox_Sair.SizeMode = Defaults.stretchImageStyle;
            PicBox_Configuracao.SizeMode = Defaults.stretchImageStyle;
            PicBox_Usuario.Image = Defaults.getImageByName("usuário_masculino");
            PicBox_Senha.Image = Defaults.getImageByName("chave");
            PicBox_Sair.Image = Defaults.getImageByName("fechar_janela");
            PicBox_Configuracao.Image = Defaults.getImageByName("engrenagem");
            // Button
            Btn_Entrar.Text = "Entrar";
        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            string usuario = TxtBox_Usuario.Text;
            string senha = MskTxtBox_Senha.Text;

            Login.usuario = usuario != "" ? usuario : "";
            Login.senha = senha != "" ? senha : "";

            if (!Login.testaLogin())
            {
                Frm_BOX_DialogBox dialog = new Frm_BOX_DialogBox();
                Image img = Defaults.getImageByName("error");

                dialog.DialogBox(
                    img,
                    tituloPergunta: "Login",
                    pergunta: "Login ou senha incorretos,\n deseja tentar novamente?",
                    nomeBotaoAfirmacao: "Sim",
                    nomeBotaoNegacao: "Não"
                );

                dialog.ShowDialog();

                if (!DialogBoxProperties.resposta)
                {
                    Application.Exit();
                }
            }
            else
            {
                this.Dispose();
            }
        }

        private void Frm_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Login.testaLogin())
            {
                Application.Exit();
            }
        }

        private void PicBox_Sair_Click(object sender, EventArgs e)
        {
            Frm_BOX_DialogBox dialog = new Frm_BOX_DialogBox();
            Image img = Defaults.getImageByName("error");

            dialog.DialogBox(
                img,
                tituloPergunta: "Sistema",
                pergunta: "Deseja finalizar o programa?",
                nomeBotaoAfirmacao: "Sim",
                nomeBotaoNegacao: "Não"
            );

            dialog.ShowDialog();

            if (DialogBoxProperties.resposta)
            {
                Application.Exit();
            }
        }

        private void PicBox_Configuracao_Click(object sender, EventArgs e)
        {
            var frm = new Frm_BOX_ConfiguracaoTecnica();
            frm.ShowDialog();
        }
    }
}
