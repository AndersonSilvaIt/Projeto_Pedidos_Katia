using Projeto_Pedido.DAL.Entities;
using System.Collections.Generic;

namespace Projeto_Pedido.Business.Repositories.EntitiesRepository {
	public class PedidoItemRepository : BaseRepository<ItemPedido> {

		public static void PreencherProduto(IList<ItemPedido> itemPedidos)
		{
			foreach (var item in itemPedidos)
			{
				if (item.IdProduto > 0)
					item.Produto = ProductRepository.GetEntity(item.IdProduto);
			}
		}

	}
}
