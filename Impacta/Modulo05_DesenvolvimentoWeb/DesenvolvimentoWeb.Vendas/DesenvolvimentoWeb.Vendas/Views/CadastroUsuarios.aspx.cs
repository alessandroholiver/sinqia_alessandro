using DesenvolvimentoWeb.Vendas.Data;
using DesenvolvimentoWeb.Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesenvolvimentoWeb.Vendas.Views
{
	public partial class CadastroUsuarios : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			var nomeUsuario = Request.QueryString["nome"];
			if (nomeUsuario != null)
			{

				nomeTextBox.Text = nomeUsuario;

			}


		}

		protected void enviarButton1_Click(object sender, EventArgs e)
		{
			try
			{
				Usuario usuario = new Usuario();
				usuario.Nome = nomeTextBox.Text;
				usuario.Senha= senhaTextBox.Text;
				
				UsuariosDao.IncluirUsuario(usuario);
			

				mensagemLabel.CssClass = "alert alert-success";
				mensagemLabel.Text = "Usuario <strong>" +usuario.Nome+ "</strong>incluido com sucesso";
			}
			catch (Exception ex)
			{

				mensagemLabel.CssClass = "alert alert-danger";
				mensagemLabel.Text = ex.Message;
			}
		}
	}
}