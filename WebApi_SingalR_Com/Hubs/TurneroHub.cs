using Microsoft.AspNetCore.SignalR;

namespace WebApi_SingalR_Com.Hubs
{
    public class TurneroHub : Hub
    {
        public static string Rol { get; set; } = "";
        public static string Turno { get; set; } = "";

        public async Task SiguienteTurno(string Rolx, string Turnox)
        {
            Rol = Rolx;
            Turno = Turnox;

            //MANDAR LA ACTUALIZACION
            await Clients.All.SendAsync("RecibirTurno", Rolx, Turnox);
        }
    }
}
