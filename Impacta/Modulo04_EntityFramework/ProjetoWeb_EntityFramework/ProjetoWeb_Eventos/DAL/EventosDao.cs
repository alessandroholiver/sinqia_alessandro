using ProjetoWeb_Eventos.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWeb_Eventos.DAL
{
	public class EventosDao
	{

		public static void IncluirEvento(Evento evento)
		{
			using (var context = new EventoEntities())
			{
				context.Eventos.Add(evento);
				context.SaveChanges();
			}
		}

		public static List<Evento> ListarEventos()
		{
			using (var context = new EventoEntities())
			{
				return context.Eventos.ToList();
			}

		}

		public static Evento BuscarEvento( int id)
		{
			using (var context = new EventoEntities())
			{
				return context.Eventos.FirstOrDefault(p=> p.Id == id);
			}

		}
	}
}