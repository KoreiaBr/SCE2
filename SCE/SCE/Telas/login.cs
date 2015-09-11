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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (bancoSCE bd = new bancoSCE())
            {
                int I = 0;
                var usuarios = from ur in bd.usuario where ur.ativo =="1" orderby ur.nome select ur;
                foreach (usuario usr in usuarios)
                {
                    if (I == 0)
                    {
                        cbUsuario.Items.Add(usr.nome);
                        cbUsuario.Text = usr.nome;
                        I++;
                    }
                    else
                    {
                        cbUsuario.Items.Add(usr.nome);
                    }
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnEntrar.PerformClick();
            }
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            using (bancoSCE bd = new bancoSCE())
            {
                string user = cbUsuario.Text;
                string senha = TxSenha.Text;
                var usuarios = from ur in bd.usuario where user == ur.nome select ur;
                foreach (usuario usr in usuarios)
                {
                    if (usr.senha == senha)
                    {
                        telainicial tInicio = new telainicial();
                        Sessao.NomeUsuario = user;
                        this.Hide();
                        tInicio.Show();
                    }
                    else
                    {
                        MessageBox.Show("Senha Incorreta!", "Erro ao logar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxSenha.Text = "";
                        TxSenha.Focus();
                    }
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

    }
}
