//Generamos la coneXION
var userConection = new signalR.HubConnectionBuilder().withUrl("/Hubs/HomeHub.cs").build();

//Generar los metodos para recibir datos del hub

//Llega como parametros la imagen convertida a string y el rol de donde proviene.
userConection.on("RecibirVoto", (rol, voto) =>
{
    //Segun el rol asigno a la etiqueta correspondiente.
    switch (rol) {

        case 'Carpintero':
            document.getElementById("voto1").innerText = voto;
        break;

        case 'Mercader':
            document.getElementById("voto2").innerText = voto;
        break;

        case 'Artillero':
            document.getElementById("voto3").innerText = voto;
        break;
    }

})

//Generar los metodos, para enviar datos hacia el hub
//Esta funcion es llamada por el servidor de manera automatica.
function actualizarVotos()
{
    let rol;
    let elemento;
    let voto;

    //Cargo un arreglo de etiquetas que pertenecen a la clase "imagen"
    let votos = document.getElementsByClassName("voto");
    
    for (var i = 0; i < votos.length; i++)
    {
        //Segun el numero que tiene esta vuelta del loop, asigno un rol y cargo el contenido del elemento.
        switch (i)
        {
            case 0:
                rol = 'Carpintero';
                elemento = document.getElementById("voto1");
                voto = elemento.innerText;
            break;

            case 1:
                rol = 'Mercader';
                elemento = document.getElementById("voto2");
                voto = elemento.innerText;
            break;

            case 2:
                rol = "Artillero";
                elemento = document.getElementById("voto3");
                voto = elemento.innerText;
            break;

            //Finalmente envio el dato a mis clientes. Uno a uno.
            userConection.send("EnviarVoto", rol, voto);
        }
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
