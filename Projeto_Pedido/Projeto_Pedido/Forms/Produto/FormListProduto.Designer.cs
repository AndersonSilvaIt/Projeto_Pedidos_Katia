namespace Projeto_Pedido.Forms {
	partial class FormListProduto {
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ddlFornecedor = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDescricao = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSearch = new FontAwesome.Sharp.IconButton();
			this.btnAdd = new FontAwesome.Sharp.IconButton();
			this.grdProduto = new System.Windows.Forms.DataGridView();
			this.FornecedorString = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Imagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IdFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PrecoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PrecoCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CadasterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnRefresh = new FontAwesome.Sharp.IconButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdProduto)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(48, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Código";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(103, 23);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(90, 26);
			this.txtCodigo.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ddlFornecedor);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Controls.Add(this.txtDescricao);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtCodigo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(633, 149);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtro";
			// 
			// ddlFornecedor
			// 
			this.ddlFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ddlFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlFornecedor.FormattingEnabled = true;
			this.ddlFornecedor.Location = new System.Drawing.Point(103, 62);
			this.ddlFornecedor.Name = "ddlFornecedor";
			this.ddlFornecedor.Size = new System.Drawing.Size(314, 25);
			this.ddlFornecedor.TabIndex = 31;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(19, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 18);
			this.label3.TabIndex = 30;
			this.label3.Text = "Fornecedor";
			// 
			// txtDescricao
			// 
			this.txtDescricao.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescricao.Location = new System.Drawing.Point(287, 23);
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.Size = new System.Drawing.Size(253, 26);
			this.txtDescricao.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(213, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Descrição";
			// 
			// btnSearch
			// 
			this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.btnSearch.IconColor = System.Drawing.Color.White;
			this.btnSearch.IconSize = 20;
			this.btnSearch.Location = new System.Drawing.Point(103, 105);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Rotation = 0D;
			this.btnSearch.Size = new System.Drawing.Size(83, 29);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
			this.grdProduto.Size = new System.Drawing.Size(597, 184);
			this.grdProduto.TabIndex = 5;
			this.grdProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProduto_CellDoubleClick);
			// 
			// FornecedorString
			// 
			this.FornecedorString.DataPropertyName = "FornecedorString";
			this.FornecedorString.HeaderText = "Fornecedor";
			this.FornecedorString.Name = "FornecedorString";
			this.FornecedorString.ReadOnly = true;
			// 
			// Fornecedor
			// 
			this.Fornecedor.DataPropertyName = "Fornecedor";
			this.Fornecedor.HeaderText = "Fornecedor";
			this.Fornecedor.Name = "Fornecedor";
			this.Fornecedor.ReadOnly = true;
			this.Fornecedor.Visible = false;
			// 
			// Observacao
			// 
			this.Observacao.DataPropertyName = "Observacao";
			this.Observacao.HeaderText = "Observacao";
			this.Observacao.Name = "Observacao";
			this.Observacao.ReadOnly = true;
			this.Observacao.Visible = false;
			// 
			// Imagem
			// 
			this.Imagem.DataPropertyName = "Imagem";
			this.Imagem.HeaderText = "Imagem";
			this.Imagem.Name = "Imagem";
			this.Imagem.ReadOnly = true;
			this.Imagem.Visible = false;
			// 
			// IdFornecedor
			// 
			this.IdFornecedor.DataPropertyName = "IdFornecedor";
			this.IdFornecedor.HeaderText = "IdFornecedor";
			this.IdFornecedor.Name = "IdFornecedor";
			this.IdFornecedor.ReadOnly = true;
			this.IdFornecedor.Visible = false;
			// 
			// Tipo
			// 
			this.Tipo.DataPropertyName = "TipoCli";
			this.Tipo.HeaderText = "TipoCli";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			this.Tipo.Visible = false;
			// 
			// PrecoVenda
			// 
			this.PrecoVenda.DataPropertyName = "PrecoVenda";
			this.PrecoVenda.HeaderText = "Preco Venda";
			this.PrecoVenda.Name = "PrecoVenda";
			this.PrecoVenda.ReadOnly = true;
			// 
			// PrecoCusto
			// 
			this.PrecoCusto.DataPropertyName = "PrecoCusto";
			this.PrecoCusto.HeaderText = "Preco Custo";
			this.PrecoCusto.Name = "PrecoCusto";
			this.PrecoCusto.ReadOnly = true;
			// 
			// UM
			// 
			this.UM.DataPropertyName = "UM";
			this.UM.HeaderText = "UM";
			this.UM.Name = "UM";
			this.UM.ReadOnly = true;
			// 
			// Descrição
			// 
			this.Descrição.DataPropertyName = "Descricao";
			this.Descrição.HeaderText = "Descrição";
			this.Descrição.Name = "Descrição";
			this.Descrição.ReadOnly = true;
			// 
			// Código
			// 
			this.Código.DataPropertyName = "Codigo";
			this.Código.HeaderText = "Código";
			this.Código.Name = "Código";
			this.Código.ReadOnly = true;
			// 
			// CadasterDate
			// 
			this.CadasterDate.DataPropertyName = "CadasterDate";
			this.CadasterDate.HeaderText = "CadasterDate";
			this.CadasterDate.Name = "CadasterDate";
			this.CadasterDate.ReadOnly = true;
			this.CadasterDate.Visible = false;
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Visible = false;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
			this.btnRefresh.IconColor = System.Drawing.Color.Blue;
			this.btnRefresh.IconSize = 20;
			this.btnRefresh.Location = new System.Drawing.Point(582, 14);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Rotation = 0D;
			this.btnRefresh.Size = new System.Drawing.Size(35, 29);
			this.btnRefresh.TabIndex = 9;
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.btnRefresh);
			this.groupBox2.Controls.Add(this.grdProduto);
			this.groupBox2.Controls.Add(this.btnAdd);
			this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 215);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(633, 258);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(260, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 18);
			this.label5.TabIndex = 5;
			this.label5.Text = "Listagem";
			// 
			// FormListProduto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(188)))), ((int)(((byte)(246)))));
			this.ClientSize = new System.Drawing.Size(663, 491);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormListProduto";
			this.Text = "Listagem de Produtos";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdProduto)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.GroupBox groupBox1;
		private FontAwesome.Sharp.IconButton btnSearch;
		private System.Windows.Forms.TextBox txtDescricao;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox ddlFornecedor;
		private System.Windows.Forms.Label label3;
		private FontAwesome.Sharp.IconButton btnAdd;
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
		private FontAwesome.Sharp.IconButton btnRefresh;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
	}
}