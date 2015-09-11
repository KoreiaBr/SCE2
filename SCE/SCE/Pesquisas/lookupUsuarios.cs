using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCE
{
    public partial class lookupUsuarios : Form
    {
        public string CodUsuario;
        public lookupUsuarios()
        {
            InitializeComponent();
        }

        private void CarregaGrid (string filtro)
        {
            using (bancoSCE bd = new bancoSCE())
            {
                var usuarios = (bd.usuario.Where(ur => ur.ativo == "1"));
                if (!string.IsNullOrEmpty(filtro))
                {
                    usuarios = usuarios.Where(ur => ur.nome.Contains(filtro));
                };
                usuarios = usuarios.OrderBy(ur => ur.nome);
                usuarios = usuarios.Select(ur => ur);
                var usr = usuarios.FirstOrDefault();
                CodUsuario = usr.ID.ToString();
                dgvResultado.DataSource = usuarios.ToList();
                dgvResultado.Columns[2].Visible = false;
                dgvResultado.Columns[0].Visible = false;
                dgvResultado.Columns[3].Visible = false;
                dgvResultado.Columns[1].HeaderText = "Nome";
                dgvResultado.Columns[1].Width = 310;
            }
        }
        
        private void lookupUsuarios_Load(object sender, EventArgs e)
        {
            CarregaGrid("");
            txtUsuario.Text = ""; 
        }

        private void dgvResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CodUsuario = dgvResultado.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void TxSenha_TextChanged(object sender, EventArgs e)
        {

            CarregaGrid(txtUsuario.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CodUsuario = "0";
            Close();
        }
        private void BtnFocusON(object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.SystemColors.InactiveBorder;
        }

        private void BtnFocusOFF(object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.SystemColors.ControlLightLight;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CodUsuario = dgvResultado.Rows[e.RowIndex].Cells[0].Value.ToString();
            Close();
        }
    }
}
