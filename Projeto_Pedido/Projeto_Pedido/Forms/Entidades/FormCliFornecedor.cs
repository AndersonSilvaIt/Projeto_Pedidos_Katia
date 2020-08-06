using Projeto_Pedido.Business.Repositories.EntitiesRepository;
using Projeto_Pedido.Business.Valitadors;
using Projeto_Pedido.DAL.Entities;
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Pedido.Forms.Entidades {
	public partial class FormCliFornecedor : FormUtil {

		private Entidade _entidade;

		public FormCliFornecedor()
		{
			InitializeComponent();
			
			AtualizaFormulario();
		}
		public FormCliFornecedor(Entidade entidade)
		{
			InitializeComponent();
			this._entidade = entidade;
			AtualizaFormulario();
			FillFields02();
			EnableFields(this, false);
			btnSave.Visible = false;
			//Caso já conter algum cadastro de produto ou pedido vinculados com essa entidade, eu não posso trocar o tipo de entidade
			if (EntityRepository.VerificaVinculoProduto_Pedido(entidade.Id))
			{
				rdbCliente.Enabled = false;
				rdbFornecedor.Enabled = false;
			}
		}

		private void FillFields02()
		{
			txtCodigo.Text = _entidade.Codigo;
			if (_entidade.TipoCli == 1)
				rdbCliente.Checked = true;
			else
				rdbCliente.Checked = true;

			txtRazaoSocial.Text = _entidade.RazaoSocial;
			txtNomeFantasia.Text = _entidade.NomeFantasia;

			ddlTipoDocumento.SelectedIndex = _entidade.TipoDocumento - 1;
			txtDocumento.Text = _entidade.Documento;
			//Verificar o preenchimento da imagem
			txtContato.Text = _entidade.Contato;
			txtEmail.Text = _entidade.Email;
			txtFoneFixo.Text = _entidade.FoneFixo;
			txtFoneCelular.Text = _entidade.FoneCelular;
			txtSite.Text = _entidade.Site;
				
			txtRua.Text = _entidade.Rua;
			txtNumero.Text = _entidade.Numero;
			txtBairro.Text = _entidade.Bairro;
			txtCidade.Text = _entidade.Cidade;
			if (!string.IsNullOrWhiteSpace(_entidade.Estado))
			{
				var index = listaUF.Find(x => x.Value == _entidade.Estado).Key;
				ddlUF.SelectedIndex = index;
			}
			txtCEP.Text = _entidade.CEP;
			txtComplemento.Text = _entidade.Complemento;
			txtObservacao.Text = _entidade.Observacao;
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
			if (_entidade == null)
				_entidade = new Entidade();

			DirtyFields(this, _entidade);
			DirtyFields02();

			EntityValidator.ValidarEntidade(_entidade);
			if (ValidacoesEntidade() > 0)
				return;

			if (_entidade.Id == 0)
				EntityRepository.Save(_entidade);
			else
				EntityRepository.Update02(_entidade);

			this.Close();
		}

		private void DirtyFields02()
		{
			if (rdbCliente.Checked)
				_entidade.TipoCli = 1;
			else
				_entidade.TipoCli = 2;

			int tipoDoc = 0;
			int.TryParse((ddlTipoDocumento.SelectedItem as dynamic).Value, out tipoDoc);

			_entidade.TipoDocumento = tipoDoc;
			_entidade.Estado = (ddlUF.SelectedItem as dynamic).Text;
		}

		private void AtualizaFormulario()
		{
			this.Text = string.Empty;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

			ddlTipoDocumento.DisplayMember = "Text";
			ddlTipoDocumento.ValueMember = "Value";

			var items = new[] {
				new { Text = "P. Física", Value = "1" },
				new { Text = "P. Jurídica", Value = "2" }
			};

			ddlTipoDocumento.DataSource = items;

			DirtyUF(ddlUF);
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (EntityRepository.VerificaVinculoProduto_Pedido(_entidade.Id))
				{
					MessageBox.Show("Esse regiso possui vínculo com Produto ou Produto, não pode ser excluído!", "Aviso", MessageBoxButtons.OK);
					return;
				}

				var result = MessageBox.Show("Deseja excluir esse Registro? ", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					EntityRepository.Delete(_entidade);
				}

				MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK);
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			EnableFields(this, true);
			btnSave.Visible = true;
			btnEdit.Visible = false;
		}

		private int ValidacoesEntidade()
		{
			if (EntityValidator.ListaValidacoes.Count > 0)
			{
				StringBuilder sb = new StringBuilder();
				foreach (var item in EntityValidator.ListaValidacoes)
				{
					sb.Append(item.Item1).Append(": ").Append(item.Item2);
					sb.AppendLine();
				}

				MessageBox.Show(sb.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return 1;
			}
			return 0;
		}

	}
}
