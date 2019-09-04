using DesenvolvimentoWeb.Vendas.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesenvolvimentoWeb.Vendas.Views
{
    public partial class Chamados_Resolvidos : System.Web.UI.Page
    {
        HttpClient client;
        static Chamado chamado;

        public Chamados_Resolvidos()
        {
            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:50632/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/jason"));


            }
        }
        protected async void Page_Load(object sender, EventArgs e)
        {

            


            if (!IsPostBack)
            {
                try
                {
                    HttpResponseMessage response = client.GetAsync("chamadosResolvidos").Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var resultado = await response.Content.ReadAsStringAsync();

                        var lista = JsonConvert.DeserializeObject<Chamado[]>(resultado).ToList();

                        chamadosRepeater.DataSource = lista;
                        chamadosRepeater.DataBind();
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }

        }
    }
}