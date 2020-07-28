using Projeto_Pedido.Business.Repositories.Operators;
using Projeto_Pedido.DAL.Entities;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace Projeto_Pedido.Business.Repositories.EntitiesRepository {

	public class ProductRepository : BaseRepository<Product> {

		public static IList<Product> SearchEntity(string codigo, string descricao, int idFornecedor)
		{
			List<FilterData> listFilterData = new List<FilterData>();

			if (!string.IsNullOrWhiteSpace(codigo))
				listFilterData.Add(FilterData.Like("Codigo", codigo, LikeOperator.Both));

			if (!string.IsNullOrWhiteSpace(descricao))
				listFilterData.Add(FilterData.Like("Descricao", descricao, LikeOperator.Both));

			if (idFornecedor > 0)
				listFilterData.Add(FilterData.Eq("IdFornecedor", idFornecedor));

			if (listFilterData.Any())
			{
				FilterCriteria fc = FilterCriteria.And(listFilterData.ToArray());

				return GetAll(fc, orderBy: "Codigo and Descricao ");
			}
			else
				return GetAll(orderBy: "Codigo and Descricao ");
		}

		public static void PreencherForencedor(IList<Product> products)
		{
			foreach (var item in products)
			{
				if (item.IdFornecedor > 0)
					item.Fornecedor = EntityRepository.GetEntity(item.IdFornecedor);
			}
		}

		public static void PreencherUnidadeMedida(IList<Product> products)
		{
			foreach (var item in products)
			{
				if (item.UnidadeMedidaId > 0)
					item.UM = UnidadeRepository.GetEntity(item.UnidadeMedidaId);
			}
		}

		public static bool VerificaDuplicidade(int idProduto, string codigo)
		{
			var instanceEntity = new Product();

			using (var conection = BaseData.DbConnection())
			{
				string orderByCommand = string.Empty;

				SQLiteCommand sQLiteCommand = new SQLiteCommand($"SELECT * FROM {instanceEntity.GetType().Name} where Codigo = '{codigo}' and id <> {idProduto} ", conection);

				using (var read = sQLiteCommand.ExecuteReader())
				{
					if (read.Read())
						return true;
				}
			}

			return false; 
		}
	}
}
