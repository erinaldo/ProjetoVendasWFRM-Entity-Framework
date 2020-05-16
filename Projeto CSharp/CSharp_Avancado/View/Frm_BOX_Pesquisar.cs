using CSharp_Avancado.Controller;
using CSharp_Avancado.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CSharp_Avancado.View
{
    public partial class Frm_BOX_Pesquisar : Form
    {
        private Frm_CER_Venda frmVenda;
        private Frm_CER_Produto frmProduto;
        private Frm_CER_Cliente frmCliente;
        private Frm_CER_Funcionario frmFuncionario;
        private Frm_CER_Fornecedor frmFonecedor;

        string NomeTabela = "";
        string Operacao = "";
        List<Produto> listaDeProdutos = new List<Produto>();
        List<Cliente> listaDeClientes = new List<Cliente>();
        List<Funcionario> listaDeFuncionarios = new List<Funcionario>();
        List<Fornecedor> listaDeFornecedores = new List<Fornecedor>();
        private List<Venda> listaDeVendas = new List<Venda>();

        public Frm_BOX_Pesquisar()
        {
            InitializeComponent();
            SetComponents();
        }

        // Pesquisar através da venda.
        public Frm_BOX_Pesquisar(Frm_CER_Venda form, string nomeTabela, string operacao)
        {
            InitializeComponent();
            SetComponents();

            this.NomeTabela = nomeTabela;
            this.Operacao = operacao;
            frmVenda = form;

            PopularTabela(this.NomeTabela);
        }
        // Pesquisa através do cadastro de produto.
        public Frm_BOX_Pesquisar(Frm_CER_Produto form, string nomeTabela, string operacao)
        {
            InitializeComponent();
            SetComponents();

            this.NomeTabela = nomeTabela;
            this.Operacao = operacao;
            frmProduto = form;

            PopularTabela(this.NomeTabela);
        }
        // Pesquisa através do cadastro de fornecedor.
        public Frm_BOX_Pesquisar(Frm_CER_Fornecedor form, string nomeTabela, string operacao)
        {
            InitializeComponent();
            SetComponents();

            this.NomeTabela = nomeTabela;
            this.Operacao = operacao;
            frmFonecedor = form;

            PopularTabela(this.NomeTabela);
        }
        // Pesquisa através do cadastro de funcionario.
        public Frm_BOX_Pesquisar(Frm_CER_Funcionario form, string nomeTabela, string operacao)
        {
            InitializeComponent();
            SetComponents();

            this.NomeTabela = nomeTabela;
            this.Operacao = operacao;
            frmFuncionario = form;

            PopularTabela(this.NomeTabela);
        }
        // Pesquisa através do cadastro de cliente.
        public Frm_BOX_Pesquisar(Frm_CER_Cliente form, string nomeTabela, string operacao)
        {
            InitializeComponent();
            SetComponents();

            this.NomeTabela = nomeTabela;
            this.Operacao = operacao;
            frmCliente = form;

            PopularTabela(this.NomeTabela);
        }

        void SetComponents()
        {
            this.Text = "Busca";
            this.StartPosition = Defaults.frmStartPointAtCenterScreen;

            Btn_Pesquisa.Text = "Pesquisa";
        }

        void PopularTabela(string nomeTabela)
        {
            var dbc = new DBC();

            switch (nomeTabela)
            {
                case "Produtos":
                    Dgv_Principal.DataSource = dbc.RecuperarProdutos();
                    Dgv_Principal.AutoGenerateColumns = false;
                    Dgv_Principal.Columns[1].HeaderText = "Descição";
                    Dgv_Principal.Columns[6].HeaderText = "Preço de Compra";
                    Dgv_Principal.Columns[7].HeaderText = "Preço de Venda";
                    Dgv_Principal.Columns[8].Visible = false;
                    break;
                case "Clientes":
                    Dgv_Principal.DataSource = dbc.RecuperarClientes();
                    Dgv_Principal.AutoGenerateColumns = false;
                    Dgv_Principal.Columns["ContatoId"].Visible = false;
                    Dgv_Principal.Columns["Contato"].Visible = false;
                    Dgv_Principal.Columns["EnderecoId"].Visible = false;
                    Dgv_Principal.Columns["Endereco"].Visible = false;
                    Dgv_Principal.Columns["DataNascimento"].Visible = false;
                    break;
                case "Funcionarios":
                    Dgv_Principal.DataSource = dbc.RecuperarFuncionarios();
                    Dgv_Principal.AutoGenerateColumns = false;
                    Dgv_Principal.Columns["Salario"].Visible = false;
                    Dgv_Principal.Columns["RG"].Visible = false;
                    Dgv_Principal.Columns["ContatoId"].Visible = false;
                    Dgv_Principal.Columns["Contato"].Visible = false;
                    Dgv_Principal.Columns["EnderecoId"].Visible = false;
                    Dgv_Principal.Columns["Endereco"].Visible = false;
                    Dgv_Principal.Columns["DataNascimento"].Visible = false;
                    Dgv_Principal.Columns["CPF"].Visible = false;
                    break;
                case "Fornecedores":
                    Dgv_Principal.DataSource = dbc.RecuperarFornecedores();
                    Dgv_Principal.AutoGenerateColumns = false;
                    Dgv_Principal.Columns["ContatoId"].Visible = false;
                    Dgv_Principal.Columns["Contato"].Visible = false;
                    Dgv_Principal.Columns["EnderecoId"].Visible = false;
                    Dgv_Principal.Columns["Endereco"].Visible = false;
                    break;
                case "Vendas":
                    //Dgv_Principal.DataSource = dbc.RecuperarVendas();
                    var vendas = dbc.RecuperarVendas();
                    Dgv_Principal.AutoGenerateColumns = false;
                    Dgv_Principal.ColumnCount = 7;

                    Dgv_Principal.Columns[0].Name = "Id";
                    Dgv_Principal.Columns[1].Name = "Cliente";
                    Dgv_Principal.Columns[2].Name = "Vendedor";
                    Dgv_Principal.Columns[3].Name = "Acréscimo";
                    Dgv_Principal.Columns[4].Name = "Desconto";
                    Dgv_Principal.Columns[5].Name = "Total Produtos";
                    Dgv_Principal.Columns[6].Name = "Total Documento";

                    foreach (var item in vendas)
                    {
                        Dgv_Principal.Rows.Add(new string []{
                            item.Id.ToString(),
                            item.Cliente.Nome,
                            item.Funcionario.Nome,
                            item.Acrescimo.ToString(),
                            item.Desconto.ToString(),
                            item.ValorTotalProdutos.ToString(),
                            item.ValorDocumento.ToString()
                        });
                    }
                    //Dgv_Principal.Columns["ClienteId"].Visible = false;
                    //Dgv_Principal.Columns["Cliente"].Visible = false;
                    //Dgv_Principal.Columns["FuncionarioId"].Visible = false;
                    //Dgv_Principal.Columns["Funcionario"].Visible = false;
                    //Dgv_Principal.Columns["Compra"].Visible = false;
                    break;
            }
        }

        private void RecuperarDadosDoItemSelecionado()
        {
            var currentRow = Dgv_Principal.CurrentRow;

            switch (this.NomeTabela)
            {
                case "Produtos":
                    Produto produto = new Produto
                    {
                        Id = Convert.ToInt32(currentRow.Cells[0].Value.ToString()),
                        Descricao = currentRow.Cells[1].Value.ToString(),
                        Tipo = currentRow.Cells[2].Value.ToString(),
                        Marca = currentRow.Cells[3].Value.ToString(),
                        //Validade = Convert.ToDateTime(currentRow.Cells[4].Value.ToString()),
                        Quantidade = Convert.ToInt32(currentRow.Cells[5].Value.ToString()),
                        PrecoCompra = Convert.ToDouble(currentRow.Cells[6].Value.ToString()),
                        PrecoVenda = Convert.ToDouble(currentRow.Cells[7].Value.ToString()),
                        Imagem = currentRow.Cells[8].Value.ToString()
                    };
                    if (Operacao == "Venda")
                        frmVenda.AdicionarProdutoNaGrid(produto);
                    if (Operacao == "Cadastro Produto")
                    {
                        frmProduto.AdicionarProdutoNoFormulario(produto);
                        this.Dispose();
                    }
                    break;
                case "Clientes":
                    var Id = Convert.ToInt32(currentRow.Cells["Id"].Value.ToString());
                    Cliente cliente = new Cliente();
                    listaDeClientes = new DBC().RecuperarClientes();

                    foreach (var c in listaDeClientes)
                    {
                        if (c.Id == Id)
                        {
                            cliente = c;
                            break;
                        }
                    }

                    if (Operacao == "Venda")
                        frmVenda.AdicionarClienteNaVenda(cliente);
                    if (Operacao == "Cadastro Cliente")
                    {
                        frmCliente.AdicionarClienteNoFormulario(cliente);
                    }
                    this.Dispose();
                    break;
                case "Funcionarios":
                    if (this.NomeTabela.Equals("Funcionarios"))
                    {
                        var IdFuncionario = Convert.ToInt32(currentRow.Cells["Id"].Value.ToString());
                        Funcionario vendedor = new Funcionario();
                        listaDeFuncionarios = new DBC().RecuperarFuncionarios();

                        foreach (var f in listaDeFuncionarios)
                        {
                            if (f.Id == IdFuncionario)
                            {
                                vendedor = f;
                                break;
                            }
                        }

                        if (Operacao == "Venda")
                            frmVenda.AdicionarVendedorNaVenda(vendedor);
                        if (Operacao == "Cadastro Funcionario")
                        {
                            frmFuncionario.AdicionarFuncionarioNoFormulario(vendedor);
                        }
                        this.Dispose();
                    }
                    break;
                case "Fornecedores":
                    var IdFornecedor = Convert.ToInt32(currentRow.Cells["Id"].Value.ToString());
                    Fornecedor fornecedor = new Fornecedor();
                    listaDeFornecedores = new DBC().RecuperarFornecedores();

                    foreach (var f in listaDeFornecedores)
                    {
                        if (f.Id == IdFornecedor)
                        {
                            fornecedor = f;
                            break;
                        }
                    }
                    frmFonecedor.AdicionarFornecedorNoFormulario(fornecedor);
                    this.Dispose();
                    break;
                case "Vendas":
                    var IdVenda = Convert.ToInt32(currentRow.Cells["Id"].Value.ToString());
                    Venda venda = new Venda();
                    listaDeVendas = new DBC().RecuperarVendas();

                    foreach (var v in listaDeVendas)
                    {
                        if (v.Id == IdVenda)
                        {
                            venda = v;
                            break;
                        }
                    }

                    List<Produto> produtosDaVenda = new List<Produto>();
                    produtosDaVenda = new DBC().RecuperarProdutosPeloID(venda.Id);
                    List<Compra> quantidadesProdutosDaVenda = new List<Compra>();
                    quantidadesProdutosDaVenda = new DBC().RecuperarQuantidadesProdutosPeloID(venda.Id);

                    frmVenda.AdicionarVendaNoFormulario(venda, produtosDaVenda, quantidadesProdutosDaVenda);
                    this.Dispose();
                    break;
            }
        }
        
        private void Btn_Pesquisa_Click(object sender, System.EventArgs e)
        {
            //var source = (DataTable) Dgv_Principal.DataSource;
            //source.DefaultView.RowFilter = string.Format("[Id] LIKE '%{0}%'", TxtBox_Pesquisa.Text);
        }

        private void Dgv_Principal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RecuperarDadosDoItemSelecionado();
            }
            e.Handled = true;
            return;
        }
    }
}
