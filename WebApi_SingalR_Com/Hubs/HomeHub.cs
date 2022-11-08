using Microsoft.AspNetCore.SignalR;

namespace WebApi_SingalR_Com.Hubs
{
    //Lo primero que debemos hacer es crear un hub, que Herede de esta clase
    public class HomeHub : Hub
    {
        public static int Turno { get; set; } = 0;

        public async Task MandarTurno(int turnox)
        {
            Turno = turnox;
            Turno++;

            //MANDAR LA ACTUALIZACION
            await Clients.Others.SendAsync("UpdateTurno", Turno);
        }
    }
}