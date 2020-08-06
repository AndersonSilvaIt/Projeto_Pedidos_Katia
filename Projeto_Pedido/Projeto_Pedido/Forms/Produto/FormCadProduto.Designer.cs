namespace Projeto_Pedido.Forms.Produto {
	partial class FormCadProduto {
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
			this.panelTitleBar = new System.Windows.Forms.Panel();
			this.btnMaximize = new FontAwesome.Sharp.IconButton();
			this.btnMinimize = new FontAwesome.Sharp.IconButton();
			this.btnClose = new FontAwesome.Sharp.IconButton();
			this.btnHome = new System.Windows.Forms.PictureBox();
			this.lblTitleChildForm = new System.Windows.Forms.Label();
			this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
			this.panelDesktop = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAddUnidadeMedida = new FontAwesome.Sharp.IconButton();
			this.ddlUnidadeMedida = new System.Windows.Forms.ComboBox();
			this.ddlFornecedor = new System.Windows.Forms.ComboBox();
			this.btnImage = new System.Windows.Forms.Button();
			this.ImagemProduto = new FontAwesome.Sharp.IconPictureBox();
			this.txtPrecoVenda = new System.Windows.Forms.TextBox();
			this.txtObservacao = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAddFornecedor = new FontAwesome.Sharp.IconButton();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDescricao = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPrecoCusto = new System.Windows.Forms.TextBox();
			this.btnDelete = new FontAwesome.Sharp.IconButton();
			this.btnSave = new FontAwesome.Sharp.IconButton();
			this.btnEdit = new FontAwesome.Sharp.IconButton();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.panelTitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
			this.panelDesktop.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ImagemProduto)).BeginInit();
			this.SuspendLayout();
			// 
			// panelTitleBar
			// 
			this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(152)))), ((int)(((byte)(231)))));
			this.panelTitleBar.Controls.Add(this.btnMaximize);
			this.panelTitleBar.Controls.Add(this.btnMinimize);
			this.panelTitleBar.Controls.Add(this.btnClose);
			this.panelTitleBar.Controls.Add(this.btnHome);
			this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
			this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
			this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
			this.panelTitleBar.Name = "panelTitleBar";
			this.panelTitleBar.Size = new System.Drawing.Size(847, 73);
			this.panelTitleBar.TabIndex = 4;
			this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
			// 
			// btnMaximize
			// 
			this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnMaximize.FlatAppearance.BorderSize = 0;
			this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMaximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
			this.btnMaximize.IconColor = System.Drawing.Color.White;
			this.btnMaximize.IconSize = 16;
			this.btnMaximize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnMaximize.Location = new System.Drawing.Point(790, 6);
			this.btnMaximize.Name = "btnMaximize";
			this.btnMaximize.Rotation = 0D;
			this.btnMaximize.Size = new System.Drawing.Size(24, 22);
			this.btnMaximize.TabIndex = 15;
			this.btnMaximize.UseVisualStyleBackColor = true;
			this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
			// 
			// btnMinimize
			// 
			this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
			this.btnMinimize.IconColor = System.Drawing.Color.White;
			this.btnMinimize.IconSize = 16;
			this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnMinimize.Location = new System.Drawing.Point(760, 6);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Rotation = 0D;
			this.btnMinimize.Size = new System.Drawing.Size(24, 22);
			this.btnMinimize.TabIndex = 14;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
			this.btnClose.IconColor = System.Drawing.Color.White;
			this.btnClose.IconSize = 16;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnClose.Location = new System.Drawing.Point(820, 6);
			this.btnClose.Name = "btnClose";
			this.btnClose.Rotation = 0D;
			this.btnClose.Size = new System.Drawing.Size(24, 22);
			this.btnClose.TabIndex = 16;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnHome
			// 
			this.btnHome.Image = global::Projeto_Pedido.Properties.Resources.Logo_Asa_Nova_sem_fundo_png;
			this.btnHome.Location = new System.Drawing.Point(5, 6);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(100, 50);
			this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnHome.TabIndex = 2;
			this.btnHome.TabStop = false;
			// 
			// lblTitleChildForm
			// 
			this.lblTitleChildForm.AutoSize = true;
			this.lblTitleChildForm.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(193)))));
			this.lblTitleChildForm.Location = new System.Drawing.Point(256, 29);
			this.lblTitleChildForm.Name = "lblTitleChildForm";
			this.lblTitleChildForm.Size = new System.Drawing.Size(201, 27);
			this.lblTitleChildForm.TabIndex = 1;
			this.lblTitleChildForm.Text = "Cadastro de Produto";
			// 
			// iconCurrentChildForm
			// 
			this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(152)))), ((int)(((byte)(231)))));
			this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(193)))));
			this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
			this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(193)))));
			this.iconCurrentChildForm.Location = new System.Drawing.Point(211, 26);
			this.iconCurrentChildForm.Name = "iconCurrentChildForm";
			this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
			this.iconCurrentChildForm.TabIndex = 0;
			this.iconCurrentChildForm.TabStop = false;
			// 
			// panelDesktop
			// 
			this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(127)))), ((int)(((byte)(221)))));
			this.panelDesktop.Controls.Add(this.groupBox1);
			this.panelDesktop.Controls.Add(this.btnDelete);
			this.panelDesktop.Controls.Add(this.btnSave);
			this.panelDesktop.Controls.Add(this.btnEdit);
			this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktop.Location = new System.Drawing.Point(0, 73);
			this.panelDesktop.Name = "panelDesktop";
			this.panelDesktop.Size = new System.Drawing.Size(847, 375);
			this.panelDesktop.TabIndex = 6;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAddUnidadeMedida);
			this.groupBox1.Controls.Add(this.ddlUnidadeMedida);
			this.groupBox1.Controls.Add(this.ddlFornecedor);
			this.groupBox1.Controls.Add(this.btnImage);
			this.groupBox1.Controls.Add(this.ImagemProduto);
			this.groupBox1.Controls.Add(this.txtPrecoVenda);
			this.groupBox1.Controls.Add(this.txtObservacao);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtCodigo);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnAddFornecedor);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtDescricao);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtPrecoCusto);
			this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
			this.groupBox1.Location = new System.Drawing.Point(12, 17);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(819, 305);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Cadastro";
			// 
			// btnAddUnidadeMedida
			// 
			this.btnAddUnidadeMedida.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddUnidadeMedida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnAddUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddUnidadeMedida.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnAddUnidadeMedida.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnAddUnidadeMedida.IconColor = System.Drawing.Color.White;
			this.btnAddUnidadeMedida.IconSize = 15;
			this.btnAddUnidadeMedida.Location = new System.Drawing.Point(129, 117);
			this.btnAddUnidadeMedida.Name = "btnAddUnidadeMedida";
			this.btnAddUnidadeMedida.Rotation = 0D;
			this.btnAddUnidadeMedida.Size = new System.Drawing.Size(25, 24);
			this.btnAddUnidadeMedida.TabIndex = 4;
			this.btnAddUnidadeMedida.UseVisualStyleBackColor = true;
			this.btnAddUnidadeMedida.Click += new System.EventHandler(this.btnAddUnidadeMedida_Click);
			// 
			// ddlUnidadeMedida
			// 
			this.ddlUnidadeMedida.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ddlUnidadeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlUnidadeMedida.FormattingEnabled = true;
			this.ddlUnidadeMedida.Location = new System.Drawing.Point(29, 114);
			this.ddlUnidadeMedida.Name = "ddlUnidadeMedida";
			this.ddlUnidadeMedida.Size = new System.Drawing.Size(94, 26);
			this.ddlUnidadeMedida.TabIndex = 3;
			// 
			// ddlFornecedor
			// 
			this.ddlFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ddlFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlFornecedor.FormattingEnabled = true;
			this.ddlFornecedor.Location = new System.Drawing.Point(29, 180);
			this.ddlFornecedor.Name = "ddlFornecedor";
			this.ddlFornecedor.Size = new System.Drawing.Size(314, 26);
			this.ddlFornecedor.TabIndex = 7;
			// 
			// btnImage
			// 
			this.btnImage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnImage.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImage.Location = new System.Drawing.Point(685, 168);
			this.btnImage.Name = "btnImage";
			this.btnImage.Size = new System.Drawing.Size(113, 23);
			this.btnImage.TabIndex = 9;
			this.btnImage.Text = "Escolher Imagem";
			this.btnImage.UseVisualStyleBackColor = true;
			this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
			// 
			// ImagemProduto
			// 
			this.ImagemProduto.BackColor = System.Drawing.Color.Transparent;
			this.ImagemProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ImagemProduto.ForeColor = System.Drawing.Color.Transparent;
			this.ImagemProduto.IconChar = FontAwesome.Sharp.IconChar.None;
			this.ImagemProduto.IconColor = System.Drawing.Color.Transparent;
			this.ImagemProduto.IconSize = 105;
			this.ImagemProduto.Location = new System.Drawing.Point(657, 62);
			this.ImagemProduto.Name = "ImagemProduto";
			this.ImagemProduto.Size = new System.Drawing.Size(141, 105);
			this.ImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImagemProduto.TabIndex = 27;
			this.ImagemProduto.TabStop = false;
			// 
			// txtPrecoVenda
			// 
			this.txtPrecoVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPrecoVenda.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecoVenda.Location = new System.Drawing.Point(365, 117);
			this.txtPrecoVenda.Name = "txtPrecoVenda";
			this.txtPrecoVenda.Size = new System.Drawing.Size(138, 19);
			this.txtPrecoVenda.TabIndex = 6;
			this.txtPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtObservacao
			// 
			this.txtObservacao.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObservacao.Location = new System.Drawing.Point(29, 243);
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.Size = new System.Drawing.Size(599, 47);
			this.txtObservacao.TabIndex = 10;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(26, 222);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(79, 18);
			this.label9.TabIndex = 23;
			this.label9.Text = "Observação";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 18);
			this.label1.TabIndex = 5;
			this.label1.Text = "Código";
			// 
			// txtCodigo
			// 
			this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCodigo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(29, 62);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(94, 19);
			this.txtCodigo.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 159);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 18);
			this.label2.TabIndex = 7;
			this.label2.Text = "Fornecedor";
			// 
			// btnAddFornecedor
			// 
			this.btnAddFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnAddFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddFornecedor.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnAddFornecedor.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnAddFornecedor.IconColor = System.Drawing.Color.White;
			this.btnAddFornecedor.IconSize = 15;
			this.btnAddFornecedor.Location = new System.Drawing.Point(349, 180);
			this.btnAddFornecedor.Name = "btnAddFornecedor";
			this.btnAddFornecedor.Rotation = 0D;
			this.btnAddFornecedor.Size = new System.Drawing.Size(25, 24);
			this.btnAddFornecedor.TabIndex = 8;
			this.btnAddFornecedor.UseVisualStyleBackColor = true;
			this.btnAddFornecedor.Click += new System.EventHandler(this.btnAddFornecedor_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(180, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 18);
			this.label3.TabIndex = 11;
			this.label3.Text = "Descrição";
			// 
			// txtDescricao
			// 
			this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDescricao.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescricao.Location = new System.Drawing.Point(183, 62);
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.Size = new System.Drawing.Size(442, 19);
			this.txtDescricao.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(26, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 18);
			this.label5.TabIndex = 13;
			this.label5.Text = "U.M";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(362, 96);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 18);
			this.label6.TabIndex = 17;
			this.label6.Text = "Preço Venda";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(180, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 18);
			this.label4.TabIndex = 15;
			this.label4.Text = "Preço Custo";
			// 
			// txtPrecoCusto
			// 
			this.txtPrecoCusto.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPrecoCusto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecoCusto.Location = new System.Drawing.Point(183, 117);
			this.txtPrecoCusto.Name = "txtPrecoCusto";
			this.txtPrecoCusto.Size = new System.Drawing.Size(138, 19);
			this.txtPrecoCusto.TabIndex = 5;
			this.txtPrecoCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnDelete
			// 
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
			this.btnDelete.IconColor = System.Drawing.Color.Red;
			this.btnDelete.IconSize = 35;
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnDelete.Location = new System.Drawing.Point(149, 330);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Rotation = 0D;
			this.btnDelete.Size = new System.Drawing.Size(37, 33);
			this.btnDelete.TabIndex = 13;
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSave
			// 
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
			this.btnSave.IconColor = System.Drawing.Color.Green;
			this.btnSave.IconSize = 35;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSave.Location = new System.Drawing.Point(43, 330);
			this.btnSave.Name = "btnSave";
			this.btnSave.Rotation = 0D;
			this.btnSave.Size = new System.Drawing.Size(37, 33);
			this.btnSave.TabIndex = 11;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
			this.btnEdit.IconColor = System.Drawing.Color.Gold;
			this.btnEdit.IconSize = 35;
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnEdit.Location = new System.Drawing.Point(96, 330);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Rotation = 0D;
			this.btnEdit.Size = new System.Drawing.Size(37, 33);
			this.btnEdit.TabIndex = 12;
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
			// 
			// FormCadProduto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(847, 448);
			this.Controls.Add(this.panelDesktop);
			this.Controls.Add(this.panelTitleBar);
			this.Name = "FormCadProduto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Produto";
			this.panelTitleBar.ResumeLayout(false);
			this.panelTitleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
			this.panelDesktop.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ImagemProduto)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelTitleBar;
		private System.Windows.Forms.Label lblTitleChildForm;
		private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
		private System.Windows.Forms.PictureBox btnHome;
		private System.Windows.Forms.Panel panelDesktop;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label1;
		private FontAwesome.Sharp.IconButton btnAddFornecedor;
		private System.Windows.Forms.TextBox txtDescricao;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPrecoVenda;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPrecoCusto;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtObservacao;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox1;
		private FontAwesome.Sharp.IconPictureBox ImagemProduto;
		private System.Windows.Forms.Button btnImage;
		private FontAwesome.Sharp.IconButton btnDelete;
		private FontAwesome.Sharp.IconButton btnSave;
		private FontAwesome.Sharp.IconButton btnEdit;
		private System.Windows.Forms.ComboBox ddlFornecedor;
		private FontAwesome.Sharp.IconButton btnMaximize;
		private FontAwesome.Sharp.IconButton btnMinimize;
		private FontAwesome.Sharp.IconButton btnClose;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ComboBox ddlUnidadeMedida;
		private FontAwesome.Sharp.IconButton btnAddUnidadeMedida;
	}
}