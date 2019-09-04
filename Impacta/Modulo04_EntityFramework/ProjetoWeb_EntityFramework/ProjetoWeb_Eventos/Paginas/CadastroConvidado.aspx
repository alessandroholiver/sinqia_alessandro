<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroConvidado.aspx.cs" Inherits="ProjetoWeb_Eventos.Paginas.CadastroConvidado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cadastro de Convidados</h1>

        <div>
        <asp:Label ID="eventoLabel" runat="server" Text="Evento:"></asp:Label><br />
        <asp:DropDownList ID="eventoDropDownList" runat="server"></asp:DropDownList><br />

            <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label><br />
        <asp:TextBox ID="NomeTextBox" runat="server"></asp:TextBox><br />

        <asp:Label ID="cpfLabel" runat="server" Text="CPF:"></asp:Label><br />
        <asp:TextBox ID="cpfTextBox" runat="server"></asp:TextBox><br />

        <asp:Label ID="telefoneLabel" runat="server" Text="Telefone:"></asp:Label><br />
        <asp:TextBox ID="telefoneTextBox" runat="server" ></asp:TextBox><br />

        <asp:Label ID="emailLabel" runat="server" Text="Email: "></asp:Label><br />
        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox><br />

        <asp:Button ID="incluirConvidadoButton" runat="server"  onClick="incluirButton" Text="Incluir Convidado" /><br />
              
        <asp:Label ID="mensagemConvidadoLabel" runat="server"></asp:Label>
         </div>
       </div>

       
    </form>
</body>
</html>
