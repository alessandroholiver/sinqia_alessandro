<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="CadastroUsuarios.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.CadastroUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">

    <div class="container">

        <h2 class="text-center text-primary">Cadastro de Usuarios</h2>
        <div class="row">
            <div class="col-md-5">
                   <div class="form-group">
                    <asp:Label ID="nomeLabel" runat="server" Text="Nome: "></asp:Label>
                    <asp:TextBox ID="nomeTextBox" MaxLength="20" CssClass="form-control" runat="server"></asp:TextBox>
                    
                    <asp:RequiredFieldValidator CssClass="text-danger" Display="Dynamic" ID="nomeRequiredFieldValidator" runat="server"
                    ControlToValidate="nomeTextBox"
                    ErrorMessage="O nome do usuario deve ser informado"></asp:RequiredFieldValidator>
                    </div>

               

                <div class="form-group">
                    <asp:Label ID="senhaLabel" runat="server" Text="Senha: "></asp:Label>
                    <asp:TextBox ID="senhaTextBox" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
                     
                    <asp:RequiredFieldValidator CssClass="text-danger" Display="Dynamic" ID="senhaRequiredFieldValidator" runat="server"
                    ControlToValidate="senhaTextBox"
                    ErrorMessage="A senha deve ser informado"></asp:RequiredFieldValidator>
                </div>

                 <div class="form-group">
                    <asp:Label ID="confirmaLabel" runat="server" Text="Confirmar sua Senha: "></asp:Label>
                    <asp:TextBox ID="confirmeTextBox" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
                     
                   <asp:CompareValidator runat="server" ID="confirmaCompareValidator"
                       ErrorMessage ="As senhas nao conferem" ControlToValidate="confirmeTextBox"
                       ControlToCompare="senhaTextBox" Display="Dynamic" CssClass="text-danger">
                                          </asp:CompareValidator>
                </div>
                <div class="form-group">
                    <asp:Button ID="enviarButton1" runat="server" CssClass="btn btn-primary" Text="IncluirUsuario" OnClick="enviarButton1_Click" />
                </div>
                <div>
                    <asp:Label ID="mensagemLabel" runat="server"></asp:Label>

                </div>
                

            </div>
        </div>
    </div>
</asp:Content>
