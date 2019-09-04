using ProjetoWeb_Eventos.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWeb_Eventos.DAL
{
	public class ConvidadosDao
	{
		public static void IncluirConvidado(Convidado convidado)
		{
			using (var context = new EventoEntities())
			{
				context.Convidados.Add(convidado);
				context.SaveChanges();
			}
		}

	}


}