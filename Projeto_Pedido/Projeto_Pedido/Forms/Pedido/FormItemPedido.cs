using Projeto_Pedido.Business.Repositories.EntitiesRepository;
using Projeto_Pedido.DAL.Entities;
using Projeto_Pedido.Forms.Produto;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Projeto_Pedido.Forms.Pedido {
	public partial class FormItemPedido : FormUtil {

		private ItemPedido _itemPedido;

		public FormItemPedido()
		{
			InitializeComponent();
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void btnMaximize_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
				WindowState = FormWindowState.Maximized;
			else
				WindowState = FormWindowState.Normal;
		}

		private void btnClose_Click(object sender, EventArgs e)
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

		private void btnAddProduto_Click(object sender, EventArgs e)
		{
			new FormCadProduto().ShowDialog();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			DirtyFields(this, _itemPedido);

			if(RepositorySingleton.GetInstance().PedidoAux == null)
				RepositorySingleton.GetInstance().PedidoAux = new DAL.Entities.Pedido();

			if(_itemPedido.Id == 0)
				RepositorySingleton.GetInstance().PedidoAux.ItensPedido.Add(_itemPedido);
			else
			{
				var index = RepositorySingleton.GetInstance().PedidoAux.ItensPedido.FindIndex(x => x.Id == _itemPedido.Id);

				RepositorySingleton.GetInstance().PedidoAux.ItensPedido.RemoveAt(index);
				RepositorySingleton.GetInstance().PedidoAux.ItensPedido.Add(_itemPedido);
			}
				
		}
	}
}
