namespace Projeto_Pedido.Forms.Entidades {
	partial class FormListEntidades {
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnRefresh = new FontAwesome.Sharp.IconButton();
			this.grdEntidade = new System.Windows.Forms.DataGridView();
			this.btnAdd = new FontAwesome.Sharp.IconButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ddlTipoDoc = new System.Windows.Forms.ComboBox();
			this.ddlTipoCli = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.ddlUF = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtDocumento = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSearch = new FontAwesome.Sharp.IconButton();
			this.txtRazaoSocial = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CadasterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TipoCliString = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DDDFoneFixo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FoneFixo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DDDFoneCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FoneCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdEntidade)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(340, 187);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 19);
			this.label5.TabIndex = 8;
			this.label5.Text = "Listagem";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnRefresh);
			this.groupBox2.Controls.Add(this.grdEntidade);
			this.groupBox2.Controls.Add(this.btnAdd);
			this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 208);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(737, 296);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
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
			this.btnRefresh.Location = new System.Drawing.Point(678, 14);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Rotation = 0D;
			this.btnRefresh.Size = new System.Drawing.Size(35, 29);
			this.btnRefresh.TabIndex = 8;
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// grdEntidade
			// 
			this.grdEntidade.AllowUserToAddRows = false;
			this.grdEntidade.AllowUserToDeleteRows = false;
			this.grdEntidade.AllowUserToResizeColumns = false;
			this.grdEntidade.AllowUserToResizeRows = false;
			this.grdEntidade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grdEntidade.BackgroundColor = System.Drawing.Color.White;
			this.grdEntidade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grdEntidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdEntidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.TipoDocumento,
            this.Descricao,
            this.RazaoSocial,
            this.Id,
            this.Rua,
            this.Numero,
            this.Bairro,
            this.Cidade,
            this.Estado,
            this.CEP,
            this.Complemento,
            this.CadasterDate,
            this.NomeFantasia,
            this.Tipo,
            this.TipoCliString,
            this.Documento,
            this.Contato,
            this.Email,
            this.DDDFoneFixo,
            this.FoneFixo,
            this.DDDFoneCelular,
            this.FoneCelular,
            this.Site,
            this.Observacao});
			this.grdEntidade.Cursor = System.Windows.Forms.Cursors.Hand;
			this.grdEntidade.Location = new System.Drawing.Point(20, 49);
			this.grdEntidade.MultiSelect = false;
			this.grdEntidade.Name = "grdEntidade";
			this.grdEntidade.ReadOnly = true;
			this.grdEntidade.RowHeadersVisible = false;
			this.grdEntidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdEntidade.ShowCellErrors = false;
			this.grdEntidade.ShowCellToolTips = false;
			this.grdEntidade.ShowEditingIcon = false;
			this.grdEntidade.ShowRowErrors = false;
			this.grdEntidade.Size = new System.Drawing.Size(693, 225);
			this.grdEntidade.TabIndex = 5;
			this.grdEntidade.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEntidade_CellDoubleClick);
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
			this.btnAdd.TabIndex = 7;
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ddlTipoDoc);
			this.groupBox1.Controls.Add(this.ddlTipoCli);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.ddlUF);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtDocumento);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Controls.Add(this.txtRazaoSocial);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtCodigo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(737, 161);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtro";
			// 
			// ddlTipoDoc
			// 
			this.ddlTipoDoc.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ddlTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlTipoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ddlTipoDoc.FormattingEnabled = true;
			this.ddlTipoDoc.ItemHeight = 17;
			this.ddlTipoDoc.Location = new System.Drawing.Point(630, 77);
			this.ddlTipoDoc.Name = "ddlTipoDoc";
			this.ddlTipoDoc.Size = new System.Drawing.Size(83, 25);
			this.ddlTipoDoc.TabIndex = 47;
			// 
			// ddlTipoCli
			// 
			this.ddlTipoCli.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ddlTipoCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlTipoCli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ddlTipoCli.FormattingEnabled = true;
			this.ddlTipoCli.ItemHeight = 17;
			this.ddlTipoCli.Location = new System.Drawing.Point(630, 37);
			this.ddlTipoCli.Name = "ddlTipoCli";
			this.ddlTipoCli.Size = new System.Drawing.Size(83, 25);
			this.ddlTipoCli.TabIndex = 46;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(589, 34);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 18);
			this.label8.TabIndex = 40;
			this.label8.Text = "Tipo";
			// 
			// ddlUF
			// 
			this.ddlUF.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ddlUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlUF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ddlUF.FormattingEnabled = true;
			this.ddlUF.ItemHeight = 17;
			this.ddlUF.Location = new System.Drawing.Point(83, 70);
			this.ddlUF.Name = "ddlUF";
			this.ddlUF.Size = new System.Drawing.Size(58, 25);
			this.ddlUF.TabIndex = 39;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(261, 77);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 18);
			this.label7.TabIndex = 37;
			this.label7.Text = "CPF / CNPJ";
			// 
			// txtDocumento
			// 
			this.txtDocumento.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDocumento.Location = new System.Drawing.Point(347, 74);
			this.txtDocumento.Name = "txtDocumento";
			this.txtDocumento.Size = new System.Drawing.Size(161, 26);
			this.txtDocumento.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(51, 77);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(26, 18);
			this.label6.TabIndex = 13;
			this.label6.Text = "UF";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(520, 77);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 18);
			this.label4.TabIndex = 12;
			this.label4.Text = "Tipo Documento";
			// 
			// btnSearch
			// 
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.btnSearch.IconColor = System.Drawing.Color.White;
			this.btnSearch.IconSize = 20;
			this.btnSearch.Location = new System.Drawing.Point(31, 120);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Rotation = 0D;
			this.btnSearch.Size = new System.Drawing.Size(83, 29);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtRazaoSocial
			// 
			this.txtRazaoSocial.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRazaoSocial.Location = new System.Drawing.Point(282, 33);
			this.txtRazaoSocial.Name = "txtRazaoSocial";
			this.txtRazaoSocial.Size = new System.Drawing.Size(226, 26);
			this.txtRazaoSocial.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(190, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Razão Social";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(83, 33);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(94, 26);
			this.txtCodigo.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(28, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Código";
			// 
			// Codigo
			// 
			this.Codigo.DataPropertyName = "Codigo";
			this.Codigo.FillWeight = 40F;
			this.Codigo.HeaderText = "Código";
			this.Codigo.Name = "Codigo";
			this.Codigo.ReadOnly = true;
			// 
			// TipoDocumento
			// 
			this.TipoDocumento.DataPropertyName = "TipoDocumento";
			this.TipoDocumento.HeaderText = "TipoDocumento";
			this.TipoDocumento.Name = "TipoDocumento";
			this.TipoDocumento.ReadOnly = true;
			this.TipoDocumento.Visible = false;
			// 
			// Descricao
			// 
			this.Descricao.DataPropertyName = "Descricao";
			this.Descricao.HeaderText = "Descricao";
			this.Descricao.Name = "Descricao";
			this.Descricao.ReadOnly = true;
			this.Descricao.Visible = false;
			// 
			// RazaoSocial
			// 
			this.RazaoSocial.DataPropertyName = "RazaoSocial";
			this.RazaoSocial.FillWeight = 120F;
			this.RazaoSocial.HeaderText = "Razão Social";
			this.RazaoSocial.Name = "RazaoSocial";
			this.RazaoSocial.ReadOnly = true;
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Visible = false;
			// 
			// Rua
			// 
			this.Rua.DataPropertyName = "Rua";
			this.Rua.HeaderText = "Rua";
			this.Rua.Name = "Rua";
			this.Rua.ReadOnly = true;
			this.Rua.Visible = false;
			// 
			// Numero
			// 
			this.Numero.DataPropertyName = "Numero";
			this.Numero.HeaderText = "Numero";
			this.Numero.Name = "Numero";
			this.Numero.ReadOnly = true;
			this.Numero.Visible = false;
			// 
			// Bairro
			// 
			this.Bairro.DataPropertyName = "Bairro";
			this.Bairro.HeaderText = "Bairro";
			this.Bairro.Name = "Bairro";
			this.Bairro.ReadOnly = true;
			this.Bairro.Visible = false;
			// 
			// Cidade
			// 
			this.Cidade.DataPropertyName = "Cidade";
			this.Cidade.FillWeight = 65F;
			this.Cidade.HeaderText = "Cidade";
			this.Cidade.Name = "Cidade";
			this.Cidade.ReadOnly = true;
			// 
			// Estado
			// 
			this.Estado.DataPropertyName = "Estado";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Estado.DefaultCellStyle = dataGridViewCellStyle1;
			this.Estado.FillWeight = 30F;
			this.Estado.HeaderText = "Estado";
			this.Estado.Name = "Estado";
			this.Estado.ReadOnly = true;
			this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// CEP
			// 
			this.CEP.DataPropertyName = "CEP";
			this.CEP.HeaderText = "CEP";
			this.CEP.Name = "CEP";
			this.CEP.ReadOnly = true;
			this.CEP.Visible = false;
			// 
			// Complemento
			// 
			this.Complemento.DataPropertyName = "Complemento";
			this.Complemento.HeaderText = "Complemento";
			this.Complemento.Name = "Complemento";
			this.Complemento.ReadOnly = true;
			this.Complemento.Visible = false;
			// 
			// CadasterDate
			// 
			this.CadasterDate.DataPropertyName = "CadasterDate";
			this.CadasterDate.HeaderText = "CadasterDate";
			this.CadasterDate.Name = "CadasterDate";
			this.CadasterDate.ReadOnly = true;
			this.CadasterDate.Visible = false;
			// 
			// NomeFantasia
			// 
			this.NomeFantasia.DataPropertyName = "NomeFantasia";
			this.NomeFantasia.HeaderText = "NomeFantasia";
			this.NomeFantasia.Name = "NomeFantasia";
			this.NomeFantasia.ReadOnly = true;
			this.NomeFantasia.Visible = false;
			// 
			// Tipo
			// 
			this.Tipo.DataPropertyName = "TipoCli";
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			this.Tipo.Visible = false;
			// 
			// TipoCliString
			// 
			this.TipoCliString.DataPropertyName = "TipoCliString";
			this.TipoCliString.FillWeight = 40F;
			this.TipoCliString.HeaderText = "Tipo";
			this.TipoCliString.Name = "TipoCliString";
			this.TipoCliString.ReadOnly = true;
			// 
			// Documento
			// 
			this.Documento.DataPropertyName = "Documento";
			this.Documento.HeaderText = "Documento";
			this.Documento.Name = "Documento";
			this.Documento.ReadOnly = true;
			this.Documento.Visible = false;
			// 
			// Contato
			// 
			this.Contato.DataPropertyName = "Contato";
			this.Contato.FillWeight = 70F;
			this.Contato.HeaderText = "Contato";
			this.Contato.Name = "Contato";
			this.Contato.ReadOnly = true;
			// 
			// Email
			// 
			this.Email.DataPropertyName = "Email";
			this.Email.HeaderText = "Email";
			this.Email.Name = "Email";
			this.Email.ReadOnly = true;
			this.Email.Visible = false;
			// 
			// DDDFoneFixo
			// 
			this.DDDFoneFixo.DataPropertyName = "DDDFoneFixo";
			this.DDDFoneFixo.HeaderText = "DDDFoneFixo";
			this.DDDFoneFixo.Name = "DDDFoneFixo";
			this.DDDFoneFixo.ReadOnly = true;
			this.DDDFoneFixo.Visible = false;
			// 
			// FoneFixo
			// 
			this.FoneFixo.DataPropertyName = "FoneFixo";
			this.FoneFixo.HeaderText = "FoneFixo";
			this.FoneFixo.Name = "FoneFixo";
			this.FoneFixo.ReadOnly = true;
			this.FoneFixo.Visible = false;
			// 
			// DDDFoneCelular
			// 
			this.DDDFoneCelular.DataPropertyName = "DDDFoneCelular";
			this.DDDFoneCelular.HeaderText = "DDDFoneCelular";
			this.DDDFoneCelular.Name = "DDDFoneCelular";
			this.DDDFoneCelular.ReadOnly = true;
			this.DDDFoneCelular.Visible = false;
			// 
			// FoneCelular
			// 
			this.FoneCelular.DataPropertyName = "FoneCelular";
			this.FoneCelular.HeaderText = "FoneCelular";
			this.FoneCelular.Name = "FoneCelular";
			this.FoneCelular.ReadOnly = true;
			this.FoneCelular.Visible = false;
			// 
			// Site
			// 
			this.Site.DataPropertyName = "Site";
			this.Site.HeaderText = "Site";
			this.Site.Name = "Site";
			this.Site.ReadOnly = true;
			this.Site.Visible = false;
			// 
			// Observacao
			// 
			this.Observacao.DataPropertyName = "Observacao";
			this.Observacao.HeaderText = "Observacao";
			this.Observacao.Name = "Observacao";
			this.Observacao.ReadOnly = true;
			this.Observacao.Visible = false;
			// 
			// FormListEntidades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(188)))), ((int)(((byte)(246)))));
			this.ClientSize = new System.Drawing.Size(761, 519);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormListEntidades";
			this.Text = "Listagem Clientes / Fornecedores";
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdEntidade)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView grdEntidade;
		private FontAwesome.Sharp.IconButton btnAdd;
		private System.Windows.Forms.GroupBox groupBox1;
		private FontAwesome.Sharp.IconButton btnSearch;
		private System.Windows.Forms.TextBox txtRazaoSocial;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtDocumento;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox ddlUF;
		private System.Windows.Forms.Label label8;
		private FontAwesome.Sharp.IconButton btnRefresh;
		private System.Windows.Forms.ComboBox ddlTipoDoc;
		private System.Windows.Forms.ComboBox ddlTipoCli;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
		private System.Windows.Forms.DataGridViewTextBoxColumn RazaoSocial;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rua;
		private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
		private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
		private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
		private System.Windows.Forms.DataGridViewTextBoxColumn Complemento;
		private System.Windows.Forms.DataGridViewTextBoxColumn CadasterDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn NomeFantasia;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn TipoCliString;
		private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
		private System.Windows.Forms.DataGridViewTextBoxColumn Contato;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn DDDFoneFixo;
		private System.Windows.Forms.DataGridViewTextBoxColumn FoneFixo;
		private System.Windows.Forms.DataGridViewTextBoxColumn DDDFoneCelular;
		private System.Windows.Forms.DataGridViewTextBoxColumn FoneCelular;
		private System.Windows.Forms.DataGridViewTextBoxColumn Site;
		private System.Windows.Forms.DataGridViewTextBoxColumn Observacao;
	}
}