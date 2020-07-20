using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Pedido.DAL.Entities {
	[NotMapped]
	public abstract class BaseEntity {
		public int Id { get; set; }
		public DateTime CadasterDate { get; set; } = DateTime.Now;
	}
}
