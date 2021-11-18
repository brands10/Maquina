<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alquilar.aspx.cs" Inherits="Maquina.Alquilar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <script src="https://cdnjs.cloudflare.com/ajax/libs/html2pdf.js/0.8.0/html2pdf.bundle.js" integrity="sha512-VqCeCECsaE2fYTxvPQk+OJ7+SQxzI1xZ6IqxuWd0GPKaJoeSFqeakVqNpMbx1AArieciBF71poL0dYTMiNgVxA==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
    <Script>      
        function generatePDF() {
        var style = "<style>";
        style = style + "table {width: 100%;font: 17px Calibri;}";
        style = style + "table, th, td {border: solid 1px #DDD; border-collapse: collapse;";
        style = style + "padding: 2px 3px;text-align: center;}";
        style = style + "</style>"
        
        const element = document.querySelector('.table.table-hover');
        var a = window.open('', '', 'height=2500,width=1500');
        a.document.write('<html><body>');
        a.document.write(style);
        a.document.write(element.innerHTML);
        a.document.write('</body ></html >');
        a.document.close();
        a.print();
      
          }
    </Script>
    
    
    <h1>Compra Partes para gestion de Maquina <asp:Label ID="AlqMaquina" runat="server"></asp:Label></h1>
    <br />
    <div class="alert alert-warning alert-dismissable">
        <p>
            <strong>¡Información! </strong> 
            Por politicas de la empresa, solo se podra alquilar un tipo de maquina a la vez. Gracias por su compreción.

        </p>
    </div>
    
    <div class="jumbotron" >
        <p>&nbsp;</p>
        <div class="container" style="text-align: center;">
            <asp:Label ID="Encontrado" runat="server" Text="" style="text-align: center; color: green; font-size: 20px;"></asp:Label>
        <asp:Label ID="NoEncontrado" runat="server" Text="" style="text-align: center; color: red; font-size: 20px;"></asp:Label>
        </div>
        
        <h4>Cantidad&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Cant" runat="server" Text="1"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Nombre "></asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Height="37px" Width="232px" placeholder="Persona que alquila"></asp:TextBox>           
        </h4>
        <h4>Descripción&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server" Width="232px" Height="37px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Precio"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Height="37px" Width="232px"></asp:TextBox>
        </h4>
        <h4>
            <asp:Label ID="Label9" runat="server" Text="Fecha Devolución"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox12" type="date" runat="server" Height="37px" Width="232px"></asp:TextBox>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="E-Mail"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtCorreo" type="text" runat="server" Height="37px" Width="232px" placheholder="A quien enviamos comprabante"></asp:TextBox>
        </h4>
        <br /><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:Button class="btn btn-primary btn-lg" ID="btnAlquilar" runat="server" Text="Confirmar Compra" Enabled="true" OnClick="btnAlquilar_Click"/>
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        <br />
    </div>
    <hr />
    <h1>Mis Alquileres</h1>
    <div class="table table-hover">                      
       <asp:GridView ID="GridView1" runat="server" class="table-default table table-bordered table-condensed table-responsive table-hover" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
       <button onclick="generatePDF()">Download as PDF</button>
     </div>
 
</asp:Content>
