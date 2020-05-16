using CSharp_Avancado.Controller;
using CSharp_Avancado.Model;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace CSharp_Avancado.View
{
    public partial class Frm_CER_Fornecedor : Form
    {
        int idFornecedorEdicao = 0;

        public Frm_CER_Fornecedor()
        {
            InitializeComponent();
            SetComponents();
            DefinirEditabilidadeDosCampos(false);
        }

        public void SetComponents()
        {
            // Form
            this.StartPosition = Defaults.frmStartPointAtParentCenter;
            this.Font = Defaults.microsoftSansSerif12Bold;
            this.Icon = Defaults.getIconByName("mais1");
            this.Text = "Fornecedor";
            // Group Box
            GrpBox_Contato.Text = "Contato";
            GrpBox_Endereco.Text = "Endereço";
            GrpBox_Informacoes.Text = "Informações";
            // Label
            Lbl_Titulo.Font = Defaults.fontPadraoTituloJanelas16Bold;

            Lbl_Bairro.Text = "Bairro";
            Lbl_CEP.Text = "CEP";
            Lbl_Cidade.Text = "Cidade";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_NomeFantasia.Text = "Nome Fantasia";
            Lbl_Titulo.Text = "Fornecedor";
            Lbl_UF.Text = "UF";
            Lbl_Telefone1.Text = "Telefone";
            Lbl_Telefone2.Text = "Telefone 2";
            Lbl_Email1.Text = "E-mail";
            //Lbl_Email2.Text = "E-mail 2";
            Lbl_CNPJ.Text = "CNPJ";
            Lbl_RamoAtuacao.Text = "Ramo Atuação";
            // Text Box
            // Masked Text Box
            MskTxtBox_CEP.Mask = Defaults.cepMask;
            MskTxtBox_CNPJ.Mask = Defaults.cnpjMask;
            MskTxtBox_Telefone1.Mask = Defaults.telefoneMask;
            MskTxtBox_Telefone2.Mask = Defaults.telefoneMask;
            // Picture Box
            // Button
            Btn_Voltar.Text = "Voltar";
            Btn_Novo_Salvar.Text = "Novo";
            Btn_LimparCampos.Text = "Limpar Campos";
            Btn_Editar.Text = "Editar";
            Btn_Excluir.Text = "Excluir";
            Btn_Pesquisar.Text = "Pesquisar";
            // Combo Box
            CmbBox_UF.Items.Clear();
            CmbBox_UF.Items.AddRange(Defaults.enumEstados());
        }

        void LimparCampos()
        {
            idFornecedorEdicao = 0;

            MskTxtBox_CNPJ.Text = "";
            MskTxtBox_CEP.Text = "";
            MskTxtBox_Telefone1.Text = "";
            MskTxtBox_Telefone2.Text = "";
            TxtBox_Email.Text = "";
            TxtBox_Bairro.Text = "";
            TxtBox_Cidade.Text = "";
            TxtBox_Logradouro.Text = "";
            TxtBox_NomeFantasia.Text = "";
            TxtBox_RamoAtuacao.Text = "";
            CmbBox_UF.Text = "Select";
        }

        public void AdicionarFornecedorNoFormulario(Fornecedor fornecedor)
        {
            idFornecedorEdicao = fornecedor.Id;
            TxtBox_NomeFantasia.Text = fornecedor.NomeFantasia;
            TxtBox_RamoAtuacao.Text = fornecedor.RamoAtuacao;
            MskTxtBox_CNPJ.Text = fornecedor.CNPJ;
            // Endereço
            MskTxtBox_CEP.Text = fornecedor.Endereco.CEP;
            TxtBox_Cidade.Text = fornecedor.Endereco.Cidade;
            TxtBox_Bairro.Text = fornecedor.Endereco.Bairro;
            TxtBox_Logradouro.Text = fornecedor.Endereco.Logradouro;

            CmbBox_UF.SelectedItem = fornecedor.Endereco.UF;
            // Contato
            MskTxtBox_Telefone1.Text = fornecedor.Contato.Telefone;
            MskTxtBox_Telefone2.Text = fornecedor.Contato.Telefone2;
            TxtBox_Email.Text = fornecedor.Contato.Email;
        }

        void DefinirEditabilidadeDosCampos(bool status)
        {
            MskTxtBox_CNPJ.Enabled = status;
            MskTxtBox_CEP.Enabled = status;
            MskTxtBox_Telefone1.Enabled = status;
            MskTxtBox_Telefone2.Enabled = status;
            TxtBox_Email.Enabled = status;
            TxtBox_Bairro.Enabled = status;
            TxtBox_Cidade.Enabled = status;
            TxtBox_Logradouro.Enabled = status;
            TxtBox_NomeFantasia.Enabled = status;
            TxtBox_RamoAtuacao.Enabled = status;
            CmbBox_UF.Enabled = status;
        }

        void ResetarFormulario()
        {
            SetComponents();
            LimparCampos();
            DefinirEditabilidadeDosCampos(false);

            Btn_Pesquisar.Enabled = true;
        }

        private void Btn_LimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void Btn_Novo_Salvar_Click(object sender, EventArgs e)
        {
            var nomeBotao = Btn_Novo_Salvar.Text;

            if (Btn_Novo_Salvar.Text == "Novo")
            {
                Btn_Novo_Salvar.Text = "Salvar";
                DefinirEditabilidadeDosCampos(true);
            }
            else
            {
                Btn_Novo_Salvar.Text = "Novo";
                DefinirEditabilidadeDosCampos(false);
            }

            if (nomeBotao.Equals("Salvar"))
            {
                var dbc = new DBC();

                if (idFornecedorEdicao > 0)
                {
                    dbc.AtualizarFornecedor(new Fornecedor
                    {
                        Id = idFornecedorEdicao,
                        NomeFantasia = TxtBox_NomeFantasia.Text,
                        RamoAtuacao = TxtBox_RamoAtuacao.Text,
                        CNPJ = MskTxtBox_CNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", ""),
                        Contato = new Contato
                        {
                            Telefone = MskTxtBox_Telefone1.Text.Replace("(", "").Replace(")", "").Replace("-", ""),
                            Telefone2 = MskTxtBox_Telefone2.Text.Replace("(", "").Replace(")", "").Replace("-", ""),
                            Email = TxtBox_Email.Text
                        },
                        Endereco = new Endereco
                        {
                            CEP = MskTxtBox_CEP.Text.Replace("-", ""),
                            UF = CmbBox_UF.SelectedItem.ToString(),
                            Cidade = TxtBox_Cidade.Text,
                            Bairro = TxtBox_Bairro.Text,
                            Logradouro = TxtBox_Logradouro.Text
                        }
                    });
                }
                else
                {
                    dbc.InserirFornecedor(new Fornecedor
                    {
                        NomeFantasia = TxtBox_NomeFantasia.Text,
                        RamoAtuacao = TxtBox_RamoAtuacao.Text,
                        CNPJ = MskTxtBox_CNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", ""),
                        Contato = new Contato
                        {
                            Telefone = MskTxtBox_Telefone1.Text.Replace("(", "").Replace(")", "").Replace("-", ""),
                            Telefone2 = MskTxtBox_Telefone2.Text.Replace("(", "").Replace(")", "").Replace("-", ""),
                            Email = TxtBox_Email.Text
                        },
                        Endereco = new Endereco
                        {
                            CEP = MskTxtBox_CEP.Text.Replace("-", ""),
                            UF = CmbBox_UF.SelectedItem.ToString(),
                            Cidade = TxtBox_Cidade.Text,
                            Bairro = TxtBox_Bairro.Text,
                            Logradouro = TxtBox_Logradouro.Text
                        }
                    });
                }
            }
        }

        private void MskTxtBox_CEP_Leave(object sender, EventArgs e)
        {
            string vCep = MskTxtBox_CEP.Text.Replace("-", "");

            if (vCep != "")
            {
                if (vCep.Length == 8)
                {
                    if (Information.IsNumeric(vCep))
                    {
                        var vJson = Uteis.GeraJSONCEP(vCep);
                        Cep.Unit CEP = new Cep.Unit();
                        CEP = Cep.DesSerializedClassUnit(vJson);

                        TxtBox_Logradouro.Text = CEP.logradouro;
                        TxtBox_Bairro.Text = CEP.bairro;
                        TxtBox_Cidade.Text = CEP.localidade;

                        CmbBox_UF.SelectedItem = CEP.uf;
                    }
                }
            }
        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            var frm = new Frm_BOX_Pesquisar(this, "Fornecedores", "Cadastro Fornecedor");
            frm.ShowDialog();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            ResetarFormulario();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (idFornecedorEdicao > 0)
            {
                DefinirEditabilidadeDosCampos(true);
                Btn_Pesquisar.Enabled = false;
                Btn_Novo_Salvar.Text = "Salvar";
            }
            else
            {
                MessageBox.Show("Pesquise antes de editar.", "Operação inválida");
            }
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            if (idFornecedorEdicao > 0)
            {
                var confirmacao = MessageBox.Show("Deseja realmente excluir o fornecedor?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmacao == DialogResult.Yes)
                {
                    var fornecedorParaExcluir = new Fornecedor{
                        Id = idFornecedorEdicao,
                        NomeFantasia = TxtBox_NomeFantasia.Text,
                        RamoAtuacao = TxtBox_RamoAtuacao.Text,
                        CNPJ = MskTxtBox_CNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", ""),
                        Contato = new Contato
                        {
                            Telefone = MskTxtBox_Telefone1.Text.Replace("(", "").Replace(")", "").Replace("-", ""),
                            Telefone2 = MskTxtBox_Telefone2.Text.Replace("(", "").Replace(")", "").Replace("-", ""),
                            Email = TxtBox_Email.Text
                        },
                        Endereco = new Endereco
                        {
                            CEP = MskTxtBox_CEP.Text.Replace("-", ""),
                            UF = CmbBox_UF.SelectedItem.ToString(),
                            Cidade = TxtBox_Cidade.Text,
                            Bairro = TxtBox_Bairro.Text,
                            Logradouro = TxtBox_Logradouro.Text
                        }
                    };

                    new DBC().ExcluirFornecedor(fornecedorParaExcluir);
                }

                ResetarFormulario();
            }
        }
    }
}
