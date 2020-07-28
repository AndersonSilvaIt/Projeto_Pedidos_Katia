namespace Projeto_Pedido.Forms {
	partial class FormConfig {
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
			this.btnEnterprise = new FontAwesome.Sharp.IconButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnUnit = new FontAwesome.Sharp.IconButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnEnterprise
			// 
			this.btnEnterprise.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEnterprise.FlatAppearance.BorderSize = 2;
			this.btnEnterprise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEnterprise.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnEnterprise.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEnterprise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(87)))));
			this.btnEnterprise.IconChar = FontAwesome.Sharp.IconChar.Building;
			this.btnEnterprise.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(87)))));
			this.btnEnterprise.IconSize = 40;
			this.btnEnterprise.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnEnterprise.Location = new System.Drawing.Point(21, 42);
			this.btnEnterprise.Name = "btnEnterprise";
			this.btnEnterprise.Rotation = 0D;
			this.btnEnterprise.Size = new System.Drawing.Size(111, 91);
			this.btnEnterprise.TabIndex = 0;
			this.btnEnterprise.Text = "Cadastro Empresa";
			this.btnEnterprise.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEnterprise.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnEnterprise.UseVisualStyleBackColor = true;
			this.btnEnterprise.Click += new System.EventHandler(this.btnEnterprise_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnUnit);
			this.groupBox1.Controls.Add(this.btnEnterprise);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(383, 300);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// btnUnit
			// 
			this.btnUnit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUnit.FlatAppearance.BorderSize = 2;
			this.btnUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUnit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnUnit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(87)))));
			this.btnUnit.IconChar = FontAwesome.Sharp.IconChar.Flask;
			this.btnUnit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(87)))));
			this.btnUnit.IconSize = 40;
			this.btnUnit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnUnit.Location = new System.Drawing.Point(150, 42);
			this.btnUnit.Name = "btnUnit";
			this.btnUnit.Rotation = 0D;
			this.btnUnit.Size = new System.Drawing.Size(111, 91);
			this.btnUnit.TabIndex = 1;
			this.btnUnit.Text = "Unidade Medida";
			this.btnUnit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnUnit.UseVisualStyleBackColor = true;
			this.btnUnit.Click += new System.EventHandler(this.btnUnit_Click);
			// 
			// FormConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(188)))), ((int)(((byte)(246)))));
			this.ClientSize = new System.Drawing.Size(408, 324);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormConfig";
			this.Text = "Configurações";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private FontAwesome.Sharp.IconButton btnEnterprise;
		private System.Windows.Forms.GroupBox groupBox1;
		private FontAwesome.Sharp.IconButton btnUnit;
	}
}