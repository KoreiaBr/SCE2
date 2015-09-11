using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCE.Telas
{
    public partial class cadProduto : Form
    {
        public bool AtivaPesquisa = false;
        public bool AdicionaFornecedor = false;
        Pesquisas.lookupProduto tPesquisaProduto = new Pesquisas.lookupProduto();
        Pesquisas.lookupFornecedor tPesquisaFornecedor = new Pesquisas.lookupFornecedor();
        cadFornecedor tCadFornecedor = new cadFornecedor();

        private void limpaTela()
        {
            txtCodigo.Text = "(Novo)";
            txtCodigoProduto.Text = "Insira um codigo";
            tbxDescricao.Text = "Insira uma descrição";
            txtClassFiscal.Text = "";
            txtQuantidade.Text = "0";
            txtCAtual.Text = "0";
            txtPeso.Text = "0";
            txtCMedio.Text = "0";
            cbxCategoria.Text = "";
            cbxImportado.Text = "Não";
            cbxEstrutura.Text = "Não";
            CarregaCategoria();

            tbxDescricao.ForeColor = System.Drawing.SystemColors.ControlLight;
            txtCodigoProduto.ForeColor = System.Drawing.SystemColors.ControlLight;
            btnDeletar.Enabled = false;
            btnNovo.Enabled = false;
            btnAddFornecedor.Enabled = false;
            btnDELFornecedor.Enabled = false;
            txtCodigoProduto.ReadOnly = false;
            lblInformacao.Text = "*Salve o produto primeiro";
            dgvFornecedor.DataSource = null;
            dgvFornecedor.Refresh();
            dgvFornecedor.Enabled = false;
        }

        private void CarregaCategoria()
        {
            using (bancoSCE bd = new bancoSCE())
            {
                var categoria = (bd.categoria.Where(ur => ur.ativo == "1"));
                categoria = categoria.OrderBy(ur => ur.descricao);
                categoria = categoria.Select(ur => ur);
                if (categoria.Count() == 0)
                {
                    cbxCategoria.DataSource = null;
                    cbxCategoria.Refresh();
                }
                else
                {
                    cbxCategoria.DataSource = categoria.ToList();
                    cbxCategoria.DisplayMember = "descricao";
                    cbxCategoria.ValueMember = "ID";
                    cbxCategoria.MaxDropDownItems=3;  
                }
           }       
            
        }

        private void CarregaFornecedores()
        {
            int CodigoProduto = Convert.ToInt32(txtCodigo.Text);
            using (bancoSCE bd = new bancoSCE())
            {
                var listaFornecedor = (from ep in bd.listafornecedores
                join f in bd.fornecedor on ep.fornecedorID equals f.ID
                where ep.podutoID == CodigoProduto select f);
                if (listaFornecedor != null )
                {
                    dgvFornecedor.Enabled = true;
                    dgvFornecedor.DataSource = listaFornecedor.ToList();
                    dgvFornecedor.Columns[0].Visible = false;
                    dgvFornecedor.Columns[2].Visible = false;
                    dgvFornecedor.Columns[3].Visible = false;
                    dgvFornecedor.Columns[4].Visible = false;
                    dgvFornecedor.Columns[5].Visible = false;
                    dgvFornecedor.Columns[6].Visible = false;
                    dgvFornecedor.Columns[1].HeaderText = "";
                    dgvFornecedor.Columns[1].Width = 400;
                }
                else
                {
                    dgvFornecedor.Refresh();
                    dgvFornecedor.Enabled = false;
                }
            }    
        }

        public static void SoNumeros(object sender, KeyPressEventArgs e, char cSymbol)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != cSymbol)
            {
                e.Handled = true;
            }

            if (e.KeyChar == cSymbol && (sender as TextBox).Text.IndexOf(cSymbol) > -1)
            {
                e.Handled = true;
            }
        }
        
        private void FormataCodigoExit(object sender, EventArgs e)
        {
            if (txtCodigoProduto.Text == "")
            {
                txtCodigoProduto.Text = "Insira um codigo";
                txtCodigoProduto.ForeColor = System.Drawing.SystemColors.ControlLight;
            }
        }

        private void FormataCodigoEnter(object sender, EventArgs e)
        {
            if (txtCodigoProduto.Text == "Insira um codigo")
            {
                txtCodigoProduto.Text = "";
                txtCodigoProduto.ForeColor = System.Drawing.SystemColors.Highlight;
            }
        }

        private void FormataDescricaoEnter(object sender, EventArgs e)
        {
            if (tbxDescricao.Text == "Insira uma descrição")
            {
                tbxDescricao.Text = "";
                tbxDescricao.ForeColor = System.Drawing.SystemColors.Highlight;
            }
        }

        private void FormataDescricaoExit(object sender, EventArgs e)
        {
            if (tbxDescricao.Text == "")
            {
                tbxDescricao.Text = "Insira uma descrição";
                tbxDescricao.ForeColor = System.Drawing.SystemColors.ControlLight;
            }                    
        }
       
        private void BtnFocusON(object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.SystemColors.InactiveBorder;
        }

        private void BtnFocusOFF(object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.SystemColors.ControlLightLight;
        }


        public cadProduto()
        {
            InitializeComponent();
        }

        private void cadProduto_Load(object sender, EventArgs e)
        {
            AdicionaFornecedor = false;
            cbxImportado.Text = "Não";
            cbxEstrutura.Text = "Não";
            limpaTela();
            CarregaCategoria();
            Sessao.FornecedorAtivo = 0;
            if (Sessao.ProdutoAtivo != "")
            {
                AtivaPesquisa = true;
            }
            else
            {
                AtivaPesquisa = false;
            }
        }

        private void pctPesquisar_Click(object sender, EventArgs e)
        {
            AtivaPesquisa = true;
            tPesquisaProduto.ShowDialog();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpaTela();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pctPesquisar_Click_1(object sender, EventArgs e)
        {
            AtivaPesquisa = true;
            tPesquisaProduto.ShowDialog();
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoNumeros(sender, e, ',');
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoNumeros(sender, e, ',');
        }

        private void cadProduto_Activated(object sender, EventArgs e)
        {
            if (AtivaPesquisa == true)
            {
                AtivaPesquisa = false; // previne o loop infinito nesse evento
                int codigo = 0;
                if (Sessao.ProdutoAtivo != "") //busca o ID do produto
                {
                    using (bancoSCE bd = new bancoSCE())
                    {
                        var produto = (bd.produto.Where(ur => ur.codigo == Sessao.ProdutoAtivo));
                        produto = produto.Select(ur => ur);
                        var usr = produto.FirstOrDefault();
                        codigo = usr.ID;
                        Sessao.ProdutoAtivo = "";
                        
                    }
                }
                else
                {
                    Sessao.ProdutoAtivo = "";
                    codigo = Convert.ToInt32(tPesquisaProduto.CodProduto);                
                }
                if (codigo > 0)
                {
                    txtCodigo.Text = tPesquisaProduto.CodProduto;
                    using (bancoSCE bd = new bancoSCE())
                    {
                        var produto = (bd.produto.Where(ur => ur.ID == codigo));
                        produto = produto.Select(ur => ur);
                        var usr = produto.FirstOrDefault();
                        txtCodigo.Text = usr.ID.ToString();
                        txtCodigoProduto.Text = usr.codigo;
                        tbxDescricao.Text = usr.descricao;
                        txtClassFiscal.Text = usr.classfiscal;
                        txtPeso.Text = Convert.ToString(usr.peso);
                        txtQuantidade.Text = Convert.ToString(usr.quantidade);
                        txtCAtual.Text = Convert.ToString(usr.custo);
                        txtCMedio.Text = Convert.ToString(usr.custoMedio);
                        cbxCategoria.SelectedValue = usr.categoriaID;
                        if (usr.estrutura == false)
                            cbxEstrutura.Text = "Não";
                        else
                            cbxEstrutura.Text = "Sim";
                        if (usr.importado == false)
                            cbxImportado.Text = "Não";
                        else
                            cbxImportado.Text = "Sim";
                    }
                    tbxDescricao.ForeColor = System.Drawing.SystemColors.Highlight;
                    txtCodigoProduto.ForeColor = System.Drawing.SystemColors.Highlight;
                    tPesquisaProduto.CodProduto = "0";
                    Sessao.ProdutoAtivo = "";
                    btnDeletar.Enabled = true;
                    btnNovo.Enabled = true;
                    btnAddFornecedor.Enabled = true;
                    btnDELFornecedor.Enabled = true;
                    txtCodigoProduto.ReadOnly = true;
                    lblInformacao.Text = "";
                    CarregaFornecedores();
                }
                else
                {
                    limpaTela();
                }
            }
            else if (AdicionaFornecedor == true)
            {
                AdicionaFornecedor = false;
                int codigoFornecedor = Convert.ToInt32(tPesquisaFornecedor.CodFornecedor);
                int CodigoProduto = Convert.ToInt32(txtCodigo.Text);
                using (bancoSCE bd = new bancoSCE())
                {
                    if (codigoFornecedor > 0)
                    {              
                    
                        listafornecedores NovoListFornec = new listafornecedores()
                        { 
                            podutoID = CodigoProduto,
                            fornecedorID = codigoFornecedor,
                        };
                        bd.listafornecedores.Add(NovoListFornec);
                        bd.SaveChanges();
                    }
                }
                tPesquisaFornecedor.CodFornecedor = "0";
                CarregaFornecedores();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja excluir o poduto?", "Deletar o produto?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                using (bancoSCE bd = new bancoSCE())
                {
                    int CodProduto = Convert.ToInt32(txtCodigo.Text);
                    produto Produto = bd.produto.First(p => p.ID == (CodProduto));
                    Produto.ativo = "0";
                    bd.SaveChanges();
                }
                limpaTela();
                MessageBox.Show("Produto excluido com sucesso!", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodigoProduto.Text != "Insira um codigo" && tbxDescricao.Text != "Insira uma descrição")
            {
                using (bancoSCE bd = new bancoSCE())
                {
                    bool importado = false;
                    bool estrutura = false;
                    if (cbxImportado.Text == "Sim")
                        importado = true;
                    if (cbxEstrutura.Text == "Sim")
                        estrutura = true;
                    string codigoProduto = txtCodigo.Text;
                    string mensagem = "Produto cadastrado com sucesso!";
                    if (codigoProduto == "(Novo)")
                    {
                        var produto = (bd.produto.Where(ur => ur.codigo == txtCodigoProduto.Text));
                        produto = produto.Select(ur => ur);
                        var usr = produto.FirstOrDefault();
                        if (produto.Count() == 0) //TESTE PARA VERIFICAR SE JA TME UM PRODUTO COM O CODIGO SELECIONADO
                        {
                            produto NovoProduto = new produto()
                            {
                                codigo = txtCodigoProduto.Text,
                                descricao = tbxDescricao.Text,
                                classfiscal = txtClassFiscal.Text,
                                quantidade = Convert.ToInt32(txtQuantidade.Text),
                                custo = Convert.ToDouble(txtCAtual.Text),
                                peso = Convert.ToDouble(txtPeso.Text),
                                custoMedio = Convert.ToDouble(txtCMedio.Text),
                                categoriaID = Convert.ToInt32(cbxCategoria.SelectedValue),
                                importado = importado,
                                estrutura = estrutura,
                                ativo = "1",
                            };
                            bd.produto.Add(NovoProduto);
                        }
                        else
                        {
                            MessageBox.Show("Codigo do produto já em uso!",
                                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtCodigoProduto.Text = "";
                            txtCodigoProduto.Focus();
                            return;
                        }
                    }
                    else
                    {
                        int CodProduto = Convert.ToInt32(txtCodigo.Text);
                        mensagem = "Produto atulizado com sucesso!";
                        produto Produto = bd.produto.First(p => p.ID == (CodProduto));
                        Produto.descricao = tbxDescricao.Text;
                        Produto.classfiscal = txtClassFiscal.Text;
                        Produto.quantidade = Convert.ToInt32(txtQuantidade.Text);
                        Produto.custo = Convert.ToDouble(txtCAtual.Text);
                        Produto.peso = Convert.ToDouble(txtPeso.Text);
                        Produto.custoMedio = Convert.ToDouble(txtCMedio.Text);
                        Produto.categoriaID = Convert.ToInt32(cbxCategoria.SelectedValue);
                        Produto.importado = importado;
                        Produto.estrutura = estrutura;
                    }
                    bd.SaveChanges();
                    MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaTela();
                }
            }
            else
            {
                MessageBox.Show("Informe um codigo e uma descrição para o produto!", 
                            "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          

        }

        private void btnAddFornecedor_Click(object sender, EventArgs e)
        {
            AdicionaFornecedor = true;
            tPesquisaFornecedor.ShowDialog();
        }
        
        private void btnDELFornecedor_Click(object sender, EventArgs e)
        {
            using (bancoSCE bd = new bancoSCE())
            {
                if (Sessao.FornecedorAtivo > 0)
                {
                    int CodigoProduto = Convert.ToInt32(txtCodigo.Text);
                    listafornecedores l = new listafornecedores();
                    var ListaFornecedores = (bd.listafornecedores.Where(ur => ur.podutoID == CodigoProduto));
                        ListaFornecedores = ListaFornecedores.Where(ur => ur.fornecedorID == Sessao.FornecedorAtivo);
                        ListaFornecedores = ListaFornecedores.Select(ur => ur);
                    if (ListaFornecedores.Count() > 0)
                    {
                        l = ListaFornecedores.FirstOrDefault();
                        bd.listafornecedores.Remove(l);
                        bd.SaveChanges();
                        CarregaFornecedores();
                        MessageBox.Show("Fornecedor excluido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        } 

        private void dgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Sessao.FornecedorAtivo = Convert.ToInt32(dgvFornecedor.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void dgvFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Sessao.FornecedorAtivo = Convert.ToInt32(dgvFornecedor.Rows[e.RowIndex].Cells[0].Value.ToString());
            tCadFornecedor.ShowDialog();
        }

        private void cadProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            limpaTela();
            Sessao.FornecedorAtivo = 0;
        } 
    }
}
