namespace SCE
{
    partial class cadUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadUsuario));
            this.lblNome = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.pcbImagem = new System.Windows.Forms.PictureBox();
            this.pctVisulizarSenha = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.pctPesquisar = new System.Windows.Forms.PictureBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.bdsResultado = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVisulizarSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNome.Location = new System.Drawing.Point(215, 80);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(79, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // tbxNome
            // 
            this.tbxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNome.ForeColor = System.Drawing.SystemColors.Control;
            this.tbxNome.Location = new System.Drawing.Point(220, 108);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(333, 31);
            this.tbxNome.TabIndex = 2;
            this.tbxNome.Text = "Insira um nome";
            this.tbxNome.Enter += new System.EventHandler(this.tbxNome_Enter);
            this.tbxNome.Leave += new System.EventHandler(this.tbxNome_Leave);
            // 
            // tbxSenha
            // 
            this.tbxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSenha.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tbxSenha.Location = new System.Drawing.Point(220, 182);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(333, 31);
            this.tbxSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSenha.Location = new System.Drawing.Point(215, 154);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(86, 25);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // pcbImagem
            // 
            this.pcbImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbImagem.Image = ((System.Drawing.Image)(resources.GetObject("pcbImagem.Image")));
            this.pcbImagem.Location = new System.Drawing.Point(12, 12);
            this.pcbImagem.Name = "pcbImagem";
            this.pcbImagem.Size = new System.Drawing.Size(197, 203);
            this.pcbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagem.TabIndex = 4;
            this.pcbImagem.TabStop = false;
            // 
            // pctVisulizarSenha
            // 
            this.pctVisulizarSenha.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pctVisulizarSenha.Image = ((System.Drawing.Image)(resources.GetObject("pctVisulizarSenha.Image")));
            this.pctVisulizarSenha.Location = new System.Drawing.Point(527, 158);
            this.pctVisulizarSenha.Name = "pctVisulizarSenha";
            this.pctVisulizarSenha.Size = new System.Drawing.Size(26, 21);
            this.pctVisulizarSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctVisulizarSenha.TabIndex = 6;
            this.pctVisulizarSenha.TabStop = false;
            this.pctVisulizarSenha.Click += new System.EventHandler(this.pctVisulizarSenha_Click);
            this.pctVisulizarSenha.MouseEnter += new System.EventHandler(this.AtivaComponente);
            this.pctVisulizarSenha.MouseLeave += new System.EventHandler(this.DesativaComponente);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(12, 221);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(129, 43);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "   Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.MouseEnter += new System.EventHandler(this.BtnFocusON);
            this.btnSalvar.MouseLeave += new System.EventHandler(this.BtnFocusOFF);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.Location = new System.Drawing.Point(286, 221);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(131, 43);
            this.btnDeletar.TabIndex = 6;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            this.btnDeletar.MouseEnter += new System.EventHandler(this.BtnFocusON);
            this.btnDeletar.MouseLeave += new System.EventHandler(this.BtnFocusOFF);
            // 
            // pctPesquisar
            // 
            this.pctPesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pctPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("pctPesquisar.Image")));
            this.pctPesquisar.Location = new System.Drawing.Point(527, 84);
            this.pctPesquisar.Name = "pctPesquisar";
            this.pctPesquisar.Size = new System.Drawing.Size(26, 21);
            this.pctPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPesquisar.TabIndex = 9;
            this.pctPesquisar.TabStop = false;
            this.pctPesquisar.Click += new System.EventHandler(this.pctPesquisar_Click);
            this.pctPesquisar.MouseEnter += new System.EventHandler(this.AtivaComponente);
            this.pctPesquisar.MouseLeave += new System.EventHandler(this.DesativaComponente);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCodigo.Location = new System.Drawing.Point(215, 12);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(93, 25);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCodigo.Location = new System.Drawing.Point(220, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(145, 31);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Text = "(Novo)";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(420, 221);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 43);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.BtnFocusON);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.BtnFocusOFF);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovo.Enabled = false;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(147, 221);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(133, 43);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_click);
            this.btnNovo.MouseEnter += new System.EventHandler(this.BtnFocusON);
            this.btnNovo.MouseLeave += new System.EventHandler(this.BtnFocusOFF);
            // 
            // cadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(565, 272);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pctPesquisar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pctVisulizarSenha);
            this.Controls.Add(this.pcbImagem);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Usuário";
            this.Activated += new System.EventHandler(this.cadUsuario_Enter);
            this.Load += new System.EventHandler(this.cadUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVisulizarSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.PictureBox pcbImagem;
        private System.Windows.Forms.PictureBox pctVisulizarSenha;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.PictureBox pctPesquisar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.BindingSource bdsResultado;
    }
}