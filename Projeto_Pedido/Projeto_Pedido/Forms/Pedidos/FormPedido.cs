using Projeto_Pedido.Business.Repositories.EntitiesRepository;
using Projeto_Pedido.DAL.Entities;
using Projeto_Pedido.Forms.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Projeto_Pedido.Forms.Pedidos {

	public partial class FormPedido : FormUtil {

		private Pedido _pedido;

		public FormPedido(Pedido pedido)
		{
			InitializeComponent();
			_pedido = pedido;
			RepositorySingleton.GetInstance().PedidoAux = _pedido;
			AtualizaFormulario();
			FillFields02();

			EnableFields(this, false);
			ExibirBotoes();
		}

		private void ExibirBotoes()
		{
			btnCancel.Visible = true;
			btnSave.Visible = false;
			btnAdd.Visible = false;

			if(_pedido.Status == 1)
			{
				btnLock.Visible = true;
				btnOpen.Visible = false;
				btnEdit.Visible = true;
			}
			if (_pedido.Status == 4 || _pedido.Status == 3)
			{
				btnEdit.Visible = false;
				btnCancel.Visible = false;
				btnAdd.Visible = false;
			}
			
			if(_pedido.Status == 3)
			{
				btnLock.Visible = false;
				btnOpen.Visible = true;
			}
		}

		public FormPedido()
		{
			InitializeComponent();
			
			_pedido = RepositorySingleton.GetInstance().PedidoAux;
			txtEstado.Text = _pedido._StatusString;

			int lastId = PedidoRepository.GetMaxId(_pedido);
			if (lastId == 0)
				lastId = 1;
			else
				lastId++;

			txtNumero.Text = lastId.ToString().PadLeft(6, '0');
			txtCadasterDate.Text = _pedido.CadasterDate.ToString("dd/MM/yyyy HH:mm:ss");
			AtualizaFormulario();

			btnEdit.Visible = false;
			btnDelete.Visible = false;
		}

		private void btnMinimize_Click(object sender, System.EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void AtualizaFormulario()
		{
			this.Text = string.Empty;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

			if (RepositorySingleton.GetInstance().PedidoAux.ItensPedido != null)
			{
				var lista = RepositorySingleton.GetInstance().PedidoAux.ItensPedido;
				var binding = new BindingList<ItemPedido>(lista);
				grdItensPedido.DataSource = binding;
				grdItensPedido.Refresh();
			}

			var listaCliente = new List<Entidade>() { new Entidade() { Codigo = "", RazaoSocial = "", Id = 0 } };
			listaCliente.AddRange(EntityRepository.GetAll().Where(x => x.TipoCli == 1).ToList());
			var a = listaCliente.OrderBy(p => p.Codigo).ThenBy(p => p.RazaoSocial).ToList();

			ddlCliente.DataSource = a;
			ddlCliente.Refresh();
			this.ddlCliente.DisplayMember = "Descricao";
			this.ddlCliente.ValueMember = "Id";

			if (_pedido != null && _pedido.ClienteId > 0)
			{
				var index = (ddlCliente.DataSource as List<Entidade>).FindIndex(x => x.Id == _pedido.ClienteId);
				ddlCliente.SelectedIndex = index;
			}

			ddlTipoPagamento.DisplayMember = "Text";
			ddlTipoPagamento.ValueMember = "Value";

			var items = new[] {
				new { Text = " ", Value = "0" },
				new { Text = "A vista", Value = "1" },
				new { Text = "Cartão Débito", Value = "2" },
				new { Text = "Cartão Crédito", Value = "3" },
				new { Text = "Boleto", Value = "4" },
				new { Text = "Transferência", Value = "5" }
			};

			ddlTipoPagamento.DataSource = items;

			if (_pedido != null && _pedido.TipoPagamento > 0)
				ddlTipoPagamento.SelectedIndex = _pedido.TipoPagamento;
		}

		private void FillFields02()
		{
			txtNumero.Text = _pedido.Numero;

			txtCadasterDate.Text = _pedido.CadasterDate.ToString("dd/MM/yyyy HH:mm:ss");

			if (_pedido.ClienteId > 0)
			{
				var index = (ddlCliente.DataSource as List<Entidade>).FindIndex(x => x.Id == _pedido.ClienteId);
				ddlCliente.SelectedIndex = index;
			}

			txtEstado.Text = _pedido._StatusString;

			ddlTipoPagamento.SelectedIndex = _pedido.TipoPagamento;

			txtDesconto.Text = _pedido.Desconto.ToString("F");
			txtEntrada.Text = _pedido.Entrada.ToString("F");

			txtTotalBruto.Text = _pedido.TotalBruto.ToString("F");
			txtTotalLiquido.Text = _pedido.TotalLiquido.ToString("F");
			txtObservacao.Text = _pedido.Observacao;

			if (_pedido.ItensPedido != null && _pedido.ItensPedido.Count > 0)
			{
				var lista = _pedido.ItensPedido;
				var binding = new BindingList<ItemPedido>(lista);
				grdItensPedido.DataSource = binding;
				grdItensPedido.Refresh();
			}
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
		
		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			var cliente = ddlCliente.SelectedItem as Entidade;
			int tipoPagamento = 0;
			int.TryParse((ddlTipoPagamento.SelectedItem as dynamic).Value, out tipoPagamento);

			new FormItemPedido().ShowDialog();

			AtualizaFormulario();

			if (cliente != null)
			{
				var index = (ddlCliente.DataSource as List<Entidade>).FindIndex(x => x.Id == cliente.Id);
				ddlCliente.SelectedIndex = index;
			}

			ddlTipoPagamento.SelectedIndex = tipoPagamento;

			CalcularTotalBruto();
		}

		private void CalcularTotalBruto()
		{
			if(RepositorySingleton.GetInstance().PedidoAux != null && 
				RepositorySingleton.GetInstance().PedidoAux.ItensPedido != null &&
				RepositorySingleton.GetInstance().PedidoAux.ItensPedido.Count > 0)
			{
				var total = RepositorySingleton.GetInstance().PedidoAux.ItensPedido.Sum(x => x.Total);
				txtTotalLiquido.Text = total.ToString("F");
			}
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			DirtyFields(this, _pedido);
			DirtyFields02();
			if (_pedido.Id == 0)
			{
				PedidoRepository.Save(_pedido);
				_pedido.Id = PedidoRepository.GetMaxId(_pedido);

				if(_pedido.ItensPedido != null && _pedido.ItensPedido.Count > 0)
				{
					foreach (var item in _pedido.ItensPedido)
					{
						item.IdPedido = _pedido.Id;
						ItensPedidoRepository.Save(item);
					}
				}
			}
			else
			{
				//Verifica se o item é novo ou edição
				PedidoRepository.Update(_pedido);
				foreach (var item in _pedido.ItensPedido)
				{
					if (item.Id == 0)
					{
						item.IdPedido = _pedido.Id;
						PedidoItemRepository.Save(item);
					}
					else
						PedidoItemRepository.Update(item);
				}

				if (_pedido.ItensPedidoDelete != null && _pedido.ItensPedidoDelete.Count > 0)
				{
					foreach (var item in _pedido.ItensPedidoDelete)
					{
						PedidoItemRepository.Delete(item);
					}
				}
			}

			this.Close();
		}

		private void DirtyFields02()
		{
			int tipoPagamento = 0;
			int.TryParse((ddlTipoPagamento.SelectedItem as dynamic).Value, out tipoPagamento);
			_pedido.TipoPagamento = tipoPagamento;

			var cliente = (ddlCliente.SelectedItem as Entidade);
			if (cliente != null)
			{
				_pedido.Cliente = cliente;
				_pedido.ClienteId = cliente.Id;
			}
		}

		private void btnAddCliente_Click(object sender, System.EventArgs e)
		{
			int tipoPagamento = 0;
			int.TryParse((ddlTipoPagamento.SelectedValue as dynamic).Value, out tipoPagamento);
			var cliente = ddlCliente.SelectedItem as Entidade;

			new FormCliFornecedor().ShowDialog();
			AtualizaFormulario();

			if (cliente != null && cliente.Id > 0)
			{
				var index = (ddlCliente.DataSource as List<Entidade>).FindIndex(x => x.Id == cliente.Id);
				ddlCliente.SelectedIndex = index;
			}

			ddlTipoPagamento.SelectedIndex = tipoPagamento;
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			try
			{
				var result = MessageBox.Show("Deseja excluir esse Registro? ", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result  == DialogResult.Yes)
				{
					if (_pedido.ItensPedido != null && _pedido.ItensPedido.Count > 0)
					{
						for (int i = 0; i < _pedido.ItensPedido.Count; i++)
							ItensPedidoRepository.Delete(_pedido.ItensPedido[i]);
					}

					if (_pedido.ItensPedidoDelete != null && _pedido.ItensPedidoDelete.Count > 0)
					{
						for (int i = 0; i < _pedido.ItensPedidoDelete.Count; i++)
							ItensPedidoRepository.Delete(_pedido.ItensPedidoDelete[i]);
					}

					PedidoRepository.Delete(_pedido);
				}

				MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK);
				this.Close();

			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			btnEdit.Visible = false;
			btnSave.Visible = true;
			btnDelete.Visible = true;
			btnAdd.Visible = true;
			EnableFields(this, true);
			btnCancel.Visible = false;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			try
			{
				var result = MessageBox.Show("Deseja Cancelar esse Pedido? ", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					_pedido.Status = 4;
					PedidoRepository.Update(_pedido);
				}
				MessageBox.Show("Pedido Cancelado com sucesso!", "Cancelamento Sucesso", MessageBoxButtons.OK);
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
			}
		}

		private void btnLock_Click(object sender, EventArgs e)
		{
			try
			{
				var result = MessageBox.Show("Deseja Fechar esse Pedido? ", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					_pedido.Status = 3;
					PedidoRepository.Update(_pedido);
				}
				MessageBox.Show("Pedido Fechado com sucesso!", "Cancelamento Sucesso", MessageBoxButtons.OK);
				txtEstado.Text = _pedido._StatusString;
				ExibirBotoes();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
			}
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			try
			{
				var result = MessageBox.Show("Deseja Reabrir esse Pedido? ", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					_pedido.Status = 1;
					PedidoRepository.Update(_pedido);
				}
				MessageBox.Show("Pedido Aberto com sucesso!", "Cancelamento Sucesso", MessageBoxButtons.OK);
				txtEstado.Text = _pedido._StatusString;

				ExibirBotoes();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
			}
		}

		private void grdItensPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1 && e.ColumnIndex > -1)
			{
				int tipoPagamento = 0;
				int.TryParse((ddlTipoPagamento.SelectedItem as dynamic).Value, out tipoPagamento);
				var cliente = ddlCliente.SelectedItem as Entidade;

				var _itemPedido = (ItemPedido)grdItensPedido.Rows[e.RowIndex].DataBoundItem;
				
				FormItemPedido frmItemPedido = new FormItemPedido(_itemPedido);
				frmItemPedido.ShowDialog();

				AtualizaFormulario();

				ddlTipoPagamento.SelectedIndex = tipoPagamento;
				if (cliente != null && cliente.Id > 0)
				{
					var index = (ddlCliente.DataSource as List<Entidade>).FindIndex(x => x.Id == cliente.Id);
					ddlCliente.SelectedIndex = index;
				}
			}
		}
	}
}
