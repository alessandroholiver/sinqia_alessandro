using ProjetoWeb_Eventos.Dados;
using ProjetoWeb_Eventos.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoWeb_Eventos.Paginas
{
	public partial class CadastroConvidado : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			//string s = Request.RequestType;

			if (!IsPostBack)
			{
				try
				{
					eventoDropDownList.DataSource = EventosDao.ListarEventos();
					eventoDropDownList.DataTextField = "Descricao";
					eventoDropDownList.DataValueField = "Id";
					eventoDropDownList.DataBind();
				}


				catch (Exception)
				{

					throw;
				}
			}
		}

		protected void incluirButton(object sender, EventArgs e)
		{
			try
			{
				Convidado convidado = new Convidado();
				convidado.CPF = cpfTextBox.Text;
				convidado.IdEvento = Convert.ToInt32(eventoDropDownList.SelectedValue);
				convidado.Nome = NomeTextBox.Text;
				convidado.Email = emailTextBox.Text;
				convidado.Telefone = telefoneTextBox.Text;

				ConvidadosDao.IncluirConvidado(convidado);


				mensagemConvidadoLabel.ForeColor = Color.Blue;
				mensagemConvidadoLabel.Text = "Convidado incluido com sucesso";
			}
			catch (Exception ex)
			{

				mensagemConvidadoLabel.ForeColor = Color.Red;
				mensagemConvidadoLabel.Text = ex.Message;
			}
		}
	}
}