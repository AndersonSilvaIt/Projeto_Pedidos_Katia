namespace Projeto_Pedido.Forms.Pedido {
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
			this.panelDesktop = new System.Windows.Forms.Panel();
			this.btnPrint = new FontAwesome.Sharp.IconButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.grdProduto = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CadasterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PrecoCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PrecoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IdFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Imagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FornecedorString = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAdd = new FontAwesome.Sharp.IconButton();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.ddlCliente = new System.Windows.Forms.ComboBox();
			this.txtObservacao = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAddCliente = new FontAwesome.Sharp.IconButton();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDescricao = new System.Windows.Forms.TextBox();
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
			this.panelDesktop.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdProduto)).BeginInit();
			this.panelTitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
			this.SuspendLayout();
			// 
			// panelDesktop
			// 
			this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(127)))), ((int)(((byte)(221)))));
			this.panelDesktop.Controls.Add(this.btnPrint);
			this.panelDesktop.Controls.Add(this.groupBox1);
			this.panelDesktop.Controls.Add(this.btnDelete);
			this.panelDesktop.Controls.Add(this.btnSave);
			this.panelDesktop.Controls.Add(this.btnEdit);
			this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktop.Location = new System.Drawing.Point(0, 73);
			this.panelDesktop.Name = "panelDesktop";
			this.panelDesktop.Size = new System.Drawing.Size(729, 676);
			this.panelDesktop.TabIndex = 8;
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
			this.btnPrint.Location = new System.Drawing.Point(621, 618);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Rotation = 0D;
			this.btnPrint.Size = new System.Drawing.Size(37, 33);
			this.btnPrint.TabIndex = 27;
			this.btnPrint.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.textBox6);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.ddlCliente);
			this.groupBox1.Controls.Add(this.txtObservacao);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtCodigo);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnAddCliente);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtDescricao);
			this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
			this.groupBox1.Location = new System.Drawing.Point(12, 17);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(698, 595);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados do Pedido";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(530, 454);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(88, 18);
			this.label11.TabIndex = 46;
			this.label11.Text = "Total Líquido";
			// 
			// textBox6
			// 
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox6.Location = new System.Drawing.Point(533, 475);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(113, 19);
			this.textBox6.TabIndex = 47;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(246, 454);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 18);
			this.label8.TabIndex = 44;
			this.label8.Text = "Entrada";
			// 
			// textBox5
			// 
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox5.Location = new System.Drawing.Point(249, 475);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(94, 19);
			this.textBox5.TabIndex = 45;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(26, 454);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 18);
			this.label7.TabIndex = 42;
			this.label7.Text = "Desconto %";
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(29, 475);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(94, 19);
			this.textBox4.TabIndex = 43;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(530, 399);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 18);
			this.label5.TabIndex = 40;
			this.label5.Text = "Total Bruto";
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(533, 420);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(113, 19);
			this.textBox2.TabIndex = 41;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(26, 399);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(102, 18);
			this.label6.TabIndex = 33;
			this.label6.Text = "Tipo Pagamento";
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(29, 420);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(94, 19);
			this.textBox3.TabIndex = 34;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.grdProduto);
			this.groupBox2.Controls.Add(this.btnAdd);
			this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(29, 132);
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
			// grdProduto
			// 
			this.grdProduto.AllowUserToAddRows = false;
			this.grdProduto.AllowUserToDeleteRows = false;
			this.grdProduto.AllowUserToResizeColumns = false;
			this.grdProduto.AllowUserToResizeRows = false;
			this.grdProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grdProduto.BackgroundColor = System.Drawing.Color.White;
			this.grdProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grdProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Id,
			this.CadasterDate,
			this.Código,
			this.Descrição,
			this.UM,
			this.PrecoCusto,
			this.PrecoVenda,
			this.Tipo,
			this.IdFornecedor,
			this.Imagem,
			this.Observacao,
			this.Fornecedor,
			this.FornecedorString});
			this.grdProduto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.grdProduto.Location = new System.Drawing.Point(20, 49);
			this.grdProduto.MultiSelect = false;
			this.grdProduto.Name = "grdProduto";
			this.grdProduto.ReadOnly = true;
			this.grdProduto.RowHeadersVisible = false;
			this.grdProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdProduto.ShowCellErrors = false;
			this.grdProduto.ShowCellToolTips = false;
			this.grdProduto.ShowEditingIcon = false;
			this.grdProduto.ShowRowErrors = false;
			this.grdProduto.Size = new System.Drawing.Size(597, 185);
			this.grdProduto.TabIndex = 5;
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Visible = false;
			// 
			// CadasterDate
			// 
			this.CadasterDate.DataPropertyName = "CadasterDate";
			this.CadasterDate.HeaderText = "CadasterDate";
			this.CadasterDate.Name = "CadasterDate";
			this.CadasterDate.ReadOnly = true;
			this.CadasterDate.Visible = false;
			// 
			// Código
			// 
			this.Código.DataPropertyName = "Codigo";
			this.Código.HeaderText = "Código";
			this.Código.Name = "Código";
			this.Código.ReadOnly = true;
			// 
			// Descrição
			// 
			this.Descrição.DataPropertyName = "Descricao";
			this.Descrição.HeaderText = "Descrição";
			this.Descrição.Name = "Descrição";
			this.Descrição.ReadOnly = true;
			// 
			// UM
			// 
			this.UM.DataPropertyName = "UM";
			this.UM.HeaderText = "UM";
			this.UM.Name = "UM";
			this.UM.ReadOnly = true;
			// 
			// PrecoCusto
			// 
			this.PrecoCusto.DataPropertyName = "PrecoCusto";
			this.PrecoCusto.HeaderText = "Preco Custo";
			this.PrecoCusto.Name = "PrecoCusto";
			this.PrecoCusto.ReadOnly = true;
			// 
			// PrecoVenda
			// 
			this.PrecoVenda.DataPropertyName = "PrecoVenda";
			this.PrecoVenda.HeaderText = "Preco Venda";
			this.PrecoVenda.Name = "PrecoVenda";
			this.PrecoVenda.ReadOnly = true;
			// 
			// Tipo
			// 
			this.Tipo.DataPropertyName = "TipoCli";
			this.Tipo.HeaderText = "TipoCli";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			this.Tipo.Visible = false;
			// 
			// IdFornecedor
			// 
			this.IdFornecedor.DataPropertyName = "IdFornecedor";
			this.IdFornecedor.HeaderText = "IdFornecedor";
			this.IdFornecedor.Name = "IdFornecedor";
			this.IdFornecedor.ReadOnly = true;
			this.IdFornecedor.Visible = false;
			// 
			// Imagem
			// 
			this.Imagem.DataPropertyName = "Imagem";
			this.Imagem.HeaderText = "Imagem";
			this.Imagem.Name = "Imagem";
			this.Imagem.ReadOnly = true;
			this.Imagem.Visible = false;
			// 
			// Observacao
			// 
			this.Observacao.DataPropertyName = "Observacao";
			this.Observacao.HeaderText = "Observacao";
			this.Observacao.Name = "Observacao";
			this.Observacao.ReadOnly = true;
			this.Observacao.Visible = false;
			// 
			// Fornecedor
			// 
			this.Fornecedor.DataPropertyName = "Fornecedor";
			this.Fornecedor.HeaderText = "Fornecedor";
			this.Fornecedor.Name = "Fornecedor";
			this.Fornecedor.ReadOnly = true;
			this.Fornecedor.Visible = false;
			// 
			// FornecedorString
			// 
			this.FornecedorString.DataPropertyName = "FornecedorString";
			this.FornecedorString.HeaderText = "Fornecedor";
			this.FornecedorString.Name = "FornecedorString";
			this.FornecedorString.ReadOnly = true;
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
			this.btnAdd.TabIndex = 4;
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
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(533, 50);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(122, 19);
			this.textBox1.TabIndex = 31;
			// 
			// ddlCliente
			// 
			this.ddlCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ddlCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlCliente.FormattingEnabled = true;
			this.ddlCliente.Location = new System.Drawing.Point(29, 101);
			this.ddlCliente.Name = "ddlCliente";
			this.ddlCliente.Size = new System.Drawing.Size(314, 26);
			this.ddlCliente.TabIndex = 29;
			// 
			// txtObservacao
			// 
			this.txtObservacao.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObservacao.Location = new System.Drawing.Point(29, 531);
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.Size = new System.Drawing.Size(617, 47);
			this.txtObservacao.TabIndex = 24;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(26, 510);
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
			// txtCodigo
			// 
			this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCodigo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(29, 50);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(94, 19);
			this.txtCodigo.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 80);
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
			this.btnAddCliente.Location = new System.Drawing.Point(349, 101);
			this.btnAddCliente.Name = "btnAddCliente";
			this.btnAddCliente.Rotation = 0D;
			this.btnAddCliente.Size = new System.Drawing.Size(25, 24);
			this.btnAddCliente.TabIndex = 10;
			this.btnAddCliente.UseVisualStyleBackColor = true;
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
			// txtDescricao
			// 
			this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDescricao.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescricao.Location = new System.Drawing.Point(150, 50);
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.Size = new System.Drawing.Size(311, 19);
			this.txtDescricao.TabIndex = 12;
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
			this.btnDelete.Location = new System.Drawing.Point(134, 618);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Rotation = 0D;
			this.btnDelete.Size = new System.Drawing.Size(37, 33);
			this.btnDelete.TabIndex = 26;
			this.btnDelete.UseVisualStyleBackColor = true;
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
			this.btnSave.Location = new System.Drawing.Point(28, 618);
			this.btnSave.Name = "btnSave";
			this.btnSave.Rotation = 0D;
			this.btnSave.Size = new System.Drawing.Size(37, 33);
			this.btnSave.TabIndex = 20;
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
			this.btnEdit.Location = new System.Drawing.Point(81, 618);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Rotation = 0D;
			this.btnEdit.Size = new System.Drawing.Size(37, 33);
			this.btnEdit.TabIndex = 25;
			this.btnEdit.UseVisualStyleBackColor = true;
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
			this.panelTitleBar.Size = new System.Drawing.Size(729, 73);
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
			this.btnMaximize.Location = new System.Drawing.Point(672, 6);
			this.btnMaximize.Name = "btnMaximize";
			this.btnMaximize.Rotation = 0D;
			this.btnMaximize.Size = new System.Drawing.Size(24, 22);
			this.btnMaximize.TabIndex = 7;
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
			this.btnMinimize.Location = new System.Drawing.Point(642, 6);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Rotation = 0D;
			this.btnMinimize.Size = new System.Drawing.Size(24, 22);
			this.btnMinimize.TabIndex = 6;
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
			this.btnClose.Location = new System.Drawing.Point(702, 6);
			this.btnClose.Name = "btnClose";
			this.btnClose.Rotation = 0D;
			this.btnClose.Size = new System.Drawing.Size(24, 22);
			this.btnClose.TabIndex = 5;
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
			this.ClientSize = new System.Drawing.Size(729, 749);
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
			((System.ComponentModel.ISupportInitialize)(this.grdProduto)).EndInit();
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
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label2;
		private FontAwesome.Sharp.IconButton btnAddCliente;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDescricao;
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
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView grdProduto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn CadasterDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn Código;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
		private System.Windows.Forms.DataGridViewTextBoxColumn UM;
		private System.Windows.Forms.DataGridViewTextBoxColumn PrecoCusto;
		private System.Windows.Forms.DataGridViewTextBoxColumn PrecoVenda;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdFornecedor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Imagem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Observacao;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
		private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorString;
		private FontAwesome.Sharp.IconButton btnAdd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox5;
		private FontAwesome.Sharp.IconButton btnPrint;
	}
}