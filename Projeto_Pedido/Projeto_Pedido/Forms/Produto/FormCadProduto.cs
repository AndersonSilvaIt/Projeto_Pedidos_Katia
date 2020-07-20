using Projeto_Pedido.Business.Repositories.EntitiesRepository;
using Projeto_Pedido.DAL.Entities;
using Projeto_Pedido.Forms.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Projeto_Pedido.Forms.Produto {
	public partial class FormCadProduto : FormUtil {
		private Product _produto;
		public FormCadProduto()
		{
			InitializeComponent();

			this.Text = string.Empty;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

			AtualizaFormulario();
		}

		public FormCadProduto(Product product)
		{
			InitializeComponent();
			_produto = product;
			this.Text = string.Empty;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

			AtualizaFormulario();
			FillFields02();
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

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (_produto == null)
					_produto = new Product();

				DirtyFields(this, _produto);
				DirtyFields02();
				if (_produto.Id == 0)
				{
					ProductRepository.Save(_produto);
				}
				else
				{
					ProductRepository.Update(_produto);
				}

				this.Close();

			}catch(Exception ex)
			{

			}
		}

		private void DirtyFields02()
		{
			var fornecedor = (ddlFornecedor.SelectedItem as Entidade);
			if(fornecedor != null)
			{
				_produto.Fornecedor = fornecedor;
				_produto.IdFornecedor = fornecedor.Id;
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnMaximize_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
				WindowState = FormWindowState.Maximized;
			else
				WindowState = FormWindowState.Normal;
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void AtualizaFormulario()
		{
			var listaFornecedor = new List<Entidade>();
			//Obtem os fornecedores tipo = 2
			listaFornecedor = new List<Entidade>() { new Entidade() { Codigo = "",  RazaoSocial = "", Id = 0 } };
			listaFornecedor.AddRange(EntityRepository.GetAll().Where(x => x.TipoCli == 2).ToList());

			var a = listaFornecedor.OrderBy(p => p.Codigo).ThenBy(p => p.RazaoSocial).ToList();

			ddlFornecedor.DataSource = a;
			ddlFornecedor.Refresh();
			this.ddlFornecedor.DisplayMember = "Descricao";
			this.ddlFornecedor.ValueMember = "Id";

			if (_produto != null)
			{
				if (_produto.IdFornecedor > 0)
				{
					var index = (ddlFornecedor.DataSource as List<Entidade>).FindIndex(x => x.Id == _produto.IdFornecedor);
					ddlFornecedor.SelectedIndex = index;
				}
			}
		}

		private void btnAddFornecedor_Click(object sender, EventArgs e)
		{
			new FormCliFornecedor().ShowDialog();
			AtualizaFormulario();
		}

		private void FillFields02()
		{
			txtCodigo.Text = _produto.Codigo;
			txtDescricao.Text = _produto.Descricao;

			// verificar  a unidade de medida, criar o combobox
			txtPrecoCusto.Text = _produto.PrecoCusto.ToString("F");
			txtPrecoVenda.Text = _produto.PrecoVenda.ToString("F");

			//VERIFICAR o campo tipo

			if(_produto.IdFornecedor > 0)
			{
				var index = (ddlFornecedor.DataSource as List<Entidade>).FindIndex(x => x.Id == _produto.IdFornecedor);
				ddlFornecedor.SelectedIndex = index;
			}

			txtObservacao.Text = _produto.Observacao;

			if(_produto.Imagem.Count() > 0)
				ImagemProduto.Image = ByteToImage(_produto.Imagem);
		}

		private void btnImage_Click(object sender, EventArgs e)
		{
			openFileDialog.FileName = "teste";
			openFileDialog.Title = "Escolha a foto";
			openFileDialog.Filter = "JPEG|*.JPG|PNG|*.png";
			openFileDialog.ShowDialog();
		}

		/*public byte[] ImageToByte(Image image, System.Drawing.Imaging.ImageFormat format)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				// Convert Image to byte[]
				image.Save(ms, format);
				byte[] imageBytes = ms.ToArray();
				return imageBytes;
			}
		}
		*/
		public Image ByteToImage(byte[] imageBytes)
		{
			// Convert byte[] to Image
			MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
			ms.Write(imageBytes, 0, imageBytes.Length);
			Image image = new Bitmap(ms);
			return image;
		}

		private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			ImagemProduto.Image = Image.FromFile(openFileDialog.FileName);
		}
	}
}
