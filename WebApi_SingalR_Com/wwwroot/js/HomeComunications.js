//Generamos la coneXION
var userConection = new signalR.HubConnectionBuilder().withUrl("/Hubs/HomeHub.cs").build();

//Generar los metodos para recibir datos del hub
userConection.on("RecibirImagen", (stringmap, rol) =>
{
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
function actualizarImagenes()
{
    const imagenes = document.getElementsByClassName("imagen");
    let rol;
    let elemento;
    let stringmap;

    for (var i = 0; i < imagenes.length; i++)
    {
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
        console.log(rol);

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
