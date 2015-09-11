namespace SCE
{
    partial class cadFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadFornecedor));
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pctPesquisar = new System.Windows.Forms.PictureBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbxCnpj = new System.Windows.Forms.TextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbxCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.tbxTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctPesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovo.Enabled = false;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(152, 295);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(133, 43);
            this.btnNovo.TabIndex = 20;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            this.btnNovo.MouseEnter += new System.EventHandler(this.BtnFocusON);
            this.btnNovo.MouseLeave += new System.EventHandler(this.BtnFocusOFF);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(429, 295);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 43);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.BtnFocusON);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.BtnFocusOFF);
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Enabled = false;
            this.tbxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCodigo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbxCodigo.Location = new System.Drawing.Point(111, 6);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(145, 31);
            this.tbxCodigo.TabIndex = 12;
            this.tbxCodigo.Text = "(Novo)";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(93, 25);
            this.lblCodigo.TabIndex = 22;
            this.lblCodigo.Text = "Código:";
            // 
            // pctPesquisar
            // 
            this.pctPesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pctPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("pctPesquisar.Image")));
            this.pctPesquisar.Location = new System.Drawing.Point(536, 48);
            this.pctPesquisar.Name = "pctPesquisar";
            this.pctPesquisar.Size = new System.Drawing.Size(26, 21);
            this.pctPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPesquisar.TabIndex = 21;
            this.pctPesquisar.TabStop = false;
            this.pctPesquisar.Click += new System.EventHandler(this.pctPesquisar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.Location = new System.Drawing.Point(291, 295);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(131, 43);
            this.btnDeletar.TabIndex = 21;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            this.btnDeletar.MouseEnter += new System.EventHandler(this.BtnFocusON);
            this.btnDeletar.MouseLeave += new System.EventHandler(this.BtnFocusOFF);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(17, 295);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(129, 43);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "   Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.MouseEnter += new System.EventHandler(this.BtnFocusON);
            this.btnSalvar.MouseLeave += new System.EventHandler(this.BtnFocusOFF);
            // 
            // tbxCnpj
            // 
            this.tbxCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCnpj.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tbxCnpj.Location = new System.Drawing.Point(17, 134);
            this.tbxCnpj.MaxLength = 18;
            this.tbxCnpj.Name = "tbxCnpj";
            this.tbxCnpj.Size = new System.Drawing.Size(286, 31);
            this.tbxCnpj.TabIndex = 15;
            this.tbxCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCnpj_KeyPress);
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCnpj.Location = new System.Drawing.Point(12, 106);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(78, 25);
            this.lblCnpj.TabIndex = 13;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // tbxNome
            // 
            this.tbxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNome.ForeColor = System.Drawing.SystemColors.Control;
            this.tbxNome.Location = new System.Drawing.Point(17, 72);
            this.tbxNome.MaxLength = 80;
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(545, 31);
            this.tbxNome.TabIndex = 14;
            this.tbxNome.Text = "Insira um nome";
            this.tbxNome.Enter += new System.EventHandler(this.FormataNome);
            this.tbxNome.Leave += new System.EventHandler(this.FormataNome);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNome.Location = new System.Drawing.Point(12, 44);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(79, 25);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome:";
            // 
            // tbxCelular
            // 
            this.tbxCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCelular.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tbxCelular.Location = new System.Drawing.Point(341, 196);
            this.tbxCelular.MaxLength = 15;
            this.tbxCelular.Name = "tbxCelular";
            this.tbxCelular.Size = new System.Drawing.Size(221, 31);
            this.tbxCelular.TabIndex = 17;
            this.tbxCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCelular_KeyPress);
            this.tbxCelular.Leave += new System.EventHandler(this.tbxCelular_Leave);
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCelular.Location = new System.Drawing.Point(336, 168);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(94, 25);
            this.lblCelular.TabIndex = 24;
            this.lblCelular.Text = "Celular:";
            // 
            // tbxTelefone
            // 
            this.tbxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTelefone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tbxTelefone.Location = new System.Drawing.Point(17, 196);
            this.tbxTelefone.MaxLength = 15;
            this.tbxTelefone.Name = "tbxTelefone";
            this.tbxTelefone.Size = new System.Drawing.Size(221, 31);
            this.tbxTelefone.TabIndex = 16;
            this.tbxTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTelefone_KeyPress);
            this.tbxTelefone.Leave += new System.EventHandler(this.tbxTelefone_Leave);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTelefone.Location = new System.Drawing.Point(12, 168);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(111, 25);
            this.lblTelefone.TabIndex = 23;
            this.lblTelefone.Text = "Telefone:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tbxEmail.Location = new System.Drawing.Point(17, 258);
            this.tbxEmail.MaxLength = 80;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(545, 31);
            this.tbxEmail.TabIndex = 18;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblemail.Location = new System.Drawing.Point(12, 230);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(85, 25);
            this.lblemail.TabIndex = 27;
            this.lblemail.Text = "E-mail:";
            // 
            // cadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(573, 349);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.tbxCelular);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.tbxTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pctPesquisar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tbxCnpj);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cadFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Fornecedor";
            this.Activated += new System.EventHandler(this.cadFornecedor_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cadFornecedor_FormClosed);
            this.Load += new System.EventHandler(this.cadFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctPesquisar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pctPesquisar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox tbxCnpj;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbxCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox tbxTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblemail;
    }
}