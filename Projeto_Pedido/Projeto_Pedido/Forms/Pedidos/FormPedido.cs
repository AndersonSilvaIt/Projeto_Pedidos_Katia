using Microsoft.Reporting.WinForms;
using Projeto_Pedido.Business.Repositories.EntitiesRepository;
using Projeto_Pedido.DAL.Entities;
using Projeto_Pedido.Forms.Entidades;
using Projeto_Pedido.Forms.FormsConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Projeto_Pedido.Forms.Pedidos {

	public partial class FormPedido : FormUtil {

		private Pedido _pedido;

		private ReportViewer reportViewer;
		private Empresa _empresa;

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
			btnAddCliente.Visible = false;
			btnAddAddress.Visible = false;

			if (_pedido.Status == 1)
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

			if (_pedido.Status == 3)
			{
				btnLock.Visible = false;
				btnOpen.Visible = true;
				btnCancel.Visible = true;
			}
		}

		public FormPedido()
		{
			InitializeComponent();
			btnPrint.Visible = false;
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

			if (_pedido.ItensPedido != null && _pedido.ItensPedido.Count > 0)
			{
				decimal totalLiquidoItens = _pedido.ItensPedido.Sum(x => x.TotalLiquido);
				lblLiquidoItens.Text = totalLiquidoItens.ToString("F");
				lblTotalLiquido.Text = totalLiquidoItens.ToString("F");

				decimal totalBrutoItens = _pedido.ItensPedido.Sum(x => x.TotalBruto);

				lblTotalBruto.Text = totalBrutoItens.ToString("F");

				decimal totalDescontosItens = _pedido.ItensPedido.Sum(x => x.Desconto);
				lblDescontoItens.Text = totalDescontosItens.ToString("F");
			}

			txtEstado.Text = _pedido._StatusString;

			ddlTipoPagamento.SelectedIndex = _pedido.TipoPagamento;

			txtDesconto.Text = _pedido.Desconto.ToString("F");
			txtEntrada.Text = _pedido.Entrada.ToString("F");

			lblTotalBruto.Text = _pedido.TotalBruto.ToString("F");
			lblTotalLiquido.Text = _pedido.TotalLiquido.ToString("F");
			txtObservacao.Text = _pedido.Observacao;

			lblValorDesconto.Text = _pedido.ValorDesconto.ToString("F");
			lblValorPagar.Text = (_pedido.TotalLiquido - _pedido.Entrada).ToString("F");

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

			CalcularValores();
		}

		private void CalcularValores()
		{
			decimal totalLiquidoItens = 0;
			decimal totalBrutoItens = 0;
			decimal totalDescontosItens = 0;
			decimal totalAPagar = 0;

			if (RepositorySingleton.GetInstance().PedidoAux != null &&
				RepositorySingleton.GetInstance().PedidoAux.ItensPedido != null &&
				RepositorySingleton.GetInstance().PedidoAux.ItensPedido.Count > 0)
			{
				var pedidoAux = RepositorySingleton.GetInstance().PedidoAux;
				totalLiquidoItens = pedidoAux.ItensPedido.Sum(x => x.TotalLiquido);
				lblLiquidoItens.Text = totalLiquidoItens.ToString("F");
				lblTotalLiquido.Text = totalLiquidoItens.ToString("F");

				totalBrutoItens = pedidoAux.ItensPedido.Sum(x => x.TotalBruto);
				lblTotalBruto.Text = totalBrutoItens.ToString("F");

				totalDescontosItens = pedidoAux.ItensPedido.Sum(x => x.Desconto);
				lblDescontoItens.Text = totalDescontosItens.ToString("F");
			}

			decimal desconto = 0;
			decimal entrada = 0;

			decimal.TryParse(txtDesconto.Text.Trim().Replace(".", ""), out desconto);
			decimal.TryParse(txtEntrada.Text.Trim().Replace(".", ""), out entrada);

			decimal totalLiquido = totalLiquidoItens;

			if (desconto > 0)
			{
				decimal valorDesconto = totalLiquidoItens * (desconto / 100);
				lblValorDesconto.Text = valorDesconto.ToString("F");

				totalLiquido = totalLiquidoItens - valorDesconto;
			}
			totalAPagar = totalLiquido;

			lblTotalLiquido.Text = totalLiquido.ToString("F");

			if (entrada > 0)
				totalLiquido -= entrada;

			totalAPagar = totalLiquido;

			lblValorPagar.Text = totalAPagar.ToString("F");
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			DirtyFields(this, _pedido);
			DirtyFields02();
			if (_pedido.Id == 0)
			{
				PedidoRepository.Save(_pedido);
				_pedido.Id = PedidoRepository.GetMaxId(_pedido);

				if (_pedido.ItensPedido != null && _pedido.ItensPedido.Count > 0)
				{
					foreach (var item in _pedido.ItensPedido)
					{
						item.IdPedido = _pedido.Id;
						ItensPedidoRepository.Save(item);
					}
				}

				if (_pedido.EnderecoEntrega != null)
				{
					if (_pedido.NovoEnderecoEntrega != null)
					{
						_pedido.EnderecoEntrega = _pedido.NovoEnderecoEntrega;
					}
					_pedido.EnderecoEntrega.PedidoId = _pedido.Id;
					EnderecoRepository.Save(_pedido.EnderecoEntrega);
				}
				else if (_pedido.NovoEnderecoEntrega != null)
				{
					_pedido.EnderecoEntrega = _pedido.NovoEnderecoEntrega;
				}
				if(_pedido.EnderecoEntrega == null)
				{
					var lista = grdEndereco.DataSource as BindingList<EnderecoEntrega>;
					if (lista != null && lista.Count > 0)
					{
						_pedido.EnderecoEntrega = lista[0];
					}
				}

				_pedido.EnderecoEntrega.PedidoId = _pedido.Id;
				EnderecoRepository.Save(_pedido.EnderecoEntrega);
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
						PedidoItemRepository.Update02(item);
				}

				if (_pedido.ItensPedidoDelete != null && _pedido.ItensPedidoDelete.Count > 0)
				{
					foreach (var item in _pedido.ItensPedidoDelete)
					{
						PedidoItemRepository.Delete(item);
					}
				}

				if (_pedido.EnderecoEntrega != null)
				{
					if (_pedido.NovoEnderecoEntrega != null)
					{
						int idDelete = _pedido.EnderecoEntrega.Id;
						EnderecoRepository.Delete(_pedido.EnderecoEntrega);
						_pedido.EnderecoEntrega = _pedido.NovoEnderecoEntrega;
						EnderecoRepository.Save(_pedido.EnderecoEntrega);
					}
					else
					{
						EnderecoRepository.Update02(_pedido.EnderecoEntrega);
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
			if (ddlTipoPagamento.SelectedValue != "0")
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
				if (result == DialogResult.Yes)
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

			}
			catch (Exception ex)
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
			btnAddCliente.Visible = true;
			EnableFields(this, true);
			btnCancel.Visible = false;
			btnAddAddress.Visible = true;
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

				CalcularValores();
			}
		}

		private void txtEntrada_Leave(object sender, EventArgs e)
		{
			CalcularValores();
		}

		private void txtDesconto_Leave(object sender, EventArgs e)
		{
			CalcularValores();
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			try
			{
				var lista = EmpresaRepository.GetAll();
				if (lista == null || lista.Count == 0)
				{
					throw new ErrorMessageException("É necessário realizar o cadastro da Empresa em COnfigurações");
				}
				_empresa = lista[0];

				string path = @"Projeto_Pedido.Reports.ImpressaoPedido.rdlc";
				if (this.reportViewer == null)
					this.reportViewer = new ReportViewer();

				var listItens = _pedido.ItensPedido;

				this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", listItens));

				FormReport frmReport = new FormReport(this.reportViewer, path, GetParametersToPrint());
				frmReport.ShowDialog();
			}
			catch (ErrorMessageException eme)
			{
				MessageBox.Show(eme.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			catch (Exception ex)
			{

			}
		}

		private IList<ReportParameter> GetParametersToPrint()
		{
			try
			{
				IList<ReportParameter> listReportParameter;
				ReportParameter Imagem = new ReportParameter("Imagem", _empresa.CaminhoImagem);
				ReportParameter RazaoSocial = new ReportParameter("RazaoSocial", _empresa.RazaoSocial);
				ReportParameter Documento = new ReportParameter("Documento", _empresa.Documento);
				ReportParameter RuaEmpresa = new ReportParameter("RuaEmpresa", _empresa.Rua);
				ReportParameter NumeroEmpresa = new ReportParameter("NumeroEmpresa", _empresa.Numero);
				ReportParameter BairroEmpresa = new ReportParameter("BairroEmpresa", _empresa.Bairro);
				ReportParameter CidadeEmpresa = new ReportParameter("CidadeEmpresa", _empresa.Cidade);
				ReportParameter EstadoEmpresa = new ReportParameter("EstadoEmpresa", _empresa.Estado);
				ReportParameter CEPEmpresa = new ReportParameter("CEPEmpresa", _empresa.CEP);
				ReportParameter FoneFixoEmpresa = new ReportParameter("FoneFixoEmpresa", _empresa.FoneFixo);
				ReportParameter FoneCelularEmpresa = new ReportParameter("FoneCelularEmpresa", _empresa.FoneCelular);
				ReportParameter EmailEmpresa = new ReportParameter("EmailEmpresa", _empresa.Email);
				ReportParameter Site = new ReportParameter("Site", _empresa.Site);

				ReportParameter DataPedido = new ReportParameter("DataPedido", _pedido.DataPedido);
				ReportParameter HoraPedido = new ReportParameter("HoraPedido", _pedido.HoraPedido);
				ReportParameter Numero = new ReportParameter("Numero", _pedido.Numero);
				ReportParameter ClienteString = new ReportParameter("ClienteString", _pedido.ClienteString);

				ReportParameter RuaCliente = new ReportParameter("RuaCliente", _pedido.Cliente.Rua);
				ReportParameter NumeroCliente = new ReportParameter("NumeroCliente", _pedido.Cliente.Numero);
				ReportParameter BairroCliente = new ReportParameter("BairroCliente", _pedido.Cliente.Bairro);
				ReportParameter CidadeCliente = new ReportParameter("CidadeCliente", _pedido.Cliente.Cidade);
				ReportParameter EstadoCliente = new ReportParameter("EstadoCliente", _pedido.Cliente.Estado);
				ReportParameter CEPCliente = new ReportParameter("CEPCliente", _pedido.Cliente.CEP);
				ReportParameter FoneFixoCliente = new ReportParameter("FoneFixoCliente", _pedido.Cliente.FoneFixo);
				ReportParameter FoneCelularCliente = new ReportParameter("FoneCelularCliente", _pedido.Cliente.FoneCelular);
				ReportParameter ClienteCodigo = new ReportParameter("ClienteCodigo", _pedido.Cliente.Codigo);

				ReportParameter TipoPagamentoString = new ReportParameter("TipoPagamentoString", _pedido.TipoPagamentoString);
				ReportParameter TotalBrutoToString = new ReportParameter("TotalBrutoToString", _pedido.TotalBrutoToString);
				ReportParameter TotalLiquidoToString = new ReportParameter("TotalLiquidoToString", _pedido.TotalLiquidoToString);
				ReportParameter TotalDescontos = new ReportParameter("TotalDescontos", _pedido.TotalDescontos);

				ReportParameter Entrada = new ReportParameter("Entrada", _pedido.Entrada.ToString("F"));
				ReportParameter ObservacaoPedido = new ReportParameter("ObservacaoPedido", _pedido.Observacao);

				CultureInfo culture = new CultureInfo("pt-BR");
				DateTimeFormatInfo dtfi = culture.DateTimeFormat;
				DateTime dtImpressao = DateTime.Now;
				int dia = dtImpressao.Day;
				int ano = dtImpressao.Year;

				string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(dtImpressao.Month));
				string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(dtImpressao.DayOfWeek));

				string data = $"{diasemana}, {dia} de {mes} de {ano}";

				ReportParameter DataImpressaoPedido = new ReportParameter("DataImpressaoPedido", data);

				ReportParameter RuaEntrega, NumeroEntrega, BairroEntrega, CidadeEntrega, EstadoEntrega, CEPEntrega, Destinatario;

				/// Endereço Entrega
				if (_pedido.EnderecoEntrega != null)
				{
					RuaEntrega = new ReportParameter("RuaEntrega", _pedido.EnderecoEntrega.Rua);
					NumeroEntrega = new ReportParameter("NumeroEntrega", _pedido.EnderecoEntrega.Numero);
					BairroEntrega = new ReportParameter("BairroEntrega", _pedido.EnderecoEntrega.Bairro);
					CidadeEntrega = new ReportParameter("CidadeEntrega", _pedido.EnderecoEntrega.Cidade);
					EstadoEntrega = new ReportParameter("EstadoEntrega", _pedido.EnderecoEntrega.Estado);
					CEPEntrega = new ReportParameter("CEPEntrega", _pedido.EnderecoEntrega.CEP);
					Destinatario = new ReportParameter("Destinatario", _pedido.EnderecoEntrega.Destinatario);
				}
				else
				{
					RuaEntrega = new ReportParameter("RuaEntrega", "");
					NumeroEntrega = new ReportParameter("NumeroEntrega", "");
					BairroEntrega = new ReportParameter("BairroEntrega", "");
					CidadeEntrega = new ReportParameter("CidadeEntrega", "");
					EstadoEntrega = new ReportParameter("EstadoEntrega", "");
					CEPEntrega = new ReportParameter("CEPEntrega", "");
					Destinatario = new ReportParameter("Destinatario", "");
				}

				listReportParameter = new List<ReportParameter>()
				{
					RazaoSocial , Documento , RuaEmpresa  , NumeroEmpresa , BairroEmpresa , CidadeEmpresa , EstadoEmpresa ,
					CEPEmpresa   , FoneFixoEmpresa , FoneCelularEmpresa , EmailEmpresa, DataPedido  , HoraPedido  , Numero ,
					ClienteString , RuaCliente , NumeroCliente , BairroCliente , CidadeCliente , EstadoCliente , CEPCliente ,
					FoneFixoCliente , FoneCelularCliente  , ClienteCodigo  , Site, TipoPagamentoString,
					TotalBrutoToString, TotalLiquidoToString, TotalDescontos, Entrada, ObservacaoPedido, DataImpressaoPedido,
					Imagem, RuaEntrega, NumeroEntrega, BairroEntrega, CidadeEntrega, EstadoEntrega, CEPEntrega, Destinatario
				};

				return listReportParameter;
			}
			catch (Exception ex)
			{
				// mensagem de erro caso nao existir o cadastro da empresa
			}

			return null;
		}

		private void ddlCliente_SelectedIndexChanged(object sender, EventArgs e)
		{
			var cliente = ddlCliente.SelectedItem as Entidade;
			if (cliente != null)
			{
				var endereco = new EnderecoEntrega();
				endereco.Rua = cliente.Rua;
				endereco.Numero = cliente.Numero;
				endereco.Bairro = cliente.Bairro;
				endereco.Cidade = cliente.Cidade;
				endereco.Estado = cliente.Estado;
				endereco.CEP = cliente.CEP;
				endereco.Complemento = cliente.Complemento;
				endereco.Destinatario = cliente.Descricao;
				//_pedido.EnderecoEntrega = endereco;

				var listaEndereco = new List<EnderecoEntrega>();
				listaEndereco.Add(endereco);

				var binding = new BindingList<EnderecoEntrega>(listaEndereco);
				grdEndereco.DataSource = binding;
				grdEndereco.Refresh();
			}

			if (_pedido.EnderecoEntrega != null)
			{
				var listaEndereco = new List<EnderecoEntrega>();
				listaEndereco.Add(_pedido.EnderecoEntrega);

				var binding = new BindingList<EnderecoEntrega>(listaEndereco);
				grdEndereco.DataSource = binding;
				grdEndereco.Refresh();
			}

			if (_pedido.NovoEnderecoEntrega != null)
			{
				var listaEndereco = new List<EnderecoEntrega>();
				listaEndereco.Add(_pedido.NovoEnderecoEntrega);

				var binding = new BindingList<EnderecoEntrega>(listaEndereco);
				grdEndereco.DataSource = binding;
				grdEndereco.Refresh();
			}
		}

		private void btnAddAddress_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Deseja alterar o Endereço de Entrega?", "Endereço de Entrega", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				_pedido.Numero = txtNumero.Text;

				EnderecoEntrega endereco;
				var lista = grdEndereco.DataSource as BindingList<EnderecoEntrega>;
				if (lista != null && lista.Count > 0)
				{
					endereco = lista[0];
				}
				else
					endereco = new EnderecoEntrega();

				new FormEndereco(_pedido, endereco).ShowDialog();
				AtualizarGridEndereco();
			}
		}

		private void AtualizarGridEndereco()
		{
			if (_pedido.NovoEnderecoEntrega != null)
			{
				var listaEndereco = new List<Endereco>();
				listaEndereco.Add(_pedido.NovoEnderecoEntrega);
				var binding = new BindingList<Endereco>(listaEndereco);
				grdEndereco.DataSource = binding;
				grdEndereco.Refresh();
			}
		}
	}
}
