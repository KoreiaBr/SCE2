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
    public partial class cadPedidos : Form
    {
        public string CodigoDoProduto = "";
        cadProduto tCadProduto = new cadProduto();
        public cadPedidos()
        {
            InitializeComponent();
        }

        private void LimpaTela()
        {
            Sessao.ProdutoAtivo = "";
            txtData.Value = DateTime.Now;
            txtUsuario.Text = Sessao.NomeUsuario;
            cmbTipo.Text = "Saída";
            txtCodProduto.Text = "";
            txtNomeProduto.Text = "";
            txtQuantidade.Text = "0";
            txtCusto.Text = "0";
            txtCusto.Enabled = false;
            btnAddItem.Enabled = false;
            btnDelItem.Enabled = false;
            btnSalvar.Enabled = true;
            cmbTipo.Enabled = true;
            txtData.Enabled = true;
            dgvProdutos.Columns[3].Visible = false;
            dgvProdutos.Columns[1].Width = 350;
            dgvProdutos.Rows.Clear();

        }

        private void AutoCompletaProdutos()
        { 
             AutoCompleteStringCollection ListaProdutos = new AutoCompleteStringCollection();
             using (bancoSCE bd = new bancoSCE())
             {
                 var produtos = from ur in bd.produto where ur.ativo == "1" orderby ur.codigo select ur;
                 foreach (produto usr in produtos)
                 {
                     ListaProdutos.Add(usr.codigo);
                 }
             }
             txtCodProduto.AutoCompleteCustomSource = ListaProdutos;
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

        private void CarregaProdutos()
        {
            string CodigoPedido = txtCodigo.Text.ToString();
           // if (CodigoPedido !="(Novo)")
            //{
                using (bancoSCE bd = new bancoSCE())
                {
                    var listaProdutos = (from e in bd.pedidosdetalhes
                                         join f in bd.pedidos on e.pedidoID equals f.ID
                                         join p in bd.produto on e.produtoID equals p.ID
                                        //where e.pedidoID == CodigoPedido
                                         select new { p.descricao, e.quantidade, p.custo });
                    if (listaProdutos != null)
                    {
                        dgvProdutos.Enabled = true;
                        dgvProdutos.DataSource = listaProdutos.ToList();
                        //dgvProdutos.Columns[0].Visible = false;
                        //dgvProdutos.Columns[1].HeaderText = "Produto";
                        //dgvProdutos.Columns[1].Width = 400;
                    }
                    else
                    {
                        dgvProdutos.Refresh();
                        dgvProdutos.Enabled = false;
                    }
                }    
            //}
        }

        private void cadPedidos_Load(object sender, EventArgs e)
        {
            LimpaTela();
            //CarregaProdutos();
            AutoCompletaProdutos();
        }

        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {
            using (bancoSCE bd = new bancoSCE())
            {
                string CodigoProduto = txtCodProduto.Text;
                produto p = new produto();
                var Produto = (bd.produto.Where(ur => ur.codigo == CodigoProduto));
                Produto = Produto.Where(ur => ur.ativo == "1");
                Produto = Produto.Select(ur => ur);
                if (Produto.Count() > 0)
                {
                    p = Produto.FirstOrDefault();
                    txtNomeProduto.Text = p.descricao;
                    btnAddItem.Enabled = true;
                }
                else
                {
                    txtNomeProduto.Text = "";
                    btnAddItem.Enabled = false;
                }
            }
        }

        private void txtCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoNumeros(sender, e, ',');
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.ToString() !="/" ) //gabiarra para não colocar o caractere especial
            {
                SoNumeros(sender, e, '/');
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            Close();
        }

        private void cmbTipo_TextChanged(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "Entrada")
            {
                txtCusto.Text = "0";
                txtCusto.Enabled = true;
                dgvProdutos.Columns[3].Visible = true;
                dgvProdutos.Columns[1].Width = 250;
            }
            else
            {
                txtCusto.Text = "";
                txtCusto.Enabled = false;
                dgvProdutos.Columns[3].Visible = false;
                dgvProdutos.Columns[1].Width = 350;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (txtCusto.Text == "")
                txtCusto.Text = "0";
            if (Convert.ToInt32(txtQuantidade.Text) > 0)
            {
                int i = (dgvProdutos.RowCount);
                if (i == 0)
                {
                    cmbTipo.Enabled = false;
                    txtData.Enabled = false;//depois de inserrir o primeiro item bloqueia a troca do tipo
                    btnDelItem.Enabled = true;
                }
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[i].Cells[0].Value = txtCodProduto.Text;
                dgvProdutos.Rows[i].Cells[1].Value = txtNomeProduto.Text;
                dgvProdutos.Rows[i].Cells[2].Value = txtQuantidade.Text;
                dgvProdutos.Rows[i].Cells[3].Value = txtCusto.Text;
                Sessao.ProdutoAtivo = txtCodProduto.Text;
                txtCodProduto.Text = "";
                txtCodProduto.Focus();
                txtQuantidade.Text = "0";
                txtCusto.Text = "0";
                CodigoDoProduto = txtCodProduto.Text;
            }
            else
            {
                MessageBox.Show("Informe a quantidade do item selecionado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQuantidade.Focus();
            }
        }

        private void btnDelItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            string mensagem = "Produto não encontrado!";
            if (Sessao.ProdutoAtivo != "")
            {
                string ProdutoDaGrid = "";
                string ProdutoSelecionado = Sessao.ProdutoAtivo;
                for (i = 0; i <= dgvProdutos.RowCount; i++)
                {
                     ProdutoDaGrid = dgvProdutos.Rows[i].Cells[0].Value.ToString();
                    if (ProdutoDaGrid == ProdutoSelecionado)
                    {
                        
                        if (dgvProdutos.RowCount > 0)
                        {
                            if (i > 0)
                                Sessao.ProdutoAtivo = dgvProdutos.Rows[(i - 1)].Cells[0].Value.ToString();
                            else
                                Sessao.ProdutoAtivo = "";
                        }
                        mensagem = ("Produto " + dgvProdutos.Rows[i].Cells[1].Value + " Excluido!");
                        dgvProdutos.Rows.RemoveAt(i);
                    }
                }
                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                   
                txtCodProduto.Focus();
                if (dgvProdutos.RowCount == 0)
                    btnDelItem.Enabled = false;
            }            
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Sessao.ProdutoAtivo = dgvProdutos.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Sessao.ProdutoAtivo = dgvProdutos.Rows[e.RowIndex].Cells[0].Value.ToString();
            tCadProduto.ShowDialog();
        }

        private void cadPedidos_FormClosed(object sender, FormClosedEventArgs e)
        {
            LimpaTela();
            Sessao.ProdutoAtivo = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int i = 0;
            int PedidoID = 0;
            int codigoProduto = 0;
            int Qtn = 0;
            double Custo = 0;
            string CodigoAlfanumerico = "";
            string Tipo = "S";
            if (cmbTipo.Text == "Entrada")
                    Tipo = "E";
           using (bancoSCE bd = new bancoSCE())
           {
               var UltimoID = (from r in bd.pedidos
                               orderby r.ID descending
                               select r).First();
               PedidoID = UltimoID.ID + 1;
            pedidos NovoPedido = new pedidos()
            {
                data = txtData.Value,
                usuario = txtUsuario.Text,
                tipo = Tipo,
            };
            bd.pedidos.Add(NovoPedido);
            for (i = 0; i <= dgvProdutos.RowCount; i++)
            {
                CodigoAlfanumerico = dgvProdutos.Rows[i].Cells[0].Value.ToString();
                Qtn = Convert.ToInt32(dgvProdutos.Rows[i].Cells[2].Value);
                Custo = Convert.ToDouble(dgvProdutos.Rows[i].Cells[3].Value);
                var produto = (bd.produto.Where(ur => ur.codigo == CodigoAlfanumerico)); //busca codigo do produto
                produto = produto.Select(ur => ur);
                var usr = produto.First();
                codigoProduto = usr.ID;               
                pedidosdetalhes NovoItemPedido = new pedidosdetalhes()
                {
                    pedidoID = PedidoID,
                    produtoID = codigoProduto,
                    quantidade = Qtn,
                    custo = Custo
                };
                bd.pedidosdetalhes.Add(NovoItemPedido);
            }
            //bd.SaveChanges();
            MessageBox.Show("Pedido salvo com sucesso!", "Informção", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            LimpaTela();



                       //int CodProduto = Convert.ToInt32(txtCodigo.Text);
                       // mensagem = "Produto atulizado com sucesso!";
                       // produto Produto = bd.produto.First(p => p.ID == (CodProduto));
                       // Produto.descricao = tbxDescricao.Text;
                       // Produto.classfiscal = txtClassFiscal.Text;
                       // Produto.quantidade = Convert.ToInt32(txtQuantidade.Text);
                       // Produto.custo = Convert.ToDouble(txtCAtual.Text);
                       // Produto.peso = Convert.ToDouble(txtPeso.Text);
                       // Produto.custoMedio = Convert.ToDouble(txtCMedio.Text);
                       // Produto.categoriaID = Convert.ToInt32(cbxCategoria.SelectedValue);
                       // Produto.importado = importado;
                       // Produto.estrutura = estrutura;
           }
        }
    }
}
