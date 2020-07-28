using Projeto_Pedido.Business.Repositories.EntitiesRepository;
using Projeto_Pedido.DAL.Entities;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Projeto_Pedido.Forms.FormsConfig {
	public partial class FormUnidList : Form {

		public FormUnidList()
		{
			InitializeComponent();

			this.Text = string.Empty;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

			Search();
		}

		private void btnMinimize_Click(object sender, System.EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
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
			this.Close();
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

		private void Search()
		{
			var lista = UnidadeRepository.GetAll();
			var binding = new BindingList<UnidadeMedida>(lista);
			grdUnidade.DataSource = binding;
			grdUnidade.Refresh();
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			new FormCadasterUnid().ShowDialog();

			Search();
		}

		private void grdUnidade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1 && e.ColumnIndex > -1)
			{
				var _unidade = (UnidadeMedida)grdUnidade.Rows[e.RowIndex].DataBoundItem;

				FormCadasterUnid frmCadUnidade = new FormCadasterUnid(_unidade);
				frmCadUnidade.ShowDialog();
				
				Search();
			}
		}
	}
}
