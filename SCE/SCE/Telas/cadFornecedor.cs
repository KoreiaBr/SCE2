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
    public partial class cadFornecedor : Form
    {
        public bool AtivaPesquisa = false;
        Pesquisas.lookupFornecedor tPesquisaFornec = new Pesquisas.lookupFornecedor();
        public cadFornecedor()
        {
            InitializeComponent();
        }

        private void limpaTela()
        {
            tbxCodigo.Text = "(Novo)";
            tbxNome.Text = "Insira um nome";
            tbxCnpj.Text = "";
            tbxTelefone.Text = "";
            tbxCelular.Text = "";
            tbxEmail.Text = "";
            tbxNome.ForeColor = System.Drawing.SystemColors.ControlLight;
            btnDeletar.Enabled = false;
            btnNovo.Enabled = false;
        }

        private void SoNumeros(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Letras
                char.IsSymbol(e.KeyChar) || //Símbolos
                char.IsWhiteSpace(e.KeyChar) || //Espaço
                char.IsPunctuation(e.KeyChar)) //Pontuação
            {
                e.Handled = true; //Não permitir
            }
        }

        private void FormataNome (object sender, EventArgs e)
        {
            if (tbxNome.Text == "Insira um nome")
            {
                tbxNome.Text = "";
                tbxNome.ForeColor = System.Drawing.SystemColors.Highlight;
            }
            else if (tbxNome.Text == "")
            {
                tbxNome.Text = "Insira um nome";
                tbxNome.ForeColor = System.Drawing.SystemColors.ControlLight;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tbxNome.Text != "Insira um nome")
            {
                using (bancoSCE bd = new bancoSCE())
                {
                    string codigoUsuario = tbxCodigo.Text;
                    string mensagem = "Fornecedor cadastrado com sucesso!";
                    if (codigoUsuario == "(Novo)")
                    {
                        fornecedor NovoFornecedor = new fornecedor() { nome = tbxNome.Text, cnpj = tbxCnpj.Text,
                            telefone = tbxTelefone.Text, celular = tbxCelular.Text, email = tbxEmail.Text, ativo = "1"};
                        bd.fornecedor.Add(NovoFornecedor);
                    }
                    else
                    {
                        int CodFornec = Convert.ToInt32(tbxCodigo.Text);
                        mensagem = "Fornecedor atulizado com sucesso!";
                        fornecedor Fornecedor = bd.fornecedor.First(p => p.ID == (CodFornec));
                        Fornecedor.nome = tbxNome.Text;
                        Fornecedor.cnpj = tbxCnpj.Text;
                        Fornecedor.telefone = tbxTelefone.Text;
                        Fornecedor.celular= tbxCelular.Text;
                        Fornecedor.email = tbxEmail.Text;
                    }
                    bd.SaveChanges();
                    MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaTela();
                }
            }
            else
            {
                MessageBox.Show("Informe um nome para o fornecedor", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpaTela();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja excluir o Fornecedor?", "Deletar o Fornecedor?",
               MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                using (bancoSCE bd = new bancoSCE())
                {
                    int CodFornec = Convert.ToInt32(tbxCodigo.Text);
                    fornecedor Fornecedor = bd.fornecedor.First(p => p.ID == (CodFornec));
                    Fornecedor.ativo = "0";
                    bd.SaveChanges();
                }
                limpaTela();
                MessageBox.Show("Fornecedor excluido com sucesso!", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoNumeros(e);   //digita apenas numeros, del e backspace
            if (e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back) // aceita deltar o que esta escrito
            {
                string textCnpj = tbxCnpj.Text;
                int tamanhoTexto = tbxCnpj.Text.Length;
                if (tamanhoTexto == 2)
                {
                    textCnpj = textCnpj.Insert(2, ".");
                }
                else if (tamanhoTexto == 6)
                {
                    textCnpj = textCnpj.Insert(6, ".");
                }
                else if (tamanhoTexto == 10)
                {
                    textCnpj = textCnpj.Insert(10, "/");
                }
                else if (tamanhoTexto == 15)
                {
                    textCnpj = textCnpj.Insert(15, "-");
                }
                tbxCnpj.Text = textCnpj;
                tbxCnpj.Select(tbxCnpj.Text.Length, 0);
            }

        }

        private void tbxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoNumeros(e);   //digita apenas numeros, del e backspace
            if (e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back) // aceita deltar o que esta escrito
            {
                string textTelefone = tbxTelefone.Text;
                int tamanhoTexto = tbxTelefone.Text.Length;
                if (tamanhoTexto == 1)
                {
                    textTelefone = textTelefone.Insert(0, "(");
                }
                else if (tamanhoTexto == 3)
                {
                    textTelefone = textTelefone.Insert(3, ") ");
                }
                else if (tamanhoTexto == 9)
                {
                    textTelefone = textTelefone.Insert(9, "-");
                }
                else if (tamanhoTexto == 14)
                {
                    textTelefone = textTelefone.Replace("-", "");
                    textTelefone = textTelefone.Insert(10, "-");

                }
                tbxTelefone.Text = textTelefone;
                tbxTelefone.Select(tbxTelefone.Text.Length, 0);
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


        private void cadFornecedor_Load(object sender, EventArgs e)
        {
            if (Sessao.FornecedorAtivo == 0)
            {
                AtivaPesquisa = false;
            }
            else
            {
                AtivaPesquisa = true;
                tPesquisaFornec.CodFornecedor = Sessao.FornecedorAtivo.ToString();
            }
        }

        private void tbxTelefone_Leave(object sender, EventArgs e)
        {
            string textTelefone = tbxTelefone.Text;
            int tamanhoTexto = tbxTelefone.Text.Length;
            if (tamanhoTexto == 14)
            {
                textTelefone = textTelefone.Replace("-", "");
                textTelefone = textTelefone.Insert(9, "-");
            }
            else if (tamanhoTexto == 15)
            {
                textTelefone = textTelefone.Replace("-", "");
                textTelefone = textTelefone.Insert(10, "-");
            }
            tbxTelefone.Text = textTelefone;
            tbxTelefone.Select(tbxTelefone.Text.Length, 0);
        }

        private void tbxCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoNumeros(e);   //digita apenas numeros, del e backspace
            if (e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back) // aceita deltar o que esta escrito
            {
                string textTelefone = tbxCelular.Text;
                int tamanhoTexto = tbxCelular.Text.Length;
                if (tamanhoTexto == 1)
                {
                    textTelefone = textTelefone.Insert(0, "(");
                }
                else if (tamanhoTexto == 3)
                {
                    textTelefone = textTelefone.Insert(3, ") ");
                }
                else if (tamanhoTexto == 9)
                {
                    textTelefone = textTelefone.Insert(9, "-");
                }
                else if (tamanhoTexto == 14)
                {
                    textTelefone = textTelefone.Replace("-", "");
                    textTelefone = textTelefone.Insert(10, "-");

                }
                tbxCelular.Text = textTelefone;
                tbxCelular.Select(tbxCelular.Text.Length, 0);
            }
        }

        private void tbxCelular_Leave(object sender, EventArgs e)
        {
            string textTelefone = tbxCelular.Text;
            int tamanhoTexto = tbxCelular.Text.Length;
            if (tamanhoTexto == 14)
            {
                textTelefone = textTelefone.Replace("-", "");
                textTelefone = textTelefone.Insert(9, "-");
            }
            else if (tamanhoTexto == 15)
            {
                textTelefone = textTelefone.Replace("-", "");
                textTelefone = textTelefone.Insert(10, "-");
            }
            tbxCelular.Text = textTelefone;
            tbxCelular.Select(tbxCelular.Text.Length, 0);
        }

        private void pctPesquisar_Click(object sender, EventArgs e)
        {
            AtivaPesquisa = true;
            tPesquisaFornec.ShowDialog();
        }

        private void cadFornecedor_Activated(object sender, EventArgs e)
        {
            if (AtivaPesquisa == true)
            {
                AtivaPesquisa = false; // previne o loop infinito nesse evento
                Sessao.FornecedorAtivo = 0;
                int codigo = Convert.ToInt32(tPesquisaFornec.CodFornecedor);
                if (codigo > 0)
                {
                    tbxCodigo.Text = tPesquisaFornec.CodFornecedor;
                    using (bancoSCE bd = new bancoSCE())
                    {
                        var fornecedor = (bd.fornecedor.Where(ur => ur.ID == codigo));
                        fornecedor = fornecedor.Select(ur => ur);
                        var usr = fornecedor.FirstOrDefault();
                        tbxCodigo.Text = usr.ID.ToString();
                        tbxNome.Text = usr.nome;
                        tbxCnpj.Text = usr.cnpj;
                        tbxTelefone.Text = usr.telefone;
                        tbxCelular.Text = usr.celular;
                        tbxEmail.Text = usr.email;
                    }
                    tbxNome.ForeColor = System.Drawing.SystemColors.Highlight;
                    tPesquisaFornec.CodFornecedor = "0";
                    btnDeletar.Enabled = true;
                    btnNovo.Enabled = true;
                }
                else
                {
                    limpaTela();
                }
            }
        }

        private void cadFornecedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            limpaTela();
        }
    }
}
