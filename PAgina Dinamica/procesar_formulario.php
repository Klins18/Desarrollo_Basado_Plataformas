<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Recuperar y procesar los datos del formulario
    $nombre = $_POST["nombre"];
    $fecha = $_POST["fecha"];
    $correo = $_POST["correo"];
    $telefono = $_POST["telefono"];
    $direccion = $_POST["direccion"];
    $nacionalidad = $_POST["nacionalidad"];
    $ingles = $_POST["ingles"];
    $lenguajes = $_POST["lenguajes"];
if (is_array($lenguajes)) {
    $lenguajes = implode(", ", $lenguajes);
} else {
    $lenguajes = ""; // Otra opción si no hay selecciones
}
    $ocupacion = $_POST["ocupacion"];
    $aptitudes = $_POST["aptitudes"];
    $habilidades = $_POST["habilidades"];
if (is_array($habilidades)) {
    $habilidades = implode(", ", $habilidades);
} else {
    $habilidades = ""; // Otra opción si no hay selecciones
}
    $perfil = $_POST["perfil"];

    // Leer el contenido de CV.html
    $cv_content = file_get_contents("CV.html");

    // Reemplazar los marcadores de posición con los datos procesados
    $cv_content = str_replace("{NOMBRE}", $nombre, $cv_content);
    $cv_content = str_replace("{FECHA}", $fecha, $cv_content);
    $cv_content = str_replace("{CORREO}", $correo, $cv_content);
    $cv_content = str_replace("{TELEFONO}", $telefono, $cv_content);
    $cv_content = str_replace("{DIRECCION}", $direccion, $cv_content);
    $cv_content = str_replace("{NACIONALIDAD}", $nacionalidad, $cv_content);
    $cv_content = str_replace("{NIVEL_INGLES}", $ingles, $cv_content);
    $cv_content = str_replace("{LENGUAJES}", $lenguajes, $cv_content);
    $cv_content = str_replace("{OCUPACION}", $ocupacion, $cv_content);
    $cv_content = str_replace("{APTITUDES}", $aptitudes, $cv_content);
    $cv_content = str_replace("{HABILIDADES}", $habilidades, $cv_content);
    $cv_content = str_replace("{PERFIL}", $perfil, $cv_content);

    // Guardar la nueva versión de CV.html con los datos actualizados
    file_put_contents("CV.html", $cv_content);

    // Redirigir al usuario a CV.html
    header("Location: CV.html");
    exit;
} else {
    // Si el formulario no se envió correctamente, puedes redirigir al usuario a una página de error o mostrar un mensaje.
    echo "Ha ocurrido un error al enviar el formulario.";
}
?>
