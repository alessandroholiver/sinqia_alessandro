using Projeto02_AcessoDados.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_AcessoDados.DAL
{
	public class CursoDao : Dao<Curso, int>
	{
		public override Curso Buscar(int chave)
		{
			throw new NotImplementedException();
		}
		public int StatusInclusaoCurso { get; set; }

		public override void Incluir(Curso elemento)
		{
			try
			{
				AbrirConexao();
				cmd.CommandText = "pr_incluir_curso";
				cmd.CommandType = CommandType.StoredProcedure;

				//Parametros
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@Codigo", elemento.Codigo);
				cmd.Parameters.AddWithValue("@IdEscola", elemento.EscolaInfo.Id);
				cmd.Parameters.AddWithValue("@Descricao", elemento.Descricao);
				cmd.Parameters.AddWithValue("@CargaHoraria", elemento.CargaHoraria);
				cmd.Parameters.AddWithValue("@Preco", elemento.Preco);

				//pegando o parametro de saida do sql
				SqlParameter parametroSaida = new SqlParameter();
				parametroSaida.ParameterName = "@status";
				parametroSaida.SqlDbType = SqlDbType.Int;
				parametroSaida.Direction = ParameterDirection.Output;
				cmd.Parameters.Add(parametroSaida);

				cmd.ExecuteNonQuery();
				int codigo = (int)parametroSaida.Value;

				StatusInclusaoCurso = codigo;
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

		public DataTable ListarCursos(int id)
			{
			var table = new DataTable();

			try
			{
				AbrirConexao();

				string sql = "SELECT C.Codigo, C.Descricao, C.CargaHoraria, C.Preco" +
					" FROM TB_CURSOS C, TB_ESCOLAS B" +
					" WHERE C.Codigo = B.Id and C.Codigo=" + id;

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

		public override IEnumerable<Curso> Listar(int id = 0)
		{
			List<Curso> curso = new List<Curso>();
			try
			{
				// verificar se o ID é menor que 0
				if (id < 0)
				{
					throw new Exception("Não é permitido parametro negativo");
				}
				AbrirConexao();

				string sql = "SELECT * FROM TB_CURSOS";

				//se o id for maior que 0, ele vai buscar apenas o evento pelo id
				if (id > 0)
				{
					sql += " WHERE IdEscola = @IdEscola";
					cmd.Parameters.Clear();
					cmd.Parameters.AddWithValue("@IdEscola", id);
				}

				//recebendo o comando sql tipo texto
				cmd.CommandText = sql;
				cmd.CommandType = CommandType.Text;

				//comando para pegar cada linha da tabela
				reader = cmd.ExecuteReader();

				while (reader.Read())
				{

					var c = new Curso();
					c.Codigo = (int)reader["Codigo"];
					c.Descricao = (string)reader["Descricao"];
					c.CargaHoraria = (int)reader["CargaHoraria"];
					c.Preco = (decimal)reader["Preco"];
					c.EscolaInfo = new cursoDao().Buscar((int)reader["IDEscola"]);

					curso.Add(c);
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
			return curso;
		}
	}
	}
}
