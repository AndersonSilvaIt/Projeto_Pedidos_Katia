namespace Projeto_Pedido.Forms {
	partial class FormEmpresa {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtRazaoSocial = new System.Windows.Forms.TextBox();
			this.txtFoneFantasia = new System.Windows.Forms.TextBox();
			this.txtDocumento = new System.Windows.Forms.TextBox();
			this.rdbJuridico = new System.Windows.Forms.RadioButton();
			this.rdbFisica = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(26, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Email";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 241);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(597, 143);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Contato";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(26, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(113, 20);
			this.label5.TabIndex = 6;
			this.label5.Text = "Fone Comercial";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(26, 86);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 20);
			this.label6.TabIndex = 7;
			this.label6.Text = "Celular";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rdbFisica);
			this.groupBox2.Controls.Add(this.rdbJuridico);
			this.groupBox2.Controls.Add(this.txtDocumento);
			this.groupBox2.Controls.Add(this.txtFoneFantasia);
			this.groupBox2.Controls.Add(this.txtRazaoSocial);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(535, 235);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Dados Básicos";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(163, 164);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(90, 20);
			this.label8.TabIndex = 4;
			this.label8.Text = "CPF / CNPJ";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(6, 105);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(111, 20);
			this.label10.TabIndex = 3;
			this.label10.Text = "Nome Fantasia";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(6, 44);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(96, 20);
			this.label11.TabIndex = 2;
			this.label11.Text = "Razão Social";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(12, 377);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(597, 143);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Endereço";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "Celular";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Fone Comercial";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(26, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Email";
			// 
			// txtRazaoSocial
			// 
			this.txtRazaoSocial.Location = new System.Drawing.Point(10, 67);
			this.txtRazaoSocial.Name = "txtRazaoSocial";
			this.txtRazaoSocial.Size = new System.Drawing.Size(511, 28);
			this.txtRazaoSocial.TabIndex = 5;
			// 
			// txtFoneFantasia
			// 
			this.txtFoneFantasia.Location = new System.Drawing.Point(10, 128);
			this.txtFoneFantasia.Name = "txtFoneFantasia";
			this.txtFoneFantasia.Size = new System.Drawing.Size(511, 28);
			this.txtFoneFantasia.TabIndex = 6;
			// 
			// txtDocumento
			// 
			this.txtDocumento.Location = new System.Drawing.Point(167, 189);
			this.txtDocumento.Name = "txtDocumento";
			this.txtDocumento.Size = new System.Drawing.Size(177, 28);
			this.txtDocumento.TabIndex = 7;
			// 
			// rdbJuridico
			// 
			this.rdbJuridico.AutoSize = true;
			this.rdbJuridico.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbJuridico.Location = new System.Drawing.Point(10, 162);
			this.rdbJuridico.Name = "rdbJuridico";
			this.rdbJuridico.Size = new System.Drawing.Size(135, 24);
			this.rdbJuridico.TabIndex = 8;
			this.rdbJuridico.TabStop = true;
			this.rdbJuridico.Text = "Pessoa Jurídica";
			this.rdbJuridico.UseVisualStyleBackColor = true;
			// 
			// rdbFisica
			// 
			this.rdbFisica.AutoSize = true;
			this.rdbFisica.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbFisica.Location = new System.Drawing.Point(10, 192);
			this.rdbFisica.Name = "rdbFisica";
			this.rdbFisica.Size = new System.Drawing.Size(117, 24);
			this.rdbFisica.TabIndex = 9;
			this.rdbFisica.TabStop = true;
			this.rdbFisica.Text = "Pessoa Física";
			this.rdbFisica.UseVisualStyleBackColor = true;
			// 
			// FormEmpresa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1046, 508);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormEmpresa";
			this.Text = "FormEmpresa";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtRazaoSocial;
		private System.Windows.Forms.TextBox txtDocumento;
		private System.Windows.Forms.TextBox txtFoneFantasia;
		private System.Windows.Forms.RadioButton rdbFisica;
		private System.Windows.Forms.RadioButton rdbJuridico;
	}
}