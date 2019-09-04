<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="CadastroItens.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.CadastroItens" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">

    <div class="container">
        <h2 class="text-center text-primary" >Inclusão de Itens</h2>
        <div class="row">
            <div class="col-md-5">
                <h3 class="text-center"> Forneça os dados:</h3>
                <div class="form-group">
                    <asp:Label ID="pedidoLabel" runat="server" Text="Pedido: "></asp:Label>
                    <asp:DropDownList ID="pedidoDropDowList" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>

                 <div class="form-group">
                    <asp:Label ID="produtoLabel" runat="server" Text="Produto: "></asp:Label>
                    <asp:DropDownList ID="produtosDropDownList1" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>



                <div class="form-group">
                    <asp:Label ID="quantidadeLabel" runat="server" Text="Quantidade:"></asp:Label>
                    <asp:TextBox ID="quantidadeTextBox" CssClass="form-control" runat="server" ></asp:TextBox>

                     <asp:RequiredFieldValidator CssClass="text-danger" Display="Dynamic" ID="quantidadeRequiredFieldValidator" runat="server"
                    ControlToValidate="quantidadeTextBox"
                    ErrorMessage="A quantidade deve ser informado"></asp:RequiredFieldValidator>

                    <asp:RangeValidator CssClass="text-danger" Display="Dynamic" ID="precoRangeValidator" runat="server"
                      ControlToValidate="quantidadeTextBox" Type="Double"
                    ErrorMessage="A quantidade deve estar entre 1 e 100"
                        MinimumValue="1" MaximumValue="100"
                        ></asp:RangeValidator>
                
                </div>

              
                             
                <div class="form-group">
                    <asp:Button ID="incluirItemButton" runat="server" CssClass="btn btn-primary" Text="Enviar" OnClick="incluirItemButton_Click" />
                </div>
                <div>
                    <asp:Label ID="mensagemLabel" runat="server"></asp:Label>

                </div>
                  
        
        </div>
        <%--<div class="col-md-7">
            <h3>lista de cliente</h3>

            <asp:repeater id="clientesrepeater" runat="server">
                <headertemplate>
                    <table class="table table-hover">
                     
                    <thead>
                            <tr>
                                <th>cpf</th>
                                <th>nome</th>
                                <th>telefone</th>
                                <th>email</th>
                            </tr>
                        </thead>
                        <tbody>
                        </headertemplate>

                            <itemtemplate>
                     <tr>
                         
                         <td>
                             <asp:label runat="server" text='<%# eval("documento") %>'></asp:label>
                         </td>
                         <td>
                             <asp:label runat="server" text='<%# eval("nome") %>'></asp:label>
                         </td>
                         <td>
                             <asp:label runat="server" text='<%# eval("telefone") %>'></asp:label>
                         </td>
                         <td>
                             <asp:label runat="server" text='<%# eval("email") %>'></asp:label>
                         </td>

                     </tr>

                </itemtemplate>

                            <footertemplate>
                            </tbody>
                        </table>
                        </footertemplate>

            </asp:repeater>
      
        </div>--%>
            
        </div> </div>
</asp:Content>
