using Projeto_Pedido.Business.Repositories.EntitiesRepository;
using Projeto_Pedido.Business.Valitadors;
using Projeto_Pedido.DAL.Entities;
using Projeto_Pedido.Forms.Entidades;
using Projeto_Pedido.Forms.FormsConfig;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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
			EnableFields(this, false);
			btnSave.Visible = false;
			btnImage.Visible = false;
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
				if (ValidacoesTela() > 0)
					return;

				if (_produto == null)
					_produto = new Product();

				DirtyFields(this, _produto);
				DirtyFields02();

				ProdutoValidator.ValidarProduto(_produto);
				if (ValidacoesEntidade() > 0)
					return;

				if (_produto.Id == 0)
					ProductRepository.Save(_produto);
				else
					ProductRepository.Update02(_produto);

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private int ValidacoesTela()
		{
			try
			{
				decimal value = 0;
				if (!string.IsNullOrWhiteSpace(txtPrecoCusto.Text.Trim())
					&& !decimal.TryParse(txtPrecoCusto.Text.Trim().Replace(".", ""), out value))
					throw new ErrorMessageException("Preço de Custo, valor inválido, verifique!");

				if (!string.IsNullOrWhiteSpace(txtPrecoVenda.Text.Trim())
					&& !decimal.TryParse(txtPrecoVenda.Text.Trim().Replace(".", ""), out value))
					throw new ErrorMessageException("Preço de Venda, valor inválido, verifique!");
			}
			catch (ErrorMessageException eme)
			{
				MessageBox.Show(eme.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return 1;
			}
			catch (Exception ex)
			{

			}
			return 0;
		}

		private int ValidacoesEntidade()
		{
			if (ProdutoValidator.ListaValidacoes.Count > 0)
			{
				StringBuilder sb = new StringBuilder();
				foreach (var item in ProdutoValidator.ListaValidacoes)
				{
					sb.Append(item.Item1).Append(": ").Append(item.Item2);
					sb.AppendLine();
				}

				MessageBox.Show(sb.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return 1;
			}
			return 0;
		}

		private void DirtyFields02()
		{
			var fornecedor = (ddlFornecedor.SelectedItem as Entidade);
			if (fornecedor != null)
			{
				_produto.Fornecedor = fornecedor;
				_produto.IdFornecedor = fornecedor.Id;
			}

			var unidade = (ddlUnidadeMedida.SelectedItem as UnidadeMedida);
			if (unidade != null)
			{
				_produto.UM = unidade;
				_produto.UnidadeMedidaId = unidade.Id;
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
			listaFornecedor = new List<Entidade>() { new Entidade() { Codigo = "", RazaoSocial = "", Id = 0 } };
			listaFornecedor.AddRange(EntityRepository.GetAll().Where(x => x.TipoCli == 2).ToList());

			var a = listaFornecedor.OrderBy(p => p.Codigo).ThenBy(p => p.RazaoSocial).ToList();

			ddlFornecedor.DataSource = a;
			ddlFornecedor.Refresh();
			this.ddlFornecedor.DisplayMember = "Descricao";
			this.ddlFornecedor.ValueMember = "Id";

			var listaUnidade = new List<UnidadeMedida>();
			//Obtem os fornecedores tipo = 2
			listaUnidade = new List<UnidadeMedida>() { new UnidadeMedida() { Unidade = "", Descricao = "", Id = 0 } };
			listaUnidade.AddRange(UnidadeRepository.GetAll().ToList());

			var b = listaUnidade.OrderBy(p => p.Unidade).ToList();
			ddlUnidadeMedida.DataSource = b;
			ddlUnidadeMedida.Refresh();
			this.ddlUnidadeMedida.DisplayMember = "Unidade";
			this.ddlUnidadeMedida.ValueMember = "Id";

			if (_produto != null)
			{
				if (_produto.IdFornecedor > 0)
				{
					var index = (ddlFornecedor.DataSource as List<Entidade>).FindIndex(x => x.Id == _produto.IdFornecedor);
					ddlFornecedor.SelectedIndex = index;
				}

				if (_produto.UnidadeMedidaId > 0)
				{
					var index = (ddlUnidadeMedida.DataSource as List<UnidadeMedida>).FindIndex(x => x.Id == _produto.UnidadeMedidaId);
					ddlUnidadeMedida.SelectedIndex = index;
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

			txtPrecoCusto.Text = _produto.PrecoCusto.ToString("F");
			txtPrecoVenda.Text = _produto.PrecoVenda.ToString("F");

			if (_produto.IdFornecedor > 0)
			{
				var index = (ddlFornecedor.DataSource as List<Entidade>).FindIndex(x => x.Id == _produto.IdFornecedor);
				ddlFornecedor.SelectedIndex = index;
			}

			if (_produto.UnidadeMedidaId > 0)
			{
				var index = (ddlUnidadeMedida.DataSource as List<UnidadeMedida>).FindIndex(x => x.Id == _produto.UnidadeMedidaId);
				ddlUnidadeMedida.SelectedIndex = index;
			}

			txtObservacao.Text = _produto.Observacao;

			if (_produto.Imagem != null && _produto.Imagem.Count() > 1000)
				ImagemProduto.Image = ByteToImage(_produto.Imagem);
		}

		private void btnImage_Click(object sender, EventArgs e)
		{
			openFileDialog.Title = "Escolha a foto";
			openFileDialog.Filter = "JPEG|*.JPG|PNG|*.png";
			openFileDialog.ShowDialog();
		}

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
			string teste = "";
			ImagemProduto.Image = Image.FromFile(openFileDialog.FileName);
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			EnableFields(this, true);
			btnSave.Visible = true;
			btnEdit.Visible = false;
			btnImage.Visible = true;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				var result = MessageBox.Show("Deseja excluir esse Registro? ", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					ProductRepository.Delete(_produto);
				}
				MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK);
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
			}
		}

		private void btnAddUnidadeMedida_Click(object sender, EventArgs e)
		{
			new FormCadasterUnid().ShowDialog();
			AtualizaFormulario();
		}
	}
}
