using Projeto_Pedido.Business.Repositories.EntitiesRepository;
using Projeto_Pedido.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_Pedido.Forms.Pedidos {

	public partial class FormListPedido : FormUtil {
		public FormListPedido()
		{
			InitializeComponent();
			
			AtualizaFormulario();
		}

		private void Search()
		{
			string numero = txtNumero.Text;
			int clientId = 0;
			var cliente = (ddlCliente.SelectedItem as Entidade);
			if (cliente != null)
				clientId = cliente.Id;

			int tipoPagamento = 0;
			int.TryParse((ddlTipoPagamento.SelectedItem as dynamic).Value, out tipoPagamento);

			int status = 0;
			int.TryParse((ddlStatus.SelectedItem as dynamic).Value, out status);

			DateTime dtPedidoInicio = DateTime.MinValue;
			if (!string.IsNullOrWhiteSpace(txtDataPedidoInicio.Text.Replace("/", "").Trim()))
			{
				DateTime.TryParse(txtDataPedidoInicio.Text, out dtPedidoInicio);
				
				if (!string.IsNullOrWhiteSpace(txtHoraPedidoInicio.Text.Replace(":", "").Trim()))
				{
					DateTime horaPedido;
					DateTime.TryParse(txtHoraPedidoInicio.Text, out horaPedido);

					dtPedidoInicio.AddMinutes(horaPedido.Minute).AddSeconds(horaPedido.Second);
				}
			}

			DateTime dtPedidoFim = DateTime.MinValue;
			if (!string.IsNullOrWhiteSpace(txtDataPedidoFim.Text.Replace("/", "").Trim()))
			{
				DateTime.TryParse(txtDataPedidoFim.Text, out dtPedidoFim);

				if (!string.IsNullOrWhiteSpace(txtHoraPedidoFim.Text.Replace(":", "").Trim()))
				{
					DateTime horaPedidoFim;
					DateTime.TryParse(txtHoraPedidoFim.Text, out horaPedidoFim);

					dtPedidoFim.AddMinutes(horaPedidoFim.Minute).AddSeconds(horaPedidoFim.Second);
				}
			}

			var lista = PedidoRepository.SearchPedido(numero, clientId, status, dtPedidoInicio, dtPedidoFim, tipoPagamento);
			PedidoRepository.PreencherCliente(lista);
			//PedidoRepository.ObterEnderecoEntregaPorPedido(lista);

			for (int i = 0; i < lista.Count; i++)
			{
				lista[i].ItensPedido = PedidoRepository.GetListaItemPedido(lista[i].Id).ToList();
			}

			var binding = new BindingList<Pedido>(lista);
			grdPedido.DataSource = binding;
			grdPedido.Refresh();
		}

		private void AtualizaFormulario()
		{
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

			ddlStatus.DisplayMember = "Text";
			ddlStatus.ValueMember = "Value";

			var items02 = new[] {
				new { Text = " ", Value = "0" },
				new { Text = "Aberto", Value = "1" },
				new { Text = "Aguardando Aprovação", Value = "2" },
				new { Text = "Fechado", Value = "3" },
				new { Text = "Cancelado", Value = "4" }
			};

			ddlTipoPagamento.DisplayMember = "Text";
			ddlTipoPagamento.ValueMember = "Value";

			ddlStatus.DataSource = items02;

			var listaCliente = new List<Entidade>() { new Entidade() { Codigo = "", RazaoSocial = "", Id = 0 } };
			listaCliente.AddRange(EntityRepository.GetAll().Where(x => x.TipoCli == 1).ToList());

			var a = listaCliente.OrderBy(p => p.Codigo).ThenBy(p => p.RazaoSocial).ToList();

			ddlCliente.DataSource = a;
			ddlCliente.Refresh();
			this.ddlCliente.DisplayMember = "Descricao";
			this.ddlCliente.ValueMember = "Id";

			Search();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			RepositorySingleton.GetInstance().PedidoAux = new DAL.Entities.Pedido();

			new FormPedido().ShowDialog();
			AtualizaFormulario();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				DateTime dtPedidoInicio;
				if (!string.IsNullOrWhiteSpace(txtDataPedidoInicio.Text.Replace("/", "").Trim()))
				{
					if (!DateTime.TryParse(txtDataPedidoInicio.Text, out dtPedidoInicio))
						throw new ErrorMessageException("Data Início inválida, verifique!");
					
					if(!string.IsNullOrWhiteSpace(txtHoraPedidoInicio.Text.Replace(":", "").Trim()))
					{
						DateTime horaPedidoInicio;
						if(!DateTime.TryParse(txtHoraPedidoInicio.Text, out horaPedidoInicio))
							throw new ErrorMessageException("Hora Inicio inválida, verifique!");

						dtPedidoInicio.AddMinutes(horaPedidoInicio.Minute).AddSeconds(horaPedidoInicio.Second);
					}
				}

				if (!string.IsNullOrWhiteSpace(txtHoraPedidoInicio.Text.Replace(":", "").Trim())
					&& string.IsNullOrWhiteSpace(txtDataPedidoInicio.Text.Replace("/", "").Trim()))
					throw new ErrorMessageException("Data e Hora Fim precisam ser preenchidos, verifique!");

				DateTime dtPedidoFim;
				if (!string.IsNullOrWhiteSpace(txtDataPedidoFim.Text.Replace("/", "").Trim()))
				{
					if (!DateTime.TryParse(txtDataPedidoFim.Text, out dtPedidoFim))
						throw new ErrorMessageException("Data Fim inválida, verifique!");

					if (!string.IsNullOrWhiteSpace(txtHoraPedidoFim.Text.Replace(":", "").Trim()))
					{
						DateTime horaPedidoFim;
						if (!DateTime.TryParse(txtHoraPedidoFim.Text, out horaPedidoFim))
							throw new ErrorMessageException("Hora Fim inválida, verifique!");

						dtPedidoFim.AddMinutes(horaPedidoFim.Minute).AddSeconds(horaPedidoFim.Second);
					}
				}

				if (!string.IsNullOrWhiteSpace(txtHoraPedidoFim.Text.Replace(":", "").Trim())
					&& string.IsNullOrWhiteSpace(txtDataPedidoFim.Text.Replace("/", "").Trim()))
					throw new ErrorMessageException("Data e Hora Fim precisam ser preenchidos, verifique!");


				Search();
			}catch(ErrorMessageException ex)
			{
				MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void grdPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1 && e.ColumnIndex > -1)
			{
				var _pedido = (Pedido)grdPedido.Rows[e.RowIndex].DataBoundItem;

				PedidoItemRepository.PreencherProduto(_pedido.ItensPedido);
				_pedido.EnderecoEntrega = EnderecoRepository.ObterEnderecoEntregaPorPedido(_pedido.Id);
				FormPedido frmPedido = new FormPedido(_pedido);
				
				frmPedido.ShowDialog();

				AtualizaFormulario();
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			ClearFields(this);
			AtualizaFormulario();
		}
	}
}
