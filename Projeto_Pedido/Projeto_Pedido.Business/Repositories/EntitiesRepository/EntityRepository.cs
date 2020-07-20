using Projeto_Pedido.Business.Repositories.Operators;
using Projeto_Pedido.DAL.Entities;
using System.Collections.Generic;
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


	}
}
