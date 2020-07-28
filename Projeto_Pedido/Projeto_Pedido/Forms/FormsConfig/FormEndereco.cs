using Projeto_Pedido.DAL.Entities;
using System.Windows.Forms;

namespace Projeto_Pedido.Forms.FormsConfig {
	public partial class FormEndereco : FormUtil {
		private Pedido _pedido;
		private EnderecoEntrega _endereo;

		public FormEndereco()
		{
			InitializeComponent();

			this.Text = string.Empty;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
		}

		public FormEndereco(Pedido pedido, EnderecoEntrega endereco)
		{
			InitializeComponent();

			this.Text = string.Empty;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

			DirtyUF(ddlUF);
			_pedido = pedido;

			if (endereco != null && _pedido.NovoEnderecoEntrega ==null && _pedido.EnderecoEntrega == null)
			{
				_endereo = endereco;
			}
			else
			{
				if (_pedido.NovoEnderecoEntrega != null)
					_endereo = _pedido.NovoEnderecoEntrega;
				else
					_endereo = _pedido.EnderecoEntrega;
			}

			lblPedido.Text = _pedido.Numero;

			FillFields02();
		}

		private void FillFields02()
		{
			txtRua.Text = _endereo.Rua;
			txtNumero.Text = _endereo.Numero;
			txtBairro.Text = _endereo.Bairro;
			txtCidade.Text = _endereo.Cidade;
			if (!string.IsNullOrWhiteSpace(_endereo.Estado))
			{
				var index = listaUF.Find(x => x.Value == _endereo.Estado).Key;
				ddlUF.SelectedIndex = index;
			}
			txtCEP.Text = _endereo.CEP;
			txtComplemento.Text = _endereo.Complemento;
			txtDestinatario.Text = _endereo.Destinatario;
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

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			EnderecoEntrega novoEndereco = new EnderecoEntrega();

			DirtyFields(this, novoEndereco);

			novoEndereco.Estado = (ddlUF.SelectedItem as dynamic).Text;

			_pedido.NovoEnderecoEntrega = novoEndereco;
			this.Close();
		}

		private void btnEdit_Click(object sender, System.EventArgs e)
		{

		}
	}
}
