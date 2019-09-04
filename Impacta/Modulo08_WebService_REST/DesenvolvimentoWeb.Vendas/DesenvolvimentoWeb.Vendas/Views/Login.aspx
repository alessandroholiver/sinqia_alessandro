<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Styles/EstilosLogin.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-top:50px;">
            <div class="container">
                <div class="row">
                    <div class="col-md-4"></div>

                    <div class="col-md-4 alert alert-dark">

                        <div id="cabecalho">
                            <h3>Forneça suas credenciais</h3>
                        </div>
                        

                        <!-- Usuario -->
                        <div class="form-group">
                            <asp:Label ID="usuarioLabel" runat="server" Text="Usuario: "></asp:Label>
                            <asp:TextBox ID="usuarioTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>

                        <!-- Senha -->
                        <div class="form-group">
                            <asp:Label ID="senhaLabel" runat="server" Text="Senha: "></asp:Label>
                            <asp:TextBox ID="senhaTextBox" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Enviar"
                                OnClick="Button1_Click"/>
                        </div>

                           <div class="form-group">
                    <asp:Label ID="mensagemLabel" runat="server"></asp:Label>

                </div>
                    </div>

                    <div class="col-md-4"></div>


                </div>

            </div>
        </div>
    </form>
</body>
</html>
