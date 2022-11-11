//Generamos la coneXION
var userConection = new signalR.HubConnectionBuilder().withUrl("/Hubs/TurneroHub.cs").build();

//Generar los metodos para recibir datos del hub
userConection.on("RecibirTurno", (rol, turno) => {

    document.getElementById("Turnero").innerHTML = turno

    switch (rol)
    {
        case "Capitan":
            document.getElementById("Key").innerHTML = "1";
        break;

        case "Carpintero":
            document.getElementById("Key").innerHTML = "2";
        break;

        case "Mercader":
            document.getElementById("Key").innerHTML = "3";
        break;

        case "Artillero":
            document.getElementById("Key").innerHTML = "4";
        break;
    }
})

//Generar los metodos, para enviar datos hacia el hub
function actualizarTurneros() {

    const key = document.getElementsByClassName("Keys");

    userConection.send("SiguienteTurno", rol,turno);
}

function ConexionRechazada() {
    console.log("La conexion fue rechazada");
}


function ConexionRealizada() {
    console.log("La conexion fue un exito");
}


//Comenzar la coneccion
userConection.start().then(ConexionRealizada, ConexionRechazada)