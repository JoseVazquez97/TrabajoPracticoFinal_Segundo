//Generamos la coneXION
var userConection = new signalR.HubConnectionBuilder().withUrl("/Hubs/EjemploHub.cs").build();

//Generar los metodos para recibir datos del hub
userConection.on("UpdateTurno", (value) => {
    document.getElementById("v1").innerHTML = value;
})

//Generar los metodos, para enviar datos hacia el hub
function siguienteTurno()
{
    var value = parseInt(document.getElementById("v1").innerHTML);
    userConection.send("MandarTurno", parseInt(value));
}

function minutos()
{
    var segS = parseInt(document.getElementById("v1").innerHTML);
    var minS = parseInt(document.getElementById("min").innerHTML);

    if (segS >= 60)
    {
        document.getElementById("v1").innerHTML = "0";
        minS++;
        document.getElementById("min").innerHTML = minS.toString();
    }
}

function ConexionRechazada() {
    console.log("La conexion fue rechazada");
}


function ConexionRealizada() {
    console.log("La conexion fue un exito");
}


//Comenzar la coneccion
userConection.start().then(ConexionRealizada, ConexionRechazada)
