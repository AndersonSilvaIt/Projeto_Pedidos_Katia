using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Projeto_Pedido.Business.Repositories.EntitiesRepository {
	public class BaseData {
		private static SQLiteConnection sqliteConnection;

		private static List<string> ListaTabelas = new List<string>() {
			"Product",
			"Entidade",
			"Pedido",
			"ItemPedido",
			"Empresa",
			"UnidadeMedida",
			"EnderecoEntrega"
		};

		public BaseData()
		{
			CriarBanco();
		}

		private static void CriarBanco() {
			try {
				var caminhoRaiz = Directory.GetDirectoryRoot(AppDomain.CurrentDomain.BaseDirectory);
				string pathRoot = caminhoRaiz + "SistemaPedido";
				string pathDB = pathRoot + @"\DBPedidos.sqlite";

				if(!Directory.Exists(pathRoot))
					Directory.CreateDirectory(pathRoot);

				if(!File.Exists(pathDB)) {
					SQLiteConnection.CreateFile(pathDB);

					CriarTabelaSQlite(ListaTabelas.ToArray());
				}

			} catch(Exception ex) {

			}
		}

		public static SQLiteConnection DbConnection()
		{
			var caminhoRaiz = Directory.GetDirectoryRoot(AppDomain.CurrentDomain.BaseDirectory);
			string pathRoot = caminhoRaiz + "SistemaPedido";
			string pathDB = pathRoot + @"\DBPedidos.sqlite";
			if(!File.Exists(pathDB)) {
				CriarBanco();
			}
			string connectionString = $@"Data Source={pathDB}; Version=3;";
			
			sqliteConnection = new SQLiteConnection(connectionString);

			if (sqliteConnection.State == System.Data.ConnectionState.Open)
				sqliteConnection.Close();

			sqliteConnection.Open();
			return sqliteConnection;
		}

		public static void CriarTabelaSQlite(string[] files) {
			try {
				Type EntityType = null;
				using(var cmd = DbConnection().CreateCommand()) {
					StringBuilder sb;
					foreach(var fileClass in files) {

						//var type = Assembly.Load("Projeto_Pedido.DAL").GetTypes().First(x => x.Name == fileClass);

						EntityType = Assembly.Load("Projeto_Pedido.DAL").GetTypes().First(x => x.Name == fileClass);

						object[] attributesObject = EntityType.GetCustomAttributes(false);
						if(attributesObject != null && attributesObject.Length > 0 && attributesObject.Any(x => x is NotMappedAttribute)) {
							continue;
						}

						sb = new StringBuilder();
						sb.Append($"CREATE TABLE IF NOT EXISTS { EntityType.Name } ( ");
						PropertyInfo[] propertyInfos = EntityType.GetProperties();

						foreach(var item in propertyInfos) {

							attributesObject = item.GetCustomAttributes(false);
							if(attributesObject != null && attributesObject.Length > 0 && attributesObject.Any(x => x is NotMappedAttribute)) {
								continue;
							}

							//Considering Nullable/Generics
							string propertyTypeName = item.PropertyType.Name;
							if(item.PropertyType.IsGenericType &&
								item.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>)) {
								propertyTypeName = item.PropertyType.GetGenericArguments()[0].Name;
							}

							switch(propertyTypeName) //item.PropertyType.Name
							{
							case "String":
								//TODO: Think how to get the string length dynamically
								//      Maybe DataAnnotations.StringLength
								//      And consider a default value = 50 (if there is no StringLength Data Annotations)
								sb.Append($"{item.Name} varchar(50),");
								break;

							case "Char":
								sb.Append($"{item.Name} char(1),");
								break;

							case "Decimal":
							case "Double":
								sb.Append($"{item.Name} numeric ,");
								break;

							case "Int32":
							case "Int64":
								if(item.Name.ToUpper() == "ID")
									sb.Append($"{item.Name} INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT ,");
								else
									sb.Append($"{item.Name} INTEGER ,");
								break;

							case "DateTime":
								sb.Append($"{item.Name} Date ,");
								break;

							//SQLite não suporta valor booleano
							case "Bool":
							case "Boolean":
								sb.Append($"{item.Name} INTEGER ,");
								break;

							case "Byte[]":
							case "byte[]":
								sb.Append($"{item.Name} BLOB ,"); //BLOB
								break;
							}


						}
						sb.Remove(sb.Length - 1, 1);
						sb.Append(" )");

						cmd.CommandText = sb.ToString();
						cmd.ExecuteNonQuery();
					}
				}
			} catch(Exception ex) {
				throw ex;
			}

		}
		
	}
}
