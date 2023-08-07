function validar_cui(num) { // PARA VALIDAR EL CUI
    var num_validos = "0123456789"
    if (num.length == 0 || num.length > 8) {
        return false;
    }

    return true;

}

function enviar_contenido() {


    var num = document.getElementById("cui").value;
    if (!validar_cui(num)) {
        alert("CUI incorrecto !!");
        return false;
    }
    console.log("Hola");
    //var fecha = new Date();
    var confirmacion = "Inicio de sesion exitoso.";
    alert(confirmacion);
    return false;

}