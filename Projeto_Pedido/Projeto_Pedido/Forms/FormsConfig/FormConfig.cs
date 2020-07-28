using Projeto_Pedido.Forms.FormsConfig;
using System.Windows.Forms;

namespace Projeto_Pedido.Forms {
	public partial class FormConfig : Form {
		public FormConfig()
		{

			InitializeComponent();
		}

		private void btnEnterprise_Click(object sender, System.EventArgs e)
		{
			new FormEmpresa().ShowDialog();
		}

		private void btnUnit_Click(object sender, System.EventArgs e)
		{
			new FormUnidList().ShowDialog();
		}
	}
}
