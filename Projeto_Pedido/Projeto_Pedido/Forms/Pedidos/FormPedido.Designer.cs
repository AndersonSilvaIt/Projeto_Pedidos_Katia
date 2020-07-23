namespace Projeto_Pedido.Forms.Pedidos {
	partial class FormPedido {
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
			this.panelDesktop = new System.Windows.Forms.Panel();
			this.btnLock = new FontAwesome.Sharp.IconButton();
			this.btnOpen = new FontAwesome.Sharp.IconButton();
			this.btnCancel = new FontAwesome.Sharp.IconButton();
			this.btnPrint = new FontAwesome.Sharp.IconButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ddlTipoPagamento = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtTotalLiquido = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtEntrada = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtDesconto = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTotalBruto = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.grdItensPedido = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProdutoString = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CadasterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAdd = new FontAwesome.Sharp.IconButton();
			this.label10 = new System.Windows.Forms.Label();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.ddlCliente = new System.Windows.Forms.ComboBox();
			this.txtObservacao = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAddCliente = new FontAwesome.Sharp.IconButton();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCadasterDate = new System.Windows.Forms.TextBox();
			this.btnDelete = new FontAwesome.Sharp.IconButton();
			this.btnSave = new FontAwesome.Sharp.IconButton();
			this.btnEdit = new FontAwesome.Sharp.IconButton();
			this.panelTitleBar = new System.Windows.Forms.Panel();
			this.btnMaximize = new FontAwesome.Sharp.IconButton();
			this.btnMinimize = new FontAwesome.Sharp.IconButton();
			this.btnClose = new FontAwesome.Sharp.IconButton();
			this.btnHome = new System.Windows.Forms.PictureBox();
			this.lblTitleChildForm = new System.Windows.Forms.Label();
			this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.panelDesktop.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdItensPedido)).BeginInit();
			this.panelTitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
			this.SuspendLayout();
			// 
			// panelDesktop
			// 
			this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(127)))), ((int)(((byte)(221)))));
			this.panelDesktop.Controls.Add(this.btnLock);
			this.panelDesktop.Controls.Add(this.btnOpen);
			this.panelDesktop.Controls.Add(this.btnCancel);
			this.panelDesktop.Controls.Add(this.btnPrint);
			this.panelDesktop.Controls.Add(this.groupBox1);
			this.panelDesktop.Controls.Add(this.btnDelete);
			this.panelDesktop.Controls.Add(this.btnSave);
			this.panelDesktop.Controls.Add(this.btnEdit);
			this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktop.Location = new System.Drawing.Point(0, 73);
			this.panelDesktop.Name = "panelDesktop";
			this.panelDesktop.Size = new System.Drawing.Size(716, 626);
			this.panelDesktop.TabIndex = 8;
			// 
			// btnLock
			// 
			this.btnLock.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLock.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnLock.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnLock.IconChar = FontAwesome.Sharp.IconChar.Lock;
			this.btnLock.IconColor = System.Drawing.Color.DarkOrange;
			this.btnLock.IconSize = 35;
			this.btnLock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnLock.Location = new System.Drawing.Point(332, 583);
			this.btnLock.Name = "btnLock";
			this.btnLock.Rotation = 0D;
			this.btnLock.Size = new System.Drawing.Size(37, 33);
			this.btnLock.TabIndex = 16;
			this.toolTip.SetToolTip(this.btnLock, "Fechar Pedido");
			this.btnLock.UseVisualStyleBackColor = true;
			this.btnLock.Visible = false;
			this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnOpen.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnOpen.IconChar = FontAwesome.Sharp.IconChar.Unlock;
			this.btnOpen.IconColor = System.Drawing.Color.Green;
			this.btnOpen.IconSize = 35;
			this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnOpen.Location = new System.Drawing.Point(289, 583);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Rotation = 0D;
			this.btnOpen.Size = new System.Drawing.Size(37, 33);
			this.btnOpen.TabIndex = 15;
			this.toolTip.SetToolTip(this.btnOpen, "Reabrir Pedido");
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Visible = false;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Backspace;
			this.btnCancel.IconColor = System.Drawing.Color.Black;
			this.btnCancel.IconSize = 35;
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCancel.Location = new System.Drawing.Point(237, 583);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Rotation = 0D;
			this.btnCancel.Size = new System.Drawing.Size(37, 33);
			this.btnCancel.TabIndex = 14;
			this.toolTip.SetToolTip(this.btnCancel, "Cancelar Pedido");
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Visible = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
			this.btnPrint.IconColor = System.Drawing.Color.LightGray;
			this.btnPrint.IconSize = 35;
			this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnPrint.Location = new System.Drawing.Point(621, 583);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Rotation = 0D;
			this.btnPrint.Size = new System.Drawing.Size(37, 33);
			this.btnPrint.TabIndex = 17;
			this.btnPrint.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ddlTipoPagamento);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.txtTotalLiquido);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtEntrada);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtDesconto);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtTotalBruto);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtEstado);
			this.groupBox1.Controls.Add(this.ddlCliente);
			this.groupBox1.Controls.Add(this.txtObservacao);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtNumero);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnAddCliente);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtCadasterDate);
			this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
			this.groupBox1.Location = new System.Drawing.Point(12, 10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(684, 564);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados do Pedido";
			// 
			// ddlTipoPagamento
			// 
			this.ddlTipoPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ddlTipoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlTipoPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ddlTipoPagamento.FormattingEnabled = true;
			this.ddlTipoPagamento.Location = new System.Drawing.Point(29, 396);
			this.ddlTipoPagamento.Name = "ddlTipoPagamento";
			this.ddlTipoPagamento.Size = new System.Drawing.Size(130, 26);
			this.ddlTipoPagamento.TabIndex = 7;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(530, 425);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(88, 18);
			this.label11.TabIndex = 46;
			this.label11.Text = "Total Líquido";
			// 
			// txtTotalLiquido
			// 
			this.txtTotalLiquido.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTotalLiquido.Enabled = false;
			this.txtTotalLiquido.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalLiquido.Location = new System.Drawing.Point(533, 446);
			this.txtTotalLiquido.Name = "txtTotalLiquido";
			this.txtTotalLiquido.Size = new System.Drawing.Size(113, 19);
			this.txtTotalLiquido.TabIndex = 47;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(246, 425);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 18);
			this.label8.TabIndex = 44;
			this.label8.Text = "Entrada";
			// 
			// txtEntrada
			// 
			this.txtEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtEntrada.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEntrada.Location = new System.Drawing.Point(249, 446);
			this.txtEntrada.Name = "txtEntrada";
			this.txtEntrada.Size = new System.Drawing.Size(94, 19);
			this.txtEntrada.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(26, 425);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 18);
			this.label7.TabIndex = 42;
			this.label7.Text = "Desconto %";
			// 
			// txtDesconto
			// 
			this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDesconto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDesconto.Location = new System.Drawing.Point(29, 446);
			this.txtDesconto.Name = "txtDesconto";
			this.txtDesconto.Size = new System.Drawing.Size(94, 19);
			this.txtDesconto.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(530, 378);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 18);
			this.label5.TabIndex = 40;
			this.label5.Text = "Total Bruto";
			// 
			// txtTotalBruto
			// 
			this.txtTotalBruto.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTotalBruto.Enabled = false;
			this.txtTotalBruto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalBruto.Location = new System.Drawing.Point(533, 399);
			this.txtTotalBruto.Name = "txtTotalBruto";
			this.txtTotalBruto.Size = new System.Drawing.Size(113, 19);
			this.txtTotalBruto.TabIndex = 41;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(26, 378);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(102, 18);
			this.label6.TabIndex = 33;
			this.label6.Text = "Tipo Pagamento";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.grdItensPedido);
			this.groupBox2.Controls.Add(this.btnAdd);
			this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(29, 126);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(633, 250);
			this.groupBox2.TabIndex = 32;
			this.groupBox2.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(272, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 19);
			this.label4.TabIndex = 34;
			this.label4.Text = "Itens";
			// 
			// grdItensPedido
			// 
			this.grdItensPedido.AllowUserToAddRows = false;
			this.grdItensPedido.AllowUserToDeleteRows = false;
			this.grdItensPedido.AllowUserToResizeColumns = false;
			this.grdItensPedido.AllowUserToResizeRows = false;
			this.grdItensPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grdItensPedido.BackgroundColor = System.Drawing.Color.White;
			this.grdItensPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grdItensPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdItensPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProdutoString,
            this.IdPedido,
            this.IdProduto,
            this.Produto,
            this.Quantidade,
            this.Desconto,
            this.Total,
            this.Preco,
            this.Observacao,
            this.CadasterDate});
			this.grdItensPedido.Cursor = System.Windows.Forms.Cursors.Hand;
			this.grdItensPedido.Location = new System.Drawing.Point(20, 49);
			this.grdItensPedido.MultiSelect = false;
			this.grdItensPedido.Name = "grdItensPedido";
			this.grdItensPedido.ReadOnly = true;
			this.grdItensPedido.RowHeadersVisible = false;
			this.grdItensPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdItensPedido.ShowCellErrors = false;
			this.grdItensPedido.ShowCellToolTips = false;
			this.grdItensPedido.ShowEditingIcon = false;
			this.grdItensPedido.ShowRowErrors = false;
			this.grdItensPedido.Size = new System.Drawing.Size(597, 185);
			this.grdItensPedido.TabIndex = 5;
			this.grdItensPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdItensPedido_CellDoubleClick);
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Visible = false;
			// 
			// ProdutoString
			// 
			this.ProdutoString.DataPropertyName = "ProdutoString";
			this.ProdutoString.HeaderText = "Produto";
			this.ProdutoString.Name = "ProdutoString";
			this.ProdutoString.ReadOnly = true;
			// 
			// IdPedido
			// 
			this.IdPedido.DataPropertyName = "IdPedido";
			this.IdPedido.HeaderText = "IdPedido";
			this.IdPedido.Name = "IdPedido";
			this.IdPedido.ReadOnly = true;
			this.IdPedido.Visible = false;
			// 
			// IdProduto
			// 
			this.IdProduto.DataPropertyName = "IdProduto";
			this.IdProduto.HeaderText = "IdProduto";
			this.IdProduto.Name = "IdProduto";
			this.IdProduto.ReadOnly = true;
			this.IdProduto.Visible = false;
			// 
			// Produto
			// 
			this.Produto.DataPropertyName = "Produto";
			this.Produto.HeaderText = "_Produto";
			this.Produto.Name = "Produto";
			this.Produto.ReadOnly = true;
			this.Produto.Visible = false;
			// 
			// Quantidade
			// 
			this.Quantidade.DataPropertyName = "Quantidade";
			this.Quantidade.HeaderText = "Quantidade";
			this.Quantidade.Name = "Quantidade";
			this.Quantidade.ReadOnly = true;
			// 
			// Desconto
			// 
			this.Desconto.DataPropertyName = "Desconto";
			this.Desconto.HeaderText = "Desconto";
			this.Desconto.Name = "Desconto";
			this.Desconto.ReadOnly = true;
			// 
			// Total
			// 
			this.Total.DataPropertyName = "Total";
			this.Total.HeaderText = "Total";
			this.Total.Name = "Total";
			this.Total.ReadOnly = true;
			// 
			// Preco
			// 
			this.Preco.DataPropertyName = "Preco";
			this.Preco.HeaderText = "Preco";
			this.Preco.Name = "Preco";
			this.Preco.ReadOnly = true;
			// 
			// Observacao
			// 
			this.Observacao.DataPropertyName = "Observacao";
			this.Observacao.HeaderText = "Observacao";
			this.Observacao.Name = "Observacao";
			this.Observacao.ReadOnly = true;
			this.Observacao.Visible = false;
			// 
			// CadasterDate
			// 
			this.CadasterDate.DataPropertyName = "CadasterDate";
			this.CadasterDate.HeaderText = "CadasterDate";
			this.CadasterDate.Name = "CadasterDate";
			this.CadasterDate.ReadOnly = true;
			this.CadasterDate.Visible = false;
			// 
			// btnAdd
			// 
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnAdd.IconColor = System.Drawing.Color.Green;
			this.btnAdd.IconSize = 20;
			this.btnAdd.Location = new System.Drawing.Point(20, 14);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Rotation = 0D;
			this.btnAdd.Size = new System.Drawing.Size(35, 29);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(530, 29);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(47, 18);
			this.label10.TabIndex = 30;
			this.label10.Text = "Status";
			// 
			// txtEstado
			// 
			this.txtEstado.AcceptsReturn = true;
			this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtEstado.Enabled = false;
			this.txtEstado.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEstado.Location = new System.Drawing.Point(533, 50);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(108, 19);
			this.txtEstado.TabIndex = 3;
			// 
			// ddlCliente
			// 
			this.ddlCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ddlCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ddlCliente.FormattingEnabled = true;
			this.ddlCliente.Location = new System.Drawing.Point(29, 97);
			this.ddlCliente.Name = "ddlCliente";
			this.ddlCliente.Size = new System.Drawing.Size(396, 26);
			this.ddlCliente.TabIndex = 4;
			// 
			// txtObservacao
			// 
			this.txtObservacao.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObservacao.Location = new System.Drawing.Point(29, 495);
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.Size = new System.Drawing.Size(617, 47);
			this.txtObservacao.TabIndex = 10;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(26, 474);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(79, 18);
			this.label9.TabIndex = 23;
			this.label9.Text = "Observação";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 18);
			this.label1.TabIndex = 5;
			this.label1.Text = "Número";
			// 
			// txtNumero
			// 
			this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNumero.Enabled = false;
			this.txtNumero.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.Location = new System.Drawing.Point(29, 50);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(94, 19);
			this.txtNumero.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 18);
			this.label2.TabIndex = 7;
			this.label2.Text = "Cliente";
			// 
			// btnAddCliente
			// 
			this.btnAddCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnAddCliente.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnAddCliente.IconColor = System.Drawing.Color.White;
			this.btnAddCliente.IconSize = 15;
			this.btnAddCliente.Location = new System.Drawing.Point(431, 97);
			this.btnAddCliente.Name = "btnAddCliente";
			this.btnAddCliente.Rotation = 0D;
			this.btnAddCliente.Size = new System.Drawing.Size(25, 24);
			this.btnAddCliente.TabIndex = 5;
			this.btnAddCliente.UseVisualStyleBackColor = true;
			this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(147, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 18);
			this.label3.TabIndex = 11;
			this.label3.Text = "Data Hora";
			// 
			// txtCadasterDate
			// 
			this.txtCadasterDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCadasterDate.Enabled = false;
			this.txtCadasterDate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCadasterDate.Location = new System.Drawing.Point(150, 50);
			this.txtCadasterDate.Name = "txtCadasterDate";
			this.txtCadasterDate.Size = new System.Drawing.Size(152, 19);
			this.txtCadasterDate.TabIndex = 2;
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
			this.btnDelete.Location = new System.Drawing.Point(134, 583);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Rotation = 0D;
			this.btnDelete.Size = new System.Drawing.Size(37, 33);
			this.btnDelete.TabIndex = 13;
			this.toolTip.SetToolTip(this.btnDelete, "Excluir");
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
			this.btnSave.Location = new System.Drawing.Point(28, 583);
			this.btnSave.Name = "btnSave";
			this.btnSave.Rotation = 0D;
			this.btnSave.Size = new System.Drawing.Size(37, 33);
			this.btnSave.TabIndex = 11;
			this.toolTip.SetToolTip(this.btnSave, "Salvar");
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
			this.btnEdit.Location = new System.Drawing.Point(81, 583);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Rotation = 0D;
			this.btnEdit.Size = new System.Drawing.Size(37, 33);
			this.btnEdit.TabIndex = 12;
			this.toolTip.SetToolTip(this.btnEdit, "Editar");
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
			this.panelTitleBar.Size = new System.Drawing.Size(716, 73);
			this.panelTitleBar.TabIndex = 7;
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
			this.btnMaximize.Location = new System.Drawing.Point(659, 6);
			this.btnMaximize.Name = "btnMaximize";
			this.btnMaximize.Rotation = 0D;
			this.btnMaximize.Size = new System.Drawing.Size(24, 22);
			this.btnMaximize.TabIndex = 19;
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
			this.btnMinimize.Location = new System.Drawing.Point(629, 6);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Rotation = 0D;
			this.btnMinimize.Size = new System.Drawing.Size(24, 22);
			this.btnMinimize.TabIndex = 18;
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
			this.btnClose.Location = new System.Drawing.Point(689, 6);
			this.btnClose.Name = "btnClose";
			this.btnClose.Rotation = 0D;
			this.btnClose.Size = new System.Drawing.Size(24, 22);
			this.btnClose.TabIndex = 20;
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
			this.lblTitleChildForm.Size = new System.Drawing.Size(70, 27);
			this.lblTitleChildForm.TabIndex = 1;
			this.lblTitleChildForm.Text = "Pedido";
			// 
			// iconCurrentChildForm
			// 
			this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(152)))), ((int)(((byte)(231)))));
			this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(193)))));
			this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
			this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(193)))));
			this.iconCurrentChildForm.Location = new System.Drawing.Point(211, 26);
			this.iconCurrentChildForm.Name = "iconCurrentChildForm";
			this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
			this.iconCurrentChildForm.TabIndex = 0;
			this.iconCurrentChildForm.TabStop = false;
			// 
			// FormPedido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(716, 699);
			this.Controls.Add(this.panelDesktop);
			this.Controls.Add(this.panelTitleBar);
			this.Name = "FormPedido";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormPedido";
			this.panelDesktop.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdItensPedido)).EndInit();
			this.panelTitleBar.ResumeLayout(false);
			this.panelTitleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelDesktop;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox ddlCliente;
		private System.Windows.Forms.TextBox txtObservacao;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label label2;
		private FontAwesome.Sharp.IconButton btnAddCliente;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCadasterDate;
		private FontAwesome.Sharp.IconButton btnDelete;
		private FontAwesome.Sharp.IconButton btnSave;
		private FontAwesome.Sharp.IconButton btnEdit;
		private System.Windows.Forms.Panel panelTitleBar;
		private FontAwesome.Sharp.IconButton btnMaximize;
		private FontAwesome.Sharp.IconButton btnMinimize;
		private FontAwesome.Sharp.IconButton btnClose;
		private System.Windows.Forms.PictureBox btnHome;
		private System.Windows.Forms.Label lblTitleChildForm;
		private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView grdItensPedido;
		private FontAwesome.Sharp.IconButton btnAdd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTotalBruto;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtDesconto;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtTotalLiquido;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtEntrada;
		private FontAwesome.Sharp.IconButton btnPrint;
		private System.Windows.Forms.ComboBox ddlTipoPagamento;
		private FontAwesome.Sharp.IconButton btnCancel;
		private FontAwesome.Sharp.IconButton btnLock;
		private FontAwesome.Sharp.IconButton btnOpen;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoString;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdPedido;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
		private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total;
		private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
		private System.Windows.Forms.DataGridViewTextBoxColumn Observacao;
		private System.Windows.Forms.DataGridViewTextBoxColumn CadasterDate;
		private System.Windows.Forms.ToolTip toolTip;
	}
}