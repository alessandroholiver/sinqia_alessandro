<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="CadastroPedidos.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.CadastroPedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
<div class="container">
        <h2 class="text-center text-primary" >Inclusão de Pedidos</h2>
        <div class="row">
            <div class="col-md-5">
                <h3 class="text-center">Forneça os dados:</h3>
                <div class="form-group">
                    <asp:Label ID="clienteLabel" runat="server" Text="Cliente: "></asp:Label>
                    <asp:DropDownList ID="clienteDropDowList" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>

                <div class="form-group">
                    <asp:Label ID="dataLabel" runat="server" Text="Data:"></asp:Label>
                    <asp:TextBox ID="dataTextBox" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>

                     <asp:RequiredFieldValidator CssClass="text-danger" Display="Dynamic" ID="dataRequiredFieldValidator" runat="server"
                    ControlToValidate="dataTextBox"
                    ErrorMessage="O data deve ser informado"></asp:RequiredFieldValidator>
                
               
                    </div>

              
                <div class="form-group">
                    <asp:Label ID="pedidoLabel" runat="server" Text="Pedido: "></asp:Label>
                    <asp:TextBox ID="pedidoTextbox" CssClass="form-control" MaxLength="20" runat="server"></asp:TextBox>

                    <asp:RequiredFieldValidator CssClass="text-danger" Display="Dynamic" ID="pedidoRequiredFieldValidator" runat="server"
                    ControlToValidate="pedidoTextBox"
                    ErrorMessage="O pedido deve ser informado"></asp:RequiredFieldValidator>
                </div>

                
                <div class="form-group">
                    <asp:Button ID="incluirPedidoButton" runat="server" CssClass="btn btn-primary" Text="Enviar" OnClick="incluirPedidoButton_Click" />
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
