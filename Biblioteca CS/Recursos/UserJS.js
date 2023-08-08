var icon = document.getElementById("icon");

icon.onclick = function () {
    document.body.classList.toggle("active");
    if (document.body.classList.contains("active")) {
        icon.src = "Recursos/Images/sun.png";
    } else {
        icon.src = "Recursos/Images/moon.png";
    }
}

/*::::::::::::::::::::::::::::::::::::::::::::::::PRESTAMO::::::::::::::::::::::::::::::::::::::::::::::::::::*/

function limpiar_contenido() {
    var vacio = "";
    document.getElementById("titulo").value = vacio;
    document.getElementById("autor").value = vacio;
    return false;
}

function enviar_contenido() {
    if (!document.getElementById("autor").value || !document.getElementById("titulo").value ) {
        alert("No se ingresó información");
        return false;
    }
    var confirmacion = "Registro de préstamo exitoso.";
    alert(confirmacion);
    return true;
}