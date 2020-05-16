using System;
using System.Linq;
using System.Windows.Forms;
using CSharp_Avancado.Controller;
using CSharp_Avancado.Model;
using Microsoft.VisualBasic;

namespace CSharp_Avancado.View
{
    public partial class Frm_CER_Cliente : Form
    {
        int idClienteEdicao = 0;

        public Frm_CER_Cliente()
        {
            InitializeComponent();
            SetComponents();
        }

        public void SetComponents()
        {
            // Form
            this.StartPosition = Defaults.frmStartPointAtParentCenter;
            this.Font = Defaults.microsoftSansSerif12Bold;
            this.Icon = Defaults.getIconByName("mais1");
            this.Text = "Cliente";
            // Group Box
            GrpBox_Endereco.Text = "Endereço";
            GrpBox_Sobre.Text = "Inf. Pessoais";
            Grp_Contato.Text = "Contato";
            // Label
            Lbl_Titulo.Font = Defaults.fontPadraoTituloJanelas16Bold;

            Lbl_Bairro.Text = "Bairro";
            Lbl_CEP.Text = "CEP";
            Lbl_Cidade.Text = "Cidade";
            Lbl_DataNsc.Text = "Data Nasc.";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_Nome.Text = "Nome";
            Lbl_Titulo.Text = "Cliente";
            Lbl_UF.Text = "UF";
            Lbl_Telefone1.Text = "Telefone";
            Lbl_Telefone2.Text = "Telefone 2";
            Lbl_Email.Text = "E-mail";
            Lbl_CPF.Text = "CPF";
            // Text Box
            // Masked Text Box
            MskBox_DataNsc.Mask = Defaults.dataMask;
            MskTxtBox_CEP.Mask = Defaults.cepMask;
            MskTxtBox_CPF.Mask = Defaults.cpfMask;
            MskTxtBox_Telefone1.Mask = Defaults.telefoneMask;
            MskTxtBox_Telefone2.Mask = Defaults.telefoneMask;
            // Picture Box
            //PicBox_Logo.SizeMode = Defaults.stretchImageStyle;
            //PicBox_Logo.Image = Defaults.getImageByName("user");
            // Button
            Btn_Voltar.Text = "Voltar";
            Btn_Novo_Salvar.Text = "Novo";
            Btn_Limpar.Text = "Limpar Campos";
            Btn_Editar.Text = "Editar";
            Btn_Excluir.Text = "Excluir";
            Btn_Pesquisar.Text = "Pesquisar";
            // Combo Box
            CmbBox_UF.Items.Clear(); 
            CmbBox_UF.Items.AddRange(Defaults.enumEstados());

            DefinirEditabilidadeDosCampos(false);
            Btn_Pesquisar.Enabled = true;
        }
        
        void LimpaCampos()
        {
            idClienteEdicao = 0;

            TxtBox_Nome.Text = "";

            TxtBox_Bairro.Text = "";
            TxtBox_Cidade.Text = "";
            TxtBox_Logradouro.Text = "";
            TxtBox_Email.Text = "";

            CmbBox_UF.Text = "Select";

            MskBox_DataNsc.Text = "";
            MskTxtBox_CPF.Text = "";
            MskTxtBox_CEP.Text = "";
            MskTxtBox_Telefone1.Text = "";
            MskTxtBox_Telefone2.Text = "";
        }

        void DefinirEditabilidadeDosCampos(bool status)
        {
            TxtBox_Nome.Enabled = status;
            MskBox_DataNsc.Enabled = status;
            MskTxtBox_CPF.Enabled = status;
            // Endereço
            MskTxtBox_CEP.Enabled = status;
            TxtBox_Cidade.Enabled = status;
            TxtBox_Bairro.Enabled = status;
            TxtBox_Logradouro.Enabled = status;

            CmbBox_UF.Enabled = status;
            // Contato
            MskTxtBox_Telefone1.Enabled = status;
            MskTxtBox_Telefone2.Enabled = status;
            TxtBox_Email.Enabled = status;

            Btn_Pesquisar.Enabled = false;
        }

        private void MskTxtBox_CEP_Leave(object sender, EventArgs e)
        {
            string vCep = MskTxtBox_CEP.Text.Replace("-","");

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

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            DefinirEditabilidadeDosCampos(false);
            Btn_Pesquisar.Enabled = true;
            Btn_Novo_Salvar.Text = "Novo";
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        public void AdicionarClienteNoFormulario(Cliente cliente)
        {
            TxtBox_Nome.Text = cliente.Nome;
            MskBox_DataNsc.Text = Convert.ToString(cliente.DataNascimento);
            MskTxtBox_CPF.Text = cliente.CPF;
            // Endereço
            MskTxtBox_CEP.Text = cliente.Endereco.CEP;
            TxtBox_Cidade.Text = cliente.Endereco.Cidade;
            TxtBox_Bairro.Text = cliente.Endereco.Bairro;
            TxtBox_Logradouro.Text = cliente.Endereco.Logradouro;

            CmbBox_UF.SelectedItem = cliente.Endereco.UF;
            // Contato
            MskTxtBox_Telefone1.Text = cliente.Contato.Telefone;
            MskTxtBox_Telefone2.Text = cliente.Contato.Telefone2;
            TxtBox_Email.Text = cliente.Contato.Email;

            DefinirEditabilidadeDosCampos(false);
            idClienteEdicao = cliente.Id;
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
                if (idClienteEdicao > 0)
                {
                    try
                    {
                        dbc.AtualizarCliente(new Cliente
                        {
                            Id = idClienteEdicao,
                            Nome = TxtBox_Nome.Text,
                            DataNascimento = Convert.ToDateTime((MskBox_DataNsc.Text)),
                            CPF = MskTxtBox_CPF.Text.Replace(".", "").Replace("-", ""),
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
                    catch (FormatException)
                    {
                        Frm_BOX_DialogBox dialogBox = new Frm_BOX_DialogBox();
                        dialogBox.DialogBox
                        (
                             Defaults.getImageByName("error"),
                             "Operação Inválida",
                             "Foram encontrados formatos incorretos preenchidos no formulário, confira os dados e tente novamente.",
                             true,
                             false,
                             "Ok",
                             ""
                        );

                        dialogBox.Show();
                    }
                }
                else
                {
                    try
                    {
                        dbc.InserirCliente(new Cliente
                        {
                            Nome = TxtBox_Nome.Text,
                            DataNascimento = Convert.ToDateTime((MskBox_DataNsc.Text)),
                            CPF = MskTxtBox_CPF.Text.Replace(".", "").Replace("-", ""),
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
                    catch (FormatException)
                    {
                        Frm_BOX_DialogBox dialogBox = new Frm_BOX_DialogBox();
                        dialogBox.DialogBox
                        (
                             Defaults.getImageByName("error"),
                             "Operação Inválida",
                             "Foram encontrados formatos incorretos preenchidos no formulário, confira os dados e tente novamente.",
                             true,
                             false,
                             "Ok",
                             ""
                        );

                        dialogBox.Show();
                    }
                }
            }                
        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            var frm = new Frm_BOX_Pesquisar(this, "Clientes", "Cadastro Cliente");
            frm.ShowDialog();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (idClienteEdicao > 0)
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
            if (idClienteEdicao > 0)
            {
                var confirmacao = MessageBox.Show("Deseja realmente excluir o cliente?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmacao == DialogResult.Yes)
                {
                    var clienteParaExcluir = new Cliente {
                        Id = idClienteEdicao,
                        Nome = TxtBox_Nome.Text,
                        DataNascimento = Convert.ToDateTime((MskBox_DataNsc.Text)),
                        CPF = MskTxtBox_CPF.Text.Replace(".", "").Replace("-", ""),
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

                    new DBC().ExcluirCliente(clienteParaExcluir);

                    LimpaCampos();
                    DefinirEditabilidadeDosCampos(false);
                    Btn_Pesquisar.Enabled = true;
                }
            }
        }
    }
}
