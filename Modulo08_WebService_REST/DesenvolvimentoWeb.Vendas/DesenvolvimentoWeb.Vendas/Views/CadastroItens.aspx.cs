using DesenvolvimentoWeb.Vendas.Data;
using DesenvolvimentoWeb.Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesenvolvimentoWeb.Vendas.Views
{
	public partial class CadastroItens : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				pedidoDropDowList.DataSource = PedidosDao.ListarPedidosVM();
				pedidoDropDowList.DataTextField = "NomeCliente";
				pedidoDropDowList.DataValueField = "IdPedido";
				pedidoDropDowList.DataBind();


				produtosDropDownList1.DataSource = ProdutosDao.ListarProdutos();
				produtosDropDownList1.DataTextField = "Descricao";
				produtosDropDownList1.DataValueField = "Id";
				produtosDropDownList1.DataBind();

			}


		}

		protected void incluirItemButton_Click(object sender, EventArgs e)
		{
			try
			{

				Item item = new Item();

				item.IdPedido = int.Parse(pedidoDropDowList.SelectedValue);
				item.IdProduto = int.Parse(produtosDropDownList1.SelectedValue);
				item.Quantidade = double.Parse(quantidadeTextBox.Text);

				ItensDao.IncluirItem(item);


				mensagemLabel.CssClass = "alert alert-success";
				mensagemLabel.Text = "Item incluido com sucesso";
			}
			catch (Exception ex)
			{

				mensagemLabel.CssClass = "alert alert-danger";
				mensagemLabel.Text = ex.Message;
			}

		}
	}
}