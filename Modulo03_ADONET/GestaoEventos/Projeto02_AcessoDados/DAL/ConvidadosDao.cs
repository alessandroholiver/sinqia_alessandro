using Projeto02_AcessoDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Projeto02_AcessoDados.DAL
{
	public class ConvidadosDao : Dao<Convidado, string>
	{
		public override Convidado Buscar(string chave)
		{
			throw new NotImplementedException();
		}
		public int StatusInclusaoConvidado { get; set; }

		public override void Incluir(Convidado elemento)
		{
			try
			{
				AbrirConexao();
				cmd.CommandText = "pr_incluir_convidado";
				cmd.CommandType = CommandType.StoredProcedure;

				//Adicionado os parametros para colocar na procedure
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@cpf", elemento.Cpf);
				cmd.Parameters.AddWithValue("@idEvento", elemento.EventoInfo.Id);
				cmd.Parameters.AddWithValue("@nome", elemento.Nome);
				cmd.Parameters.AddWithValue("@telefone", elemento.Telefone);
				cmd.Parameters.AddWithValue("@email", elemento.Email);

				//pegando o parametro de saida do sql da Procedure
				SqlParameter parametroSaida = new SqlParameter();
				parametroSaida.ParameterName = "@status";	
				parametroSaida.SqlDbType = SqlDbType.Int;
				parametroSaida.Direction = ParameterDirection.Output;
				cmd.Parameters.Add(parametroSaida);


				cmd.ExecuteNonQuery();
				int status = (int)parametroSaida.Value;

				StatusInclusaoConvidado = status;
		
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

		//Metodo que retorna um conjunto de valores da tabela TBConvidados em forma de obejetos

		public DataTable ListarConvidados(int id)
		{
			var table = new DataTable();

			try
			{
				AbrirConexao();

				string sql = "SELECT C.CPF, C.Nome, C.Email, C.Telefone" +
					" FROM TBConvidados C, TBEventos B" +
					" WHERE B.Id = C.IdEvento AND C.IdEvento=" + id;

				cmd.CommandText = sql;
				cmd.CommandType = CommandType.Text;
				adapter.SelectCommand = cmd;

				adapter.Fill(table);
			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				FecharConexao();

			}

			return table;

		}

		public override IEnumerable<Convidado> Listar(int id = 0)
		{
			List<Convidado> convidados = new List<Convidado>();

			try
			{
				// verificar se o ID é menor que 0
				if (id < 0)
				{
					throw new Exception("Não é permitido parametro negativo");
				}
				AbrirConexao();

				string sql = "SELECT * FROM TBConvidados";

				//se o id for maior que 0, ele vai buscar apenas o evento pelo id
				if (id > 0)
				{
					sql+= " WHERE IdEvento = @IdEvento";
					cmd.Parameters.Clear();
					cmd.Parameters.AddWithValue("@IdEvento", id);
				}

				//recebendo o comando sql tipo texto
				cmd.CommandText = sql;
				cmd.CommandType = CommandType.Text;

				//comando para pegar cada linha da tabela
				reader = cmd.ExecuteReader();

				while (reader.Read()) {

					var c = new Convidado();
					c.Cpf = (string)reader["CPF"];
					c.Nome = (string)reader["Nome"];
					c.Email = (string)reader["Email"];
					c.Telefone = (string)reader["Telefone"];
					c.EventoInfo = new EventosDao().Buscar((int)reader["IDEvento"]);

					convidados.Add(c);
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
			return convidados;
		}
	}
}
