using Microsoft.AspNetCore.SignalR;
using System.Drawing;

namespace WebApi_SingalR_Com.Hubs
{
    //Lo primero que debemos hacer es crear un hub, que Herede de esta clase
    public class HomeHub : Hub
    {
                                //imageUCL -> Imagen Cliente
        public static string imagenU1 { get; set; } = "";
        public static string Rol { get; set; } = "";

        public async Task EnviarImagen(string imagenU1x, string rol)
        {
            imagenU1= imagenU1x;
            Rol = rol;

            //MANDAR LA ACTUALIZACION
            await Clients.All.SendAsync("RecibirImagen", imagenU1x, rol);
        }
    }
}
