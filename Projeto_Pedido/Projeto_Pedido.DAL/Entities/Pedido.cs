using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Projeto_Pedido.DAL.Entities {

	public class Pedido : BaseEntity {

		public string Numero { get; set; }

		[NotMapped]
		public string ClienteString
		{ get
			{ if (Cliente != null) {
					if (!string.IsNullOrWhiteSpace(Cliente.Codigo) && !string.IsNullOrWhiteSpace(Cliente.RazaoSocial))
						return $"{Cliente.Codigo} • {Cliente.RazaoSocial}";
				}
				return "";
			}
		}

		[NotMapped]
		public string DataToString
		{ get { return this.CadasterDate.ToString("dd/MM/yyyy HH:mm:ss"); }}

		[NotMapped]
		public string TipoPagamentoString
		{
			get
			{
				switch (TipoPagamento)
				{
					case 0: return "";
					case 1: return "A vista";
					case 2: return "Cartão Débito";
					case 3: return "Cartão Crédito";
					case 4: return "Boleto";
					case 5: return "Transferência";
				}
				return "";
			}
		}

		[NotMapped]
		public string TotalBrutoToString { get { return TotalBruto.ToString("F"); } }

		[NotMapped]
		public string TotalDescontos
		{
			get
			{
				if (ItensPedido != null && ItensPedido.Count > 0)
				{
					var somaDescontos = ItensPedido.Sum(x => x.ValorDesconto) + ValorDesconto;
					return somaDescontos.ToString("F");

				}
				return ValorDesconto.ToString("F");
			}
		}

		[NotMapped]
		public string TotalLiquidoToString { get { return TotalLiquido.ToString("F"); } }

		[NotMapped]
		public string _StatusString
		{
			get
			{
				switch (Status)
				{
					case 1: return "Aberto";
					case 2: return "Aguardando Aprovação";
					case 3: return "Fechado";
					case 4: return "Cancelado";
				}
				return "";
			}
		}

		public int ClienteId { get; set; }
		public int Status { get; set; } = 1;
		public int TipoPagamento { get; set; }
		public decimal Desconto { get; set; }
		public decimal ValorDesconto { get; set; }
		public decimal Entrada { get; set; }
		public decimal TotalBruto { get; set; }
		public decimal TotalLiquido { get; set; }
		public string Observacao { get; set; }

		[NotMapped]
		public Entidade Cliente { get; set; }
		
		[NotMapped]
		public List<ItemPedido> ItensPedido { get; set; }

		[NotMapped]
		public List<ItemPedido> ItensPedidoDelete { get; set; }

		[NotMapped]
		public string DataPedido { get { return CadasterDate.ToString("dd/MM/yyyy"); } }

		[NotMapped]
		public string HoraPedido { get { return CadasterDate.ToString("HH:mm:ss"); } }
		
		[NotMapped]
		public EnderecoEntrega EnderecoEntrega { get; set; }

		[NotMapped]
		public EnderecoEntrega NovoEnderecoEntrega { get; set; }

		[NotMapped]
		public string ObterEstadoPedido { get { return _StatusString; } }
	}
}
