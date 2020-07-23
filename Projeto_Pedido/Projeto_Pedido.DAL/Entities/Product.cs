
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Pedido.DAL.Entities {
	public class Product : BaseEntity {

		public string Codigo { get; set; }
		public string Descricao { get; set; }
		public string UM { get; set; }
		public decimal PrecoCusto { get; set; }
		public decimal PrecoVenda { get; set; }
		public int Tipo { get; set; }
		public int IdFornecedor { get; set; }
		public byte[] Imagem { get; set; }
		public string Observacao { get; set; }

		[NotMapped]
		public string ProdutoString { get
			{
				if (string.IsNullOrWhiteSpace(Codigo) && string.IsNullOrWhiteSpace(Descricao))
					return "";

				return $"{Codigo} • {Descricao}";
			}
		}

		[NotMapped]
		public Entidade Fornecedor { get; set; }

		[NotMapped]
		public string FornecedorString {
			get
			{
				if(Fornecedor != null)
				{
					if(!string.IsNullOrWhiteSpace(Fornecedor.Codigo) && !string.IsNullOrWhiteSpace(Fornecedor.RazaoSocial))
						return $"{Fornecedor.Codigo} • {Fornecedor.RazaoSocial}";
				}
				return "";
			}
		}
	}
}
