using DesenvolvimentoWeb.Vendas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesenvolvimentoWeb.Vendas.Views
{
	public partial class ListaItensAjax : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				pedidoDropDowList.DataSource = PedidosDao.ListarPedidosVM();
				pedidoDropDowList.DataTextField = "NomeCliente";
				pedidoDropDowList.DataValueField = "NumeroPedido";
				pedidoDropDowList.DataBind();
				pedidoDropDowList.Items.Insert(0, "SELECIONE UM PEDIDO");
			}

		}

		protected void pedidoDropDowList_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListarItens();
		}

		protected void excluirLinkButton_Click(object sender, EventArgs e)
		{
			try
			{
				var x = ((LinkButton)sender).CommandArgument;

				ItensDao.RemoverItem(int.Parse(x));
				ListarItens();
			}
			catch (Exception)
			{

				throw;
			}

		}

		private void ListarItens()
		{

			try
			{
				string numeroPedido = pedidoDropDowList.SelectedValue;
				itensRepeater.DataSource = ItensDao.ListarItensPorPedidos(numeroPedido);
				itensRepeater.DataBind();
			}
			catch (Exception)
			{

				throw;
			}

		}
	}
}
