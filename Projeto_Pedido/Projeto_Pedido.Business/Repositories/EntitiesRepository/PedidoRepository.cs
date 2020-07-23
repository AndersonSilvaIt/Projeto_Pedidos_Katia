using Projeto_Pedido.Business.Repositories.Operators;
using Projeto_Pedido.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SQLite;
using System.Linq;

namespace Projeto_Pedido.Business.Repositories.EntitiesRepository {

	public class PedidoRepository : BaseRepository<Pedido> {

		public static IList<Pedido> SearchPedido(string numero, int idCliente, int status, DateTime dtPedidoInicio, DateTime dtPedidoFim, int tipoPagamento)
		{
			List<FilterData> listFilterData = new List<FilterData>();

			if (!string.IsNullOrWhiteSpace(numero))
				listFilterData.Add(FilterData.Like("Numero", numero, LikeOperator.Both));

			if (idCliente > 0)
				listFilterData.Add(FilterData.Eq("ClienteId", idCliente));

			if (status > 0)
				listFilterData.Add(FilterData.Eq("Status", status));

			if (tipoPagamento > 0)
				listFilterData.Add(FilterData.Eq("TipoPagamento", tipoPagamento));

			if (dtPedidoInicio > DateTime.MinValue)
				listFilterData.Add(FilterData.Ge("CadasterDate", dtPedidoInicio));

			if (dtPedidoFim > DateTime.MinValue)
				listFilterData.Add(FilterData.Lt("CadasterDate", dtPedidoFim));

			if (listFilterData.Any())
			{
				FilterCriteria fc = FilterCriteria.And(listFilterData.ToArray());

				return GetAll(fc, orderBy: "Numero ");
			}
			else
				return GetAll(orderBy: "Numero ");
		}

		public static IList<ItemPedido> GetListaItemPedido(int idPedido)
		{
			var  instanceEntity = new ItemPedido();
			var properties = instanceEntity.GetType().GetProperties();
			IList<ItemPedido> listObject = new List<ItemPedido>();

			using (var conection = BaseData.DbConnection())
			{
				string orderByCommand = string.Empty;

				SQLiteCommand sQLiteCommand = new SQLiteCommand($"SELECT * FROM {instanceEntity.GetType().Name} where idPedido = {idPedido} ", conection);
				decimal decimalValue = 0;
				//double doubleValue = 0;
				int intValue = 0;
				DateTime dateValue = DateTime.MinValue;
				object[] attributesObject;

				using (var read = sQLiteCommand.ExecuteReader())
				{
					while (read.Read())
					{
						instanceEntity = new ItemPedido();

						foreach (var item in properties)
						{
							attributesObject = item.GetCustomAttributes(false);
							if (attributesObject != null && attributesObject.Length > 0 && attributesObject.Any(x => x is NotMappedAttribute))
							{
								continue;
							}
							switch (item.PropertyType.Name)
							{
								case "String":
									instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, Convert.ToString(read[item.Name]));
									break;

								case "Char":
									int defaultCharValue = 255; //Space
									int.TryParse(Convert.ToString(read[item.Name]), out defaultCharValue);
									instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, Convert.ToChar(defaultCharValue));
									break;

								case "Decimal":
									if (read[item.Name] != null && decimal.TryParse(Convert.ToString(read[item.Name]), out decimalValue))
										instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, decimalValue);
									break;

								case "Int32":
								case "Int64":
									if (read[item.Name] != null && int.TryParse(Convert.ToString(read[item.Name]), out intValue))
										instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, intValue);
									break;

								case "DateTime":
									if (read[item.Name] != null && DateTime.TryParse(Convert.ToString(read[item.Name]), out dateValue))
										instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, dateValue);
									break;

								case "Boolean":
									if (read[item.Name] != null && int.TryParse(Convert.ToString(read[item.Name]), out intValue))
									{
										bool boolValue = intValue == 1;
										instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, boolValue);
									}
									break;

								case "byte[]":
								case "Byte[]":
									byte[] valorByte;

									if (read[item.Name] != null && ((read[item.Name] as byte[]) != null))
									{
										valorByte = (byte[])read[item.Name];
										instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, valorByte);
									}

									break;
							}
						}

						listObject.Add(instanceEntity);
					}
					return listObject;
				}
			}

			return null;
		}
		
		public static void PreencherCliente(IList<Pedido> pedidos)
		{
			foreach (var item in pedidos)
			{
				if (item.ClienteId > 0)
					item.Cliente = EntityRepository.GetEntity(item.ClienteId);
			}
		}
	}
}
