<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Maquina.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://fonts.googleapis.com/css?family=Nunito&display=swap" rel="stylesheet"/>         
    <link href="css/login.css" rel="stylesheet" />
</head>
<body>
    <div id="contenedor">            
            <div id="contenedorcentrado"> 
                <div id="login"> 
                    <form id="form1" runat="server">
                        <label for="usuario">Usuario</label>
                        <asp:TextBox id="usuario" runat="server" type="text" name="usuario" placeholder="Usuario" required=""></asp:TextBox>                        
                        <label for="password">Contraseña</label>
                        <asp:TextBox id="contra" runat="server" type="password" placeholder="Contraseña" name="password" required=""></asp:TextBox>                       
                        <asp:Button id="Inicio" runat="server" Text="Iniciar Sesión" OnClick="Inicio_Click"></asp:Button>
                    </form>                    
                </div>
                <div id="derecho">
                    <div class="titulo">
                        Bienvenido
                    </div>
                    <hr/>
                    <div class="pie-form">
                        <p style="color: aliceblue;">Hola este es mi proyecto</p>
                        <hr/>
                        <a href="#">Hola</a>
                    </div>
                </div>
            </div>
        </div>   
</body>
</html>
