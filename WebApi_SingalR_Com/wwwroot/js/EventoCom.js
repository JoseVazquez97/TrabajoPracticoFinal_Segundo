//Generamos la coneXION
var userConection = new signalR.HubConnectionBuilder().withUrl("/Hubs/HomeHub.cs").build();

//Generar los metodos para recibir datos del hub

userConection.on("RecibirEvento", (evento) => {

    document.getElementById("EventoActual").innerText = evento;
})

//Generar los metodos, para enviar datos hacia el hub
//Esta funcion es llamada por el servidor de manera automatica.
function actualizarEvento()
{
    let evento;
    evento = document.getElementById("EventoActual").innerHTML;


    //Finalmente envio el dato a mis clientes.
    userConection.send("EnviarEvento", evento);
}

function ConexionRechazada() {
    console.log("La conexion fue rechazada");
}


function ConexionRealizada() {
    console.log("La conexion fue un exito");
}


//Comenzar la coneccion
userConection.start().then(ConexionRealizada, ConexionRechazada)
