namespace CSharp_Avancado.View
{
    partial class Frm_BOX_DialogBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PicBox_QuestionImage = new System.Windows.Forms.PictureBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Pergunta = new System.Windows.Forms.Label();
            this.Btn_RespostaPositiva = new System.Windows.Forms.Button();
            this.Btn_RespostaNegativa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_QuestionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBox_QuestionImage
            // 
            this.PicBox_QuestionImage.Location = new System.Drawing.Point(25, 76);
            this.PicBox_QuestionImage.Name = "PicBox_QuestionImage";
            this.PicBox_QuestionImage.Size = new System.Drawing.Size(133, 121);
            this.PicBox_QuestionImage.TabIndex = 0;
            this.PicBox_QuestionImage.TabStop = false;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_Titulo.Location = new System.Drawing.Point(212, 24);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Titulo.TabIndex = 1;
            this.Lbl_Titulo.Text = "label1";
            // 
            // Lbl_Pergunta
            // 
            this.Lbl_Pergunta.AutoSize = true;
            this.Lbl_Pergunta.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_Pergunta.Location = new System.Drawing.Point(168, 76);
            this.Lbl_Pergunta.Name = "Lbl_Pergunta";
            this.Lbl_Pergunta.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Pergunta.TabIndex = 2;
            this.Lbl_Pergunta.Text = "label2";
            // 
            // Btn_RespostaPositiva
            // 
            this.Btn_RespostaPositiva.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Btn_RespostaPositiva.Location = new System.Drawing.Point(192, 203);
            this.Btn_RespostaPositiva.Name = "Btn_RespostaPositiva";
            this.Btn_RespostaPositiva.Size = new System.Drawing.Size(93, 35);
            this.Btn_RespostaPositiva.TabIndex = 3;
            this.Btn_RespostaPositiva.Text = "button1";
            this.Btn_RespostaPositiva.UseVisualStyleBackColor = true;
            this.Btn_RespostaPositiva.Click += new System.EventHandler(this.Btn_RespostaPositiva_Click);
            // 
            // Btn_RespostaNegativa
            // 
            this.Btn_RespostaNegativa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Btn_RespostaNegativa.Location = new System.Drawing.Point(312, 203);
            this.Btn_RespostaNegativa.Name = "Btn_RespostaNegativa";
            this.Btn_RespostaNegativa.Size = new System.Drawing.Size(94, 35);
            this.Btn_RespostaNegativa.TabIndex = 4;
            this.Btn_RespostaNegativa.Text = "button2";
            this.Btn_RespostaNegativa.UseVisualStyleBackColor = true;
            this.Btn_RespostaNegativa.Click += new System.EventHandler(this.Btn_RespostaNegativa_Click);
            // 
            // Frm_BOX_DialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(480, 250);
            this.Controls.Add(this.Btn_RespostaNegativa);
            this.Controls.Add(this.Btn_RespostaPositiva);
            this.Controls.Add(this.Lbl_Pergunta);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.PicBox_QuestionImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_BOX_DialogBox";
            this.Text = "Frm_DialogBox";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_QuestionImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBox_QuestionImage;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Pergunta;
        private System.Windows.Forms.Button Btn_RespostaPositiva;
        private System.Windows.Forms.Button Btn_RespostaNegativa;
    }
}