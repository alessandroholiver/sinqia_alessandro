using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_AcessoDados.Models
{
	public class Evento
	{
		public int Id { get; set; }
		public string Descricao { get; set; }
		public string Responsavel { get; set; }
		public DateTime Data { get; set; }
		public double Preco { get; set; }

		//propriedade de navegação
		public List<Convidado> Convidados { get; set; }

	}
}
