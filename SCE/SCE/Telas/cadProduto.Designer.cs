namespace SCE.Telas
{
    partial class cadProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadProduto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxProduto = new System.Windows.Forms.GroupBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.pctPesquisar = new System.Windows.Forms.PictureBox();
            this.gbxOpcoes = new System.Windows.Forms.GroupBox();
            this.cbxEstrutura = new System.Windows.Forms.ComboBox();
            this.cbxImportado = new System.Windows.Forms.ComboBox();
            this.lblEstrutura = new System.Windows.Forms.Label();
            this.lblImportado = new System.Windows.Forms.Label();
            this.gbxCusto = new System.Windows.Forms.GroupBox();
            this.txtCMedio = new System.Windows.Forms.TextBox();
            this.txtCAtual = new System.Windows.Forms.TextBox();
            this.lblCustoMedio = new System.Windows.Forms.Label();
            this.lblCustoAtual = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtClassFiscal = new System.Windows.Forms.TextBox();
            this.lblClassFiscal = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.gbxFornecedores = new System.Windows.Forms.GroupBox();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.btnAddFornecedor = new System.Windows.Forms.Button();
            this.btnDELFornecedor = new System.Windows.Forms.Button();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.gbxProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPesquisar)).BeginInit();
            this.gbxOpcoes.SuspendLayout();
            this.gbxCusto.SuspendLayout();
            this.gbxFornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxProduto
            // 
            this.gbxProduto.Controls.Add(this.txtPeso);
            this.gbxProduto.Controls.Add(this.txtQuantidade);
            this.gbxProduto.Controls.Add(this.pctPesquisar);
            this.gbxProduto.Controls.Add(this.gbxOpcoes);
            this.gbxProduto.Controls.Add(this.gbxCusto);
            this.gbxProduto.Controls.Add(this.lblQuantidade);
            this.gbxProduto.Controls.Add(this.lblPeso);
            this.gbxProduto.Controls.Add(this.txtClassFiscal);
            this.gbxProduto.Controls.Add(this.lblClassFiscal);
            this.gbxProduto.Controls.Add(this.lblCategoria);
            this.gbxProduto.Controls.Add(this.cbxCategoria);
            this.gbxProduto.Controls.Add(this.txtCodigoProduto);
            this.gbxProduto.Controls.Add(this.lblCodigoProduto);
            this.gbxProduto.Controls.Add(this.btnNovo);
            this.gbxProduto.Controls.Add(this.btnCancelar);
            this.gbxProduto.Controls.Add(this.txtCodigo);
            this.gbxProduto.Controls.Add(this.lblCodigo);
            this.gbxProduto.Controls.Add(this.btnDeletar);
            this.gbxProduto.Controls.Add(this.btnSalvar);
            this.gbxProduto.Controls.Add(this.tbxDescricao);
            this.gbxProduto.Controls.Add(this.lblDescricao);
            this.gbxProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProduto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbxProduto.Location = new System.Drawing.Point(5, 6);
            this.gbxProduto.Name = "gbxProduto";
            this.gbxProduto.Size = new System.Drawing.Size(588, 435);
            this.gbxProduto.TabIndex = 0;
            this.gbxProduto.TabStop = false;
            this.gbxProduto.Text = "Produto:";
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtPeso.Location = new System.Drawing.Point(17, 239);
            this.txtPeso.MaxLength = 6;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(135, 31);
            this.txtPeso.TabIndex = 63;
            this.txtPeso.Text = "0";
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtQuantidade.Location = new System.Drawing.Point(341, 239);
            this.txtQuantidade.MaxLength = 6;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(135, 31);
            this.txtQuantidade.TabIndex = 62;
            this.txtQuantidade.Text = "0";
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // pctPesquisar
            // 
            this.pctPesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pctPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("pctPesquisar.Image")));
            this.pctPesquisar.Location = new System.Drawing.Point(549, 52);
            this.pctPesquisar.Name = "pctPesquisar";
            this.pctPesquisar.Size = new System.Drawing.Size(26, 21);
            this.pctPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPesquisar.TabIndex = 61;
            this.pctPesquisar.TabStop = false;
            this.pctPesquisar.Click += new System.EventHandler(this.pctPesquisar_Click_1);
            // 
            // gbxOpcoes
            // 
            this.gbxOpcoes.Controls.Add(this.cbxEstrutura);
            this.gbxOpcoes.Controls.Add(this.cbxImportado);
            this.gbxOpcoes.Controls.Add(this.lblEstrutura);
            this.gbxOpcoes.Controls.Add(this.lblImportado);
            this.gbxOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOpcoes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbxOpcoes.Location = new System.Drawing.Point(314, 276);
            this.gbxOpcoes.Name = "gbxOpcoes";
            this.gbxOpcoes.Size = new System.Drawing.Size(261, 100);
            this.gbxOpcoes.TabIndex = 20;
            this.gbxOpcoes.TabStop = false;
            this.gbxOpcoes.Text = "Definições";
            // 
            // cbxEstrutura
            // 
            this.cbxEstrutura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstrutura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbxEstrutura.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbxEstrutura.FormattingEnabled = true;
            this.cbxEstrutura.Items.AddRange(new object[] {
            "Não",
            "Sim"});
            this.cbxEstrutura.Location = new System.Drawing.Point(135, 55);
            this.cbxEstrutura.Name = "cbxEstrutura";
            this.cbxEstrutura.Size = new System.Drawing.Size(118, 33);
            this.cbxEstrutura.TabIndex = 24;
            // 
            // cbxImportado
            // 
            this.cbxImportado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxImportado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbxImportado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbxImportado.FormattingEnabled = true;
            this.cbxImportado.Items.AddRange(new object[] {
            "Não",
            "Sim"});
            this.cbxImportado.Location = new System.Drawing.Point(11, 55);
            this.cbxImportado.Name = "cbxImportado";
            this.cbxImportado.Size = new System.Drawing.Size(118, 33);
            this.cbxImportado.TabIndex = 22;
            // 
            // lblEstrutura
            // 
            this.lblEstrutura.AutoSize = true;
            this.lblEstrutura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstrutura.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEstrutura.Location = new System.Drawing.Point(130, 27);
            this.lblEstrutura.Name = "lblEstrutura";
            this.lblEstrutura.Size = new System.Drawing.Size(115, 25);
            this.lblEstrutura.TabIndex = 23;
            this.lblEstrutura.Text = "Estrutura:";
            // 
            // lblImportado
            // 
            this.lblImportado.AutoSize = true;
            this.lblImportado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblImportado.Location = new System.Drawing.Point(1, 27);
            this.lblImportado.Name = "lblImportado";
            this.lblImportado.Size = new System.Drawing.Size(123, 25);
            this.lblImportado.TabIndex = 21;
            this.lblImportado.Text = "Importado:";
            // 
            // gbxCusto
            // 
            this.gbxCusto.Controls.Add(this.txtCMedio);
            this.gbxCusto.Controls.Add(this.txtCAtual);
            this.gbxCusto.Controls.Add(this.lblCustoMedio);
            this.gbxCusto.Controls.Add(this.lblCustoAtual);
            this.gbxCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCusto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbxCusto.Location = new System.Drawing.Point(18, 276);
            this.gbxCusto.Name = "gbxCusto";
            this.gbxCusto.Size = new System.Drawing.Size(290, 100);
            this.gbxCusto.TabIndex = 15;
            this.gbxCusto.TabStop = false;
            this.gbxCusto.Text = "Custo";
            // 
            // txtCMedio
            // 
            this.txtCMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMedio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtCMedio.Location = new System.Drawing.Point(155, 55);
            this.txtCMedio.MaxLength = 6;
            this.txtCMedio.Name = "txtCMedio";
            this.txtCMedio.ReadOnly = true;
            this.txtCMedio.Size = new System.Drawing.Size(129, 31);
            this.txtCMedio.TabIndex = 64;
            this.txtCMedio.Text = "0";
            // 
            // txtCAtual
            // 
            this.txtCAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCAtual.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtCAtual.Location = new System.Drawing.Point(11, 55);
            this.txtCAtual.MaxLength = 6;
            this.txtCAtual.Name = "txtCAtual";
            this.txtCAtual.ReadOnly = true;
            this.txtCAtual.Size = new System.Drawing.Size(138, 31);
            this.txtCAtual.TabIndex = 63;
            this.txtCAtual.Text = "0";
            // 
            // lblCustoMedio
            // 
            this.lblCustoMedio.AutoSize = true;
            this.lblCustoMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoMedio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCustoMedio.Location = new System.Drawing.Point(146, 27);
            this.lblCustoMedio.Name = "lblCustoMedio";
            this.lblCustoMedio.Size = new System.Drawing.Size(135, 25);
            this.lblCustoMedio.TabIndex = 18;
            this.lblCustoMedio.Text = "Medio: (R$)";
            // 
            // lblCustoAtual
            // 
            this.lblCustoAtual.AutoSize = true;
            this.lblCustoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoAtual.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCustoAtual.Location = new System.Drawing.Point(6, 27);
            this.lblCustoAtual.Name = "lblCustoAtual";
            this.lblCustoAtual.Size = new System.Drawing.Size(125, 25);
            this.lblCustoAtual.TabIndex = 16;
            this.lblCustoAtual.Text = "Atual: (R$)";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQuantidade.Location = new System.Drawing.Point(336, 211);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(140, 25);
            this.lblQuantidade.TabIndex = 13;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPeso.Location = new System.Drawing.Point(12, 211);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(101, 25);
            this.lblPeso.TabIndex = 11;
            this.lblPeso.Text = "Peso:(g)";
            // 
            // txtClassFiscal
            // 
            this.txtClassFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassFiscal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtClassFiscal.Location = new System.Drawing.Point(341, 175);
            this.txtClassFiscal.MaxLength = 80;
            this.txtClassFiscal.Name = "txtClassFiscal";
            this.txtClassFiscal.Size = new System.Drawing.Size(234, 31);
            this.txtClassFiscal.TabIndex = 10;
            // 
            // lblClassFiscal
            // 
            this.lblClassFiscal.AutoSize = true;
            this.lblClassFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassFiscal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblClassFiscal.Location = new System.Drawing.Point(336, 147);
            this.lblClassFiscal.Name = "lblClassFiscal";
            this.lblClassFiscal.Size = new System.Drawing.Size(230, 25);
            this.lblClassFiscal.TabIndex = 9;
            this.lblClassFiscal.Text = "Classificação Fiscal:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCategoria.Location = new System.Drawing.Point(12, 147);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(121, 25);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownHeight = 206;
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbxCategoria.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.IntegralHeight = false;
            this.cbxCategoria.ItemHeight = 25;
            this.cbxCategoria.Location = new System.Drawing.Point(17, 175);
            this.cbxCategoria.MaxDropDownItems = 20;
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(223, 33);
            this.cbxCategoria.TabIndex = 8;
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProduto.ForeColor = System.Drawing.SystemColors.Control;
            this.txtCodigoProduto.Location = new System.Drawing.Point(354, 45);
            this.txtCodigoProduto.MaxLength = 7;
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(189, 31);
            this.txtCodigoProduto.TabIndex = 4;
            this.txtCodigoProduto.Text = "Insira um codigo";
            this.txtCodigoProduto.Enter += new System.EventHandler(this.FormataCodigoEnter);
            this.txtCodigoProduto.Leave += new System.EventHandler(this.FormataCodigoExit);
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProduto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCodigoProduto.Location = new System.Drawing.Point(262, 48);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(93, 25);
            this.lblCodigoProduto.TabIndex = 3;
            this.lblCodigoProduto.Text = "Código:";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovo.Enabled = false;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(160, 382);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(133, 43);
            this.btnNovo.TabIndex = 27;
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
            this.btnCancelar.Location = new System.Drawing.Point(442, 382);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 43);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.BtnFocusON);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.BtnFocusOFF);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCodigo.Location = new System.Drawing.Point(55, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(145, 31);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.Text = "(Novo)";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCodigo.Location = new System.Drawing.Point(12, 45);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(41, 25);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "ID:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.Location = new System.Drawing.Point(299, 382);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(131, 43);
            this.btnDeletar.TabIndex = 28;
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
            this.btnSalvar.Location = new System.Drawing.Point(18, 382);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(129, 43);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.Text = "   Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.MouseEnter += new System.EventHandler(this.BtnFocusON);
            this.btnSalvar.MouseLeave += new System.EventHandler(this.BtnFocusOFF);
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescricao.ForeColor = System.Drawing.SystemColors.Control;
            this.tbxDescricao.Location = new System.Drawing.Point(17, 107);
            this.tbxDescricao.MaxLength = 80;
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(558, 31);
            this.tbxDescricao.TabIndex = 6;
            this.tbxDescricao.Text = "Insira uma descrição";
            this.tbxDescricao.Enter += new System.EventHandler(this.FormataDescricaoEnter);
            this.tbxDescricao.Leave += new System.EventHandler(this.FormataDescricaoExit);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDescricao.Location = new System.Drawing.Point(12, 79);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(124, 25);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição:";
            // 
            // gbxFornecedores
            // 
            this.gbxFornecedores.Controls.Add(this.dgvFornecedor);
            this.gbxFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFornecedores.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbxFornecedores.Location = new System.Drawing.Point(602, 6);
            this.gbxFornecedores.Name = "gbxFornecedores";
            this.gbxFornecedores.Size = new System.Drawing.Size(346, 288);
            this.gbxFornecedores.TabIndex = 60;
            this.gbxFornecedores.TabStop = false;
            this.gbxFornecedores.Text = "Fornecedores";
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToDeleteRows = false;
            this.dgvFornecedor.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFornecedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Enabled = false;
            this.dgvFornecedor.EnableHeadersVisualStyles = false;
            this.dgvFornecedor.Location = new System.Drawing.Point(6, 29);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            this.dgvFornecedor.Size = new System.Drawing.Size(334, 253);
            this.dgvFornecedor.TabIndex = 25;
            this.dgvFornecedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedor_CellClick);
            this.dgvFornecedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedor_CellDoubleClick);
            // 
            // btnAddFornecedor
            // 
            this.btnAddFornecedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddFornecedor.Enabled = false;
            this.btnAddFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFornecedor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAddFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFornecedor.Image")));
            this.btnAddFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFornecedor.Location = new System.Drawing.Point(602, 300);
            this.btnAddFornecedor.Name = "btnAddFornecedor";
            this.btnAddFornecedor.Size = new System.Drawing.Size(143, 43);
            this.btnAddFornecedor.TabIndex = 61;
            this.btnAddFornecedor.Text = "Adicionar";
            this.btnAddFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFornecedor.UseVisualStyleBackColor = false;
            this.btnAddFornecedor.Click += new System.EventHandler(this.btnAddFornecedor_Click);
            this.btnAddFornecedor.MouseEnter += new System.EventHandler(this.BtnFocusON);
            this.btnAddFornecedor.MouseLeave += new System.EventHandler(this.BtnFocusOFF);
            // 
            // btnDELFornecedor
            // 
            this.btnDELFornecedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDELFornecedor.Enabled = false;
            this.btnDELFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELFornecedor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDELFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnDELFornecedor.Image")));
            this.btnDELFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDELFornecedor.Location = new System.Drawing.Point(805, 300);
            this.btnDELFornecedor.Name = "btnDELFornecedor";
            this.btnDELFornecedor.Size = new System.Drawing.Size(143, 43);
            this.btnDELFornecedor.TabIndex = 62;
            this.btnDELFornecedor.Text = "Excluir";
            this.btnDELFornecedor.UseVisualStyleBackColor = false;
            this.btnDELFornecedor.Click += new System.EventHandler(this.btnDELFornecedor_Click);
            this.btnDELFornecedor.MouseEnter += new System.EventHandler(this.BtnFocusON);
            this.btnDELFornecedor.MouseLeave += new System.EventHandler(this.BtnFocusOFF);
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Location = new System.Drawing.Point(605, 346);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(126, 13);
            this.lblInformacao.TabIndex = 63;
            this.lblInformacao.Text = "*Salve o Produto primeiro";
            // 
            // cadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.lblInformacao);
            this.Controls.Add(this.btnAddFornecedor);
            this.Controls.Add(this.btnDELFornecedor);
            this.Controls.Add(this.gbxFornecedores);
            this.Controls.Add(this.gbxProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Produto";
            this.Activated += new System.EventHandler(this.cadProduto_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cadProduto_FormClosed);
            this.Load += new System.EventHandler(this.cadProduto_Load);
            this.gbxProduto.ResumeLayout(false);
            this.gbxProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPesquisar)).EndInit();
            this.gbxOpcoes.ResumeLayout(false);
            this.gbxOpcoes.PerformLayout();
            this.gbxCusto.ResumeLayout(false);
            this.gbxCusto.PerformLayout();
            this.gbxFornecedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProduto;
        private System.Windows.Forms.PictureBox pctPesquisar;
        private System.Windows.Forms.GroupBox gbxOpcoes;
        private System.Windows.Forms.ComboBox cbxEstrutura;
        private System.Windows.Forms.ComboBox cbxImportado;
        private System.Windows.Forms.Label lblEstrutura;
        private System.Windows.Forms.Label lblImportado;
        private System.Windows.Forms.GroupBox gbxCusto;
        private System.Windows.Forms.Label lblCustoMedio;
        private System.Windows.Forms.Label lblCustoAtual;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtClassFiscal;
        private System.Windows.Forms.Label lblClassFiscal;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxCategoria;
        public System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.GroupBox gbxFornecedores;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.Button btnAddFornecedor;
        private System.Windows.Forms.Button btnDELFornecedor;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtCMedio;
        private System.Windows.Forms.TextBox txtCAtual;

    }
}