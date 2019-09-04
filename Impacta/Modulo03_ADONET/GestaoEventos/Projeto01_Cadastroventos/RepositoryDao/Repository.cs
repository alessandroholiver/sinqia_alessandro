using Projeto02_AcessoDados.DAL;
using Projeto02_AcessoDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01_Cadastroventos.RepositoryDao
{
	public sealed class Repository
	{
		static EventosDao eventosDao;
		static ConvidadosDao convidadoDao;

		public static EventosDao GetEventosDao()
		{

			if (eventosDao == null)
			{
				eventosDao = new EventosDao();

			}
			return eventosDao;
		}


		public static ConvidadosDao GetConvidadosDao()
		{

			if (convidadoDao == null)
			{
				convidadoDao = new ConvidadosDao();

			}
			return convidadoDao;
		}
	}
}
