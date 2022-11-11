//Generamos la coneXION
var userConection = new signalR.HubConnectionBuilder().withUrl("/Hubs/HomeHub.cs").build();

//Generar los metodos para recibir datos del hub
userConection.on("RecibirTurno", (rol,key,turno) => {

    var turnoAnt = document.getElementById("Turnero").innerHTML;

    if (turno != turnoAnt)
    {
        document.getElementById("Turnero").innerHTML = turno;

        switch (rol) {
            case 'Capitan':
                document.getElementById("key1").innerText = key;
                document.getElementById("key2").innerText = "0";
                document.getElementById("key3").innerText = "0";
                document.getElementById("key4").innerText = "0";
            break;

            case 'Carpintero':
                document.getElementById("key1").innerText = "0";
                document.getElementById("key2").innerText = key;
                document.getElementById("key3").innerText = "0";
                document.getElementById("key4").innerText = "0";
            break;

            case 'Mercader':
                document.getElementById("key1").innerText = "0";
                document.getElementById("key2").innerText = "0";
                document.getElementById("key3").innerText = key;
                document.getElementById("key4").innerText = "0";
            break;

            case 'Artillero':
                document.getElementById("key1").innerText = "0";
                document.getElementById("key2").innerText = "0";
                document.getElementById("key3").innerText = "0";
                document.getElementById("key4").innerText = key;
            break;
        }

    }
})

//Generar los metodos, para enviar datos hacia el hub
function actualizarTurneros() {

    let elemento;
    let turno = document.getElementById("Turnero").innerText;
    let key = "0";

    //Cargo un arreglo de etiquetas que pertenecen a la clase "imagen"
    const keys = document.getElementsByClassName("Keys");

    for (var i = 0; i < keys.length; i++) {
        //Segun el numero que tiene esta vuelta del loop, asigno un rol y cargo el contenido del elemento.
        switch (i) {
            case 0:
                
                elemento = document.getElementById("key1");
                if (elemento.innerText == "1")
                {
                    rol = "Capitan";
                    key = "1";
                }
                
            break;

            case 1:
               
                elemento = document.getElementById("key2");
                if (elemento.innerText == "1") {
                    rol = 'Carpintero';
                    key = "1";
                }

            break;

            case 2:
                elemento = document.getElementById("key3");
                if (elemento.innerText == "1") {
                    rol = 'Mercader';
                    key = "1";
                }
            break;

            case 3:
                elemento = document.getElementById("key4");
                if (elemento.innerText == "1") {
                    rol = 'Astillero';
                    key = "1";
                }
            break;
        }
    }

    userConection.send("SiguienteTurno", rol, key, turno);
}

function ConexionRechazada() {
    console.log("La conexion fue rechazada");
}


function ConexionRealizada() {
    console.log("La conexion fue un exito");
}


//Comenzar la coneccion
userConection.start().then(ConexionRealizada, ConexionRechazada)