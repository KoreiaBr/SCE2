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

    public partial class cadUsuario : Form
    {

        public bool VisulizarSenha = false;
        public bool AtivaPesquisa = false;
        lookupUsuarios tPesquisaUser = new lookupUsuarios();

        public cadUsuario()
        {
            InitializeComponent();
        }

        private void pctVisulizarSenha_Click(object sender, EventArgs e)
        {
            if (VisulizarSenha == false)
            {
                tbxSenha.PasswordChar = char.Parse("\0");
                pctVisulizarSenha.BorderStyle = BorderStyle.Fixed3D;
                VisulizarSenha = true;
            }
            else
            {
                tbxSenha.PasswordChar = Convert.ToChar("*");
                pctVisulizarSenha.BorderStyle = BorderStyle.None;
                VisulizarSenha = false;
            }
            
        }

        private void limpaTela()
        {
            txtCodigo.Text = "(Novo)";
            tbxNome.Text = "Insira um nome";
            tbxSenha.Text = "";
            tbxNome.ForeColor = System.Drawing.SystemColors.ControlLight;
            btnDeletar.Enabled = false;
            btnNovo.Enabled = false;
        }


        private void AtivaComponente(object sender, EventArgs e)
        {
            (sender as PictureBox).BorderStyle = BorderStyle.FixedSingle;
        }

        private void DesativaComponente(object sender, EventArgs e)
        {
            if (VisulizarSenha == false)
            {
                (sender as PictureBox).BorderStyle = BorderStyle.None;
            }
            else
            {
                (sender as PictureBox).BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaTela();
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tbxNome.Text != "Insira um nome" && !string.IsNullOrEmpty(tbxSenha.Text))
            {
                using (bancoSCE bd = new bancoSCE())
                {
                    string codigoUsuario = txtCodigo.Text;
                    string mensagem = "Usuario cadastrado com sucesso!";
                    if (codigoUsuario == "(Novo)")
                    {
                        usuario NovoUsuario = new usuario() { nome = tbxNome.Text, senha = tbxSenha.Text, ativo = "1"};
                        bd.usuario.Add(NovoUsuario);
                    }
                    else
                    {
                        int CodUsuario = Convert.ToInt32(txtCodigo.Text);
                        mensagem = "Usuario atulizado com sucesso!";
                        usuario Usuario = bd.usuario.First(p => p.ID == (CodUsuario));
                        Usuario.nome = tbxNome.Text;
                        Usuario.senha = tbxSenha.Text;
                    }
                    bd.SaveChanges();
                    MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaTela();
                }
            }
            else
            {
                MessageBox.Show("Informe um nome e Senha", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void tbxNome_Enter(object sender, EventArgs e)
        {
            if (tbxNome.Text == "Insira um nome")
            {
                tbxNome.Text = "";
            }
            tbxNome.ForeColor = System.Drawing.SystemColors.Highlight;
        }

        private void tbxNome_Leave(object sender, EventArgs e)
        {
            if (tbxNome.Text == "")
            {
                tbxNome.Text = "Insira um nome";
                tbxNome.ForeColor = System.Drawing.SystemColors.ControlLight;
            }
        }

        private void pctPesquisar_Click(object sender, EventArgs e)
        {
            AtivaPesquisa = true;
            tPesquisaUser.ShowDialog();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            limpaTela();
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

        private void cadUsuario_Enter(object sender, EventArgs e)
        {
            if (AtivaPesquisa == true)
            {
                AtivaPesquisa = false; // previne o loop infinito nesse evento
                int codigo = Convert.ToInt32(tPesquisaUser.CodUsuario);
                if (codigo > 0)
                {
                    txtCodigo.Text = tPesquisaUser.CodUsuario;
                    using (bancoSCE bd = new bancoSCE())
                    {
                        var usuarios = (bd.usuario.Where( ur => ur.ID == codigo));
                        usuarios = usuarios.Select(ur => ur);
                        var usr = usuarios.FirstOrDefault();
                        txtCodigo.Text = usr.ID.ToString();
                        tbxNome.Text = usr.nome;
                        tbxSenha.Text = usr.senha;
                    }
                    tbxNome.ForeColor = System.Drawing.SystemColors.Highlight;
                    tPesquisaUser.CodUsuario = "0";
                    btnDeletar.Enabled = true;
                    btnNovo.Enabled = true;
                }
                else
                {
                    limpaTela();
                }  
            }
            
        }

        private void cadUsuario_Load(object sender, EventArgs e)
        {
            AtivaPesquisa = false;
            limpaTela();
        }

        private void btnNovo_click(object sender, EventArgs e)
        {
            limpaTela();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja excluir o usuario?", "Deletar o Usuario?",
               MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                using (bancoSCE bd = new bancoSCE())
                {
                    int codigoUsuario = Convert.ToInt32(txtCodigo.Text);
                    usuario Usuario = bd.usuario.First(p => p.ID == codigoUsuario);
                    Usuario.ativo = "0";
                    bd.SaveChanges();
                }
                limpaTela();
                MessageBox.Show("Usuario excluido com sucesso!", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}
