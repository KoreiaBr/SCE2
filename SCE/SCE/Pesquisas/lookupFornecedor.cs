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
    public partial class lookupFornecedor : Form
    {
        public string CodFornecedor;
        public lookupFornecedor()
        {
            InitializeComponent();
        }

        private void CarregaGrid(string filtro)
        {
            using (bancoSCE bd = new bancoSCE())
            {
                var fornecedor = (bd.fornecedor.Where(ur => ur.ativo == "1"));
                if (!string.IsNullOrEmpty(filtro))
                {
                    fornecedor = fornecedor.Where(ur => ur.nome.Contains(filtro));
                };
                fornecedor = fornecedor.OrderBy(ur => ur.nome);
                fornecedor = fornecedor.Select(ur => ur);
                if (fornecedor.Count() == 0)
                {
                    CodFornecedor = "0";
                    dgvResultado.Refresh();
                }
                else
                {
                    var usr = fornecedor.FirstOrDefault();
                    CodFornecedor = usr.ID.ToString();
                    dgvResultado.DataSource = fornecedor.ToList();
                    dgvResultado.Columns[0].Visible = false;
                    dgvResultado.Columns[2].Visible = false;
                    dgvResultado.Columns[4].Visible = false;
                    dgvResultado.Columns[5].Visible = false;
                    dgvResultado.Columns[6].Visible = false;
                    dgvResultado.Columns[1].HeaderText = "Fornecedor";
                    dgvResultado.Columns[3].HeaderText = "Telefone";
                    dgvResultado.Columns[1].Width = 360;
                    dgvResultado.Columns[3].Width = 120;
                }
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

        private void lookupFornecedor_Load(object sender, EventArgs e)
        {
            CarregaGrid("");
            txtFornecedor.Text = ""; 
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CodFornecedor = "0";
            Close();
        }

        private void dgvResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CodFornecedor = dgvResultado.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CodFornecedor = dgvResultado.Rows[e.RowIndex].Cells[0].Value.ToString();
            Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            CarregaGrid(txtFornecedor.Text);
        }
    }
}
