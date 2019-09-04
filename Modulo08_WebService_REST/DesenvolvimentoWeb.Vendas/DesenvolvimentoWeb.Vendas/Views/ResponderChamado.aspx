<%@ Page Title="" Async="true" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="ResponderChamado.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.ResponderChamado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">

    <div class="container">
        <h2 class="text-center text-primary" >Responder Chamado</h2>
        <div class="row">
            <div class="col-md-7">
                      <div class="form-group">
                    <asp:Label ID="chamadosLabel" runat="server" Text="Chamado: "></asp:Label>
                    <asp:DropDownList ID="chamadosDropDowList" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>

               <div class="form-group">
                    <asp:Button ID="buscarButton" runat="server" CssClass="btn btn-info" Text="Buscar Chamado" OnClick="buscarButton_Click" />
                </div>
                
                <div class="form-group">
                    <asp:Label ID="buscarLabel" runat="server" Text="Descricao:"></asp:Label>
                    <asp:TextBox ID="descricaoTextBox" TextMode="MultiLine" Rows="4" Columns="50" CssClass="form-control text-primary" ReadOnly="true" runat="server" ></asp:TextBox>
                
                    </div>

                 
              
                <div class="form-group">
                    <asp:Label ID="responderLabel" runat="server" Text="Responder: "></asp:Label>
                    <asp:TextBox ID="responderTextbox" 
                     TextMode="MultiLine" Rows="4" Columns="50"   CssClass="form-control" MaxLength="20" runat="server"></asp:TextBox>

                </div>



                
                <div class="form-group">
                    <asp:Button ID="responderButton" runat="server" CssClass="btn btn-primary" Text="Responder Chamado" OnClick="responderButton_Click" />
                </div>

                <div class="form-group">
                    <asp:Button ID="apagarButton" runat="server" CssClass="btn btn-primary" Text="Apagar Chamado" OnClick="apagarButton_Click" />
                </div>

                <div>
                    <asp:Label ID="mensagemLabel" runat="server"></asp:Label>

                </div>
                  
        
        </div>
       
            
        </div> </div>
</asp:Content>
