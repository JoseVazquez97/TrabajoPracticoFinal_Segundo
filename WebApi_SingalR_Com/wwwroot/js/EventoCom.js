//Generamos la coneXION
var userConection = new signalR.HubConnectionBuilder().withUrl("/Hubs/HomeHub.cs").build();

//Generar los metodos para recibir datos del hub

userConection.on("RecibirEvento", (evento) => {

    document.getElementById("EventoActual").innerText = evento;
})

userConection.on("RecibirEventoRandom", (evento) => {

    if (evento != "Isla") {
        document.getElementById("EventoRandom").innerText = evento;
    }
})

userConection.on("RecibirOrden", (orden) => {

    if (orden != "Tripulante") {
        document.getElementById("Desicion").innerText = orden;
    }
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

function actualizarEventoR() {
    let evento;
    evento = document.getElementById("EventoRandom").innerHTML;


    //Finalmente envio el dato a mis clientes.
    userConection.send("EnviarEventoRandom", evento);
}

function actualizarOrden() {
    let orden;
    orden = document.getElementById("Desicion").innerHTML;


    //Finalmente envio el dato a mis clientes.
    userConection.send("EnviarOrden", orden);
}

function ConexionRechazada() {
    console.log("La conexion fue rechazada");
}


function ConexionRealizada() {
    console.log("La conexion fue un exito");
}


//Comenzar la coneccion
userConection.start().then(ConexionRealizada, ConexionRechazada)
