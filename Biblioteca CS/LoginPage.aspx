<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Biblioteca_CS.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  <title>Iniciar Sesión</title>
  <link rel="icon" type="image/png" href="https://scontent.faqp1-1.fna.fbcdn.net/v/t39.30808-6/332319294_2237668383092057_2920168158318927642_n.jpg?_nc_cat=101&cb=99be929b-3346023f&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeFsFtwEroiEnG9LhyGSIDiYQ-cUKZijbYlD5xQpmKNtiUHJK_rQEijtQktJfwTUCye_u4SmpOVUOvnqD51CB6Pw&_nc_ohc=IvnXPYHL12YAX9lCati&_nc_ht=scontent.faqp1-1.fna&oh=00_AfBFZFioAe8WDgmmqznc9qzOkyO8CcmsFSzp7ugRdh6VaQ&oe=64B8EE61"/>

<!--JQuery-->
<script type="text/javascript" src="/Scripts/jquery-3.4.1.min.js"></script>
<!-- Bootstrap core CSS -->
<link rel="stylesheet" href="/Content/bootstrap.min.css" />
<script type="text/javascript" src="/Scripts/bootstrap.min.js"></script>
<script type="text/javascript" src="/Scripts/modernizr-2.8.3.js"></script>

<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"/>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>

<!--RECURSOS EN LINEA-->
<script src="https://kit.fontawesome.com/760315b711.js" crossorigin="anonymous"></script>
<link rel="preconnect" href="https://fonts.googleapis.com"/>
<link href="https://fonts.googleapis.com/css2?family=Chakra+Petch:wght@400;500;600&display=swap" rel="stylesheet" />

<!--RECURSOS-->
<script src="Recursos/LoginJS.js"></script>
<link rel="stylesheet" href="Recursos/LoginCSS.css"/>

</head>
<body>
  
  <div class="container">
    <img src="Recursos/Imagenes/Logo-color.png" alt="Read-logo" width="220" height="70"/>
    <h1>Iniciar Sesión</h1>
    <form id="form1" runat="server" class="text-center col-11">
      <label id="labelcui">CUI:<asp:TextBox ID="cui" runat="server" class="form-control" type="text"> </asp:TextBox></label>
      <label id="labelcorreo">Correo:<asp:TextBox ID="email" runat="server" class="form-control" type="text"> </asp:TextBox></label>
      <label id="labelcontraseña">Contraseña:<asp:TextBox ID="contrasena" runat="server" type="password" class="form-control" ></asp:TextBox></label>
      <asp:Button ID="Button1" runat="server" class="btn-lg btn-success" style="margin-top: 2vh; font-family: 'Kanit', sans-serif" text="Iniciar Sesión" OnClientClick="return enviar_contenido();" OnClick="ButtonEnter_Click" />
      <div class="nuevousuario">¿Nuevo por aquí? <a href="MainPage.aspx"><strong>Crea una cuenta</strong></a></div>

    </form>
  </div>
</body>
</html>
