using Projeto02_WCFPagamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Projeto02_WCFPagamentos
{
	[ServiceContract]
	public interface IServicePagamentos
	{
		[OperationContract]
		List<CartaoContract> ListarCartoes();
		[OperationContract]
		List<PagamentoContract> ListarPagamentos();
		[OperationContract]
		int EfetuarPagamento(PagamentoContract pagamento);




	}
}
