using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Pedido.DAL.Entities {


	public class Entidade : Endereco {

		public string Codigo { get; set; }
		public string RazaoSocial { get; set; }
		public string NomeFantasia { get; set; }
		public int TipoCli { get; set; }

		[NotMapped]
		public string TipoCliString { get
			{
				if (TipoCli == 1)
					return "Cliente";

				if(TipoCli == 2)
					return "Fornecedor";

				return "";
			}
		}

		public int TipoDocumento { get; set; }
		public string Documento { get; set; }

		public string Contato { get; set; }
		public string Email { get; set; }
		public string FoneFixo { get; set; }
		public string FoneCelular { get; set; }

		public string Site { get; set; }

		public string Observacao { get; set; }

		[NotMapped]
		public string Descricao {
			get
			{
				if (string.IsNullOrWhiteSpace(Codigo) && string.IsNullOrWhiteSpace(RazaoSocial))
					return " ";
				return $"{this.Codigo} • {this.RazaoSocial}";
			}
		}
	}
}
