<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Biblioteca_CS.UserPage" %>

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
    <title>Prestamo de Libros - Read.CS</title>

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

    <!--BODY-->
    <div class="contenedor">
        <div>
            <h2> Libros en posesión</h2> <!-- CUADRO: Nombre, autor, fecha de préstamo, fecha de entrega, estado -->
            <div class="sin-data">
                <h6>No tienes libros prestados, ¿no te animas en adquirir alguno?</h6> <hr />
            </div>
            <div class="con_data">
                <table class="table table-bordered">
                  <thead>
                    <tr>
                      <th scope="col">#</th>
                      <th scope="col">Título</th>
                      <th scope="col">Autor</th>
                      <th scope="col">Año</th>
                      <th scope="col">Categoría</th>
                    </tr>
                  </thead>
                  <tbody>
                    <tr>
                      <th scope="row">1</th>
                      <td>Mark</td>
                      <td>Otto</td>
                      <td>@mdo</td>
                    </tr>
                    <tr>
                      <th scope="row">2</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>@fat</td>
                    </tr>
                    <tr>
                      <th scope="row">3</th>
                      <td colspan="2">Larry the Bird</td>
                      <td>@twitter</td>
                    </tr>
                  </tbody>
                </table>
            </div>
        </div>
        <div>
            <h2> Últimos libros prestados</h2>  <!-- HISTORIAL -->
            <div class="sin-data">
                <h6>SIN REGISTRO</h6> <hr />
            </div>
            <div class="con_data">
                
            </div>
        </div>
        <div>
            <h2> Libros más solicitados</h2>  <!-- HISTORIAL -->
            <div class="sin-data">
                <h6>SIN REGISTRO</h6> <hr />
            </div>
            <div class="con_data">
                ESTADÍSTICA
            </div>
        </div>

    </div>
    <form id="form1" runat="server">
        
       
        
    </form>
</body>
</html>
