using Projeto_Pedido.DAL.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SQLite;
using System.Linq;

namespace Projeto_Pedido.Business.Repositories.EntitiesRepository {

	public class EnderecoRepository : BaseRepository<EnderecoEntrega> {

		public static EnderecoEntrega ObterEnderecoEntregaPorPedido(int idPedido)
		{
			var instanceEntity = new EnderecoEntrega();
			var properties = instanceEntity.GetType().GetProperties();
			object[] attributesObject;

			using (var conection = BaseData.DbConnection())
			{
				SQLiteCommand sQLiteCommand = new SQLiteCommand($"SELECT * FROM {instanceEntity.GetType().Name} where PedidoId = {idPedido} ", conection);
				decimal decimalValue = 0;
				double doubleValue = 0;
				int intValue = 0;
				DateTime dateValue = DateTime.MinValue;
				using (var read = sQLiteCommand.ExecuteReader())
				{
					if (read.Read())
					{
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

								case "Decimal":
									if (read[item.Name] != null && decimal.TryParse(Convert.ToString(read[item.Name]), out decimalValue))
										instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, decimalValue);
									break;

								case "Double":
									if (read[item.Name] != null && double.TryParse(Convert.ToString(read[item.Name]), out doubleValue))
										instanceEntity.GetType().GetProperty(item.Name).SetValue(instanceEntity, doubleValue);
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
							}
						}
						return instanceEntity;
					}
					else
						return null;
				}
			}
		}
	}
}
