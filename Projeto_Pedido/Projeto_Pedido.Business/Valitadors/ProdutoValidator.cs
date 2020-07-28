using Projeto_Pedido.Business.Repositories.EntitiesRepository;
using Projeto_Pedido.DAL.Entities;
using System;
using System.Collections.Generic;

namespace Projeto_Pedido.Business.Valitadors {

	public static class ProdutoValidator  {

		public static List<Tuple<string, string>> ListaValidacoes;
		public static void ValidarProduto(Product product)
		{
			ListaValidacoes = new List<Tuple<string, string>>();

			if (string.IsNullOrWhiteSpace(product.Codigo))
				ListaValidacoes.Add(new Tuple<string, string>("Código", "Campo Código é obrigatório"));

			if (ProductRepository.VerificaDuplicidade(product.Id, product.Codigo))
				ListaValidacoes.Add(new Tuple<string, string>("Código", $"Já existe um produto com esse código: {product.Codigo}"));

			if (string.IsNullOrWhiteSpace(product.Descricao))
				ListaValidacoes.Add(new Tuple<string, string>("Descrição", "Campo Descrição é obrigatório"));
		}
	}
}
