//Generamos la coneXION
var userConection = new signalR.HubConnectionBuilder().withUrl("/Hubs/EjemploHub.cs").build();

//Generar los metodos para recibir datos del hub
userConection.on("UpdateTurno", (valor) => {
    var x = document.getElementById("v1");
    x.innerHTML = parseInt(valor);
})

//Generar los metodos, para enviar datos hacia el hub
function siguienteTurno() {

    var turno = parseInt(document.getElementById("v1").innerHTML);

    userConection.send("MandarTurno", parseInt(turno));

}





function ConexionRechazada() {
    console.log("La conexion fue rechazada");
}


function ConexionRealizada() {
    console.log("La conexion fue un exito");
}


//Comenzar la coneccion
userConection.start().then(ConexionRealizada, ConexionRechazada)
