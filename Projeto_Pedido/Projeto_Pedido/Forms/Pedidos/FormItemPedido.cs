﻿using Projeto_Pedido.Business.Repositories.EntitiesRepository;
using Projeto_Pedido.DAL.Entities;
using Projeto_Pedido.Forms.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Projeto_Pedido.Forms.Pedidos {
	public partial class FormItemPedido : FormUtil {

		private ItemPedido _itemPedido;

		public FormItemPedido()
		{
			InitializeComponent();

			AtualizaFormulario();
		}

		public FormItemPedido(ItemPedido itemPedido)
		{
			InitializeComponent();

			_itemPedido = itemPedido;

			AtualizaFormulario();

			EnableFields(this, false);
			btnEdit.Visible = true;
			btnSave.Visible = false;
			btnAddProduto.Visible = false;
		}

		private void AtualizaFormulario()
		{
			this.Text = string.Empty;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

			var listaProduto = new List<Product>();
		
			listaProduto = new List<Product>() { new Product() { Codigo = "", Descricao = "", Id = 0 } };
			listaProduto.AddRange(ProductRepository.GetAll());

			var a = listaProduto.OrderBy(p => p.Codigo).ThenBy(p => p.Descricao).ToList();
			ddlProduto.DataSource = a;
			ddlProduto.Refresh();
			ddlProduto.DisplayMember = "ProdutoString";
			ddlProduto.ValueMember = "Id";

			if (_itemPedido != null && _itemPedido.IdProduto > 0)
			{
				var index = (ddlProduto.DataSource as List<Product>).FindIndex(x => x.Id == _itemPedido.IdProduto);
				ddlProduto.SelectedIndex = index;
			}
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
			AtualizaFormulario();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (_itemPedido == null)
				_itemPedido = new ItemPedido();

			DirtyFields(this, _itemPedido);
			DirtyFields02();
			
			if (RepositorySingleton.GetInstance().PedidoAux == null)
				RepositorySingleton.GetInstance().PedidoAux = new DAL.Entities.Pedido();

			if (RepositorySingleton.GetInstance().PedidoAux.ItensPedido == null)
				RepositorySingleton.GetInstance().PedidoAux.ItensPedido = new List<ItemPedido>();

			if (_itemPedido.Id == 0)
				RepositorySingleton.GetInstance().PedidoAux.ItensPedido.Add(_itemPedido);
			else
			{
				var index = RepositorySingleton.GetInstance().PedidoAux.ItensPedido.FindIndex(x => x.Id == _itemPedido.Id);

				RepositorySingleton.GetInstance().PedidoAux.ItensPedido.RemoveAt(index);
				RepositorySingleton.GetInstance().PedidoAux.ItensPedido.Add(_itemPedido);
			}
			this.Close();
		}

		private void DirtyFields02()
		{
			var produto = (ddlProduto.SelectedItem as Product);
			if (produto != null)
			{
				_itemPedido.Produto = produto;
				_itemPedido.IdProduto = produto.Id;
			}
		}

		private void txtDesconto_Leave(object sender, EventArgs e)
		{
			var teste = "";
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			EnableFields(this, true);
			btnEdit.Visible = false;
			btnSave.Visible = true;
			btnAddProduto.Visible = true;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				var result = MessageBox.Show("Deseja excluir esse Registro? ", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					if(_itemPedido.Id == 0)
					{
						RepositorySingleton.GetInstance().PedidoAux.ItensPedido.Remove(_itemPedido);
					}
					else
					{
						RepositorySingleton.GetInstance().PedidoAux.ItensPedido.Remove(_itemPedido);
						if (RepositorySingleton.GetInstance().PedidoAux.ItensPedidoDelete == null)
							RepositorySingleton.GetInstance().PedidoAux.ItensPedidoDelete = new List<ItemPedido>();

						RepositorySingleton.GetInstance().PedidoAux.ItensPedidoDelete.Add(_itemPedido);
					}
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
