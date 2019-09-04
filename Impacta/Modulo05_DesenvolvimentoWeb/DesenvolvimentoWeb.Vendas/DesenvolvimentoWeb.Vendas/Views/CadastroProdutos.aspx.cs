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
	public partial class CadastroProdutos : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				categoriaDropDowList.DataSource = ProdutosDao.ListarCategorias();
				categoriaDropDowList.DataTextField = "Descricao";
				categoriaDropDowList.DataValueField = "Id";
				categoriaDropDowList.DataBind();


				List<string> unidades = new List<string>()
				{
					"KILO", "PACOTE,", "POLEGADAS", "LITROS", "GRAMAS", "DECIBEIS", "UNIDADE"
				};

				unidadeDropDownList.DataSource = unidades;
				unidadeDropDownList.DataBind();

				produtosrepeater.DataSource = ProdutosDao.ListarProdutos();
				produtosrepeater.DataBind();
			}
		}

		protected void enviarButton1_Click(object sender, EventArgs e)
		{
			try
			{
				HttpPostedFile file = figuraFileUpload.PostedFile;
				//Validando a foto

				if (file == null ||	string.IsNullOrEmpty(file.FileName) || 
					file.InputStream == null)
				{
					throw new Exception("Arquivo para o produto nao encontrado");
				}

				Produto produto = new Produto();
				produto.IdCategoria = Convert.ToInt32(categoriaDropDowList.SelectedValue);
				produto.Descricao = descricaoTextBox.Text;
				produto.Unidade = unidadeDropDownList.SelectedValue;
				produto.Preco = Convert.ToDouble(precoTextebox.Text);

				

				produto.MimeType = file.ContentType;

				byte[] bytes = new byte[file.InputStream.Length];
				file.InputStream.Read(bytes, 0, bytes.Length);
				produto.Foto = bytes;


				ProdutosDao.IncluirProduto(produto);
				//ListarRepeaterClientes();

				mensagemLabel.CssClass = "alert alert-success";
				mensagemLabel.Text = "Produto incluido com sucesso";
			}
			catch (Exception ex)
			{

				mensagemLabel.CssClass = "alert alert-danger";
				mensagemLabel.Text = ex.Message;
			}
		}

		protected void produtosrepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
		{
			HiddenField idField =(HiddenField)e.Item.FindControl("idHiddenField");

			if (idField!=null)
			{

				int id = Convert.ToInt32(idField.Value);
				Image image = (Image)e.Item.FindControl("produtoImage");

				image.ImageUrl = "data:" + ProdutosDao.BuscarProduto(id).MimeType+ ";base64,"+ ProdutosDao.ExibirImagem(id);
				
			}
		}
	}
}