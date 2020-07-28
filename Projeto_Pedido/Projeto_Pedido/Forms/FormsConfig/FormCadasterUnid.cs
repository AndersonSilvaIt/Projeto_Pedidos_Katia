using Projeto_Pedido.Business.Repositories.EntitiesRepository;
using Projeto_Pedido.DAL.Entities;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Projeto_Pedido.Forms.FormsConfig {
	public partial class FormCadasterUnid : FormUtil {

		private UnidadeMedida _unidade;

		public FormCadasterUnid()
		{
			InitializeComponent();
			AtualizaFormulario();
		}

		public FormCadasterUnid(UnidadeMedida unidade)
		{
			InitializeComponent();
			AtualizaFormulario();
			_unidade = unidade;
			FillFields02();
			btnSave.Visible = false;
			EnableFields(this, false);
		}

		private void FillFields02()
		{
			txtUnidade.Text = _unidade.Unidade;
			txtDescricao.Text = _unidade.Descricao;
		}

		private void AtualizaFormulario()
		{
			this.Text = string.Empty;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (_unidade == null)
					_unidade = new UnidadeMedida();

				DirtyFields(this, _unidade);

				if(_unidade.Id == 0)
				{
					UnidadeRepository.Save(_unidade);
				}
				else
				{
					UnidadeRepository.Update(_unidade);
				}

				this.Close();

			}catch(Exception ex)
			{

			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			EnableFields(this, true);
			btnSave.Visible = true;
			btnEdit.Visible = false;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				var result = MessageBox.Show("Deseja excluir esse Registro? ", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					UnidadeRepository.Delete(_unidade);
				}

				MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK);
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
			}
		}
	}
}
