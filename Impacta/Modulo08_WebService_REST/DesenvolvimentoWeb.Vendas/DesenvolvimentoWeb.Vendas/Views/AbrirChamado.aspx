<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="AbrirChamado.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.AbrirChamado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
<div class="container">
        <h2 class="text-center text-primary" >Abertura de Chamado</h2>
        <div class="row">
            <div class="col-md-7">
                <h3 class="text-center">Forneça os dados:</h3>
                <div class="form-group">
                    <asp:Label ID="assuntoLabel" runat="server" Text="Assunto: "></asp:Label>
                    <asp:DropDownList ID="assuntoDropDowList" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>

                <div class="form-group">
                    <asp:Label ID="documentoLabel" runat="server" Text="Documento:"></asp:Label>
                    <asp:TextBox ID="documentoTextBox" CssClass="form-control" runat="server" ></asp:TextBox>
                

               
                    </div>

              
                <div class="form-group">
                    <asp:Label ID="descricaoLabel" runat="server" Text="Descricao: "></asp:Label>
                    <asp:TextBox ID="descricaoTextbox" 
                     TextMode="MultiLine" Rows="4" Columns="50"   CssClass="form-control" MaxLength="20" runat="server"></asp:TextBox>

                    
                </div>

                
                <div class="form-group">
                    <asp:Button ID="enviarPedidoButton" runat="server" CssClass="btn btn-primary" Text="Abrir Chamado" OnClick="enviarPedidoButton_Click" />
                </div>
                <div>
                    <asp:Label ID="mensagemLabel" runat="server"></asp:Label>

                </div>
                  
        
        </div>
       
            
        </div> </div>

</asp:Content>
