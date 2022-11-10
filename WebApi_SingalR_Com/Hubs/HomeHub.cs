using Microsoft.AspNetCore.SignalR;
using System.Drawing;

namespace WebApi_SingalR_Com.Hubs
{
    //Lo primero que debemos hacer es crear un hub, que Herede de esta clase
    public class HomeHub : Hub
    {
                                //imageUCL -> Imagen Cliente
        public static string imageUCL { get; set; } = "";

        public static string imagenU2 { get; set; } = "";
        public static string imagenU3 { get; set; } = "";
        public static string imagenU4 { get; set; } = "";

        public async Task EnviarImagen(string imageUCLx, string imagenU2x, string imagenU3x, string imagenU4x)
        {
            imageUCL= imageUCLx;
            imagenU2= imagenU2x;
            imagenU3= imagenU3x;
            imagenU4= imagenU4x;

            //MANDAR LA ACTUALIZACION
            await Clients.All.SendAsync("RecibirImagen", imageUCL, imagenU2, imagenU3, imagenU4);
        }
    }
}
