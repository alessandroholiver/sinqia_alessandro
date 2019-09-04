using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Projeto02_AcessoDados.DAL
{
	public abstract class Dao<T,K>
	{
		public Dao()
		{
			cn = new SqlConnection(conexao);
			cmd = new SqlCommand();
			cmd.Connection = cn;
			adapter = new SqlDataAdapter();
		}

		protected string conexao = @"Password=Imp@ct@;Persist Security Info=True;User ID=sa;Initial Catalog=DB_ESCOLA;Data Source=.";

		protected SqlConnection cn;
		protected SqlCommand cmd;

		protected SqlDataAdapter adapter;
		protected SqlDataReader reader;

		protected void AbrirConexao()
		{

			cn.Open();

		}

		protected void FecharConexao()
		{
			if (cn.State == ConnectionState.Open && cn != null)
				cn.Close();
		}

		public abstract void Incluir(T elemento);
		public abstract T Buscar(K chave);
		public abstract IEnumerable<T> Listar(int id = 0);

	}
}
