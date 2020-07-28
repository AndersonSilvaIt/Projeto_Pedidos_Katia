using Projeto_Pedido.Business.Repositories.EntitiesRepository;
using Projeto_Pedido.DAL.Entities;
using Projeto_Pedido.Forms.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Projeto_Pedido.Forms {
	public partial class FormListProduto : FormUtil {

		public FormListProduto()
		{
			InitializeComponent();

			AtualizaFormulario();
		}

		private void Search()
		{
			string codigo = txtCodigo.Text;
			string descricao = txtDescricao.Text;
			int idFornecedor = 0;
			var fornecedor = (ddlFornecedor.SelectedItem as Entidade);
			if (fornecedor != null)
			{
				idFornecedor = fornecedor.Id;
			}

			var lista = ProductRepository.SearchEntity(codigo, descricao, idFornecedor);
			ProductRepository.PreencherForencedor(lista);
			ProductRepository.PreencherUnidadeMedida(lista);

			var binding = new BindingList<Product>(lista);
			grdProduto.DataSource = binding;
			grdProduto.Refresh();
		}

		private void AtualizaFormulario()
		{
			var listaFornecedor = new List<Entidade>();
			//Obtem os fornecedores tipo = 1
			listaFornecedor = new List<Entidade>() { new Entidade() { Codigo = "", RazaoSocial = "", Id = 0 } };
			listaFornecedor.AddRange(EntityRepository.GetAll().Where(x => x.TipoCli == 2).ToList());

			var a = listaFornecedor.OrderBy(p => p.Codigo).ThenBy(p => p.RazaoSocial).ToList();

			ddlFornecedor.DataSource = a;
			ddlFornecedor.Refresh();
			this.ddlFornecedor.DisplayMember = "Descricao";
			this.ddlFornecedor.ValueMember = "Id";

			Search();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			new FormCadProduto().ShowDialog();
			AtualizaFormulario();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Search();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			ClearFields(this);
			AtualizaFormulario();
		}

		private void grdProduto_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1 && e.ColumnIndex > -1)
			{
				var _product = (Product)grdProduto.Rows[e.RowIndex].DataBoundItem;
				FormCadProduto frmCadProduto = new FormCadProduto(_product);

				frmCadProduto.ShowDialog();

				AtualizaFormulario();
			}
		}
	}
}
