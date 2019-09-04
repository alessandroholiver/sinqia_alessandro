<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="EfetuarPagamento.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.EfetuarPagamento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">

    <div class="container">
        <h2 class=" text-center text-primary">Selecionar um item para pagar</h2>

        <div class="form-group">
            <asp:Label ID="pedidoLabel" runat="server" Text="Pedido: "></asp:Label>
            <asp:DropDownList ID="pedidoDropDowList" CssClass="form-control"
                runat="server">
            </asp:DropDownList>
        </div>
        <hr />
        <div class="form-group">
            <asp:Label ID="cartaoLabel" runat="server" Text="Numero do Cartão: "></asp:Label>
            <asp:TextBox ID="cartaoTextBox" MaxLength="16" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="cartaoRequiredFieldValidator1" runat="server" ErrorMessage="Informe o numero do cartao"
                ControlToValidate="cartaoTextBox"
                Display="Dynamic" CssClass="text text-danger"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
                 <asp:Button ID="pagamentoButton" runat="server" OnClick="pagamentoButton_Click" Text="Efetuar Pagamento" CssClass="btn btn-primary" />
   
        </div>

        <div class="form-group">
            <asp:Label ID="mensagemLabel" runat="server" Text=""></asp:Label>
            </div>


    </div>
</asp:Content>
