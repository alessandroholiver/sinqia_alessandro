using DesenvolvimentoWeb.Vendas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesenvolvimentoWeb.Vendas.Views
{
	public partial class EfetuarPagamento : System.Web.UI.Page
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

		protected void pagamentoButton_Click(object sender, EventArgs e)
		{
			try
			{
				//Obtendo o numero do pedido
				string numPedido = pedidoDropDowList.SelectedValue;

				//o valor total de itens para o pedido selecionado
				double totalPedido = ItensDao.ListarItensPorPedidos(numPedido).Sum(p => p.ValorTotalItem);

				//Obtendo o numero do cartao
				string cartao = cartaoTextBox.Text;

				//instanciando a classe pagamento contract obtida atrves do serviço
				ServiceProxy.PagamentoContract pagamento = new ServiceProxy.PagamentoContract();
				pagamento.NumeroCartao = cartao;
				pagamento.NumeroPedido = numPedido;
				pagamento.Valor = totalPedido;


				ServiceProxy.ServicePagamentosClient service = new ServiceProxy.ServicePagamentosClient();

				int resposta = service.EfetuarPagamento(pagamento);


				switch (resposta)
				{
					
					case 1:
						throw new Exception("Numero de cartão não encontrado");
						

					case 2:
						throw new Exception ( "O pedido ja foi está pago");
					

					case 3:
						throw new Exception("Limite insuficiente");
						
						
					default:
						break;
				}
				mensagemLabel.CssClass = "text text-success";
				mensagemLabel.Text = "Pedido <strong>" + numPedido + "</strong> pago com sucesso";



			}
			catch (Exception ex)
			{
				mensagemLabel.CssClass = "text text-danger";
				mensagemLabel.Text = ex.Message;
			}
		}
	}
}