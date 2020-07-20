using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Pedido.DAL.Entities {
	public class ItemPedido : BaseEntity {

		public int IdPedido { get; set; }
		public int IdProduto { get; set; }

		[NotMapped]
		public Product Produto { get; set; }

		public decimal Quantidade { get; set; }
		public decimal Desconto { get; set; }

		public decimal Total { get; set; }
		public string Observacao { get; set; }
	}
}
