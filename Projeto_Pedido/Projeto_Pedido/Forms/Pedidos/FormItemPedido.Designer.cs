namespace Projeto_Pedido.Forms.Pedidos {
	partial class FormItemPedido {
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblValorProduto = new System.Windows.Forms.Label();
			this.lblTotalLiquido = new System.Windows.Forms.Label();
			this.lblValorDesconto = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtObservacao = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.ddlProduto = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtQuantidade = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAddProduto = new FontAwesome.Sharp.IconButton();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDesconto = new System.Windows.Forms.TextBox();
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
			this.panelTitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
			this.SuspendLayout();
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
			this.panelDesktop.Size = new System.Drawing.Size(676, 332);
			this.panelDesktop.TabIndex = 10;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblValorProduto);
			this.groupBox1.Controls.Add(this.lblTotalLiquido);
			this.groupBox1.Controls.Add(this.lblValorDesconto);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtObservacao);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.ddlProduto);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtQuantidade);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnAddProduto);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtDesconto);
			this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
			this.groupBox1.Location = new System.Drawing.Point(12, 17);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(652, 254);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Item";
			// 
			// lblValorProduto
			// 
			this.lblValorProduto.AutoSize = true;
			this.lblValorProduto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValorProduto.Location = new System.Drawing.Point(560, 80);
			this.lblValorProduto.Name = "lblValorProduto";
			this.lblValorProduto.Size = new System.Drawing.Size(28, 18);
			this.lblValorProduto.TabIndex = 55;
			this.lblValorProduto.Text = "0,0";
			// 
			// lblTotalLiquido
			// 
			this.lblTotalLiquido.AutoSize = true;
			this.lblTotalLiquido.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalLiquido.Location = new System.Drawing.Point(370, 136);
			this.lblTotalLiquido.Name = "lblTotalLiquido";
			this.lblTotalLiquido.Size = new System.Drawing.Size(28, 18);
			this.lblTotalLiquido.TabIndex = 54;
			this.lblTotalLiquido.Text = "0,0";
			// 
			// lblValorDesconto
			// 
			this.lblValorDesconto.AutoSize = true;
			this.lblValorDesconto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValorDesconto.Location = new System.Drawing.Point(257, 136);
			this.lblValorDesconto.Name = "lblValorDesconto";
			this.lblValorDesconto.Size = new System.Drawing.Size(28, 18);
			this.lblValorDesconto.TabIndex = 53;
			this.lblValorDesconto.Text = "0,0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(226, 115);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 18);
			this.label6.TabIndex = 52;
			this.label6.Text = "Desconto R$";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(463, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 18);
			this.label5.TabIndex = 50;
			this.label5.Text = "Valor Produto: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(26, 175);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 18);
			this.label4.TabIndex = 48;
			this.label4.Text = "Observação";
			// 
			// txtObservacao
			// 
			this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtObservacao.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObservacao.Location = new System.Drawing.Point(29, 196);
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.Size = new System.Drawing.Size(569, 42);
			this.txtObservacao.TabIndex = 6;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(355, 114);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(61, 18);
			this.label10.TabIndex = 30;
			this.label10.Text = "Total R$";
			// 
			// ddlProduto
			// 
			this.ddlProduto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ddlProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ddlProduto.FormattingEnabled = true;
			this.ddlProduto.Location = new System.Drawing.Point(29, 47);
			this.ddlProduto.Name = "ddlProduto";
			this.ddlProduto.Size = new System.Drawing.Size(569, 26);
			this.ddlProduto.TabIndex = 1;
			this.ddlProduto.SelectedIndexChanged += new System.EventHandler(this.ddlProduto_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 18);
			this.label1.TabIndex = 5;
			this.label1.Text = "Quantidade";
			// 
			// txtQuantidade
			// 
			this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtQuantidade.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuantidade.Location = new System.Drawing.Point(29, 136);
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.Size = new System.Drawing.Size(94, 19);
			this.txtQuantidade.TabIndex = 3;
			this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 18);
			this.label2.TabIndex = 7;
			this.label2.Text = "Produto";
			// 
			// btnAddProduto
			// 
			this.btnAddProduto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddProduto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnAddProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddProduto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnAddProduto.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnAddProduto.IconColor = System.Drawing.Color.White;
			this.btnAddProduto.IconSize = 15;
			this.btnAddProduto.Location = new System.Drawing.Point(604, 47);
			this.btnAddProduto.Name = "btnAddProduto";
			this.btnAddProduto.Rotation = 0D;
			this.btnAddProduto.Size = new System.Drawing.Size(25, 24);
			this.btnAddProduto.TabIndex = 2;
			this.btnAddProduto.UseVisualStyleBackColor = true;
			this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(147, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 18);
			this.label3.TabIndex = 11;
			this.label3.Text = "Desc %";
			// 
			// txtDesconto
			// 
			this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDesconto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDesconto.Location = new System.Drawing.Point(150, 136);
			this.txtDesconto.Name = "txtDesconto";
			this.txtDesconto.Size = new System.Drawing.Size(49, 19);
			this.txtDesconto.TabIndex = 4;
			this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
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
			this.btnDelete.Location = new System.Drawing.Point(138, 285);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Rotation = 0D;
			this.btnDelete.Size = new System.Drawing.Size(37, 33);
			this.btnDelete.TabIndex = 9;
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
			this.btnSave.Location = new System.Drawing.Point(32, 285);
			this.btnSave.Name = "btnSave";
			this.btnSave.Rotation = 0D;
			this.btnSave.Size = new System.Drawing.Size(37, 33);
			this.btnSave.TabIndex = 7;
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
			this.btnEdit.Location = new System.Drawing.Point(85, 285);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Rotation = 0D;
			this.btnEdit.Size = new System.Drawing.Size(37, 33);
			this.btnEdit.TabIndex = 8;
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
			this.panelTitleBar.Size = new System.Drawing.Size(676, 73);
			this.panelTitleBar.TabIndex = 9;
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
			this.btnMaximize.Location = new System.Drawing.Point(619, 6);
			this.btnMaximize.Name = "btnMaximize";
			this.btnMaximize.Rotation = 0D;
			this.btnMaximize.Size = new System.Drawing.Size(24, 22);
			this.btnMaximize.TabIndex = 11;
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
			this.btnMinimize.Location = new System.Drawing.Point(589, 6);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Rotation = 0D;
			this.btnMinimize.Size = new System.Drawing.Size(24, 22);
			this.btnMinimize.TabIndex = 10;
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
			this.btnClose.Location = new System.Drawing.Point(649, 6);
			this.btnClose.Name = "btnClose";
			this.btnClose.Rotation = 0D;
			this.btnClose.Size = new System.Drawing.Size(24, 22);
			this.btnClose.TabIndex = 12;
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
			this.lblTitleChildForm.Size = new System.Drawing.Size(123, 27);
			this.lblTitleChildForm.TabIndex = 1;
			this.lblTitleChildForm.Text = "Item Pedido";
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
			// FormItemPedido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(676, 405);
			this.Controls.Add(this.panelDesktop);
			this.Controls.Add(this.panelTitleBar);
			this.Name = "FormItemPedido";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormItemPedido";
			this.panelDesktop.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panelTitleBar.ResumeLayout(false);
			this.panelTitleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelDesktop;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox ddlProduto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtQuantidade;
		private System.Windows.Forms.Label label2;
		private FontAwesome.Sharp.IconButton btnAddProduto;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDesconto;
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
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtObservacao;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblTotalLiquido;
		private System.Windows.Forms.Label lblValorDesconto;
		private System.Windows.Forms.Label lblValorProduto;
	}
}