using Projeto_Pedido.Forms.Produto;
using System;
using System.Windows.Forms;

namespace Projeto_Pedido.Forms {
	public partial class FormListProduto : Form {
		public FormListProduto()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			new FormCadProduto().ShowDialog();
		}
	}
}
