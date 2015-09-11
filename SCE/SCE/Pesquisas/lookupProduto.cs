using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCE.Pesquisas
{
    public partial class lookupProduto : Form
    {
        public string CodProduto;
        public lookupProduto()
        {
            InitializeComponent();
        }

        private void CarregaGrid(string filtro)
        {
            using (bancoSCE bd = new bancoSCE())
            {
                var produto = (bd.produto.Where(ur => ur.ativo == "1"));
                if (!string.IsNullOrEmpty(filtro))
                {
                    produto = produto.Where(ur => ur.descricao.Contains(filtro));
                };
                produto = produto.OrderBy(ur => ur.descricao);
                produto = produto.Select(ur => ur);
                if (produto.Count() == 0)
                {
                    CodProduto = "0";
                    dgvResultado.DataSource = null;
                    dgvResultado.Refresh();
                }
                else
                {
                    var usr = produto.FirstOrDefault();
                    CodProduto = usr.ID.ToString();
                    dgvResultado.DataSource = produto.ToList();
                    dgvResultado.Columns[0].Visible = false;
                    dgvResultado.Columns[3].Visible = false;
                    dgvResultado.Columns[4].Visible = false;
                    dgvResultado.Columns[5].Visible = false;
                    dgvResultado.Columns[6].Visible = false;
                    dgvResultado.Columns[7].Visible = false;
                    dgvResultado.Columns[8].Visible = false;
                    dgvResultado.Columns[9].Visible = false;
                    dgvResultado.Columns[10].Visible = false;
                    dgvResultado.Columns[11].Visible = false;
                    dgvResultado.Columns[1].HeaderText = "Codigo";
                    dgvResultado.Columns[2].HeaderText = "Descrção";
                    dgvResultado.Columns[1].Width = 100;
                    dgvResultado.Columns[2].Width = 380;
                }
            }
        }


        private void lookupProduto_Load(object sender, EventArgs e)
        {
            CarregaGrid("");
            txtProduto.Text = "";
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            CarregaGrid(txtProduto.Text);
        }

        private void dgvResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CodProduto = dgvResultado.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CodProduto = dgvResultado.Rows[e.RowIndex].Cells[0].Value.ToString();
            Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CodProduto = "0";
            Close();
        }
    }
}
