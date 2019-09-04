using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Projeto02_AcessoDados.DAL
{
	/*Esta classe é abtrasta pois é o minimo que o objeto pode fazer, ela nao precisa ser instanciada
	 O simbolo <> é para fazer a classe se tornar generica para receber o tipo de objeto que a classe
	filha precisa receber*/
	public abstract class Dao<T, K>
	{
		public Dao()
		{
			cn = new SqlConnection(conexao);
			cmd = new SqlCommand();
			cmd.Connection = cn;
			adapter = new SqlDataAdapter();
		}
		//string de conexao com o banco de dados
	   	protected string conexao =  @"Password=Imp@ct@;Persist Security Info=True;User ID=sa;Initial Catalog=DB_EVENTOS;Data Source=.";
	
		//objetos de acesso a dados
		protected SqlConnection cn; //comandos de conexao com o banco
		protected SqlCommand cmd; // comandos de update, select e etc

		protected SqlDataReader reader; //modo conectado unidirecional
		protected SqlDataAdapter adapter; //  modo desconectado multidirecional


		//metodos para abrir e fechar conexao

		protected void AbrirConexao()
		{
			cn.Open();
		}

		protected void FecharConexao()
		{
			if(cn.State == ConnectionState.Open && cn!= null )
			cn.Close();
		}

		//Metodos abstratos para o minimo que a classe filhas precisa para funcionar
		//Isto obriga as classe filhas implementarem o metodo dentro delas
		public abstract void Incluir(T elemento);
		public abstract T Buscar(K chave);

		// metodo com valor opçional - nA ausncia do parametro ele fica como default
		public abstract IEnumerable<T> Listar(int id = 0);

	}
}
