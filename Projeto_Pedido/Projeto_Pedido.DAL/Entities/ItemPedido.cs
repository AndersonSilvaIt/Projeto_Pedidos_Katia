using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Pedido.DAL.Entities {
	public class ItemPedido : BaseEntity {

		public int IdPedido { get; set; }
		public int IdProduto { get; set; }

		[NotMapped]
		public Product Produto { get; set; }

		[NotMapped]
		public decimal Preco { get
			{
				if (Produto != null)
					return Produto.PrecoVenda;

				return 0;
			}
		}

		public decimal Quantidade { get; set; }
		public decimal Desconto { get; set; }

		public decimal Total { get; set; }
		public string Observacao { get; set; }

		[NotMapped]
		public string ProdutoString
		{
			get
			{
				if(Produto != null)
				{
					if (string.IsNullOrWhiteSpace(Produto.Codigo) && string.IsNullOrWhiteSpace(Produto.Descricao))
						return "";

					return $"{Produto.Codigo} • {Produto.Descricao}";
				}
				return "";
			}
		}
	}
}
