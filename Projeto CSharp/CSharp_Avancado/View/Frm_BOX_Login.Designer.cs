namespace CSharp_Avancado.View
{
    partial class Frm_BOX_Login
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
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.TxtBox_Usuario = new System.Windows.Forms.TextBox();
            this.PicBox_Usuario = new System.Windows.Forms.PictureBox();
            this.PicBox_Senha = new System.Windows.Forms.PictureBox();
            this.Btn_Entrar = new System.Windows.Forms.Button();
            this.PicBox_Sair = new System.Windows.Forms.PictureBox();
            this.PicBox_Configuracao = new System.Windows.Forms.PictureBox();
            this.MskTxtBox_Senha = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Senha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Configuracao)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Location = new System.Drawing.Point(206, 29);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "label1";
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Location = new System.Drawing.Point(154, 80);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Usuario.TabIndex = 1;
            this.Lbl_Usuario.Text = "label2";
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Location = new System.Drawing.Point(153, 142);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Senha.TabIndex = 2;
            this.Lbl_Senha.Text = "label3";
            // 
            // TxtBox_Usuario
            // 
            this.TxtBox_Usuario.Location = new System.Drawing.Point(152, 101);
            this.TxtBox_Usuario.Name = "TxtBox_Usuario";
            this.TxtBox_Usuario.Size = new System.Drawing.Size(167, 20);
            this.TxtBox_Usuario.TabIndex = 0;
            // 
            // PicBox_Usuario
            // 
            this.PicBox_Usuario.Location = new System.Drawing.Point(109, 85);
            this.PicBox_Usuario.Name = "PicBox_Usuario";
            this.PicBox_Usuario.Size = new System.Drawing.Size(35, 35);
            this.PicBox_Usuario.TabIndex = 5;
            this.PicBox_Usuario.TabStop = false;
            // 
            // PicBox_Senha
            // 
            this.PicBox_Senha.Location = new System.Drawing.Point(108, 149);
            this.PicBox_Senha.Name = "PicBox_Senha";
            this.PicBox_Senha.Size = new System.Drawing.Size(35, 35);
            this.PicBox_Senha.TabIndex = 6;
            this.PicBox_Senha.TabStop = false;
            // 
            // Btn_Entrar
            // 
            this.Btn_Entrar.Location = new System.Drawing.Point(152, 235);
            this.Btn_Entrar.Name = "Btn_Entrar";
            this.Btn_Entrar.Size = new System.Drawing.Size(140, 38);
            this.Btn_Entrar.TabIndex = 2;
            this.Btn_Entrar.Text = "button1";
            this.Btn_Entrar.UseVisualStyleBackColor = true;
            this.Btn_Entrar.Click += new System.EventHandler(this.Btn_Entrar_Click);
            // 
            // PicBox_Sair
            // 
            this.PicBox_Sair.Location = new System.Drawing.Point(386, 13);
            this.PicBox_Sair.Name = "PicBox_Sair";
            this.PicBox_Sair.Size = new System.Drawing.Size(30, 30);
            this.PicBox_Sair.TabIndex = 8;
            this.PicBox_Sair.TabStop = false;
            this.PicBox_Sair.Click += new System.EventHandler(this.PicBox_Sair_Click);
            // 
            // PicBox_Configuracao
            // 
            this.PicBox_Configuracao.Location = new System.Drawing.Point(330, 13);
            this.PicBox_Configuracao.Name = "PicBox_Configuracao";
            this.PicBox_Configuracao.Size = new System.Drawing.Size(30, 30);
            this.PicBox_Configuracao.TabIndex = 9;
            this.PicBox_Configuracao.TabStop = false;
            this.PicBox_Configuracao.Click += new System.EventHandler(this.PicBox_Configuracao_Click);
            // 
            // MskTxtBox_Senha
            // 
            this.MskTxtBox_Senha.Location = new System.Drawing.Point(152, 164);
            this.MskTxtBox_Senha.Name = "MskTxtBox_Senha";
            this.MskTxtBox_Senha.Size = new System.Drawing.Size(167, 20);
            this.MskTxtBox_Senha.TabIndex = 1;
            // 
            // Frm_BOX_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 285);
            this.Controls.Add(this.MskTxtBox_Senha);
            this.Controls.Add(this.PicBox_Configuracao);
            this.Controls.Add(this.PicBox_Sair);
            this.Controls.Add(this.Btn_Entrar);
            this.Controls.Add(this.PicBox_Senha);
            this.Controls.Add(this.PicBox_Usuario);
            this.Controls.Add(this.TxtBox_Usuario);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_BOX_Login";
            this.Text = "Frm_Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Login_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Senha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Configuracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.TextBox TxtBox_Usuario;
        private System.Windows.Forms.PictureBox PicBox_Usuario;
        private System.Windows.Forms.PictureBox PicBox_Senha;
        private System.Windows.Forms.Button Btn_Entrar;
        private System.Windows.Forms.PictureBox PicBox_Sair;
        private System.Windows.Forms.PictureBox PicBox_Configuracao;
        private System.Windows.Forms.MaskedTextBox MskTxtBox_Senha;
    }
}