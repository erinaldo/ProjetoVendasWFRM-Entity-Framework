namespace CSharp_Avancado.View
{
    partial class Frm_CER_Produto
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
            this.Lbl_DescricaoProd = new System.Windows.Forms.Label();
            this.TxtBox_DescricaoProd = new System.Windows.Forms.TextBox();
            this.TxtBox_Marca = new System.Windows.Forms.TextBox();
            this.Lbl_Marca = new System.Windows.Forms.Label();
            this.TxtBox_Tipo = new System.Windows.Forms.TextBox();
            this.Lbl_Tipo = new System.Windows.Forms.Label();
            this.GrpBox_Descricao = new System.Windows.Forms.GroupBox();
            this.TxtBox_Quantidade = new System.Windows.Forms.TextBox();
            this.Lbl_Quantidade = new System.Windows.Forms.Label();
            this.GrpBox_Preco = new System.Windows.Forms.GroupBox();
            this.TxtBox_PrecoCompra = new System.Windows.Forms.TextBox();
            this.Lbl_PrecoCompra = new System.Windows.Forms.Label();
            this.Lbl_PrecoVenda = new System.Windows.Forms.Label();
            this.TxtBox_PrecoVenda = new System.Windows.Forms.TextBox();
            this.Btn_Novo_Salvar = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Btn_LimparCampos = new System.Windows.Forms.Button();
            this.PicBox_ImagemProduto = new System.Windows.Forms.PictureBox();
            this.Lbl_ImagemProduto = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Btn_ImagemProduto = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Pesquisar = new System.Windows.Forms.Button();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.GrpBox_Descricao.SuspendLayout();
            this.GrpBox_Preco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_ImagemProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Location = new System.Drawing.Point(331, 22);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "label1";
            // 
            // Lbl_DescricaoProd
            // 
            this.Lbl_DescricaoProd.AutoSize = true;
            this.Lbl_DescricaoProd.Location = new System.Drawing.Point(9, 41);
            this.Lbl_DescricaoProd.Name = "Lbl_DescricaoProd";
            this.Lbl_DescricaoProd.Size = new System.Drawing.Size(35, 13);
            this.Lbl_DescricaoProd.TabIndex = 1;
            this.Lbl_DescricaoProd.Text = "label2";
            // 
            // TxtBox_DescricaoProd
            // 
            this.TxtBox_DescricaoProd.Location = new System.Drawing.Point(72, 38);
            this.TxtBox_DescricaoProd.Name = "TxtBox_DescricaoProd";
            this.TxtBox_DescricaoProd.Size = new System.Drawing.Size(325, 20);
            this.TxtBox_DescricaoProd.TabIndex = 0;
            // 
            // TxtBox_Marca
            // 
            this.TxtBox_Marca.Location = new System.Drawing.Point(72, 73);
            this.TxtBox_Marca.Name = "TxtBox_Marca";
            this.TxtBox_Marca.Size = new System.Drawing.Size(232, 20);
            this.TxtBox_Marca.TabIndex = 1;
            // 
            // Lbl_Marca
            // 
            this.Lbl_Marca.AutoSize = true;
            this.Lbl_Marca.Location = new System.Drawing.Point(9, 76);
            this.Lbl_Marca.Name = "Lbl_Marca";
            this.Lbl_Marca.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Marca.TabIndex = 3;
            this.Lbl_Marca.Text = "label3";
            // 
            // TxtBox_Tipo
            // 
            this.TxtBox_Tipo.Location = new System.Drawing.Point(72, 108);
            this.TxtBox_Tipo.Name = "TxtBox_Tipo";
            this.TxtBox_Tipo.Size = new System.Drawing.Size(143, 20);
            this.TxtBox_Tipo.TabIndex = 2;
            // 
            // Lbl_Tipo
            // 
            this.Lbl_Tipo.AutoSize = true;
            this.Lbl_Tipo.Location = new System.Drawing.Point(9, 111);
            this.Lbl_Tipo.Name = "Lbl_Tipo";
            this.Lbl_Tipo.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Tipo.TabIndex = 5;
            this.Lbl_Tipo.Text = "label4";
            // 
            // GrpBox_Descricao
            // 
            this.GrpBox_Descricao.Controls.Add(this.TxtBox_DescricaoProd);
            this.GrpBox_Descricao.Controls.Add(this.TxtBox_Quantidade);
            this.GrpBox_Descricao.Controls.Add(this.TxtBox_Tipo);
            this.GrpBox_Descricao.Controls.Add(this.Lbl_Quantidade);
            this.GrpBox_Descricao.Controls.Add(this.Lbl_DescricaoProd);
            this.GrpBox_Descricao.Controls.Add(this.Lbl_Tipo);
            this.GrpBox_Descricao.Controls.Add(this.Lbl_Marca);
            this.GrpBox_Descricao.Controls.Add(this.TxtBox_Marca);
            this.GrpBox_Descricao.Location = new System.Drawing.Point(34, 64);
            this.GrpBox_Descricao.Name = "GrpBox_Descricao";
            this.GrpBox_Descricao.Size = new System.Drawing.Size(414, 173);
            this.GrpBox_Descricao.TabIndex = 0;
            this.GrpBox_Descricao.TabStop = false;
            this.GrpBox_Descricao.Text = "groupBox1";
            // 
            // TxtBox_Quantidade
            // 
            this.TxtBox_Quantidade.Location = new System.Drawing.Point(72, 142);
            this.TxtBox_Quantidade.Name = "TxtBox_Quantidade";
            this.TxtBox_Quantidade.Size = new System.Drawing.Size(143, 20);
            this.TxtBox_Quantidade.TabIndex = 4;
            // 
            // Lbl_Quantidade
            // 
            this.Lbl_Quantidade.AutoSize = true;
            this.Lbl_Quantidade.Location = new System.Drawing.Point(9, 145);
            this.Lbl_Quantidade.Name = "Lbl_Quantidade";
            this.Lbl_Quantidade.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Quantidade.TabIndex = 5;
            this.Lbl_Quantidade.Text = "label6";
            // 
            // GrpBox_Preco
            // 
            this.GrpBox_Preco.Controls.Add(this.TxtBox_PrecoCompra);
            this.GrpBox_Preco.Controls.Add(this.Lbl_PrecoCompra);
            this.GrpBox_Preco.Controls.Add(this.Lbl_PrecoVenda);
            this.GrpBox_Preco.Controls.Add(this.TxtBox_PrecoVenda);
            this.GrpBox_Preco.Location = new System.Drawing.Point(476, 64);
            this.GrpBox_Preco.Name = "GrpBox_Preco";
            this.GrpBox_Preco.Size = new System.Drawing.Size(215, 101);
            this.GrpBox_Preco.TabIndex = 1;
            this.GrpBox_Preco.TabStop = false;
            this.GrpBox_Preco.Text = "groupBox2";
            // 
            // TxtBox_PrecoCompra
            // 
            this.TxtBox_PrecoCompra.Location = new System.Drawing.Point(81, 34);
            this.TxtBox_PrecoCompra.Name = "TxtBox_PrecoCompra";
            this.TxtBox_PrecoCompra.Size = new System.Drawing.Size(117, 20);
            this.TxtBox_PrecoCompra.TabIndex = 5;
            // 
            // Lbl_PrecoCompra
            // 
            this.Lbl_PrecoCompra.AutoSize = true;
            this.Lbl_PrecoCompra.Location = new System.Drawing.Point(8, 37);
            this.Lbl_PrecoCompra.Name = "Lbl_PrecoCompra";
            this.Lbl_PrecoCompra.Size = new System.Drawing.Size(35, 13);
            this.Lbl_PrecoCompra.TabIndex = 1;
            this.Lbl_PrecoCompra.Text = "label5";
            // 
            // Lbl_PrecoVenda
            // 
            this.Lbl_PrecoVenda.AutoSize = true;
            this.Lbl_PrecoVenda.Location = new System.Drawing.Point(8, 72);
            this.Lbl_PrecoVenda.Name = "Lbl_PrecoVenda";
            this.Lbl_PrecoVenda.Size = new System.Drawing.Size(35, 13);
            this.Lbl_PrecoVenda.TabIndex = 3;
            this.Lbl_PrecoVenda.Text = "label7";
            // 
            // TxtBox_PrecoVenda
            // 
            this.TxtBox_PrecoVenda.Location = new System.Drawing.Point(81, 69);
            this.TxtBox_PrecoVenda.Name = "TxtBox_PrecoVenda";
            this.TxtBox_PrecoVenda.Size = new System.Drawing.Size(117, 20);
            this.TxtBox_PrecoVenda.TabIndex = 6;
            // 
            // Btn_Novo_Salvar
            // 
            this.Btn_Novo_Salvar.Location = new System.Drawing.Point(366, 377);
            this.Btn_Novo_Salvar.Name = "Btn_Novo_Salvar";
            this.Btn_Novo_Salvar.Size = new System.Drawing.Size(95, 30);
            this.Btn_Novo_Salvar.TabIndex = 8;
            this.Btn_Novo_Salvar.Text = "button1";
            this.Btn_Novo_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Novo_Salvar.Click += new System.EventHandler(this.Btn_Novo_Salvar_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Location = new System.Drawing.Point(786, 377);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(95, 30);
            this.Btn_Voltar.TabIndex = 12;
            this.Btn_Voltar.Text = "button2";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Btn_LimparCampos
            // 
            this.Btn_LimparCampos.Location = new System.Drawing.Point(34, 377);
            this.Btn_LimparCampos.Name = "Btn_LimparCampos";
            this.Btn_LimparCampos.Size = new System.Drawing.Size(130, 30);
            this.Btn_LimparCampos.TabIndex = 9;
            this.Btn_LimparCampos.Text = "button3";
            this.Btn_LimparCampos.UseVisualStyleBackColor = true;
            this.Btn_LimparCampos.Click += new System.EventHandler(this.Btn_LimparCampos_Click);
            // 
            // PicBox_ImagemProduto
            // 
            this.PicBox_ImagemProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBox_ImagemProduto.Location = new System.Drawing.Point(741, 68);
            this.PicBox_ImagemProduto.Name = "PicBox_ImagemProduto";
            this.PicBox_ImagemProduto.Size = new System.Drawing.Size(140, 120);
            this.PicBox_ImagemProduto.TabIndex = 12;
            this.PicBox_ImagemProduto.TabStop = false;
            // 
            // Lbl_ImagemProduto
            // 
            this.Lbl_ImagemProduto.AutoSize = true;
            this.Lbl_ImagemProduto.Location = new System.Drawing.Point(738, 45);
            this.Lbl_ImagemProduto.Name = "Lbl_ImagemProduto";
            this.Lbl_ImagemProduto.Size = new System.Drawing.Size(35, 13);
            this.Lbl_ImagemProduto.TabIndex = 7;
            this.Lbl_ImagemProduto.Text = "label8";
            // 
            // Btn_ImagemProduto
            // 
            this.Btn_ImagemProduto.Location = new System.Drawing.Point(741, 191);
            this.Btn_ImagemProduto.Name = "Btn_ImagemProduto";
            this.Btn_ImagemProduto.Size = new System.Drawing.Size(140, 22);
            this.Btn_ImagemProduto.TabIndex = 7;
            this.Btn_ImagemProduto.Text = "button4";
            this.Btn_ImagemProduto.UseVisualStyleBackColor = true;
            this.Btn_ImagemProduto.Click += new System.EventHandler(this.Btn_ImagemProduto_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Location = new System.Drawing.Point(487, 377);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(95, 30);
            this.Btn_Editar.TabIndex = 11;
            this.Btn_Editar.Text = "button1";
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_Pesquisar
            // 
            this.Btn_Pesquisar.Location = new System.Drawing.Point(243, 377);
            this.Btn_Pesquisar.Name = "Btn_Pesquisar";
            this.Btn_Pesquisar.Size = new System.Drawing.Size(95, 30);
            this.Btn_Pesquisar.TabIndex = 10;
            this.Btn_Pesquisar.Text = "button1";
            this.Btn_Pesquisar.UseVisualStyleBackColor = true;
            this.Btn_Pesquisar.Click += new System.EventHandler(this.Btn_Pesquisar_Click);
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.Location = new System.Drawing.Point(609, 377);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(95, 30);
            this.Btn_Excluir.TabIndex = 13;
            this.Btn_Excluir.Text = "button1";
            this.Btn_Excluir.UseVisualStyleBackColor = true;
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // Frm_CER_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 422);
            this.Controls.Add(this.Btn_Excluir);
            this.Controls.Add(this.Btn_Pesquisar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_ImagemProduto);
            this.Controls.Add(this.Lbl_ImagemProduto);
            this.Controls.Add(this.PicBox_ImagemProduto);
            this.Controls.Add(this.Btn_LimparCampos);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Novo_Salvar);
            this.Controls.Add(this.GrpBox_Preco);
            this.Controls.Add(this.GrpBox_Descricao);
            this.Controls.Add(this.Lbl_Titulo);
            this.Name = "Frm_CER_Produto";
            this.Text = "Frm_CadastrarProduto";
            this.GrpBox_Descricao.ResumeLayout(false);
            this.GrpBox_Descricao.PerformLayout();
            this.GrpBox_Preco.ResumeLayout(false);
            this.GrpBox_Preco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_ImagemProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_DescricaoProd;
        private System.Windows.Forms.TextBox TxtBox_DescricaoProd;
        private System.Windows.Forms.TextBox TxtBox_Marca;
        private System.Windows.Forms.Label Lbl_Marca;
        private System.Windows.Forms.TextBox TxtBox_Tipo;
        private System.Windows.Forms.Label Lbl_Tipo;
        private System.Windows.Forms.GroupBox GrpBox_Descricao;
        private System.Windows.Forms.GroupBox GrpBox_Preco;
        private System.Windows.Forms.TextBox TxtBox_PrecoCompra;
        private System.Windows.Forms.TextBox TxtBox_Quantidade;
        private System.Windows.Forms.Label Lbl_PrecoCompra;
        private System.Windows.Forms.Label Lbl_Quantidade;
        private System.Windows.Forms.Label Lbl_PrecoVenda;
        private System.Windows.Forms.TextBox TxtBox_PrecoVenda;
        private System.Windows.Forms.Button Btn_Novo_Salvar;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Button Btn_LimparCampos;
        private System.Windows.Forms.PictureBox PicBox_ImagemProduto;
        private System.Windows.Forms.Label Lbl_ImagemProduto;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Btn_ImagemProduto;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Pesquisar;
        private System.Windows.Forms.Button Btn_Excluir;
    }
}