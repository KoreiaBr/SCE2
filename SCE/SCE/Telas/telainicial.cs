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
    public partial class telainicial : Form
    {
        public bool VerificaCLique = false;
        public bool cadastroAberto = false;
        public bool relatorioAberto = false;
        public telainicial()
        {
            InitializeComponent();
        }

        private void telainicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MenuFocusON(object sender, EventArgs e)
        {
            (sender as Label).BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            (sender as Label).BorderStyle = BorderStyle.Fixed3D;
        }

        private void MenuFocusOFF(object sender, EventArgs e)
        {
            if (VerificaCLique == false)
            {
                (sender as Label).BackColor = System.Drawing.SystemColors.ActiveCaption;
                (sender as Label).BorderStyle = BorderStyle.None;            
            }
        }

        private void lblProduto_Click(object sender, EventArgs e)
        {
            VerificaCLique = true;
            Telas.cadProduto tCadProduto = new Telas.cadProduto();
            tCadProduto.ShowDialog();
        }

        private void lblFornecedor_Click(object sender, EventArgs e)
        {
            VerificaCLique = true;
            cadFornecedor tCadFornecedor = new cadFornecedor();
            tCadFornecedor.ShowDialog();        
        }
        
        private void lblUsuario_Click(object sender, EventArgs e)
        {
            VerificaCLique = true;
            cadUsuario tCadUsuario = new cadUsuario();
            tCadUsuario.ShowDialog();        
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Você está saindo", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                Application.Exit();
            }
        }

        private void telainicial_Activated(object sender, EventArgs e)
        {
            if (VerificaCLique == true)
            {
                VerificaCLique = false;
            }
        }

        private void telainicial_Load(object sender, EventArgs e)
        {
            bslVersaoSys.Text = Sessao.ObtemVersao();         
            bslUsuarioSys.Text = Sessao.NomeUsuario;
        }

        private void lblCadastros_Click(object sender, EventArgs e)
        {
            if (cadastroAberto == false && relatorioAberto == false)
            {
                cadastroAberto = true;
                MenuFechado.Visible = false;
                MenuCadastroAberto.Visible = true;
                MenuRelatorioAberto.Visible = false;
                menuCompleto.Visible = false;         
            }
            else if (cadastroAberto == false && relatorioAberto == true)
            {
                cadastroAberto = true;
                MenuFechado.Visible = false;
                MenuCadastroAberto.Visible = false;
                MenuRelatorioAberto.Visible = false;
                menuCompleto.Visible = true;  
            }
            else if (cadastroAberto == true && relatorioAberto == true)
            {
                cadastroAberto = false;
                MenuFechado.Visible = false;
                MenuCadastroAberto.Visible = false;
                MenuRelatorioAberto.Visible = true;
                menuCompleto.Visible = false;  
            }
            else if (cadastroAberto == true && relatorioAberto == false)
            {
                cadastroAberto = false;
                MenuFechado.Visible = true;
                MenuCadastroAberto.Visible = false;
                MenuRelatorioAberto.Visible = false;
                menuCompleto.Visible = false;  
            }
        }

        private void lblRelatorios_click(object sender, EventArgs e)
        {
            if (cadastroAberto == false && relatorioAberto == false)
            {
                relatorioAberto = true;
                MenuFechado.Visible = false;
                MenuCadastroAberto.Visible = false;
                MenuRelatorioAberto.Visible = true;
                menuCompleto.Visible = false;
            }
            else if (cadastroAberto == true && relatorioAberto == false)
            {
                relatorioAberto = true;
                MenuFechado.Visible = false;
                MenuCadastroAberto.Visible = false;
                MenuRelatorioAberto.Visible = false;
                menuCompleto.Visible = true;
            }
            else if (cadastroAberto == true && relatorioAberto == true)
            {
                relatorioAberto = false;
                MenuFechado.Visible = false;
                MenuCadastroAberto.Visible = true;
                MenuRelatorioAberto.Visible = false;
                menuCompleto.Visible = false;
            }
            else if (cadastroAberto == false && relatorioAberto == true)
            {
                relatorioAberto = false;
                MenuFechado.Visible = true;
                MenuCadastroAberto.Visible = false;
                MenuRelatorioAberto.Visible = false;
                menuCompleto.Visible = false;
            }
        }

        private void lblPedidos_Click(object sender, EventArgs e)
        {
            VerificaCLique = true;
            Telas.cadPedidos tCadPedido = new Telas.cadPedidos();
            tCadPedido.ShowDialog();
        }
    }
}
