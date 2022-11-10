//Generamos la coneXION
var userConection = new signalR.HubConnectionBuilder().withUrl("/Hubs/HomeHub.cs").build();

//Generar los metodos para recibir datos del hub
userConection.on("RecibirImagen", (bitmap1, bitmap2, bitmap3, bitmap4) =>
{
    document.getElementById("imagen1").innerHTML = bitmap1;
    document.getElementById("imagen2").innerHTML = bitmap2;
    document.getElementById("imagen3").innerHTML = bitmap3;
    document.getElementById("imagen4").innerHTML = bitmap4;
})

//Generar los metodos, para enviar datos hacia el hub
function actualizarImagenes()
{
    var imagen1 = document.getElementById("imagen1").innerHTML;
    var imagen2 = document.getElementById("imagen2").innerHTML;
    var imagen3 = document.getElementById("imagen3").innerHTML;
    var imagen4 = document.getElementById("imagen4").innerHTML;

    userConection.send("EnviarImagen", imagen1,imagen2,imagen3,imagen4);
}

function ConexionRechazada() {
    console.log("La conexion fue rechazada");
}


function ConexionRealizada() {
    console.log("La conexion fue un exito");
}


//Comenzar la coneccion
userConection.start().then(ConexionRealizada, ConexionRechazada)
