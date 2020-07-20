using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Projeto_Pedido.Forms.Pedido {

	public partial class FormPedido : FormUtil {

		
		public FormPedido()
		{
			InitializeComponent();

			this.Text = string.Empty;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
		}

		private void btnMinimize_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnMaximize_Click(object sender, System.EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
				WindowState = FormWindowState.Maximized;
			else
				WindowState = FormWindowState.Normal;
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
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

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			new FormItemPedido().ShowDialog();

		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{



		}
	}
}
