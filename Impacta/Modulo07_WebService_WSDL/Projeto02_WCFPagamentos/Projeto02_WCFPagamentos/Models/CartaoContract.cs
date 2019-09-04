using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Projeto02_WCFPagamentos.Models
{
	[DataContract]
	public class CartaoContract
	{
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string NumeroCartao { get; set; }
		[DataMember]
		public double Limite { get; set; }
	}
}