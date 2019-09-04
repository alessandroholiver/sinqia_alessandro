using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02_AcessoDados.Models;
using Projeto02_AcessoDados.DAL;

namespace Projeto01_CadastroEscola.RepositoryDao
{
	class Repository
	{
		static CursoDao cursoDao;
		static EscolaDao escolaDao;

		public static EscolaDao GetEscolaDao()
		{
			if (escolaDao == null)
			{
				escolaDao = new EscolaDao();
			}

			return escolaDao;
		}

		public static CursoDao GetCursoDao()
		{
			if (cursoDao == null)
			{
				cursoDao = new CursoDao();
			}

			return cursoDao;
		}
	}
}
