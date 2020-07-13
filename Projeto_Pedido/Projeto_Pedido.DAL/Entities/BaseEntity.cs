using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Pedido.DAL.Entities {
	[NotMapped]
	public abstract class BaseEntity {
		public long Id { get; set; }
		public DateTime CadasterDate { get; set; } = DateTime.Now;
	}
}
