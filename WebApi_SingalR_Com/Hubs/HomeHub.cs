using Microsoft.AspNetCore.SignalR;
using System.Drawing;

namespace WebApi_SingalR_Com.Hubs
{
    //Lo primero que debemos hacer es crear un hub, que Herede de esta clase
    public class HomeHub : Hub
    {
        public static string imagen1 { get; set; } = "";
        public static string imagen2 { get; set; } = "";
        public static string imagen3 { get; set; } = "";
        public static string imagen4 { get; set; } = "";

        public async Task EnviarImagen(string img1, string img2, string img3, string img4)
        {
            imagen1 = img1;
            imagen2 = img2;
            imagen3 = img3;
            imagen4 = img4;

            //MANDAR LA ACTUALIZACION
            await Clients.All.SendAsync("RecibirImagen", imagen1,imagen2,imagen3,imagen4);
        }
    }
}