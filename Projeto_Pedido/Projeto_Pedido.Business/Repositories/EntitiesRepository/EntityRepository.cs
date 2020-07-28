using Projeto_Pedido.Business.Repositories.Operators;
using Projeto_Pedido.DAL.Entities;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace Projeto_Pedido.Business.Repositories.EntitiesRepository {
	public class EntityRepository : BaseRepository<Entidade> {

		public static IList<Entidade> SearchEntity(string codigo, string razaoSocial, int tipoCli, int tipODoc, string documento, string UF)
		{
			List<FilterData> listFilterData = new List<FilterData>();

			if (!string.IsNullOrWhiteSpace(codigo))
				listFilterData.Add(FilterData.Like("Codigo", codigo, LikeOperator.Both));

			if (!string.IsNullOrWhiteSpace(razaoSocial))
				listFilterData.Add(FilterData.Like("RazaoSocial", razaoSocial, LikeOperator.Both));

			if (tipoCli > 0)
				listFilterData.Add(FilterData.Eq("TipoCli", tipoCli));

			if (tipODoc > 0)
				listFilterData.Add(FilterData.Eq("TipoDocumento", tipODoc));

			if (!string.IsNullOrWhiteSpace(UF))
				listFilterData.Add(FilterData.Eq("Estado", UF));

			if (!string.IsNullOrWhiteSpace(documento))
				listFilterData.Add(FilterData.Like("Documento", documento, LikeOperator.Both));

			if (listFilterData.Any())
			{
				FilterCriteria fc = FilterCriteria.And(listFilterData.ToArray());
				
				return GetAll(fc, orderBy: "Codigo and RazaoSocial ");
			}
			else
				return GetAll(orderBy: "Codigo and RazaoSocial ");
		}

		public static bool VerificaDuplicidade(int idEntidade, string codigo)
		{
			var instanceEntity = new Entidade();

			using (var conection = BaseData.DbConnection())
			{
				string orderByCommand = string.Empty;

				SQLiteCommand sQLiteCommand = new SQLiteCommand($"SELECT * FROM {instanceEntity.GetType().Name} where Codigo = '{codigo}' and id <> {idEntidade} ", conection);

				using (var read = sQLiteCommand.ExecuteReader())
				{
					if (read.Read())
						return true;
				}
			}

			return false;
		}

		public static bool VerificaVinculoProduto_Pedido(int idEntidade)
		{
			using (var conection = BaseData.DbConnection())
			{
				string orderByCommand = string.Empty;

				//Verifica vinculo com fornecedor
				SQLiteCommand sQLiteCommand = new SQLiteCommand($"SELECT * FROM Product where IdFornecedor =  {idEntidade} ", conection);
				using (var read = sQLiteCommand.ExecuteReader())
				{
					if (read.Read())
						return true;
				}

				//Verifica vinculo com Pedido
				sQLiteCommand = new SQLiteCommand($"SELECT * FROM Pedido where ClienteId =  {idEntidade} ", conection);
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
