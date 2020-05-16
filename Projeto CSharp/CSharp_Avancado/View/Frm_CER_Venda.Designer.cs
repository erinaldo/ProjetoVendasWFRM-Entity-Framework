namespace CSharp_Avancado.View
{
    partial class Frm_CER_Venda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dgv_Principal = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtBox_NomeVendedor = new System.Windows.Forms.TextBox();
            this.TxtBox_CodVendedor = new System.Windows.Forms.TextBox();
            this.Lbl_CodFuncionario = new System.Windows.Forms.Label();
            this.TxtBox_NomeCliente = new System.Windows.Forms.TextBox();
            this.Lbl_CodCliente = new System.Windows.Forms.Label();
            this.TxtBox_CodCliente = new System.Windows.Forms.TextBox();
            this.TxtBox_Doc = new System.Windows.Forms.TextBox();
            this.Lbl_Doc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtBox_ValorDoc = new System.Windows.Forms.TextBox();
            this.Lbl_ValorDoc = new System.Windows.Forms.Label();
            this.TxtBox_Observacao = new System.Windows.Forms.TextBox();
            this.Lbl_Observacao = new System.Windows.Forms.Label();
            this.TxtBox_Desconto = new System.Windows.Forms.TextBox();
            this.Lbl_Desconto = new System.Windows.Forms.Label();
            this.TxtBox_Acrescimo = new System.Windows.Forms.TextBox();
            this.Lbl_Acrescimo = new System.Windows.Forms.Label();
            this.TxtBox_ValorTotalProdutos = new System.Windows.Forms.TextBox();
            this.Lbl_ValorTotalProdutos = new System.Windows.Forms.Label();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Novo_Salvar = new System.Windows.Forms.Button();
            this.Btn_LimparCampos = new System.Windows.Forms.Button();
            this.Btn_Pesquisar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Principal)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Location = new System.Drawing.Point(407, 28);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Dgv_Principal);
            this.panel1.Controls.Add(this.TxtBox_NomeVendedor);
            this.panel1.Controls.Add(this.TxtBox_CodVendedor);
            this.panel1.Controls.Add(this.Lbl_CodFuncionario);
            this.panel1.Controls.Add(this.TxtBox_NomeCliente);
            this.panel1.Controls.Add(this.Lbl_CodCliente);
            this.panel1.Controls.Add(this.TxtBox_CodCliente);
            this.panel1.Controls.Add(this.TxtBox_Doc);
            this.panel1.Controls.Add(this.Lbl_Doc);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 210);
            this.panel1.TabIndex = 1;
            // 
            // Dgv_Principal
            // 
            this.Dgv_Principal.AllowUserToAddRows = false;
            this.Dgv_Principal.AllowUserToResizeColumns = false;
            this.Dgv_Principal.AllowUserToResizeRows = false;
            this.Dgv_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Principal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.Quantidade,
            this.Preco});
            this.Dgv_Principal.Location = new System.Drawing.Point(10, 50);
            this.Dgv_Principal.Name = "Dgv_Principal";
            this.Dgv_Principal.Size = new System.Drawing.Size(820, 155);
            this.Dgv_Principal.TabIndex = 2;
            this.Dgv_Principal.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Principal_CellMouseDoubleClick);
            this.Dgv_Principal.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.Dgv_Principal_RowsRemoved);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Cód.";
            this.Codigo.Name = "Codigo";
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descricao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Descricao.Width = 900;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quantidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Quantidade.Width = 150;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Preco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Preco.Width = 150;
            // 
            // TxtBox_NomeVendedor
            // 
            this.TxtBox_NomeVendedor.Location = new System.Drawing.Point(627, 10);
            this.TxtBox_NomeVendedor.Name = "TxtBox_NomeVendedor";
            this.TxtBox_NomeVendedor.Size = new System.Drawing.Size(164, 20);
            this.TxtBox_NomeVendedor.TabIndex = 11;
            // 
            // TxtBox_CodVendedor
            // 
            this.TxtBox_CodVendedor.Location = new System.Drawing.Point(576, 10);
            this.TxtBox_CodVendedor.Name = "TxtBox_CodVendedor";
            this.TxtBox_CodVendedor.Size = new System.Drawing.Size(45, 20);
            this.TxtBox_CodVendedor.TabIndex = 1;
            this.TxtBox_CodVendedor.TextChanged += new System.EventHandler(this.TxtBox_CodVendedor_TextChanged);
            this.TxtBox_CodVendedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBox_CodVendedor_KeyDown);
            // 
            // Lbl_CodFuncionario
            // 
            this.Lbl_CodFuncionario.AutoSize = true;
            this.Lbl_CodFuncionario.Location = new System.Drawing.Point(515, 13);
            this.Lbl_CodFuncionario.Name = "Lbl_CodFuncionario";
            this.Lbl_CodFuncionario.Size = new System.Drawing.Size(35, 13);
            this.Lbl_CodFuncionario.TabIndex = 9;
            this.Lbl_CodFuncionario.Text = "label5";
            // 
            // TxtBox_NomeCliente
            // 
            this.TxtBox_NomeCliente.Location = new System.Drawing.Point(219, 10);
            this.TxtBox_NomeCliente.Name = "TxtBox_NomeCliente";
            this.TxtBox_NomeCliente.Size = new System.Drawing.Size(291, 20);
            this.TxtBox_NomeCliente.TabIndex = 8;
            // 
            // Lbl_CodCliente
            // 
            this.Lbl_CodCliente.AutoSize = true;
            this.Lbl_CodCliente.Location = new System.Drawing.Point(122, 13);
            this.Lbl_CodCliente.Name = "Lbl_CodCliente";
            this.Lbl_CodCliente.Size = new System.Drawing.Size(35, 13);
            this.Lbl_CodCliente.TabIndex = 7;
            this.Lbl_CodCliente.Text = "label5";
            // 
            // TxtBox_CodCliente
            // 
            this.TxtBox_CodCliente.Location = new System.Drawing.Point(168, 10);
            this.TxtBox_CodCliente.Name = "TxtBox_CodCliente";
            this.TxtBox_CodCliente.Size = new System.Drawing.Size(45, 20);
            this.TxtBox_CodCliente.TabIndex = 0;
            this.TxtBox_CodCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBox_CodCliente_KeyDown);
            // 
            // TxtBox_Doc
            // 
            this.TxtBox_Doc.BackColor = System.Drawing.SystemColors.Control;
            this.TxtBox_Doc.Location = new System.Drawing.Point(54, 10);
            this.TxtBox_Doc.Name = "TxtBox_Doc";
            this.TxtBox_Doc.ReadOnly = true;
            this.TxtBox_Doc.Size = new System.Drawing.Size(62, 20);
            this.TxtBox_Doc.TabIndex = 13;
            // 
            // Lbl_Doc
            // 
            this.Lbl_Doc.AutoSize = true;
            this.Lbl_Doc.Location = new System.Drawing.Point(13, 13);
            this.Lbl_Doc.Name = "Lbl_Doc";
            this.Lbl_Doc.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Doc.TabIndex = 4;
            this.Lbl_Doc.Text = "label5";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TxtBox_ValorDoc);
            this.panel2.Controls.Add(this.Lbl_ValorDoc);
            this.panel2.Controls.Add(this.TxtBox_Observacao);
            this.panel2.Controls.Add(this.Lbl_Observacao);
            this.panel2.Controls.Add(this.TxtBox_Desconto);
            this.panel2.Controls.Add(this.Lbl_Desconto);
            this.panel2.Controls.Add(this.TxtBox_Acrescimo);
            this.panel2.Controls.Add(this.Lbl_Acrescimo);
            this.panel2.Controls.Add(this.TxtBox_ValorTotalProdutos);
            this.panel2.Controls.Add(this.Lbl_ValorTotalProdutos);
            this.panel2.Location = new System.Drawing.Point(12, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 100);
            this.panel2.TabIndex = 2;
            // 
            // TxtBox_ValorDoc
            // 
            this.TxtBox_ValorDoc.Location = new System.Drawing.Point(10, 68);
            this.TxtBox_ValorDoc.Name = "TxtBox_ValorDoc";
            this.TxtBox_ValorDoc.ReadOnly = true;
            this.TxtBox_ValorDoc.Size = new System.Drawing.Size(103, 20);
            this.TxtBox_ValorDoc.TabIndex = 21;
            // 
            // Lbl_ValorDoc
            // 
            this.Lbl_ValorDoc.AutoSize = true;
            this.Lbl_ValorDoc.Location = new System.Drawing.Point(7, 51);
            this.Lbl_ValorDoc.Name = "Lbl_ValorDoc";
            this.Lbl_ValorDoc.Size = new System.Drawing.Size(41, 13);
            this.Lbl_ValorDoc.TabIndex = 20;
            this.Lbl_ValorDoc.Text = "label11";
            // 
            // TxtBox_Observacao
            // 
            this.TxtBox_Observacao.Location = new System.Drawing.Point(424, 28);
            this.TxtBox_Observacao.Multiline = true;
            this.TxtBox_Observacao.Name = "TxtBox_Observacao";
            this.TxtBox_Observacao.Size = new System.Drawing.Size(361, 60);
            this.TxtBox_Observacao.TabIndex = 6;
            // 
            // Lbl_Observacao
            // 
            this.Lbl_Observacao.AutoSize = true;
            this.Lbl_Observacao.Location = new System.Drawing.Point(421, 12);
            this.Lbl_Observacao.Name = "Lbl_Observacao";
            this.Lbl_Observacao.Size = new System.Drawing.Size(41, 13);
            this.Lbl_Observacao.TabIndex = 18;
            this.Lbl_Observacao.Text = "label10";
            // 
            // TxtBox_Desconto
            // 
            this.TxtBox_Desconto.Location = new System.Drawing.Point(255, 28);
            this.TxtBox_Desconto.Name = "TxtBox_Desconto";
            this.TxtBox_Desconto.Size = new System.Drawing.Size(103, 20);
            this.TxtBox_Desconto.TabIndex = 5;
            this.TxtBox_Desconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBox_Desconto_KeyDown_1);
            // 
            // Lbl_Desconto
            // 
            this.Lbl_Desconto.AutoSize = true;
            this.Lbl_Desconto.Location = new System.Drawing.Point(252, 12);
            this.Lbl_Desconto.Name = "Lbl_Desconto";
            this.Lbl_Desconto.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Desconto.TabIndex = 17;
            this.Lbl_Desconto.Text = "label9";
            // 
            // TxtBox_Acrescimo
            // 
            this.TxtBox_Acrescimo.Location = new System.Drawing.Point(132, 28);
            this.TxtBox_Acrescimo.Name = "TxtBox_Acrescimo";
            this.TxtBox_Acrescimo.Size = new System.Drawing.Size(103, 20);
            this.TxtBox_Acrescimo.TabIndex = 4;
            this.TxtBox_Acrescimo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBox_Acrescimo_KeyDown_1);
            // 
            // Lbl_Acrescimo
            // 
            this.Lbl_Acrescimo.AutoSize = true;
            this.Lbl_Acrescimo.Location = new System.Drawing.Point(129, 12);
            this.Lbl_Acrescimo.Name = "Lbl_Acrescimo";
            this.Lbl_Acrescimo.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Acrescimo.TabIndex = 15;
            this.Lbl_Acrescimo.Text = "label8";
            // 
            // TxtBox_ValorTotalProdutos
            // 
            this.TxtBox_ValorTotalProdutos.Location = new System.Drawing.Point(10, 28);
            this.TxtBox_ValorTotalProdutos.Name = "TxtBox_ValorTotalProdutos";
            this.TxtBox_ValorTotalProdutos.Size = new System.Drawing.Size(103, 20);
            this.TxtBox_ValorTotalProdutos.TabIndex = 3;
            this.TxtBox_ValorTotalProdutos.Enter += new System.EventHandler(this.TxtBox_ValorTotalProdutos_Enter);
            this.TxtBox_ValorTotalProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBox_ValorTotalProdutos_KeyDown);
            // 
            // Lbl_ValorTotalProdutos
            // 
            this.Lbl_ValorTotalProdutos.AutoSize = true;
            this.Lbl_ValorTotalProdutos.Location = new System.Drawing.Point(7, 12);
            this.Lbl_ValorTotalProdutos.Name = "Lbl_ValorTotalProdutos";
            this.Lbl_ValorTotalProdutos.Size = new System.Drawing.Size(35, 13);
            this.Lbl_ValorTotalProdutos.TabIndex = 13;
            this.Lbl_ValorTotalProdutos.Text = "label7";
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Voltar.Location = new System.Drawing.Point(751, 397);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(95, 30);
            this.Btn_Voltar.TabIndex = 11;
            this.Btn_Voltar.Text = "button1";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Excluir.Location = new System.Drawing.Point(598, 397);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(95, 30);
            this.Btn_Excluir.TabIndex = 12;
            this.Btn_Excluir.Text = "button2";
            this.Btn_Excluir.UseVisualStyleBackColor = true;
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Editar.Location = new System.Drawing.Point(470, 397);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(95, 30);
            this.Btn_Editar.TabIndex = 10;
            this.Btn_Editar.Text = "button3";
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_Novo_Salvar
            // 
            this.Btn_Novo_Salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Novo_Salvar.Location = new System.Drawing.Point(347, 397);
            this.Btn_Novo_Salvar.Name = "Btn_Novo_Salvar";
            this.Btn_Novo_Salvar.Size = new System.Drawing.Size(95, 30);
            this.Btn_Novo_Salvar.TabIndex = 7;
            this.Btn_Novo_Salvar.Text = "button1";
            this.Btn_Novo_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Novo_Salvar.Click += new System.EventHandler(this.Btn_Novo_Salvar_Click);
            // 
            // Btn_LimparCampos
            // 
            this.Btn_LimparCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_LimparCampos.Location = new System.Drawing.Point(12, 397);
            this.Btn_LimparCampos.Name = "Btn_LimparCampos";
            this.Btn_LimparCampos.Size = new System.Drawing.Size(130, 30);
            this.Btn_LimparCampos.TabIndex = 8;
            this.Btn_LimparCampos.Text = "button2";
            this.Btn_LimparCampos.UseVisualStyleBackColor = true;
            this.Btn_LimparCampos.Click += new System.EventHandler(this.Btn_LimparCampos_Click);
            // 
            // Btn_Pesquisar
            // 
            this.Btn_Pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Pesquisar.Location = new System.Drawing.Point(223, 395);
            this.Btn_Pesquisar.Name = "Btn_Pesquisar";
            this.Btn_Pesquisar.Size = new System.Drawing.Size(95, 30);
            this.Btn_Pesquisar.TabIndex = 9;
            this.Btn_Pesquisar.Text = "button4";
            this.Btn_Pesquisar.UseVisualStyleBackColor = true;
            this.Btn_Pesquisar.Click += new System.EventHandler(this.Btn_Pesquisar_Click);
            // 
            // Frm_CER_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 437);
            this.Controls.Add(this.Btn_Pesquisar);
            this.Controls.Add(this.Btn_LimparCampos);
            this.Controls.Add(this.Btn_Novo_Salvar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Excluir);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_Titulo);
            this.Name = "Frm_CER_Venda";
            this.Text = "Frm_NovaVenda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Principal)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Button Btn_Excluir;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.TextBox TxtBox_NomeVendedor;
        private System.Windows.Forms.TextBox TxtBox_CodVendedor;
        private System.Windows.Forms.Label Lbl_CodFuncionario;
        private System.Windows.Forms.TextBox TxtBox_NomeCliente;
        private System.Windows.Forms.Label Lbl_CodCliente;
        private System.Windows.Forms.TextBox TxtBox_CodCliente;
        private System.Windows.Forms.TextBox TxtBox_Doc;
        private System.Windows.Forms.Label Lbl_Doc;
        private System.Windows.Forms.TextBox TxtBox_Desconto;
        private System.Windows.Forms.Label Lbl_Desconto;
        private System.Windows.Forms.TextBox TxtBox_Acrescimo;
        private System.Windows.Forms.Label Lbl_Acrescimo;
        private System.Windows.Forms.TextBox TxtBox_ValorTotalProdutos;
        private System.Windows.Forms.Label Lbl_ValorTotalProdutos;
        private System.Windows.Forms.TextBox TxtBox_ValorDoc;
        private System.Windows.Forms.Label Lbl_ValorDoc;
        private System.Windows.Forms.TextBox TxtBox_Observacao;
        private System.Windows.Forms.Label Lbl_Observacao;
        private System.Windows.Forms.Button Btn_Novo_Salvar;
        private System.Windows.Forms.Button Btn_LimparCampos;
        private System.Windows.Forms.Button Btn_Pesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridView Dgv_Principal;
    }
}