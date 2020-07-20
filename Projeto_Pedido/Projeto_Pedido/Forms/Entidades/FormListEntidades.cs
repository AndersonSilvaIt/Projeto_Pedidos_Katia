using Projeto_Pedido.Business.Repositories.EntitiesRepository;
using Projeto_Pedido.DAL.Entities;
using System;
using System.ComponentModel;


namespace Projeto_Pedido.Forms.Entidades {
	public partial class FormListEntidades : FormUtil {

		public FormListEntidades()
		{
			InitializeComponent();
			AtualizaFormulario();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			new FormCliFornecedor().ShowDialog();
			AtualizaFormulario();
		}

		private void Search()
		{
			string codigo = txtCodigo.Text;
			string razaoSocial = txtRazaoSocial.Text;
			int tipoCliente = 0;
			int.TryParse((ddlTipoCli.SelectedItem as dynamic).Value, out tipoCliente);

			int tipoDoc = 0;
			int.TryParse((ddlTipoDoc.SelectedItem as dynamic).Value, out tipoDoc);

			string UF = (ddlUF.SelectedItem as dynamic).Text;
	
			string documento = txtDocumento.Text;
			
			var lista = EntityRepository.SearchEntity(codigo, razaoSocial, tipoCliente, tipoDoc, documento, UF);
			var binding = new BindingList<Entidade>(lista);
			grdEntidade.DataSource = binding;
			grdEntidade.Refresh();
		}

		private void AtualizaFormulario()
		{
			ddlTipoDoc.DisplayMember = "Text";
			ddlTipoDoc.ValueMember = "Value";
			var items = new[] {
				new { Text = " ", Value = "0" },
				new { Text = "P. Física", Value = "1" },
				new { Text = "P. Jurídica", Value = "2" }
			};
			ddlTipoDoc.DataSource = items;

			ddlTipoCli.DisplayMember = "Text";
			ddlTipoCli.ValueMember = "Value";
			var itemsCliente = new[] {
				new { Text = " ", Value = "0" },
				new { Text = "Cliente", Value = "1" },
				new { Text = "Fornecedor", Value = "2" }
			};
			ddlTipoCli.DataSource = itemsCliente;

			DirtyUF(ddlUF);

			Search();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			ClearFields(this);
			AtualizaFormulario();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Search();
		}

		private void grdEntidade_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1 && e.ColumnIndex > -1)
			{
				var _entidade = (Entidade)grdEntidade.Rows[e.RowIndex].DataBoundItem;

				FormCliFornecedor frmCliFornecedor = new FormCliFornecedor(_entidade);
				frmCliFornecedor.ShowDialog();
				this.Close();

				AtualizaFormulario();
			}
		}
	}
}
