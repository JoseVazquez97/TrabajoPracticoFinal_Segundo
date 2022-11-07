using Microsoft.AspNetCore.SignalR;

namespace WebApi_SingalR_Com.Hubs
{

    //Lo primero que debemos hacer es crear un hub, que Herede de esta clase
    public class HomeHub : Hub
    {
        public static int valor1 { get; set; } = 0;
        public static int valor2 { get; set; } = 0;

        public async Task TirarDados()
        {
            //MANDAR LA ACTUALIZACION
            await Clients.All.SendAsync("VerDados", valor1, valor2);
        }
    }
}
