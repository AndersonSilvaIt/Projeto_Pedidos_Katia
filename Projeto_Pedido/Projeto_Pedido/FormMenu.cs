using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Projeto_Pedido.Forms;
using Projeto_Pedido.Forms.Entidades;
using Projeto_Pedido.Forms.Pedidos;

namespace Projeto_Pedido {
	public partial class FormMenu: Form {

		//Fields
		private IconButton currentBtn;
		private Panel leftBorderBtn;
		private Form currentChildForm;

		public FormMenu() {

			InitializeComponent();
			leftBorderBtn = new Panel();
			leftBorderBtn.Size = new Size(7, 60);
			panelMenu.Controls.Add(leftBorderBtn);

			// Form
			this.Text = string.Empty;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
		}

		// Structs

		//private struct RGBColors {
		//	public static Color color1 = Color.FromArgb(172,126,241	);
		//	public static Color color2 = Color.FromArgb(249, 118, 176);
		//	public static Color color3 = Color.FromArgb(253,138,114	);
		//	public static Color color4 = Color.FromArgb(95,77,221);
		//	public static Color color5 = Color.FromArgb(249,88,155);
		//	public static Color color6 = Color.FromArgb(24,161,251 );
		//}

		//Methods
		private void ActivateButton(object senderBtn)
		{
			if(senderBtn != null)
			{
				DisableButton();
				currentBtn = (IconButton)senderBtn;
				currentBtn.BackColor = Color.FromArgb(68, 68, 193);
				currentBtn.ForeColor = Color.White;
				currentBtn.TextAlign = ContentAlignment.MiddleCenter;
				currentBtn.IconColor = Color.White;
				currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
				currentBtn.ImageAlign = ContentAlignment.MiddleRight;

				//left border
				//leftBorderBtn.BackColor = color;
				leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
				leftBorderBtn.Visible = true;
				leftBorderBtn.BringToFront();

				iconCurrentChildForm.IconChar = currentBtn.IconChar;
				iconCurrentChildForm.IconColor = currentBtn.IconColor;
			}
		}

		private void DisableButton()
		{
			if(currentBtn != null)
			{
				currentBtn.BackColor = Color.FromArgb(178,188,246);
				currentBtn.ForeColor = Color.FromArgb(7, 7, 87);
				
				currentBtn.TextAlign = ContentAlignment.MiddleLeft;
				currentBtn.IconColor = Color.FromArgb(7, 7, 87);
				currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
				currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
			}
		}

		private void OpenChildForms(Form childForm)
		{
			if(currentChildForm != null)
				currentChildForm.Close();

			currentChildForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;

			panelDesktop.Controls.Add(childForm);
			panelDesktop.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			lblTitleChildForm.Text = childForm.Text;
		}

		private void btnPedidos_Click(object sender, System.EventArgs e)
		{
			ActivateButton(sender);
			OpenChildForms(new FormListPedido());
		}

		private void btnClienteFornecedor_Click(object sender, System.EventArgs e)
		{
			ActivateButton(sender);
			OpenChildForms(new FormListEntidades());
		}

		private void btnHome_Click(object sender, System.EventArgs e)
		{
			Reset();
		}

		private void Reset()
		{
			DisableButton();
			leftBorderBtn.Visible = false;

			iconCurrentChildForm.IconChar = IconChar.Home;
			iconCurrentChildForm.IconColor = Color.MediumPurple;
			lblTitleChildForm.Text = "Home";

			if (currentChildForm != null)
				currentChildForm.Close();
		}

		//DragForm

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();

		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

		private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnMaximize_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
				WindowState = FormWindowState.Maximized;
			else
				WindowState = FormWindowState.Normal;
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void btnProduto_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
			OpenChildForms(new FormListProduto());
		}
	}
}
