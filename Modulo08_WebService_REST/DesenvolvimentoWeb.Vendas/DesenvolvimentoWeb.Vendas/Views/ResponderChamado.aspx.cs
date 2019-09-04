using DesenvolvimentoWeb.Vendas.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesenvolvimentoWeb.Vendas.Views
{
    public partial class ResponderChamado : System.Web.UI.Page
    {
        //OBJETO QUE FAZ ACESSO AO SERVIÇO
        //  HttpClient esta presente no namspace system net http
        HttpClient client;
       static Chamado chamado;

        public ResponderChamado()
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
                    HttpResponseMessage response = client.GetAsync("chamadosPendentes").Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var resultado = await response.Content.ReadAsStringAsync();

                        var lista = JsonConvert.DeserializeObject<Chamado[]>(resultado).ToList();

                        chamadosDropDowList.DataSource = lista;
                        chamadosDropDowList.DataTextField = "ChamadoId";
                        chamadosDropDowList.DataValueField = "ChamadoId";
                        chamadosDropDowList.DataBind();

                        responderButton.Enabled = (chamado != null);
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }

        }
      

        protected async void buscarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(chamadosDropDowList.SelectedValue);

                HttpResponseMessage response = client.GetAsync("api/chamados/"+id).Result;

                if (response.IsSuccessStatusCode)
                {
                    var resultado = await response.Content.ReadAsStringAsync();

                    chamado = JsonConvert.DeserializeObject<Chamado>(resultado);

                    responderButton.Enabled = (chamado != null);

                    descricaoTextBox.Text = chamado.Assunto + ":\n\n" + chamado.Descricao;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected async void responderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (chamado == null)
                {
                    throw new Exception("Por favor, buscar um chamado");
                }
                chamado.Resposta = responderTextbox.Text;

                //criando o objeto no formato JSON
                string json = JsonConvert.SerializeObject(chamado);

                //definindo o json para um fluxo de bytes
                HttpContent content = new StringContent(json, Encoding.Unicode, "application/json");

                //enviando o objeto serializado para o webservice
                var response = await client.PutAsync("api/chamados/", content);

                if (response.IsSuccessStatusCode)
                {

                    mensagemLabel.CssClass = "alert alert-sucess";
                    mensagemLabel.Text = "Chamado respondido com sucesso";

                }
                else
                {

                    string erro = response.StatusCode + " - " + response.ReasonPhrase;
                    throw new Exception(erro);
                }

            }
            catch (Exception ex)
            {

                mensagemLabel.CssClass = "alert alert-danger";
                mensagemLabel.Text = ex.Message;
            }
        }

        protected async void apagarButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (chamado == null)
                {
                    throw new Exception("Por favor, buscar um chamado");
                }
                int id = int.Parse(chamadosDropDowList.SelectedValue);

                //criando o objeto no formato JSON
                string json = JsonConvert.SerializeObject(chamado);

                //definindo o json para um fluxo de bytes
                HttpContent content = new StringContent(json, Encoding.Unicode, "application/json");

                //enviando o objeto serializado para o webservice
                var response = await client.DeleteAsync("api/chamados/"+id);

                if (response.IsSuccessStatusCode)
                {

                    mensagemLabel.CssClass = "alert alert-sucess";
                    mensagemLabel.Text = "Chamado excluido com sucesso";

                }
                else
                {

                    string erro = response.StatusCode + " - " + response.ReasonPhrase;
                    throw new Exception(erro);
                }

            }
            catch (Exception ex)
            {

                mensagemLabel.CssClass = "alert alert-danger";
                mensagemLabel.Text = ex.Message;
            }

        }
    }
}