using Projeto_Pedido.Business.Repositories.EntitiesRepository;
using System;
using System.Windows.Forms;

namespace Projeto_Pedido.Forms.Pedido {

	public partial class FormListPedido : Form {
		public FormListPedido()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			RepositorySingleton.GetInstance().PedidoAux = new DAL.Entities.Pedido();

			new FormPedido().ShowDialog();
		}
	}
}
