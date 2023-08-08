<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prestamo.aspx.cs" Inherits="Biblioteca_CS.Prestamo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

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

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inicio</title>

<!--RECURSOS-->
<script src="Recursos/UserJS.js"></script>
<link rel="stylesheet" href="Recursos/UserCSS.css"/>


</head>
<body>
        <!--HEADER-->
        <header class="p-4 mb-3 border-bottom" style="background-color:#001F3D">
            <div class="container">
              <div class="d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start">
                <a class="navbar-brand">
                    <img src="Recursos/Imagenes/Logo-blanco.png" width="240" height="80" alt=""/>
                </a>

                <ul class="nav col-12 col-lg-4 me-lg-auto mb-2 justify-content-center mb-md-0"style="font-size:23px">
                  <li><a href="Inicio.aspx" class="nav-link px-2 link-light"><strong>Inicio</strong></a></li>
                  <li><a href="Prestamo.aspx" class="nav-link px-2 link-light"><strong>Préstamo</strong></a></li>
                  <li><a href="Biblioteca.aspx" class="nav-link px-2 link-light"><strong>Bilioteca</strong></a></li>
              
                </ul>

                <form class="col-12 col-lg-auto mb-3 mb-lg-0 me-lg-3">
                  <img src="Recursos/Images/moon.png" id="icon"/>
                </form>

                <div class="dropdown text-end">
                  <a href="#" class="d-block link-light text-decoration-none dropdown-toggle" id="dropdownUser1" data-bs-toggle="dropdown" aria-expanded="false">
                    <img src="https://venngage-wordpress.s3.amazonaws.com/uploads/2022/09/meme_this_is_fine_dog.png" alt="icon" width="50" height="50" class="rounded-circle"/>
                  </a>

                  <ul class="dropdown-menu text-small" aria-labelledby="dropdownUser1">
                    <li><a class="dropdown-item" href="#">Sign out</a></li>
                  </ul>
                </div>
              </div>
            </div>
        </header>

    <form id="form1" runat="server">
        <!--BODY-->
        <div class="form">
            <h2 class="title-forms"> Registro de préstamo</h2>
            
            <div class="form-content">        
                <div class="row">
                    <label id="labeltitulo" class="col-sm-2 col-form-label formato centrarf">Titulo:</label>
                    <div class="col-10">
                        <asp:TextBox runat="server" ID="titulo" class="form-control" type="text"  /><br/>
                    </div>
                </div>
                <div class="row">
                    <label id="labelautor" class="col-sm-2 col-form-label formato centrarf">Autor:</label>
                    <div class="col-10">
                        <asp:TextBox runat="server" ID="TextBox1" class="form-control" type="text"  /><br/>
                    </div>
                </div>
                <div class="row">
                    <label id="labelfechaprestamo" class="col-sm-2 col-form-label formato centrarf">Fecha de préstamo:</label>
                    <div class="col-4">
                        <asp:TextBox runat="server" ID="FechaPrestamo" class="form-control" type="datetime-local" disabled="false"/><br/>
                    </div>
                
                    <label id="labelfechaentrega" class="col-sm-2 col-form-label formato centrarf">Fecha de entrega *:</label>
                    <div class="col-4">
                        <asp:TextBox runat="server" ID="FechaEntrega" class="form-control" type="date" disabled="false" /><br/>
                    </div>
                </div>
                <h6> *El plazo máximo de préstamo es por 3 días.</h6>
            </div>
        </div>
    </form>
    <script>
        //FECHA DE PRESTAMO
        var fechaPrestamo = document.getElementById('<%= FechaPrestamo.ClientID %>');
        var fechaHoraActualUTC = new Date();
        var offsetPeru = -5; 
        fechaHoraActualUTC.setHours(fechaHoraActualUTC.getHours() + offsetPeru);
        var formattedFechaHoraActual = fechaHoraActualUTC.toISOString().slice(0, 16); 
        fechaPrestamo.value = formattedFechaHoraActual;

        //FECHA DE ENTREGA
        var fechaEntrega = document.getElementById('<%= FechaEntrega.ClientID %>');
        var fechaActual = new Date();
        fechaActual.setDate(fechaActual.getDate() + 3);
        var formattedFecha = fechaActual.toISOString().slice(0, 10); 
        fechaEntrega.value = formattedFecha;

    </script>

</body>
</html>
