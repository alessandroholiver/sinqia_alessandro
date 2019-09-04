<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="CadastroProdutos.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.CadastroProdutos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">

     <div class="container">
        <h2 class="text-center text-primary" >Cadastro de Produtos</h2>
        <div class="row">
            <div class="col-md-5">
                <h3 class="text-center">Forneça os dados:</h3>
                <div class="form-group">
                    <asp:Label ID="categoriaLabel" runat="server" Text="Documento: "></asp:Label>
                    <asp:DropDownList ID="categoriaDropDowList" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>

                <div class="form-group">
                    <asp:Label ID="desrcicaoLabel" runat="server" Text="Descrição:"></asp:Label>
                    <asp:TextBox ID="descricaoTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                    
                    <asp:RequiredFieldValidator CssClass="text-danger" Display="Dynamic" ID="descricaoRequiredFieldValidator" runat="server"
                    ControlToValidate="descricaoTextBox"
                    ErrorMessage="A descricao deve ser informado"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <asp:Label ID="unidadeLabel" runat="server" Text="Unidade: "></asp:Label>
                    <asp:DropDownList ID="unidadeDropDownList" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>

                <div class="form-group">
                    <asp:Label ID="precoLabel" runat="server"  Text="Preco: "></asp:Label>
                    <asp:TextBox ID="precoTextebox"  CssClass="form-control" runat="server"></asp:TextBox>

                    <asp:RequiredFieldValidator CssClass="text-danger" Display="Dynamic" ID="precoRequiredFieldValidator" runat="server"
                    ControlToValidate="precoTexteBox"
                    ErrorMessage="O preço deve ser informado"></asp:RequiredFieldValidator>


                    <asp:RangeValidator CssClass="text-danger" Display="Dynamic" ID="precoRangeValidator" runat="server"
                      ControlToValidate="precoTexteBox" Type="Double"
                    ErrorMessage="O valor deve estar entre R$1 e R$10.000,00"
                        MinimumValue="1" MaximumValue="10000"
                        ></asp:RangeValidator>
                </div>

                <div class="form-group">
                    <asp:Label ID="figuraLabel" runat="server" Text="Figura: "></asp:Label>
                    <asp:fileUpload ID="figuraFileUpload"  CssClass="form-control" runat="server"></asp:fileUpload>
                </div>

                <div class="form-group">
                    <asp:Button ID="incluirProdutoButton" runat="server" CssClass="btn btn-primary" Text="Enviar" OnClick="enviarButton1_Click" />
                </div>
                <div>
                    <asp:Label ID="mensagemLabel" runat="server"></asp:Label>

                </div>
                  
        
        </div>
        <div class="col-md-7">
            <h3>Lista de Produtos</h3>

            <asp:repeater id="produtosrepeater" runat="server"  OnItemDataBound="produtosrepeater_ItemDataBound">
                <headertemplate>
                    <table class="table table-hover">
                     
                    <thead>
                            <tr>
                                <th>ID</th>
                                <th>Descrição</th>
                                <th>Preço</th>
                                <th>Imagem</th>
                            </tr>
                        </thead>
                        <tbody>
                        </headertemplate>

                            <itemtemplate>
                     <tr>
                         
                         <td>
                             <asp:label runat="server" text='<%# Eval("Id") %>'></asp:label>
                         </td>
                         <td>
                             <asp:label runat="server" text='<%# Eval("Descricao") %>'></asp:label>
                         </td>
                         <td>
                             <asp:label runat="server" text='<%# Eval("Preco") %>'></asp:label>
                         </td>
                         <td>
                             <asp:HiddenField  ID="idHiddenField" runat="server" value='<%# Eval("Id") %>' />
                             <asp:Image ID="produtoImage" runat="server" Width="100" />
                         </td>

                     </tr>

                </itemtemplate>

                            <footertemplate>
                            </tbody>
                        </table>
                        </footertemplate>

            </asp:repeater>
      
        </div>
            
        </div>

    </div>
</asp:Content>
