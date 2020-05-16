namespace CSharp_Avancado.View
{
    partial class Frm_BOX_Pesquisar
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
            this.Dgv_Principal = new System.Windows.Forms.DataGridView();
            this.TxtBox_Pesquisa = new System.Windows.Forms.TextBox();
            this.Btn_Pesquisa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Principal)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Principal
            // 
            this.Dgv_Principal.AllowUserToAddRows = false;
            this.Dgv_Principal.AllowUserToDeleteRows = false;
            this.Dgv_Principal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Principal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Principal.Location = new System.Drawing.Point(12, 41);
            this.Dgv_Principal.Name = "Dgv_Principal";
            this.Dgv_Principal.ReadOnly = true;
            this.Dgv_Principal.Size = new System.Drawing.Size(686, 206);
            this.Dgv_Principal.TabIndex = 0;
            this.Dgv_Principal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv_Principal_KeyDown);
            // 
            // TxtBox_Pesquisa
            // 
            this.TxtBox_Pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBox_Pesquisa.Location = new System.Drawing.Point(12, 15);
            this.TxtBox_Pesquisa.Name = "TxtBox_Pesquisa";
            this.TxtBox_Pesquisa.Size = new System.Drawing.Size(605, 20);
            this.TxtBox_Pesquisa.TabIndex = 1;
            // 
            // Btn_Pesquisa
            // 
            this.Btn_Pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Pesquisa.Location = new System.Drawing.Point(623, 13);
            this.Btn_Pesquisa.Name = "Btn_Pesquisa";
            this.Btn_Pesquisa.Size = new System.Drawing.Size(75, 23);
            this.Btn_Pesquisa.TabIndex = 2;
            this.Btn_Pesquisa.Text = "button1";
            this.Btn_Pesquisa.UseVisualStyleBackColor = true;
            this.Btn_Pesquisa.Click += new System.EventHandler(this.Btn_Pesquisa_Click);
            // 
            // Frm_BOX_Pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(711, 258);
            this.Controls.Add(this.Btn_Pesquisa);
            this.Controls.Add(this.TxtBox_Pesquisa);
            this.Controls.Add(this.Dgv_Principal);
            this.Name = "Frm_BOX_Pesquisar";
            this.Text = "Frm_PesquisaProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Principal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Principal;
        private System.Windows.Forms.TextBox TxtBox_Pesquisa;
        private System.Windows.Forms.Button Btn_Pesquisa;
    }
}