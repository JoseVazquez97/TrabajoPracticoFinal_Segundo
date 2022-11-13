//Generamos la coneXION
var userConection = new signalR.HubConnectionBuilder().withUrl("/Hubs/HomeHub.cs").build();

//Generar los metodos para recibir datos del hub

//Llega como parametros la imagen convertida a string y el rol de donde proviene.
userConection.on("RecibirImagen", (stringmap, rol) =>
{
    //Segun el rol asigno a la etiqueta correspondiente.
    switch (rol) {
        case 'Capitan':
            document.getElementById("img1").innerText = stringmap;
        break;

        case 'Carpintero':
            document.getElementById("img2").innerText = stringmap;
        break;

        case 'Mercader':
            document.getElementById("img3").innerText = stringmap;
        break;

        case 'Artillero':
            document.getElementById("img4").innerText = stringmap;
        break;
    }

})

//Generar los metodos, para enviar datos hacia el hub
//Esta funcion es llamada por el servidor de manera automatica.
function actualizarImagenes()
{
    let rol;
    let elemento;
    let stringmap;

    //Cargo un arreglo de etiquetas que pertenecen a la clase "imagen"
    let imagenes = document.getElementsByClassName("imagen");
    
    for (var i = 0; i < imagenes.length; i++)
    {
        //Segun el numero que tiene esta vuelta del loop, asigno un rol y cargo el contenido del elemento.
        switch (i)
        {
            case 0:
                rol = 'Capitan';
                elemento = document.getElementById("img1");
                stringmap = elemento.innerText;
            break;

            case 1:
                rol = 'Carpintero';
                elemento = document.getElementById("img2");
                stringmap = elemento.innerText;
            break;

            case 2:
                rol = 'Mercader';
                elemento = document.getElementById("img3");
                stringmap = elemento.innerText;
            break;

            case 3:
                rol = "Artillero";
                elemento = document.getElementById("img4");
                stringmap = elemento.innerText;
            break;
        }

        //Finalmente envio el dato a mis clientes. Uno a uno.
        userConection.send("EnviarImagen", stringmap, rol);
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
