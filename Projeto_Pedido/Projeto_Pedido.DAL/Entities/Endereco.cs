using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Pedido.DAL.Entities {

	[NotMapped]
	public class Endereco : BaseEntity {

		public string Rua { get; set; }
		public string Numero { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string Estado { get; set; }
		public string CEP { get; set; }
		public string Complemento { get; set; }
	}

	public class EnderecoEntrega : Endereco {
		public int PedidoId { get; set; }
		public string Destinatario { get; set; }
	}
}
