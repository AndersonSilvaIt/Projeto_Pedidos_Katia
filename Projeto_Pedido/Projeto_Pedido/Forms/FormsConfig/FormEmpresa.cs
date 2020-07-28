using Projeto_Pedido.Business.Repositories.EntitiesRepository;
using Projeto_Pedido.DAL.Entities;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Projeto_Pedido.Forms {
	public partial class FormEmpresa: FormUtil {
		Empresa _empresa;
		public FormEmpresa() {
			InitializeComponent();

			this.Text = string.Empty;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
			DirtyUF(ddlUF);
			var lista = EmpresaRepository.GetAll();
			if (lista != null && lista.Count > 0)
			{
				EnableFields(this, false);
				btnSave.Visible = false;
				btnImage.Visible = false;
				_empresa = lista[0];
				FillFields02();
			}
		}

		private void FillFields02()
		{
			if (_empresa.TipoCli == 1)
				rdbFisica.Checked = true;
			else
				rdbFisica.Checked = true;

			txtRazaoSocial.Text = _empresa.RazaoSocial;
			txtNomeFantasia.Text = _empresa.NomeFantasia;

			txtDocumento.Text = _empresa.Documento;
			//Verificar o preenchimento da imagem
			txtEmail.Text = _empresa.Email;
			txtFoneFixo.Text = _empresa.FoneFixo;
			txtSite.Text = _empresa.Site;

			txtRua.Text = _empresa.Rua;
			txtBairro.Text = _empresa.Bairro;
			txtCidade.Text = _empresa.Cidade;
			if (!string.IsNullOrWhiteSpace(_empresa.Estado))
			{
				var index = listaUF.Find(x => x.Value == _empresa.Estado).Key;
				ddlUF.SelectedIndex = index;
			}
			txtCEP.Text = _empresa.CEP;
			txtComplemento.Text = _empresa.Complemento;

			if (_empresa.Imagem != null && _empresa.Imagem.Count() > 0)
				ImagemLogo.Image = ByteToImage(_empresa.Imagem);
		}

		public Image ByteToImage(byte[] imageBytes)
		{
			// Convert byte[] to Image
			MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
			ms.Write(imageBytes, 0, imageBytes.Length);
			Image image = new Bitmap(ms);
			return image;
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

		private void btnClose_Click(object sender, System.EventArgs e)
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

		private void btnMinimize_Click(object sender, System.EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if (_empresa == null)
				_empresa = new Empresa();

			DirtyFields(this, _empresa);
			DirtyFields02();

			if (!string.IsNullOrWhiteSpace(openFileDialog.FileName))
			{
				var caminhoRaiz = Directory.GetDirectoryRoot(AppDomain.CurrentDomain.BaseDirectory);
				string pathRoot = caminhoRaiz + "SistemaPedido";
				string pathCopy = pathRoot += "\\" + openFileDialog.SafeFileName;
				_empresa.CaminhoImagem = pathCopy;
				File.Copy(openFileDialog.FileName, pathCopy, true);
			}
			
			if (_empresa.Id == 0)
				EmpresaRepository.Save(_empresa);
			else
				EmpresaRepository.Update(_empresa);

			this.Close();
		}

		private void DirtyFields02()
		{
			if (rdbFisica.Checked)
				_empresa.TipoCli = 1;
			else
				_empresa.TipoCli = 2;

			_empresa.Estado = (ddlUF.SelectedItem as dynamic).Text;
		}

		private void btnEdit_Click(object sender, System.EventArgs e)
		{
			btnEdit.Visible = false;
			btnSave.Visible = true;
			btnImage.Visible = true;
			EnableFields(this, true);
		}

		private void btnImage_Click(object sender, System.EventArgs e)
		{
			openFileDialog.FileName = "teste";
			openFileDialog.Title = "Escolha a foto";
			openFileDialog.Filter = "JPEG|*.JPG|PNG|*.png";
			openFileDialog.ShowDialog();
		}

		private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			ImagemLogo.Image = Image.FromFile(openFileDialog.FileName);
		}
	}
}
