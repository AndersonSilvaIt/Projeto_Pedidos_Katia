using Projeto_Pedido.DAL.Entities;
using System.Collections.Generic;

namespace Projeto_Pedido.Business.Repositories.EntitiesRepository {
	public class RepositorySingleton {

		private RepositorySingleton()
		{
		}

		public Pedido PedidoAux { get; set; }

		private static RepositorySingleton _instance;

		public static RepositorySingleton GetInstance()
		{
			if(_instance == null)
			{
				_instance = new RepositorySingleton();
			}
			return _instance;
		}

	}
}
