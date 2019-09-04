using Projeto02_AcessoDados.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_AcessoDados.DAL
{
	public class EscolaDao : Dao<Escola, int>
	{
		public override Escola Buscar(int chave)
		{
			Escola escola = null;

			try
			{
				AbrirConexao();
				cmd.CommandText = "SELECT * FROM TB_ESCOLAS WHERE Id= @Id";
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@Id", chave);
				reader = cmd.ExecuteReader();

				if (reader.Read()) {

					escola = new Escola();

					escola.Id = (int)reader["Id"];
					escola.Descricao = reader["Descricao"].ToString();
					escola.Endereco = reader["Endereco"].ToString();
					escola.telefone = reader["Telefone"].ToString();

				}

			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				FecharConexao();
			}

			return escola;
		}

		public override void Incluir(Escola elemento)
		{
			
			try
			{
				AbrirConexao();

				cmd.CommandText = "INSERT INTO TB_ESCOLAS (Descricao, Endereco, Telefone)" +
					"VALUES (@Descricao, @Endereco, @Telefone)";
				cmd.CommandType = CommandType.Text;



				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@Descricao", elemento.Descricao);
				cmd.Parameters.AddWithValue("@Endereco", elemento.Endereco);
				cmd.Parameters.AddWithValue("@Telefone", elemento.telefone);

				cmd.ExecuteNonQuery();

			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				FecharConexao();
			}
		}

		public override IEnumerable<Escola> Listar(int id = 0)
		{
			List<Escola> escola = new List<Escola>();

			try
			{

				if (id != 0)
				{

				}

			}
			catch (Exception)
			{

				throw;
			}

		}
	}
}
