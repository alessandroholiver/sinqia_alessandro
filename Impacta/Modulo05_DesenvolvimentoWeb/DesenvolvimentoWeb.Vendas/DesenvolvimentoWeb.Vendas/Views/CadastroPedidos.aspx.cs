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
	public partial class CadastroPedidos : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				clienteDropDowList.DataSource = ClientesDao.ListarClientes();
				clienteDropDowList.DataTextField = "Nome";
				clienteDropDowList.DataValueField = "Documento";
				clienteDropDowList.DataBind();

			}
		}

		protected void incluirPedidoButton_Click(object sender, EventArgs e)
		{
			try
			{
				
				Pedido pedido = new Pedido();
				pedido.DocCliente = clienteDropDowList.SelectedValue;
				pedido.Data = Convert.ToDateTime(dataTextBox.Text);
				pedido.NumeroPedido = pedidoTextbox.Text;
				

				PedidosDao.IncluirPedido(pedido);
				

				mensagemLabel.CssClass = "alert alert-success";
				mensagemLabel.Text = "Pedido incluido com sucesso";
			}
			catch (Exception ex)
			{

				mensagemLabel.CssClass = "alert alert-danger";
				mensagemLabel.Text = ex.Message;
			}
		}

	
	}
}