using CSharp_Avancado.Controller;
using CSharp_Avancado.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Avancado.View
{
    public partial class Frm_CER_Produto : Form
    {
        // global var
        string caminhoImagem = "";
        int idProdutoEdicao = 0;

        public Frm_CER_Produto()
        {
            InitializeComponent();
            SetComponents();
        }

        public void SetComponents()
        {
            // Form
            this.Font = Defaults.microsoftSansSerif10Bold;
            this.StartPosition = Defaults.frmStartPointAtCenterScreen;
            this.Text = "Produto";
            this.Icon = Defaults.getIconByName("mais1");
            // Group Box
            GrpBox_Descricao.Text = "Descrição";
            GrpBox_Preco.Text = "Preço";
            // Label
            Lbl_Titulo.Font = Defaults.fontPadraoTituloJanelas16Bold;

            Lbl_DescricaoProd.Text = "Descrição";
            Lbl_ImagemProduto.Text = "Imagem do Produto";
            Lbl_Marca.Text = "Marca";
            Lbl_PrecoCompra.Text = "Preço Compra";
            Lbl_PrecoVenda.Text = "Preço Venda";
            Lbl_Tipo.Text = "Tipo";
            Lbl_Titulo.Text = "Produto";
            Lbl_Quantidade.Text = "Quantidade";
            Lbl_Validade.Text = "Validade";
            // Text Box
            // Masked Text Box
            MskTxtBox_Validade.Mask = Defaults.dataMask;
            // Picture Box
            PicBox_ImagemProduto.SizeMode = Defaults.stretchImageStyle;
            // Button
            Btn_Voltar.Text = "Voltar";
            Btn_Novo_Salvar.Text = "Novo";
            Btn_LimparCampos.Text = "Limpar Campos";
            Btn_ImagemProduto.Text = "Escolher...";
            Btn_Editar.Text = "Editar";
            Btn_Excluir.Text = "Excluir";
            Btn_Pesquisar.Text = "Pesquisar";

            DefinirEditabilidadeDosCampos(false);
            Btn_Pesquisar.Enabled = true;
        }

        public void AdicionarProdutoNoFormulario(Produto produto)
        {
            idProdutoEdicao = produto.Id;
            TxtBox_DescricaoProd.Text = produto.Descricao;
            TxtBox_Marca.Text = produto.Marca;
            TxtBox_PrecoCompra.Text = Convert.ToString(produto.PrecoCompra);
            TxtBox_PrecoVenda.Text = Convert.ToString(produto.PrecoVenda);
            TxtBox_Tipo.Text = produto.Tipo;
            TxtBox_Quantidade.Text = Convert.ToString(produto.Quantidade);
            //MskTxtBox_Validade.Text = Convert.ToString(produto.Validade);
            if (!String.IsNullOrEmpty(produto.Imagem))
                PicBox_ImagemProduto.Image = Image.FromFile(produto.Imagem);
        }

        private void LimparFormulario()
        {
            idProdutoEdicao = 0;

            TxtBox_DescricaoProd.Text = "";
            TxtBox_Marca.Text = "";
            TxtBox_PrecoCompra.Text = "";
            TxtBox_PrecoVenda.Text = "";
            TxtBox_Quantidade.Text = "";
            TxtBox_Tipo.Text = "";

            MskTxtBox_Validade.Text = "";
            PicBox_ImagemProduto.Image = null;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
            DefinirEditabilidadeDosCampos(false);
            Btn_Pesquisar.Enabled = true;
            Btn_Novo_Salvar.Text = "Novo";
        }

        private void Btn_LimparCampos_Click(object sender, EventArgs e)
        {
            LimparFormulario();
            DefinirEditabilidadeDosCampos(false);
            Btn_Pesquisar.Enabled = true;
            Btn_Novo_Salvar.Text = "Novo";
        }

        private void Btn_ImagemProduto_Click(object sender, EventArgs e)
        {
            caminhoImagem = new Uteis().AbrirPasta();

            if (caminhoImagem != null)
            {
                try
                {
                    PicBox_ImagemProduto.Image = Image.FromFile(caminhoImagem);
                }
                catch (System.OutOfMemoryException)
                {
                    MessageBox.Show("Formato de imagem não suportado, recomendado .JPG & .PNG", "Erro de Formato");
                }
            }
            else
                PicBox_ImagemProduto.Image = null;
        }

        private void DefinirEditabilidadeDosCampos(bool status)
        {
            MskTxtBox_Validade.Enabled = status;
            TxtBox_DescricaoProd.Enabled = status;
            TxtBox_Marca.Enabled = status;
            TxtBox_PrecoCompra.Enabled = status;
            TxtBox_PrecoVenda.Enabled = status;
            TxtBox_Quantidade.Enabled = status;
            TxtBox_Tipo.Enabled = status;
            Btn_ImagemProduto.Enabled = status;

            Btn_Pesquisar.Enabled = false;
        }

        private void Btn_Novo_Salvar_Click(object sender, EventArgs e)
        {
            var nomeBotao = Btn_Novo_Salvar.Text;

            if (Btn_Novo_Salvar.Text == "Novo")
            {
                LimparFormulario();
                DefinirEditabilidadeDosCampos(true);
                Btn_Pesquisar.Enabled = false;
                Btn_Novo_Salvar.Text = "Salvar";                
            }
            else
            {
                Btn_Novo_Salvar.Text = "Novo";
                DefinirEditabilidadeDosCampos(false);
            }

            if (nomeBotao.Equals("Salvar"))
            {
                if (idProdutoEdicao > 0)
                {
                    new DBC().AtualizarProduto(new Produto
                    {
                        Id = idProdutoEdicao,
                        Descricao = TxtBox_DescricaoProd.Text,
                        Tipo = TxtBox_Tipo.Text,
                        Marca = TxtBox_Marca.Text,
                        //Validade = Convert.ToDateTime(MskTxtBox_Validade.Text),
                        Quantidade = Convert.ToInt32(TxtBox_Quantidade.Text),
                        PrecoCompra = Convert.ToDouble(TxtBox_PrecoCompra.Text),
                        PrecoVenda = Convert.ToDouble(TxtBox_PrecoVenda.Text),
                        Imagem = caminhoImagem
                    });
                }
                else
                {
                    new DBC().InserirProduto(new Produto
                    {
                        Descricao = TxtBox_DescricaoProd.Text,
                        Tipo = TxtBox_Tipo.Text,
                        Marca = TxtBox_Marca.Text,
                        //Validade = Convert.ToDateTime(MskTxtBox_Validade.Text),
                        Quantidade = Convert.ToInt32(TxtBox_Quantidade.Text),
                        PrecoCompra = Convert.ToDouble(TxtBox_PrecoCompra.Text),
                        PrecoVenda = Convert.ToDouble(TxtBox_PrecoVenda.Text),
                        Imagem = caminhoImagem
                    });
                }
            }
        }


        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            var frm = new Frm_BOX_Pesquisar(this, "Produtos", "Cadastro Produto");
            frm.ShowDialog();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (idProdutoEdicao > 0)
            {
                Btn_Novo_Salvar.Text = "Salvar";
                DefinirEditabilidadeDosCampos(true);
            }
            else
            {
                MessageBox.Show("Pesquise antes de editar.", "Operação inválida");
            }
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            if (idProdutoEdicao > 0)
            {
                var confirmacao = MessageBox.Show("Deseja realmente excluir o produto?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmacao == DialogResult.Yes)
                {
                    new DBC().ExcluirProduto(new Produto
                    {
                        Id = idProdutoEdicao,
                        Descricao = TxtBox_DescricaoProd.Text,
                        Tipo = TxtBox_Tipo.Text,
                        Marca = TxtBox_Marca.Text,
                        //Validade = Convert.ToDateTime(MskTxtBox_Validade.Text),
                        Quantidade = Convert.ToInt32(TxtBox_Quantidade.Text),
                        PrecoCompra = Convert.ToDouble(TxtBox_PrecoCompra.Text),
                        PrecoVenda = Convert.ToDouble(TxtBox_PrecoVenda.Text),
                        Imagem = caminhoImagem
                    });

                    LimparFormulario();
                }
            }
        }
    }
}
