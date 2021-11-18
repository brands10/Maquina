<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarMaquina.aspx.cs" Inherits="Maquina.EliminarMaquina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2>Eliminar Maquina</h2>
        <p>&nbsp;</p>
        <h4>Codigo De Maquina&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Width="363px" Height="37px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button class="btn btn-primary btn-lg" ID="Eliminar" runat="server" Text="ELIMINAR" OnClick="Eliminar_Click" />
        </h4>
    </div>
</asp:Content>
