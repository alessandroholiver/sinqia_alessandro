<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="ListaItens.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.ListaItens" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <div class="container">
        <h2 class=" text-center text-primary">Lista de Itens</h2>
        
        <div class="form-group">
                    <asp:Label ID="pedidoLabel" runat="server" Text="Pedido: "></asp:Label>
                    <asp:DropDownList ID="pedidoDropDowList" CssClass="form-control" 
                        OnSelectedIndexChanged="pedidoDropDowList_SelectedIndexChanged" 
                        runat="server" AutoPostBack="true"></asp:DropDownList>
                </div>
        <hr />

        <asp:Repeater ID="itensRepeater" runat="server">


            <HeaderTemplate>

            </HeaderTemplate>

            <ItemTemplate>
                <div class=" alert alert-secondary">
                    <div style="float: right;">
                        <asp:Linkbutton ID="excluirLinkButton" 
                            runat="server" OnClientClick="javascript:return confirm ('Tem Certeza ?');" 
                            OnClick="excluirLinkButton_Click" CommandArgument='<%# Eval ("IdItem") %>' >
                            [x]
                                                  </asp:Linkbutton>
                    </div>
                    <strong>Produto</strong>
                    <asp:Label ID="descricaoPedidoLabel" runat="server" Text='<%# Eval("DescricaoProduto") %>'>

                    </asp:Label><br />
               

                <div>
                    <strong>Pedido:</strong>
                    <asp:Label ID="pedidoLabel" runat="server" Text='<%# Eval("NumeroPedido") %>'>

                    </asp:Label>

                    <div>
                    <strong>Data Pedido:</strong>
                    <asp:Label ID="dtLabel" runat="server" Text='<%# Eval("DataPedido") %>'>

                    </asp:Label><br />

                        <div>
                    <strong>Valor Pedido:</strong>
                    <asp:Label ID="valorPedidoLabel" runat="server" Text='<%# Eval("ValorTotalItem") %>'>

                    </asp:Label><br />
                </div>
                </div>
                </div>
                     </div>
            </ItemTemplate>

            <FooterTemplate>

            </FooterTemplate>

        </asp:Repeater>

    </div>
</asp:Content>

