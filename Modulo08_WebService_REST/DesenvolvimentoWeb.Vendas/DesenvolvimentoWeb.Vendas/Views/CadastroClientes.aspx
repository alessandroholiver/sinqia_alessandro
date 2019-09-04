<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="CadastroClientes.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.CadastroClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <div class="container">
        <h2 class="text-center text-primary">Cadastro de Clientes</h2>
        <div class="row">
            <div class="col-md-5">
                <h3 class="text-center">Forneça os dados:</h3>
                <div class="form-group">
                    <asp:Label ID="documentoLabel" runat="server" Text="Documento: "></asp:Label>
                    <asp:TextBox ID="documentoTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                    
                    <asp:RequiredFieldValidator CssClass="text-danger" Display="Dynamic" ID="documentoRequiredFieldValidator" runat="server"
                    ControlToValidate="documentoTextBox"
                    ErrorMessage="O documento deve ser informado"></asp:RequiredFieldValidator>
                    </div>

               

                <div class="form-group">
                    <asp:Label ID="nomeLabel" runat="server" Text="Nome: "></asp:Label>
                    <asp:TextBox ID="nomeTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                     
                    <asp:RequiredFieldValidator CssClass="text-danger" Display="Dynamic" ID="nomeRequiredFieldValidator" runat="server"
                    ControlToValidate="nomeTextBox"
                    ErrorMessage="O nome deve ser informado"></asp:RequiredFieldValidator>
                </div>
               
                
                
                <div class="form-group">
                    <asp:Label ID="telefoneLabel" runat="server" Text="Telefone:  "></asp:Label>
                    <asp:TextBox ID="telefoneTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                    
                    <asp:RequiredFieldValidator CssClass="text-danger" Display="Dynamic" ID="telefoneRequiredFieldValidator" runat="server"
                    ControlToValidate="telefoneTextBox"
                    ErrorMessage="O telefone deve ser informado"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <asp:Label ID="emailLabel" runat="server" Text="Email: "></asp:Label>
                    <asp:TextBox TextMode="Email" ID="emailTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                    
                    <asp:RequiredFieldValidator CssClass="text-danger" Display="Dynamic" ID="emailRequiredFieldValidator" runat="server"
                    ControlToValidate="emailTextBox"
                    ErrorMessage="O email deve ser informado"></asp:RequiredFieldValidator>
                
                    <asp:RegularExpressionValidator ID="emailRegularExpresion"
                    ErrorMessage="Email inválido"
                    runat="server"
                    CssClass="text-danger"
                    Display="Dynamic" ControlToValidate="emailTextBox" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ></asp:RegularExpressionValidator>
                </div>

                <div class="form-group">
                    <asp:Button ID="enviarButton1" runat="server" CssClass="btn btn-primary" Text="Enviar" OnClick="enviarButton1_Click" />
                </div>
                <div>
                    <asp:Label ID="mensagemLabel" runat="server"></asp:Label>

                </div>
                  
        
        </div>
        <div class="col-md-7">
            <h3>Lista de Cliente</h3>

            <asp:Repeater ID="clientesRepeater" runat="server">
                <HeaderTemplate>
                    <table class="table table-hover">
                     
                    <thead>
                            <tr>
                                <th>CPF</th>
                                <th>Nome</th>
                                <th>Telefone</th>
                                <th>Email</th>
                            </tr>
                        </thead>
                        <tbody>
                        </HeaderTemplate>

                            <itemtemplate>
                     <tr>
                         
                         <td>
                             <asp:Label runat="server" Text='<%# Eval("Documento") %>'></asp:Label>
                         </td>
                         <td>
                             <asp:Label runat="server" Text='<%# Eval("Nome") %>'></asp:Label>
                         </td>
                         <td>
                             <asp:Label runat="server" Text='<%# Eval("telefone") %>'></asp:Label>
                         </td>
                         <td>
                             <asp:Label runat="server" Text='<%# Eval("Email") %>'></asp:Label>
                         </td>

                     </tr>

                </itemtemplate>

                            <footertemplate>
                            </tbody>
                        </table>
                        </FooterTemplate>

            </asp:Repeater>
      
        </div>
            
        </div>

    </div>
</asp:Content>
