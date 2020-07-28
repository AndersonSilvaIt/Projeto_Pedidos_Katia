using Projeto_Pedido.Business.Repositories.EntitiesRepository;
using Projeto_Pedido.DAL.Entities;
using System;
using System.Collections.Generic;

namespace Projeto_Pedido.Business.Valitadors {
	public static class EntityValidator {

		public static List<Tuple<string, string>> ListaValidacoes;
		public static void ValidarEntidade(Entidade entidade)
		{
			ListaValidacoes = new List<Tuple<string, string>>();

			if (string.IsNullOrWhiteSpace(entidade.Codigo))
				ListaValidacoes.Add(new Tuple<string, string>("Código", "Campo Código é obrigatório"));

			if (EntityRepository.VerificaDuplicidade(entidade.Id, entidade.Codigo))
				ListaValidacoes.Add(new Tuple<string, string>("Código", $"Já existe um cadastro com esse código: {entidade.Codigo}"));

			if (string.IsNullOrWhiteSpace(entidade.RazaoSocial))
				ListaValidacoes.Add(new Tuple<string, string>("Razão Social", "Campo Razão Social é obrigatório"));
		}
	}
}
