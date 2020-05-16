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
    public partial class Frm_BOX_DialogBox : Form
    {
        public Frm_BOX_DialogBox()
        {
            InitializeComponent();
        }

        public void SetComponents()
        {
            var defFontStyle = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);

            // Form
            this.StartPosition = Defaults.frmStartPointAtCenterScreen;
            this.FormBorderStyle = Defaults.frmNoneBorderStyle;
            this.Text = "Dialog";
            // Label
            Lbl_Titulo.Font = defFontStyle;
            Lbl_Pergunta.Font = defFontStyle;
            Lbl_Titulo.Text = DialogBoxProperties.tituloPergunta;
            Lbl_Pergunta.Text = DialogBoxProperties.pergunta;
            Lbl_Pergunta.MaximumSize = new Size(300, 120);
            // Text Box
            // Picture Box
            PicBox_QuestionImage.Image = DialogBoxProperties.imagemPergunta;
            // Button
            Btn_RespostaPositiva.Text = DialogBoxProperties.nomeBotaoAfirmacao;
            Btn_RespostaNegativa.Text = DialogBoxProperties.nomeBotaoNegacao;
        }

        public void DialogBox(Image imagemDaPergunta,string tituloPergunta, string pergunta, 
            string nomeBotaoAfirmacao = "Ok", string nomeBotaoNegacao = "Cancel")
        {
            DialogBoxProperties.tituloPergunta = tituloPergunta;
            DialogBoxProperties.pergunta = pergunta;
            DialogBoxProperties.nomeBotaoAfirmacao = nomeBotaoAfirmacao;
            DialogBoxProperties.nomeBotaoNegacao = nomeBotaoNegacao;
            DialogBoxProperties.imagemPergunta = imagemDaPergunta;

            SetComponents();
        }

        public void DialogBox(Image imagemDaPergunta, string tituloPergunta, string pergunta, bool botaoAfirmacaoAtivo, 
            bool botaoNegacaoAtivo, string nomeBotaoAfirmacao = "Ok", string nomeBotaoNegacao = "Cancel")
        {
            DialogBoxProperties.tituloPergunta = tituloPergunta;
            DialogBoxProperties.pergunta = pergunta;
            DialogBoxProperties.nomeBotaoAfirmacao = nomeBotaoAfirmacao;
            DialogBoxProperties.nomeBotaoNegacao = nomeBotaoNegacao;
            DialogBoxProperties.imagemPergunta = imagemDaPergunta;

            if (!botaoAfirmacaoAtivo)
            {
                Btn_RespostaPositiva.Enabled = false;
                Btn_RespostaPositiva.Visible = false;
            }

            if (!botaoNegacaoAtivo)
            {
                Btn_RespostaNegativa.Enabled = false;
                Btn_RespostaNegativa.Visible = false;
            }

            SetComponents();
        }

        private void Btn_RespostaNegativa_Click(object sender, EventArgs e)
        {
            DialogBoxProperties.resposta = false;
            this.Dispose();
        }

        private void Btn_RespostaPositiva_Click(object sender, EventArgs e)
        {
            DialogBoxProperties.resposta = true;
            this.Dispose();
        }
    }
}
