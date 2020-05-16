using CSharp_Avancado.Controller;
using CSharp_Avancado.Model;
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
    public partial class Frm_CER_Venda : Form
    {
        int tableIndex = 0;
        private int idVendaEdicao = 0;
        List<Produto> produtosVenda = new List<Produto>();

        public Frm_CER_Venda()
        {
            InitializeComponent();
            SetComponents();
        }

        public void SetComponents()
        {
            // Form
            this.Font = Defaults.microsoftSansSerif12Bold;
            this.StartPosition = Defaults.frmStartPointAtCenterScreen;
            this.Text = "Venda";
            // Group Box
            // Label
            Lbl_Titulo.Text = "Venda";
            Lbl_Acrescimo.Text = "Acréscimo";
            Lbl_CodCliente.Text = "Cliente";
            Lbl_Desconto.Text = "Desconto";
            Lbl_Doc.Text = "Doc.";
            Lbl_Observacao.Text = "Observação";
            Lbl_ValorDoc.Text = "Valor Doc.";
            Lbl_ValorTotalProdutos.Text = "Total Prod.";
            Lbl_CodFuncionario.Text = "Funcionário";
            // Text Box
            TxtBox_ValorDoc.Text = "0";
            TxtBox_Desconto.Text = "0";
            TxtBox_Acrescimo.Text = "0";
            TxtBox_ValorTotalProdutos.Text = "0";
            // Picture Box
            // Button
            Btn_Voltar.Text = "Voltar";
            Btn_Novo_Salvar.Text = "Novo";
            Btn_LimparCampos.Text = "Limpar Campos";
            Btn_Editar.Text = "Editar";
            Btn_Excluir.Text = "Excluir";
            Btn_Pesquisar.Text = "Pesquisar";
            // Data Grid View
            Dgv_Principal.Rows.Add();

            DefinirEditabilidadeDosCampos(false);
            Btn_Pesquisar.Enabled = true;
        }

        void Limpar()
        {
            idVendaEdicao = 0;
            Dgv_Principal.Rows.Clear();
            tableIndex = 0;

            TxtBox_CodCliente.Text = "";
            TxtBox_NomeCliente.Text = "";
            TxtBox_CodVendedor.Text = "";
            TxtBox_NomeVendedor.Text = "";
            TxtBox_ValorDoc.Text = "0";
            TxtBox_ValorTotalProdutos.Text = "0";
            TxtBox_Observacao.Text = "";
            TxtBox_Desconto.Text = "0";
            TxtBox_Acrescimo.Text = "0";
        }

        public void AdicionarProdutoNaGrid(Produto produtoSelecionado)
        {
            Dgv_Principal.Rows.Add();

            Dgv_Principal.Rows[tableIndex].Cells[0].Value = produtoSelecionado.Id;
            Dgv_Principal.Rows[tableIndex].Cells[1].Value = produtoSelecionado.Descricao;
            Dgv_Principal.Rows[tableIndex].Cells[2].Value = 1;
            Dgv_Principal.Rows[tableIndex].Cells[3].Value = produtoSelecionado.PrecoVenda;

            produtoSelecionado.Quantidade = Convert.ToInt32(Dgv_Principal.Rows[tableIndex].Cells[2].Value);
            produtosVenda.Add(produtoSelecionado);

            tableIndex++;
        }

        public void AdicionarProdutosRecuperadosDaVendaNaGrid(Produto produtoSelecionado, Compra compras)
        {
            Dgv_Principal.Rows.Add();

            Dgv_Principal.Rows[tableIndex].Cells[0].Value = produtoSelecionado.Id;
            Dgv_Principal.Rows[tableIndex].Cells[1].Value = produtoSelecionado.Descricao;
            Dgv_Principal.Rows[tableIndex].Cells[2].Value = compras.QuantidadeProduto;
            Dgv_Principal.Rows[tableIndex].Cells[3].Value = produtoSelecionado.PrecoVenda;

            produtosVenda.Add(produtoSelecionado);

            tableIndex++;
        }

        private void DefinirEditabilidadeDosCampos(bool status)
        {
            Dgv_Principal.Enabled = status;
            TxtBox_CodCliente.Enabled = status;
            TxtBox_NomeCliente.Enabled = status;
            TxtBox_CodVendedor.Enabled = status;
            TxtBox_NomeVendedor.Enabled = status;
            TxtBox_ValorDoc.Enabled = status;
            TxtBox_ValorTotalProdutos.Enabled = status;
            TxtBox_Observacao.Enabled = status;
            TxtBox_Desconto.Enabled = status;
            TxtBox_Acrescimo.Enabled = status;
            TxtBox_Doc.Enabled = false;
            Btn_Pesquisar.Enabled = false;
        }

        private void CalculaValores()
        {
            var valorProdutos = 0d;
            TxtBox_ValorTotalProdutos.Text = Convert.ToString(valorProdutos);

            for (int i = 0; i < Dgv_Principal.Rows.Count - 1; i++)
            {
                valorProdutos = Convert.ToDouble(TxtBox_ValorTotalProdutos.Text);

                var valorNovoProduto = Convert.ToDouble(Dgv_Principal.Rows[i].Cells[3].Value.ToString());
                var quantidadeNovoProduto = Convert.ToInt32(Dgv_Principal.Rows[i].Cells[2].Value.ToString());

                valorProdutos += (valorNovoProduto * quantidadeNovoProduto);
                TxtBox_ValorTotalProdutos.Text = Convert.ToString(valorProdutos);
            }

            // define valores nos campos de valores da venda
            var valorTotalDoc = ((Convert.ToDouble(TxtBox_ValorTotalProdutos.Text.Trim(',')) + Convert.ToDouble(TxtBox_Acrescimo.Text.Trim(','))) - Convert.ToDouble(TxtBox_Desconto.Text.Trim(',')));
            TxtBox_ValorDoc.Text = Convert.ToString(valorTotalDoc);
        }

        public void AdicionarClienteNaVenda(Cliente cliente)
        {
            TxtBox_CodCliente.Text = Convert.ToString(cliente.Id);
            TxtBox_NomeCliente.Text = cliente.Nome;
        }

        public void AdicionarVendedorNaVenda(Funcionario vendedor)
        {
            TxtBox_CodVendedor.Text = Convert.ToString(vendedor.Id);
            TxtBox_NomeVendedor.Text = vendedor.Nome;
        }

        private void DGV_Principal_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var frm = new Frm_BOX_Pesquisar(this, "Produtos", "Venda");
            frm.ShowDialog();
        }

        private void Btn_Novo_Salvar_Click(object sender, EventArgs e)
        {
            var nomeBotao = Btn_Novo_Salvar.Text;

            if (Btn_Novo_Salvar.Text == "Novo")
            {
                Limpar();
                Btn_Novo_Salvar.Text = "Salvar";
                DefinirEditabilidadeDosCampos(true);
                Btn_Pesquisar.Enabled = false;
            }
            else
            {
                Btn_Novo_Salvar.Text = "Novo";
                DefinirEditabilidadeDosCampos(false);
            }

            if (nomeBotao.Equals("Salvar"))
            {
                if (idVendaEdicao > 0)
                {
                    DBC dbc = new DBC();
                    var IdCliente = Convert.ToInt32(TxtBox_CodCliente.Text);
                    var IdFuncionario = Convert.ToInt32(TxtBox_CodVendedor.Text);
                    var quantidadeVendida = new List<int>();

                    for (int i = 0; i < Dgv_Principal.Rows.Count - 1; i++)
                    {
                        quantidadeVendida.Add(Convert.ToInt32(Dgv_Principal.Rows[i].Cells["Quantidade"].Value.ToString()));
                    }

                    dbc.AtualizarVenda(new Venda
                    {
                        Id = idVendaEdicao,
                        ClienteId = IdCliente,
                        FuncionarioId = IdFuncionario,
                        ValorTotalProdutos = Convert.ToDouble(TxtBox_ValorTotalProdutos.Text),
                        ValorDocumento = Convert.ToDouble(TxtBox_ValorDoc.Text),
                        Acrescimo = Convert.ToDouble(TxtBox_Acrescimo.Text),
                        Desconto = Convert.ToDouble(TxtBox_Desconto.Text),
                        Observacao = TxtBox_Observacao.Text
                    }, produtosVenda, quantidadeVendida);
                }
                else
                {
                    DBC dbc = new DBC();
                    var IdCliente = Convert.ToInt32(TxtBox_CodCliente.Text);
                    var IdFuncionario = Convert.ToInt32(TxtBox_CodVendedor.Text);
                    var quantidadeVendida = new List<int>();

                    for (int i = 0; i < Dgv_Principal.Rows.Count - 1; i++)
                    {
                        quantidadeVendida.Add(Convert.ToInt32(Dgv_Principal.Rows[i].Cells["Quantidade"].Value.ToString()));
                    }

                    dbc.InserirVenda(new Venda
                    {
                        ClienteId = IdCliente,
                        FuncionarioId = IdFuncionario,
                        ValorTotalProdutos = Convert.ToDouble(TxtBox_ValorTotalProdutos.Text),
                        ValorDocumento = Convert.ToDouble(TxtBox_ValorDoc.Text),
                        Acrescimo = Convert.ToDouble(TxtBox_Acrescimo.Text),
                        Desconto = Convert.ToDouble(TxtBox_Desconto.Text),
                        Observacao = TxtBox_Observacao.Text
                    }, produtosVenda, quantidadeVendida);
                }                
            }
        }

        private void TxtBox_CodCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var frm = new Frm_BOX_Pesquisar(this, "Clientes", "Venda");
                frm.ShowDialog();
            }
        }

        private void TxtBox_CodVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var frm = new Frm_BOX_Pesquisar(this, "Funcionarios", "Venda");
                frm.ShowDialog();
            }
        }

        private void Dgv_Principal_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (Dgv_Principal.Rows.Count == 0)
            {
                Dgv_Principal.Rows.Add(1);
            }
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Limpar();
            DefinirEditabilidadeDosCampos(false);
            Btn_Pesquisar.Enabled = true;
        }

        private void TxtBox_ValorTotalProdutos_Enter(object sender, EventArgs e)
        {
            CalculaValores();
        }
        
        private void TxtBox_ValorTotalProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculaValores();
            }
        }

        private void TxtBox_Acrescimo_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculaValores();
            }
        }

        private void TxtBox_Desconto_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculaValores();
            }
        }

        private void TxtBox_CodVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            var frm = new Frm_BOX_Pesquisar(this, "Vendas", "Cadastro Venda");
            frm.ShowDialog();
        }

        public void AdicionarVendaNoFormulario(Venda venda, List<Produto> produtosDaVenda, List<Compra> compras)
        {
            Dgv_Principal.Rows.Clear();
            tableIndex = 0;
            idVendaEdicao = venda.Id;

            TxtBox_CodCliente.Text = Convert.ToString(venda.Cliente.Id);
            TxtBox_NomeCliente.Text = venda.Cliente.Nome;
            TxtBox_CodVendedor.Text = Convert.ToString(venda.Funcionario.Id);
            TxtBox_NomeVendedor.Text = venda.Funcionario.Nome;
            TxtBox_ValorDoc.Text = Convert.ToString(venda.ValorDocumento);
            TxtBox_ValorTotalProdutos.Text = Convert.ToString(venda.ValorTotalProdutos);
            TxtBox_Observacao.Text = venda.Observacao;
            TxtBox_Desconto.Text = Convert.ToString(venda.Desconto);
            TxtBox_Acrescimo.Text = Convert.ToString(venda.Acrescimo);

            int i = 0;
            foreach (var item in produtosDaVenda)
            {
                AdicionarProdutosRecuperadosDaVendaNaGrid(item, compras[i]);
                i++;
            }
        }

        private void Btn_LimparCampos_Click(object sender, EventArgs e)
        {
            Limpar();
            DefinirEditabilidadeDosCampos(false);
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (idVendaEdicao > 0)
            {
                DefinirEditabilidadeDosCampos(true);
                
                Btn_Novo_Salvar.Text = "Salvar";
            }
            else
            {
                MessageBox.Show("Selecione uma venda para editar.", "Erro de edição");
            }
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show("Deseja realmente excluir o funcionário?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirmacao == DialogResult.Yes)
            {
                if (idVendaEdicao > 0)
                {
                    DBC dbc = new DBC();
                    var IdCliente = Convert.ToInt32(TxtBox_CodCliente.Text);
                    var IdFuncionario = Convert.ToInt32(TxtBox_CodVendedor.Text);
                    var quantidadeVendida = new List<int>();

                    for (int i = 0; i < Dgv_Principal.Rows.Count - 1; i++)
                    {
                        quantidadeVendida.Add(Convert.ToInt32(Dgv_Principal.Rows[i].Cells["Quantidade"].Value.ToString()));
                    }

                    dbc.ExcluirVenda(new Venda
                    {
                        Id = idVendaEdicao,
                        ClienteId = IdCliente,
                        FuncionarioId = IdFuncionario,
                        ValorTotalProdutos = Convert.ToDouble(TxtBox_ValorTotalProdutos.Text),
                        ValorDocumento = Convert.ToDouble(TxtBox_ValorDoc.Text),
                        Acrescimo = Convert.ToDouble(TxtBox_Acrescimo.Text),
                        Desconto = Convert.ToDouble(TxtBox_Desconto.Text),
                        Observacao = TxtBox_Observacao.Text
                    }, produtosVenda, quantidadeVendida);
                }
                else
                {
                    MessageBox.Show("Selecione uma venda para excluir.", "Erro de exclusão");
                }
            }
        }
    }
}
