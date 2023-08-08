window.addEventListener("scroll", function () {
    var header = document.querySelector("header");
    header.classList.toggle("abajo", window.scrollY > 0);
})

function limpiar_contenido() {
    var vacio = "";
    document.getElementById("nombre").value = vacio;
    document.getElementById("apellido").value = vacio;
    document.getElementById("email").value = vacio;
    document.getElementById("cui").value = vacio;
    document.getElementById("carrera").value = 0;
    document.getElementById("estudiante").checked = false;
    document.getElementById("docente").checked = false;
    document.getElementById("egresado").checked = false;
    document.getElementById("password").value = vacio;
    document.getElementById("password2").value = vacio;
    return false;
}

function mostrar_alerta(text) {
    Swal.fire({
        title: 'Error!',
        text: text,
        icon: 'error',
        confirmButtonText: 'Aceptar'
    });
}

function validar_contenido() {
    var name, lastname, mail, cui, carreer, teacher, graduate, student, password1, password2;
    var vacio = "";
    name = document.getElementById("nombre").value;
    lastname = document.getElementById("apellido").value;
    mail = document.getElementById("email").value;
    cui = document.getElementById("cui").value;
    carreer = document.getElementById("carrera").value;
    student = document.getElementById("estudiante").checked;
    teacher = document.getElementById("docente").checked;
    graduate = document.getElementById("egresado").checked;
    password1 = document.getElementById("password").value;
    password2 = document.getElementById("password2").value;
    if (/^[a-zA-Z]+$/.test(name) == false) {
        mostrar_alerta('Error al ingresar nombre');
        document.getElementById("nombre").value = vacio;
        return false;
    }
    else if (/^[a-zA-Z\s\u00f1\u00d1]+$/.test(lastname) == false) {
        mostrar_alerta('Error al ingresar apellidos');
        document.getElementById("apellido").value = vacio;
        return false;
    }
    else if (/^[\w-]+(\.[/w-]+)*@unsa.edu.pe/.test(mail) == false) {
        mostrar_alerta('Error al ingresar correo');
        document.getElementById("email").value = vacio;
        return false;
    }
    else if (carreer == 'Selecciona una opcion') {
        mostrar_alerta('Error al seleccionar carrera');
        document.getElementById("carrera").value = vacio;
        return false;
    }
    else if (/^[0-9]\d*$/.test(cui) == false) {
        mostrar_alerta('Error al ingresar CUI')
        document.getElementById("cui").value = vacio;
        return false;
    }

    else if ((student == false && teacher == false && graduate == false) || (student == true && teacher == true && graduate == false) || (student == true && teacher == false && graduate == true) || (student == false && teacher == true && graduate == true) || (student == true && teacher == true && graduate == true)) {
        mostrar_alerta('Error al marcar el Rol');
        document.getElementById("estudiante").checked = vacio;
        document.getElementById("docente").checked = vacio;
        document.getElementById("egresado").checked = vacio;
        return false;
    }
    else if (/^(.|[\r\n]){8,}$/gm.test(password1) == false) {
        mostrar_alerta('Error al ingresar la contraseña,debe de llenar todos los recuadros y esta debe contener almenos 8 caracteres');
        document.getElementById("password").value = vacio;
        return false;
    }
    else if (/^(.|[\r\n]){8,}$/gm.test(password2) == false) {
        mostrar_alerta('Error al ingresar la contraseña, debe de llenar todos los recuadros y esta debe contener almenos 8 caracteres');
        document.getElementById("password2").value = vacio;
        return false;
    }
    else if (password1 != password2) {
        mostrar_alerta('Las contraseñas ingresadas no coinciden');
        document.getElementById("password").value = vacio;
        document.getElementById("password2").value = vacio;
        return false;
    }
    else {
        var Dias = ['Dom', 'Lun', 'Mar', 'Mier', 'Jue', 'Vier', 'Sab'];
        var Meses = ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'];

        var fecha = new Date();
        var day = Dias[fecha.getDay()];
        var date = fecha.getDate();
        var month = Meses[fecha.getMonth()];
        var year = fecha.getFullYear();
        var second = fecha.getSeconds();
        var minute = fecha.getMinutes();
        var hour = fecha.getHours();
        var hora_completa = hour + ":" + minute + ":" + second;

        Swal.fire({
            title: 'Exito!',
            text: "Registrado con éxito el " + day + " " + date + "/" + month + "/" + year + " a las " + hora_completa + " GMT-0500 (hora estándar de Perú)",
            icon: 'success',
            confirmButtonText: 'Aceptar'
        });
    }
}
function limpiar_contenido() {
    var vacio = "";
    document.getElementById("nombre").value = vacio;
    document.getElementById("apellido").value = vacio;
    document.getElementById("email").value = vacio;
    document.getElementById("cui").value = vacio;
    document.getElementById("carrera").selectedIndex = 0;
    document.getElementById("estudiante").checked = false;
    document.getElementById("docente").checked = false;
    document.getElementById("egresado").checked = false;
    document.getElementById("password").value = vacio;
    document.getElementById("password2").value = vacio;

    return false;
}

function mostrar_alerta(text) {
    Swal.fire({
        title: 'Error!',
        text: text,
        icon: 'error',
        confirmButtonText: 'Aceptar'
    });
}

function ValidarCampos() {
    let nombre = $('#nombre').val();
    let apellido = $('#apellido').val();
    let cui = $('#cui').val();
    let email = $('#email').val();
    if (nombre && apellido && cui && email) {
        console.log("Se empaqueta contenido " + nombre + ", " + apellido + "," + cui + "," + email);
        EmpaquetarContenido(nombre, apellido, cui, email);
    }
    else {
        console.log("Los campos de Nombre y Apellido deben estar llenos");
    }
}

function EmpaquetarContenido(nombre, apellido, cui, email) {
    console.log("EmpaquetarContenido() fue llamada.");
    $.ajax({
        url: 'MainPage.aspx/GetValidacion',
        type: 'POST',
        async: true,
        data: '{ "nombre" : "' + nombre + '", "apellidos" : "' + apellido + '", "mail" : "' + email + '", "cui" : "' + cui + '"}',
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: exito
    });
    return false;
}

function exito(data) {
    console.log("Retornando respuesta");
    var returnS = data.d;
    if (returnS) {
        mostrar_alerta("El Usuario ya está registrado");
        limpiar_contenido();
    }
    else {
        Swal.fire({
            title: 'Exito!',
            text: "Correcto",
            icon: 'success',
            confirmButtonText: 'Aceptar'
        });
    }
    return false;
}

function mostrar_modal() {
    var modal1 = new bootstrap.Modal(document.getElementById('errorModal'));
    modal1.show();
    return true;
}
function redireccionar() {
    // Realizar cualquier acción antes de la redirección si es necesario

    // Redirigir a otra página
    window.location.href = "LoginPage.aspx";
}