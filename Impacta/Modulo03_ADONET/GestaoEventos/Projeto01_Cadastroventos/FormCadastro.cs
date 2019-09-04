using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto02_AcessoDados;
using Projeto02_AcessoDados.Models;
using Projeto02_AcessoDados.DAL;
using Projeto01_Cadastroventos.RepositoryDao;

namespace Projeto01_Cadastroventos
{
	public partial class FormCadastro : Form
	{
		public FormCadastro()
		{
			InitializeComponent();
			ListarEventos();
			
		}

		private void incluirEventobutton_Click(object sender, EventArgs e)
		{
			try
			{
				Evento evento = new Evento();
				evento.Descricao = descTextBox.Text;
				evento.Data = Convert.ToDateTime(dataMaskedTextBox.Text);
				evento.Responsavel = respTextBox.Text;
				evento.Preco = Convert.ToDouble(valorTextBox.Text);

				EventosDao dao = Repository.GetEventosDao();
				dao.Incluir(evento);
				ListarEventos();

				MessageBox.Show("evento incluido com sucesso");

				//Limpando o campo de entrada
				descTextBox.Clear();
				dataMaskedTextBox.Clear();
				valorTextBox.Clear();
				respTextBox.Clear();

				// colocando o cursor na caixa de texto
				descTextBox.Focus();

				
				eventosComboBox.Items.Add(evento.Descricao);
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void ListarEventos() {

			try
			{
				var dao = Repository.GetEventosDao();
				eventosComboBox.DataSource = dao.Listar();
				eventosComboBox.DisplayMember = "Descricao"; //Text
				eventosComboBox.ValueMember = "Id"; //Value
			}
			catch (Exception ex)
			{


				MessageBox.Show(ex.Message);
				
			}
		}

		private void incluirConvidadobutton_Click(object sender, EventArgs e)
		{
			try
			{
				Convidado convidado = new Convidado();
				ConvidadosDao dao = Repository.GetConvidadosDao();

				convidado.Cpf = cpfTextBox.Text;
				convidado.Nome = nomeTextBoxC.Text;
				convidado.Email = emailTextBox.Text;
				convidado.Telefone = telefoneTextBox.Text;


				//obtendo o ID do evento apartir do obejo comboBox
				int id = (int)eventosComboBox.SelectedValue;

				convidado.EventoInfo = Repository.GetEventosDao().Buscar(id);

				//Incluindo o convidado no banco de dados
				dao.Incluir(convidado);

				if (dao.StatusInclusaoConvidado == 1)
				{
					MessageBox.Show("Convidado alterado com sucesso");
				}
				else {

					MessageBox.Show("Convidado incluido com sucesso");
				}

				cpfTextBox.Clear();
				nomeTextBoxC.Clear();
				emailTextBox.Clear();
				telefoneTextBox.Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			}
		}

		private void buscarConvidadosButton_Click(object sender, EventArgs e)
		{
			try
			{
				int id = (int)eventosComboBox.SelectedValue;

				var dao = Repository.GetConvidadosDao();
				convidadosDataGridView.DataSource = dao.ListarConvidados(id); 
				
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
