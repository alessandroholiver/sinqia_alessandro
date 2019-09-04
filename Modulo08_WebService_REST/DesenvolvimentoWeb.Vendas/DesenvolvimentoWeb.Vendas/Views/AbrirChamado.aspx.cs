using DesenvolvimentoWeb.Vendas.Data;
using DesenvolvimentoWeb.Vendas.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesenvolvimentoWeb.Vendas.Views
{
    public partial class AbrirChamado : System.Web.UI.Page
    {
        //OBJETO QUE FAZ ACESSO AO SERVIÇO
        //  HttpClient esta presente no namspace system net http
        HttpClient client;
        public AbrirChamado()
        {
            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress=new Uri("http://localhost:50632/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/jason"));

            
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                List<string> assuntos = new List<string>()
                {
                    "SUGESTÃO", "ELOGIOS", "RECLAMAÇÃO", "TROCAS","DÙVIDAS"
                };

                assuntoDropDowList.DataSource = assuntos;
                assuntoDropDowList.DataBind();
            }

        }

        protected async void enviarPedidoButton_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = ClientesDao.BuscarCliente(documentoTextBox.Text);
                if (cliente == null)
                {
                    throw new Exception("Não existe nenhum cliente com o documento informado");

                }


                Chamado chamado = new Chamado();
                chamado.Assunto = assuntoDropDowList.SelectedValue;
                chamado.Documento = documentoTextBox.Text;
                chamado.Descricao = descricaoTextbox.Text;

                //criando o objeto no formato JSON
                string json = JsonConvert.SerializeObject(chamado);

                //definindo o json para um fluxo de bytes
                HttpContent content = new StringContent(json, Encoding.Unicode, "application/json");

                //enviando o objeto serializado para o webservice
                var response = await client.PostAsync("api/chamados", content);

                //verificar se ocorreu a inclusao corretamente
                if (response.IsSuccessStatusCode)
                {

                    mensagemLabel.CssClass = "alert alert-sucess";
                    mensagemLabel.Text = "Chamado aberto com sucesso";

                }
                else {

                    string erro = response.StatusCode + " - " + response.ReasonPhrase;
                    throw new Exception(erro);
                }

            }
            catch ( Exception ex)
            {

                mensagemLabel.CssClass = "alert alert-danger";
                mensagemLabel.Text = ex.Message;
            }
        }
    }
}