using Microsoft.AspNetCore.SignalR;

namespace WebApi_SingalR_Com.Hubs
{
    public class EjemploHub : Hub
    {
        public static int Turno { get; set; } = 0;

        public async Task MandarTurno(int turnox)
        {
            Turno = turnox;
            Turno++;

            //MANDAR LA ACTUALIZACION

            await Clients.All.SendAsync("UpdateTurno", Turno);
        }
    }
}
