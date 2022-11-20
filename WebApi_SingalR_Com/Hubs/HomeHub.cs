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
        public static string Turno { get; set; } = "";
        public static string Voto { get; set; } = "";
        public static string Evento { get; set; } = "";

        public static string EventoRandom { get; set; } = "";

        //WebCams
        public async Task EnviarImagen(string imagenU1x, string rol)
        {
            imagenU1= imagenU1x;
            Rol = rol;

            //MANDAR LA ACTUALIZACION
            await Clients.All.SendAsync("RecibirImagen", imagenU1x, rol);
        }

        //Turnero
        public async Task SiguienteTurno(string Turnox)
        {
            Turno = Turnox;

            //MANDAR LA ACTUALIZACION
            await Clients.All.SendAsync("RecibirTurno",Turnox);
        }

        //Eventos
        public async Task EnviarEvento(string evento)
        {
            Evento = evento;

            //MANDAR LA ACTUALIZACION
            await Clients.All.SendAsync("RecibirEvento", evento);
        }

        //Evento Random
        public async Task EnviarEventoRandom(string evento)
        {
            EventoRandom = evento;

            //MANDAR LA ACTUALIZACION
            await Clients.All.SendAsync("RecibirEventoRandom", evento);
        }

        //Votos
        public async Task EnviarVoto(string voto, string rol)
        {
            Voto = voto;
            Rol = rol;

            //MANDAR LA ACTUALIZACION
            await Clients.All.SendAsync("RecibirVoto", voto, rol);
        }
    }
}
