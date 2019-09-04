using Projeto01_ServiceWFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Projeto01_ServiceWFC
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	public interface IServiceConceitos
	{
		[OperationContract]
		List<Aluno> ListarAluno();

		[OperationContract]
		void AdicionarAluno(Aluno aluno);

		//metodos adiionais
		[OperationContract]
		List<string> ListarNome();

		[OperationContract]
		double CalcularSoma(double y, double z);
	}


	
}
