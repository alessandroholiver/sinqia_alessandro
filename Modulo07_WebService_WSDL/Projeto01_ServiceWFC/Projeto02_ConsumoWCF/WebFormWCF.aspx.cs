using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto02_ConsumoWCF
{
	public partial class WebFormWCF : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void calcularButton_Click(object sender, EventArgs e)
		{
			var x = Convert.ToDouble(valor1TextBox.Text);
			var y = Convert.ToDouble(valor2TextBox.Text);

			ServicePooxy.ServiceConceitosClient client = new ServicePooxy.ServiceConceitosClient();


			var resultado = client.CalcularSoma(x, y);

			nomesListBox.Items.Clear();
			nomesListBox.Items.Add("Soma: " + resultado);
		}

		protected void nomesButton_Click(object sender, EventArgs e)
		{
			ServicePooxy.ServiceConceitosClient client = new ServicePooxy.ServiceConceitosClient();

			nomesListBox.Items.Clear();
			var nome = client.ListarNome();
			foreach (var item in nome)
			{
				nomesListBox.Items.Add(item);

			}
		}
	}
}