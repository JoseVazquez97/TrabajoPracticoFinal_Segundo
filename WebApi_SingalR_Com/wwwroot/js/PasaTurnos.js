//Generamos la coneXION
var userConection = new signalR.HubConnectionBuilder().withUrl("/Hubs/HomeHub.cs").build();

//Generar los metodos para recibir datos del hub
userConection.on("RecibirTurno", (key,turno) => {

    document.getElementById("Turnero").innerHTML = turno

    switch (key)
    {
        case "1":
            document.getElementById("Key").innerHTML = "2";
        break;

        case "2":
            document.getElementById("Key").innerHTML = "3";
        break;

        case "3":
            document.getElementById("Key").innerHTML = "4";
        break;

        case "4":
            document.getElementById("Key").innerHTML = "1";
        break;
    }
})

//Generar los metodos, para enviar datos hacia el hub
function actualizarTurneros() {

    var turno = document.getElementById("Turnero");
    var key = document.getElementById("Keys");


    userConection.send("SiguienteTurno", key,turno);
}

function ConexionRechazada() {
    console.log("La conexion fue rechazada");
}


function ConexionRealizada() {
    console.log("La conexion fue un exito");
}


//Comenzar la coneccion
userConection.start().then(ConexionRealizada, ConexionRechazada)