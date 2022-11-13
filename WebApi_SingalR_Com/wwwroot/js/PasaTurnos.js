//Generamos la coneXION
var userConection = new signalR.HubConnectionBuilder().withUrl("/Hubs/HomeHub.cs").build();

//RECIBIR MENSAJE
userConection.on("RecibirTurno", (turno) => {

    let turnoActual = document.getElementById("TurnoActual").innerHTML;

    if (parseInt(turnoActual) < parseInt(turno))
    {
        document.getElementById("TurnoActual").innerHTML = turno.toString();
    }
})

//Generar los metodos, para enviar datos hacia el hub
function actualizarTurneros()
{
    let elemento = document.getElementById("TurnoActual");
    var turno = elemento.innerText;

    userConection.send("SiguienteTurno", turno);
}

function ConexionRechazada() {
    console.log("La conexion fue rechazada");
}

function ConexionRealizada() {
    console.log("La conexion fue un exito");
}

//Comenzar la coneccion
userConection.start().then(ConexionRealizada, ConexionRechazada)