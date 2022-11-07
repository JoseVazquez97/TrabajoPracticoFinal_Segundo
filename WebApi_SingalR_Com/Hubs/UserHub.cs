using Microsoft.AspNetCore.SignalR;

namespace WebApi_SingalR_Com.Hubs
{

    //Lo primero que debemos hacer es crear un hub, que Herede de esta clase
    public class UserHub : Hub
    {
        public static int Turno { get; set; } = 0;

        public async Task MandarTurno() 
        {
            Turno++;

            //MANDAR LA ACTUALIZACION
            await Clients.All.SendAsync("UpdateTurno", Turno);
        }
    }
}


