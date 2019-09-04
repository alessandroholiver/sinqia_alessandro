<%@ Page Title="" Async="true" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="Chamados Resolvidos.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.Chamados_Resolvidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
     <div class="container">
        <h2 class="text-center text-primary" >Chamados Resolvidos</h2>
        <div class="row">
    
        <div class="col-md-7">
            <h3>Lista de Chamados</h3>

            <asp:repeater id="chamadosRepeater" runat="server" >
                <headertemplate>
                    <table class="table table-hover">
                     
                    <thead>
                            <tr>
                                <th>ID</th>
                                <th>Documento</th>
                                <th>Assunto</th>
                                <th>Descrição</th>
                                <th>Resposta</th>
                            </tr>
                        </thead>
                        <tbody>
                        </headertemplate>

                            <itemtemplate>
                     <tr>
                         
                         <td>
                             <asp:label runat="server" text='<%# Eval("ChamadoId") %>'></asp:label>
                         </td>
                         <td>
                             <asp:label runat="server" text='<%# Eval("Documento") %>'></asp:label>
                         </td>
                         <td>
                             <asp:label runat="server" text='<%# Eval("Assunto") %>'></asp:label>
                         </td>
                         <td>
                             <asp:label runat="server" text='<%# Eval("Descricao") %>'></asp:label>
                         </td>
                         <td>
                             <asp:label runat="server" text='<%# Eval("Resposta") %>'></asp:label>
                         </td>
                         
                     </tr>

                </itemtemplate>

                            <footertemplate>
                            </tbody>
                        </table>
                        </footertemplate>

            </asp:repeater>
      
        </div>
            
        </div>

    </div>

</asp:Content>
