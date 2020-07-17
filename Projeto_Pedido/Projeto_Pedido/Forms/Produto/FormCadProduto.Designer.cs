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
			this.btnHome = new System.Windows.Forms.PictureBox();
			this.lblTitleChildForm = new System.Windows.Forms.Label();
			this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
			this.panelDesktop = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnImage = new System.Windows.Forms.Button();
			this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAddFornecedor = new FontAwesome.Sharp.IconButton();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.btnDelete = new FontAwesome.Sharp.IconButton();
			this.btnSave = new FontAwesome.Sharp.IconButton();
			this.btnEdit = new FontAwesome.Sharp.IconButton();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.panelTitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
			this.panelDesktop.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelTitleBar
			// 
			this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(152)))), ((int)(((byte)(231)))));
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
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.btnImage);
			this.groupBox1.Controls.Add(this.iconPictureBox1);
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Controls.Add(this.textBox8);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox7);
			this.groupBox1.Controls.Add(this.txtCodigo);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnAddFornecedor);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBox6);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
			this.groupBox1.Location = new System.Drawing.Point(12, 17);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(819, 305);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Cadastro";
			// 
			// btnImage
			// 
			this.btnImage.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImage.Location = new System.Drawing.Point(685, 168);
			this.btnImage.Name = "btnImage";
			this.btnImage.Size = new System.Drawing.Size(113, 23);
			this.btnImage.TabIndex = 28;
			this.btnImage.Text = "Escolher Imagem";
			this.btnImage.UseVisualStyleBackColor = true;
			// 
			// iconPictureBox1
			// 
			this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(127)))), ((int)(((byte)(221)))));
			this.iconPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
			this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
			this.iconPictureBox1.IconSize = 105;
			this.iconPictureBox1.Location = new System.Drawing.Point(657, 62);
			this.iconPictureBox1.Name = "iconPictureBox1";
			this.iconPictureBox1.Size = new System.Drawing.Size(141, 105);
			this.iconPictureBox1.TabIndex = 27;
			this.iconPictureBox1.TabStop = false;
			// 
			// textBox5
			// 
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox5.Location = new System.Drawing.Point(332, 117);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(138, 19);
			this.textBox5.TabIndex = 18;
			// 
			// textBox8
			// 
			this.textBox8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox8.Location = new System.Drawing.Point(29, 243);
			this.textBox8.Multiline = true;
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(599, 47);
			this.textBox8.TabIndex = 24;
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
			// textBox7
			// 
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox7.Location = new System.Drawing.Point(524, 183);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(104, 19);
			this.textBox7.TabIndex = 22;
			// 
			// txtCodigo
			// 
			this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCodigo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(29, 62);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(94, 19);
			this.txtCodigo.TabIndex = 6;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(521, 162);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(94, 18);
			this.label8.TabIndex = 21;
			this.label8.Text = "Data Cadastro";
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
			this.btnAddFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnAddFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddFornecedor.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnAddFornecedor.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnAddFornecedor.IconColor = System.Drawing.Color.Black;
			this.btnAddFornecedor.IconSize = 15;
			this.btnAddFornecedor.Location = new System.Drawing.Point(343, 178);
			this.btnAddFornecedor.Name = "btnAddFornecedor";
			this.btnAddFornecedor.Rotation = 0D;
			this.btnAddFornecedor.Size = new System.Drawing.Size(25, 24);
			this.btnAddFornecedor.TabIndex = 10;
			this.btnAddFornecedor.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(147, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 18);
			this.label3.TabIndex = 11;
			this.label3.Text = "Descrição";
			// 
			// textBox6
			// 
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox6.Location = new System.Drawing.Point(524, 117);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(104, 19);
			this.textBox6.TabIndex = 20;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(150, 62);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(478, 19);
			this.textBox1.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(521, 96);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 18);
			this.label7.TabIndex = 19;
			this.label7.Text = "Tipo";
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
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(29, 117);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(94, 19);
			this.textBox4.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(329, 96);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 18);
			this.label6.TabIndex = 17;
			this.label6.Text = "Preço Venda";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(147, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 18);
			this.label4.TabIndex = 15;
			this.label4.Text = "Preço Custo";
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(150, 117);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(138, 19);
			this.textBox3.TabIndex = 16;
			// 
			// btnDelete
			// 
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
			this.btnDelete.IconColor = System.Drawing.Color.Red;
			this.btnDelete.IconSize = 35;
			this.btnDelete.Location = new System.Drawing.Point(149, 330);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Rotation = 0D;
			this.btnDelete.Size = new System.Drawing.Size(37, 33);
			this.btnDelete.TabIndex = 26;
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
			this.btnSave.IconColor = System.Drawing.Color.Green;
			this.btnSave.IconSize = 35;
			this.btnSave.Location = new System.Drawing.Point(43, 330);
			this.btnSave.Name = "btnSave";
			this.btnSave.Rotation = 0D;
			this.btnSave.Size = new System.Drawing.Size(37, 33);
			this.btnSave.TabIndex = 20;
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnEdit
			// 
			this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
			this.btnEdit.IconColor = System.Drawing.Color.Gold;
			this.btnEdit.IconSize = 35;
			this.btnEdit.Location = new System.Drawing.Point(96, 330);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Rotation = 0D;
			this.btnEdit.Size = new System.Drawing.Size(37, 33);
			this.btnEdit.TabIndex = 25;
			this.btnEdit.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(29, 180);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(259, 26);
			this.comboBox1.TabIndex = 29;
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
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
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
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox1;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
		private System.Windows.Forms.Button btnImage;
		private FontAwesome.Sharp.IconButton btnDelete;
		private FontAwesome.Sharp.IconButton btnSave;
		private FontAwesome.Sharp.IconButton btnEdit;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}