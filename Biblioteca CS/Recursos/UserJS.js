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
