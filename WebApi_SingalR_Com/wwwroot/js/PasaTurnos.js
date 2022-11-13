//Generamos la coneXION
var userConection = new signalR.HubConnectionBuilder().withUrl("/Hubs/HomeHub.cs").build();

//RECIBIR MENSAJE
userConection.on("RecibirTurno", (rol, turno, key) => {

    let turnoAct = document.getElementById("TurnoActual").innerHTML;

    if (parseInt(turnoAct) < parseInt(turno))
    {
        document.getElementById("TurnoActual").innerText = turno;

        switch (rol)
        {
            case 'Capitan':
                document.getElementById("key").innerText = '2';
            break;

            case 'Carpintero':
                document.getElementById("key").innerText = '3';
            break;

            case 'Mercader':
                document.getElementById("key").innerText = '4';
            break;

            case 'Artillero':
                document.getElementById("key").innerText = '1';
            break;
        }
    } else { }
})

//Generar los metodos, para enviar datos hacia el hub
function actualizarTurneros()
{

    let rol = 'Refresh';
    let turno;
    let key;
 
    turno = document.getElementById("TurnoActual").innerText;
    key = document.getElementById("key").innerText;

    userConection.send("SiguienteTurno", rol, turno, key);
}

function ConexionRechazada() {
    console.log("La conexion fue rechazada");
}

function ConexionRealizada() {
    console.log("La conexion fue un exito");
}

//Comenzar la coneccion
userConection.start().then(ConexionRealizada, ConexionRechazada)