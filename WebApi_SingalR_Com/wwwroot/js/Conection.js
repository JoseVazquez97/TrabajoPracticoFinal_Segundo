//Generamos la coneXION

var userConection = new signalR.HubConnectionBuilder().withUrl("/Hubs/UserHub.cs").build();

//Generar los metodos para recibir datos del hub
userConection.on("UpdateTurno", (value) =>
{
    var x = document.getElementById("Turnero");
    x.innerHTML = value.toString();
})

//Generar los metodos, para enviar datos hacia el hub
function siguienteTurno()
{
    userConection.send("MandarTurno");
}

function ConexionRechazada()
{
    console.log("La conexion fue rechazada");
}


function ConexionRealizada() {
    console.log("La conexion fue un exito");
}


//Comenzar la coneccion
userConection.start().then(ConexionRealizada, ConexionRechazada)