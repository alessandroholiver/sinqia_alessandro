﻿using ProjetoWeb_Eventos.Dados;
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
	public partial class CadastroEventos : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void incluirButton_Click(object sender, EventArgs e)
		{
			try
			{
				Evento evento = new Evento();
				evento.Descricao = descricaoTextBox.Text;
				evento.Resposavel = responsavelTextBox.Text;
				evento.Descricao = descricaoTextBox.Text;
				evento.Data = Convert.ToDateTime(dataTextBox.Text);
				evento.Preco = Convert.ToDouble(precoTextBox.Text);

				EventosDao.IncluirEvento(evento);
				mensagemLabel.ForeColor = Color.Blue;
				mensagemLabel.Text = "Evento incluido com sucesso";


			}
			catch (Exception ex)
			{
				mensagemLabel.ForeColor = Color.Red;
				mensagemLabel.Text = ex.Message;
			}
		}
	}
}