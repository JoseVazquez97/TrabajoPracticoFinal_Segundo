//Generamos la coneXION

var userConection = new signalR.HubConnectionBuilder().withUrl("/Hubs/HomeHub.cs").build();

//Generar los metodos para recibir datos del hub
userConection.on("VerDados", (valueX1, valueX2) =>
{
    var value1 = valueX1;
    var value2 = valueX2;

    document.getElementById("v1").innerHTML = value1;
    document.getElementById("v2").innerHTML = value2;
})

function UpdateHome()
{
    var value1 = parseInt(document.getElementById("v1").innerHTML);
    var value2 = parseInt(document.getElementById("v2").innerHTML);

    userConection.invoke("TirarDados", value1, value2);
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