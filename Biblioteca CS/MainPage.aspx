<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Biblioteca_CS.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Read.CS</title>

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
<script src="Recursos/MainJS.js"></script>
<link rel="stylesheet" href="Recursos/MainCSS.css"/>

</head>
<body>
    <form id="form1" runat="server" onsubmit="return validar_contenido()">
        
        <header >
            <img src="Recursos/Imagenes/UNSA-blanco.png" alt="logo-unsa" class="logo"/>
            <nav>
                <ul>
                    <li><a href="#Inicio">Inicio</a></li>
                    <li><a href="#Libros">Libros</a></li>
                    <li><a href="#Responsables">Centro de estudiantes</a></li>  
                    <li><a href="#Contacto">Contacto</a></li>
                </ul>
            </nav>
        </header>
        
        <!-- Modal -->
        <div class="modal fade bd-example-modal-lg" id="Registrom" tabindex="-1" role="dialog" >
            <div class="modal-dialog modal-lg modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h2 class="modal-title" style="justify-content:center; font-family: 'Kanit', sans-serif;" id="RegistromLabel">REGÍSTRATE</h2>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">X</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <label id="labelname" class="col-sm-2 col-form-label formato centrarf">Nombres:</label>
                            <div class="col-4">
                                <asp:TextBox runat="server" ID="nombre" class="form-control" type="text"  /><br/>
                            </div>
                
                            <label id="labellastname" class="col-sm-2 col-form-label formato centrarf">Apellidos:</label>
                            <div class="col-4">
                                <asp:TextBox runat="server" ID="apellido" class="form-control" type="text"  /><br/>
                            </div>
                        </div>

                        <div class="row">
                            <label id="labelmail" class="col-sm-2 col-form-label formato centrarf">Correo institucional:</label>
                            <div class="col-4">
                                <div class="input-group flex-nowrap">
                                    <span class="input-group-text" id="addon-wrapping">@</span>
                                    <asp:TextBox runat="server" ID="email" type="text" class="form-control"/>
                                </div>
                            </div>
                    
                            <label id="labelcui" class="col-sm-2 col-form-label formato centrarf">CUI:</label>
                            <div class="col-4 centrar">
                                <asp:TextBox runat="server" ID="cui" class="form-control" type="text"  /><br/>
                            </div>
                         </div>

                         <div class="row">
                            <label id="labelcarreer" class="col-sm-2 col-form-label formato centrarf">Carrera:</label>
                            <div class="col-4 centrar">
                                <asp:DropDownList ID="carrera" class="form-control" runat="server"></asp:DropDownList><br/>
                            </div> <br/>
                    
                            <label id="labelrol" class="col-sm-2 col-form-label formato centrarf">Rol:</label>
                            <div class="col-4">
                                <div class="form-check form-check-inline"> 
                                    <asp:RadioButton runat="server" class="form-check-input" ID="estudiante" value="Estudiante" />
                                    <label class="form-check-label">Estudiante</label>
                                </div>
                                <div class="form-check form-check-inline">
                                    <asp:RadioButton runat="server" class="form-check-input" ID="docente" value="Docente" />
                                    <label class="form-check-label">Docente</label>
                                </div> 
                                <div class="form-check form-check-inline">
                                    <asp:RadioButton runat="server" class="form-check-input" ID="egresado" value="Egresado" />
                                    <label class="form-check-label">Egresado</label>
                                </div> 
                            </div> <br />
                         </div>
                
                        <div class="row">
                            <label id="labelpassword" class="col-sm-2 col-form-label formato centrarf">Contraseña:</label>
                            <div class="col-4">
                                <asp:TextBox runat="server" ID="password" class="form-control" type="text"  /><br/>
                            </div>
                    
                            <label id="labelpassword2" class="col-sm-2 col-form-label formato centrarf">Confirma la contraseña:</label>
                            <div class="col-4">
                                <asp:TextBox runat="server" ID="password2" class="form-control" type="text"  /><br/>
                            </div>
                         </div>
                    </div>
                    <div class="modal-footer" style="justify-content: center">
                        <asp:Button ID="Button1" class="btn btn-dark" runat="server" Text="Limpiar" type="button" OnClientClick="return limpiar_contenido();"/>
                        <asp:Button ID="Button2" runat="server" Text="Enviar" class="btn btn-success" type="button" OnClick="Button_Enviar_Click"/>
                    </div>
                </div>
            </div>
        </div>



        <!--ENCABEZADO-->
        <section id="Inicio" class="inicio">  
            <img src="Recursos/Imagenes/ComputerSciencePRINCIPAL.png" alt="fondo" class="inicio"/>
            <div class="text">
                <img src="Recursos/Imagenes/Read-text.png" alt="Read.CS" class="img"/>
                
                <hr />
                <h2 style="margin-top:10vh">Sistema Bibliotecario</h2>
                <h3>Computer Science</h3>            
            
                <div class="btn">
                    <button id="Singin" class="btn-registro" type="button" data-toggle="modal" data-target="#Registrom">Registrarse</button>
                    <asp:Button ID="Login" class="btn-direccionar" runat="server" OnClick="ButtonLogin_Click" text="Iniciar Sesión" />

                </div>
            </div>
        </section>

        <div class="contenedor-general">

            <!--LIBROS-->
            <section id="Libros" class="libros">
                <div class="center">
                    <h2>Libros</h2>
                    <p>Les presentamos algunos de los libros con los que contamos:</p>
                </div>
                <div class="libros-content containerbook">
                    <div class="card" style="--clr: #009688">
                        <div class="img-box">
                            <img src="https://mediacdn.nhbs.com/jackets/jackets_orig/jpics/220891.jpg"/>
                        </div>
                        <div class="content">
                            <h2>Learning SQL</h2>
                            <h4>Beaulieu A., 2009</h4>
                            <p>
                            
                                Actualizada para los últimos sistemas de administración de 
                                bases de datos, incluidos MySQL 6.0, Oracle 11g y SQL Server 
                                2008 de Microsoft, esta guía introductoria lo pondrá en 
                                funcionamiento con SQL rápidamente. Ya sea que necesite 
                                escribir aplicaciones de bases de datos, realizar tareas 
                                administrativas o generar informes, Learning SQL, segunda 
                                edición, lo ayudará a dominar fácilmente todos los 
                                fundamentos de SQL.
                            </p>
                        </div>
                    </div>

                    <div class="card" style="--clr: #009688">
                        <div class="img-box">
                            <img src="https://images.cdn3.buscalibre.com/fit-in/360x360/a1/a3/a1a3e675a71e800dca15c4a1af729057.jpg"/>
                        </div>
                        <div class="content">
                            <h2>Matemáticas Discretas</h2>
                            <h4>Richard Johnsonbaugh, 2005</h4>
                            <p>

                                Cómo programar en C++, 10/e proporciona una introducción 
                                Este libro se diseñó para un curso de introducción a las 
                                matemáticas discretas. La exposición es clara y adecuada, 
                                además de que contiene abundantes ejercicios. Esta edición, 
                                al igual que las anteriores, incluye temas como algoritmos,
                                combinatoria, conjuntos, funciones e inducción matemática. 
                                También toma en cuenta la comprensión y construcción de pruebas
                                y, en general, el reforzamiento matemático.
                            </p>
                        </div>
                    </div>

                    <div class="card" style="--clr: #009688">
                        <div class="img-box">
                            <img src="https://deitel.com/wp-content/uploads/2020/01/c-plus-plus-how-to-program-10e.jpg"/>
                        </div>
                        <div class="content">
                            <h2>C++ How to Program </h2>
                            <h4>Deitel P., Deitel H., 2017</h4>
                            <p>

                                Cómo programar en C++, 10/e proporciona una introducción 
                                clara, atractiva y entretenida a la programación en C++11
                                y C++14 con cientos de programas totalmente codificados y
                                explicaciones detalladas.
                            </p>
                        </div>
                    </div>
                </div>
            </section>

            <!--RESPONSABLES-->
            <section id="Responsables" class="responsable">
                <div class="example center">
                    <h2>Responsables</h2>
                    <p>Estudiantes pertenecientes al Centro de Estudiantes:</p>
                </div> 
                <div style="text-align:center">
                    <div class="profile-card">
                        <div class="profile-content">
                            <div class="profile-picture">
                                <img src="https://i.pinimg.com/736x/7a/01/0a/7a010ac3404163330a2f9ee0a6f109e8.jpg" alt="" class="rounded-circle"/>
                            </div>
                            <h2 class="profile-name">Piero Vizcarra</h2>
                            <p class="profile-description">Presidente del centro de estudiantes.</p>
                            <ul class="social-icons">
                                <li><a href="#"><i class="fab fa-twitter"></i></a></li>
                                <li><a href="#"><i class="fab fa-facebook"></i></a></li>
                                <li><a href="#"><i class="fab fa-instagram"></i></a></li>
                            </ul>
                        </div>
                    </div>
                    <div class="profile-card">
                        <div class="profile-content">
                            <div class="profile-picture">
                                <img src="https://images3.memedroid.com/images/UPLOADED256/5f8a2410632ef.jpeg" alt="" class="rounded-circle"/>
                            </div>
                            <h2 class="profile-name">Joel Perca</h2>
                            <p class="profile-description">Presidente del centro de estudiantes.</p>
                            <ul class="social-icons">
                                <li><a href="#"><i class="fab fa-twitter"></i></a></li>
                                <li><a href="#"><i class="fab fa-facebook"></i></a></li>
                                <li><a href="#"><i class="fab fa-instagram"></i></a></li>
                            </ul>
                        </div>
                    </div>
                    <div class="profile-card">
                        <div class="profile-content">
                            <div class="profile-picture">
                                <img src="https://yt3.googleusercontent.com/Ctm3p-RhMaBBKfd0sR3UznQeDQ3dXJakCj801Noe7-iEsgUvGul_C6nLVUvVL6wQNGnf5OUC=s900-c-k-c0x00ffffff-no-rj" alt="" class="rounded-circle"/>
                            </div>
                            <h2 class="profile-name">Lighai Zhong</h2>
                            <p class="profile-description">Presidente del centro de estudiantes.</p>
                            <ul class="social-icons">
                                <li><a href="#"><i class="fab fa-twitter"></i></a></li>
                                <li><a href="#"><i class="fab fa-facebook"></i></a></li>
                                <li><a href="#"><i class="fab fa-instagram"></i></a></li>
                            </ul>
                        </div>
                    </div>
                    <div class="profile-card">
                        <div class="profile-content">
                            <div class="profile-picture">
                                <img src="https://64.media.tumblr.com/ee77e28c4b9fa43956df54980aedbb9c/tumblr_pmdi5fo8OW1vjy21go2_250.jpg" alt="" class="rounded-circle"/>
                            </div>
                            <h2 class="profile-name">Karla Cornejo</h2>
                            <p class="profile-description">Presidente del centro de estudiantes.</p>
                            <ul class="social-icons">
                                <li><a href="#"><i class="fab fa-twitter"></i></a></li>
                                <li><a href="#"><i class="fab fa-facebook"></i></a></li>
                                <li><a href="#"><i class="fab fa-instagram"></i></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </section>

        </div>

        <!--CONTACTO-->
        <section id="Contacto" class="contacto">
            <footer class="pie-pagina">
                <div class="grupo1">
                    <div class="zona">
                        <figure>
                            <a href="#">
                                <img src="Recursos/Imagenes/Logo-blanco.png" alt="logounsa" />
                            </a>
                        </figure>
                    </div>
                    <div class="zona">
                        <h3>Escuela Profesional de Ciencia de la Computación</h3><hr/>
                        <strong>Dirección:</strong>
                        <p>Av. Venezuela S/N Puerta 3 Campus de Ingenieria Pabellón Alan Turing</p>
                        <strong>Teléfono:</strong>
                        <p>054 - 285298</p>
                        <strong>Support:</strong> <a href="mailto:epcc@unsa.edu.pe">epcc@unsa.edu.pe</a>
                    </div>
                    <div class="zona" style="text-align: center">
                        <h2>SIGUENOS</h2>
                        <div class="red-social">
                            <a href="https://www.facebook.com/epcc.unsa" class="fa-brands fa-square-facebook"></a>
                            <a href="#" class="fa-brands fa-square-instagram"></a>
                            <a href="#" class="fa-brands fa-square-youtube"></a>
                        </div>
                    </div>
                </div>
                <div class="grupo2">
                    <small>&copy; 2023 <b>Computer Science</b> - Todos los Derechos Reservados.</small>
                </div>
            </footer>
        </section>

    </form>
</body>

</html>
