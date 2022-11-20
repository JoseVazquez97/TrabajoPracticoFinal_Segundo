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

//Recibir valores de dados
userConection.on("RecibirDados", (val1, val2) => {

    if (val1 != "0" && val2 != "0")
    {
        document.getElementById("val1").innerHTML = val1;
        document.getElementById("val2").innerHTML = val2;
    }
})


//Generar los metodos, para enviar datos hacia el hub
function actualizarTurneros()
{
    let elemento = document.getElementById("TurnoActual");
    var turno = elemento.innerText;

    userConection.send("SiguienteTurno", turno);
}

//Enviar valores de dados al resto.
function actualizarDados() {
    let elemento1 = document.getElementById("val1");
    let elemento2 = document.getElementById("val2");
    var val1 = elemento1.innerText;
    var val2 = elemento2.innerText;

    userConection.send("EnviarDados", val1, val2);
}


function ConexionRechazada() {
    console.log("La conexion fue rechazada");
}

function ConexionRealizada() {
    console.log("La conexion fue un exito");
}

//Comenzar la coneccion
userConection.start().then(ConexionRealizada, ConexionRechazada)