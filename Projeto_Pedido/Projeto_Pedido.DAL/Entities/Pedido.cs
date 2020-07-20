using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Pedido.DAL.Entities {

	public class Pedido : BaseEntity {

		public string Numero { get; set; }
		public DateTime DataPedido { get; set; }
		public int ClienteId { get; set; }

		public int Status { get; set; }
		
		public int TipoPagamento { get; set; }
		public decimal Desconto { get; set; }
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
	}
}
