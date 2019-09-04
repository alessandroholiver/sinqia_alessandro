using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Projeto01_ServiceWFC.Models;

namespace Projeto01_ServiceWFC
{
	
	public class ServiceConceitos : IServiceConceitos
	{
		private List<Aluno> alunos = new List<Aluno>();

		public void AdicionarAluno(Aluno aluno)
		{
			alunos.Add(aluno);
		}

		public double CalcularSoma(double y, double z)
		{
			return y + z;
		}

		public List<Aluno> ListarAluno()
		{
			return alunos;
		}

		public List<string> ListarNome()
		{
			return new List<string>()
			{
				"Bolsonaro","Lula","Pedro","Silvio Santos","Temer"

			};
		}
	}
}
