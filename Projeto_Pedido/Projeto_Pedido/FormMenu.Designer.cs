using System.Drawing;

namespace Projeto_Pedido {
	partial class FormMenu {
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
			this.panelMenu = new System.Windows.Forms.Panel();
			this.btnClienteFornecedor = new FontAwesome.Sharp.IconButton();
			this.btnPedidos = new FontAwesome.Sharp.IconButton();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.btnHome = new System.Windows.Forms.PictureBox();
			this.panelTitleBar = new System.Windows.Forms.Panel();
			this.btnMaximize = new FontAwesome.Sharp.IconButton();
			this.btnMinimize = new FontAwesome.Sharp.IconButton();
			this.btnClose = new FontAwesome.Sharp.IconButton();
			this.lblTitleChildForm = new System.Windows.Forms.Label();
			this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
			this.panelShadow = new System.Windows.Forms.Panel();
			this.panelDesktop = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelMenu.SuspendLayout();
			this.panelLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
			this.panelTitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
			this.panelDesktop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(188)))), ((int)(((byte)(246)))));
			this.panelMenu.Controls.Add(this.btnClienteFornecedor);
			this.panelMenu.Controls.Add(this.btnPedidos);
			this.panelMenu.Controls.Add(this.panelLogo);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(136, 479);
			this.panelMenu.TabIndex = 2;
			// 
			// btnClienteFornecedor
			// 
			this.btnClienteFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClienteFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnClienteFornecedor.FlatAppearance.BorderSize = 0;
			this.btnClienteFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClienteFornecedor.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnClienteFornecedor.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClienteFornecedor.ForeColor = System.Drawing.Color.White;
			this.btnClienteFornecedor.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
			this.btnClienteFornecedor.IconColor = System.Drawing.Color.White;
			this.btnClienteFornecedor.IconSize = 16;
			this.btnClienteFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClienteFornecedor.Location = new System.Drawing.Point(0, 137);
			this.btnClienteFornecedor.Name = "btnClienteFornecedor";
			this.btnClienteFornecedor.Rotation = 0D;
			this.btnClienteFornecedor.Size = new System.Drawing.Size(136, 48);
			this.btnClienteFornecedor.TabIndex = 5;
			this.btnClienteFornecedor.Text = "Cliente Fornecedor";
			this.btnClienteFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClienteFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClienteFornecedor.UseVisualStyleBackColor = true;
			this.btnClienteFornecedor.Click += new System.EventHandler(this.btnClienteFornecedor_Click);
			// 
			// btnPedidos
			// 
			this.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnPedidos.FlatAppearance.BorderSize = 0;
			this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPedidos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnPedidos.ForeColor = System.Drawing.Color.White;
			this.btnPedidos.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
			this.btnPedidos.IconColor = System.Drawing.Color.White;
			this.btnPedidos.IconSize = 16;
			this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPedidos.Location = new System.Drawing.Point(0, 89);
			this.btnPedidos.Name = "btnPedidos";
			this.btnPedidos.Rotation = 0D;
			this.btnPedidos.Size = new System.Drawing.Size(136, 48);
			this.btnPedidos.TabIndex = 4;
			this.btnPedidos.Text = "Pedidos";
			this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPedidos.UseVisualStyleBackColor = true;
			this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
			// 
			// panelLogo
			// 
			this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(188)))), ((int)(((byte)(246)))));
			this.panelLogo.Controls.Add(this.btnHome);
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(136, 89);
			this.panelLogo.TabIndex = 3;
			// 
			// btnHome
			// 
			this.btnHome.Image = global::Projeto_Pedido.Properties.Resources.Logo_Asa_Nova_sem_fundo_png;
			this.btnHome.Location = new System.Drawing.Point(12, 23);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(100, 50);
			this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnHome.TabIndex = 0;
			this.btnHome.TabStop = false;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// panelTitleBar
			// 
			this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(152)))), ((int)(((byte)(231)))));
			this.panelTitleBar.Controls.Add(this.btnMaximize);
			this.panelTitleBar.Controls.Add(this.btnMinimize);
			this.panelTitleBar.Controls.Add(this.btnClose);
			this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
			this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
			this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitleBar.Location = new System.Drawing.Point(136, 0);
			this.panelTitleBar.Name = "panelTitleBar";
			this.panelTitleBar.Size = new System.Drawing.Size(709, 73);
			this.panelTitleBar.TabIndex = 3;
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
			this.btnMaximize.Location = new System.Drawing.Point(652, 3);
			this.btnMaximize.Name = "btnMaximize";
			this.btnMaximize.Rotation = 0D;
			this.btnMaximize.Size = new System.Drawing.Size(24, 22);
			this.btnMaximize.TabIndex = 4;
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
			this.btnMinimize.Location = new System.Drawing.Point(622, 3);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Rotation = 0D;
			this.btnMinimize.Size = new System.Drawing.Size(24, 22);
			this.btnMinimize.TabIndex = 3;
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
			this.btnClose.Location = new System.Drawing.Point(682, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Rotation = 0D;
			this.btnClose.Size = new System.Drawing.Size(24, 22);
			this.btnClose.TabIndex = 2;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblTitleChildForm
			// 
			this.lblTitleChildForm.AutoSize = true;
			this.lblTitleChildForm.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(193)))));
			this.lblTitleChildForm.Location = new System.Drawing.Point(63, 32);
			this.lblTitleChildForm.Name = "lblTitleChildForm";
			this.lblTitleChildForm.Size = new System.Drawing.Size(43, 19);
			this.lblTitleChildForm.TabIndex = 1;
			this.lblTitleChildForm.Text = "Home";
			// 
			// iconCurrentChildForm
			// 
			this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(152)))), ((int)(((byte)(231)))));
			this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(193)))));
			this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
			this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(193)))));
			this.iconCurrentChildForm.Location = new System.Drawing.Point(25, 23);
			this.iconCurrentChildForm.Name = "iconCurrentChildForm";
			this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
			this.iconCurrentChildForm.TabIndex = 0;
			this.iconCurrentChildForm.TabStop = false;
			// 
			// panelShadow
			// 
			this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(193)))));
			this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelShadow.Location = new System.Drawing.Point(136, 73);
			this.panelShadow.Name = "panelShadow";
			this.panelShadow.Size = new System.Drawing.Size(709, 5);
			this.panelShadow.TabIndex = 4;
			// 
			// panelDesktop
			// 
			this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(127)))), ((int)(((byte)(221)))));
			this.panelDesktop.Controls.Add(this.pictureBox1);
			this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktop.Location = new System.Drawing.Point(136, 78);
			this.panelDesktop.Name = "panelDesktop";
			this.panelDesktop.Size = new System.Drawing.Size(709, 401);
			this.panelDesktop.TabIndex = 5;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Image = global::Projeto_Pedido.Properties.Resources.Logo_Asa_Nova_sem_fundo_png;
			this.pictureBox1.Location = new System.Drawing.Point(216, 111);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(270, 148);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// FormMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(845, 479);
			this.Controls.Add(this.panelDesktop);
			this.Controls.Add(this.panelShadow);
			this.Controls.Add(this.panelTitleBar);
			this.Controls.Add(this.panelMenu);
			this.Name = "FormMenu";
			this.Opacity = 0.9D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu";
			this.panelMenu.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
			this.panelTitleBar.ResumeLayout(false);
			this.panelTitleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
			this.panelDesktop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.Panel panelLogo;
		private FontAwesome.Sharp.IconButton btnPedidos;
		private System.Windows.Forms.Panel panelTitleBar;
		private FontAwesome.Sharp.IconButton btnClienteFornecedor;
		private System.Windows.Forms.PictureBox btnHome;
		private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
		private System.Windows.Forms.Label lblTitleChildForm;
		private System.Windows.Forms.Panel panelShadow;
		private System.Windows.Forms.Panel panelDesktop;
		private FontAwesome.Sharp.IconButton btnClose;
		private FontAwesome.Sharp.IconButton btnMinimize;
		private FontAwesome.Sharp.IconButton btnMaximize;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

