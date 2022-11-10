//Generamos la coneXION
var userConection = new signalR.HubConnectionBuilder().withUrl("/Hubs/HomeHub.cs").build();

//Generar los metodos para recibir datos del hub
userConection.on("RecibirImagen", (stringmap1, stringmap2, stringmap3, stringmap4) =>
{
    console.log("mensajesRecibidos");
    document.getElementById("imagen1").innerHTML = stringmap1;
    document.getElementById("imagen2").innerHTML = stringmap2;
    document.getElementById("imagen3").innerHTML = stringmap3;
    document.getElementById("imagen4").innerHTML = stringmap4;
})

//Generar los metodos, para enviar datos hacia el hub
function actualizarImagenes()
{
    var stringmap1 = document.getElementById("imagen1").innerHTML.toString();
    var stringmap2 = document.getElementById("imagen2").innerHTML.toString();
    var stringmap3 = document.getElementById("imagen3").innerHTML.toString();
    var stringmap4 = document.getElementById("imagen4").innerHTML.toString();

    document.getElementById("imagen1").innerHTML = "";
    document.getElementById("imagen2").innerHTML = "";
    document.getElementById("imagen3").innerHTML = "";
    document.getElementById("imagen4").innerHTML = "";

    userConection.send("EnviarImagen", stringmap1, stringmap2, stringmap3, stringmap4);
}

function borrarImagenes()
{
    
}

function ConexionRechazada() {
    console.log("La conexion fue rechazada");
}


function ConexionRealizada() {
    console.log("La conexion fue un exito");
}


//Comenzar la coneccion
userConection.start().then(ConexionRealizada, ConexionRechazada)
