using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Pedido.DAL.Entities {
	public class ItemPedido : BaseEntity {

		public int IdPedido { get; set; }
		public int IdProduto { get; set; }

		[NotMapped]
		public Product Produto { get; set; }

		[NotMapped]
		public string PrecoToString { get
			{
				if (Produto != null)
					return Produto.PrecoVenda.ToString("F");

				return 0.ToString("F");
			}
		}

		public decimal Quantidade { get; set; }

		[NotMapped]
		public string QuantidadeToString
		{
			get
			{
				return Quantidade.ToString("F");
			}
		}

		public decimal Desconto { get; set; }
		public decimal ValorDesconto { get; set; }

		[NotMapped]
		public string ValorDescontoToString { get { return ValorDesconto.ToString("F"); } }

		public decimal TotalBruto { get; set; }

		public decimal TotalLiquido { get; set; }

		[NotMapped]
		public string TotalToString { get
			{
				return TotalLiquido.ToString("F");
			}
		}

		[NotMapped]
		public string TotalBrutoToString { get
			{
				return TotalBruto.ToString("F");
			}
		}

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


		[NotMapped]
		public string CodigoProduto
		{
			get
			{
				if (Produto != null) return Produto.Codigo;

				return "";
			}
		}

		[NotMapped]
		public string DescricaoProduto
		{
			get
			{
				if (Produto != null)
					return Produto.Descricao;

				return "";
			}
		}


		[NotMapped]
		public string UnidadeMedida
		{
			get
			{
				if (Produto != null)
					return Produto.UnidadeMedidaString;

				return "";
			}
		}

	}
}
