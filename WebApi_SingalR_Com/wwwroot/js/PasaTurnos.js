//Generamos la coneXION
var userConection = new signalR.HubConnectionBuilder().withUrl("/Hubs/HomeHub.cs").build();

//RECIBIR MENSAJE
userConection.on("RecibirTurno", (rol, turno, key) => {

    let turnoAct = document.getElementById("TurnoActual").innerHTML;

    switch (rol) //Y segun el rol que hizo el cambio paso el turno
    {
        case 'Capitan':
            document.getElementById("key1").innerHTML = key;

            if (parseInt(turno) > turnoAct)
            {
                document.getElementById("TurnoActual").innerHTML = turno;
                document.getElementById("key1").innerHTML = '0';
                document.getElementById("key2").innerHTML = '1';
            }
        break;

        case 'Carpintero':
            document.getElementById("key2").innerHTML = key;
            if (parseInt(turno) > turnoAct) {
                document.getElementById("TurnoActual").innerHTML = turno;
                document.getElementById("key2").innerHTML = '0';
                document.getElementById("key3").innerHTML = '1';
            }
        break;

        case 'Mercader':
            document.getElementById("key3").innerHTML = key;
            if (parseInt(turno) > turnoAct) {
                document.getElementById("TurnoActual").innerHTML = turno;
                document.getElementById("key3").innerHTML = '0';
                document.getElementById("key4").innerHTML = '1';
            }
        break;

        case 'Astillero':
            document.getElementById("key4").innerHTML = key;
            if (parseInt(turno) > turnoAct) {
                document.getElementById("TurnoActual").innerHTML = turno;
                document.getElementById("key4").innerHTML = '0';
                document.getElementById("key1").innerHTML = '1';
            }
        break;
    }
})

//Generar los metodos, para enviar datos hacia el hub
function actualizarTurneros() {

    let key;
    let elemento;
    let turno = document.getElementById("TurnoActual").innerText;

    //Cargo un arreglo de etiquetas que pertenecen a la clase "imagen"
    let roles = document.getElementsByClassName("roles");

    for (var i = 0; i < roles.length; i++) {
        //Segun el numero que tiene esta vuelta del loop, asigno un rol y cargo el contenido del elemento.
        switch (i)
        {
            case 0:
                rol = 'Capitan';
                elemento = document.getElementById("key1");
                key = elemento.innerText;
            break;

            case 1:
                rol = 'Carpintero';
                elemento = document.getElementById("key2");
                key = elemento.innerText;
            break;

            case 2:
                rol = 'Mercader';
                elemento = document.getElementById("key3");
                key = elemento.innerText;
            break;

            case 3:
                rol = 'Astillero';
                elemento = document.getElementById("key4");
                key = elemento.innerText;
            break;
        }

        userConection.send("SiguienteTurno", rol, turno, key);
    }
}

function ConexionRechazada() {
    console.log("La conexion fue rechazada");
}

function ConexionRealizada() {
    console.log("La conexion fue un exito");
}

//Comenzar la coneccion
userConection.start().then(ConexionRealizada, ConexionRechazada)