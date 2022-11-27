using Microsoft.AspNetCore.SignalR;
using System.Drawing;

namespace WebApi_SingalR_Com.Hubs
{
    //Lo primero que debemos hacer es crear un hub, que Herede de esta clase
    public class HomeHub : Hub
    {
        //Recursos
        public async Task EnviarRecursos(string recursos)
        {
            //MANDAR LA ACTUALIZACION
            await Clients.All.SendAsync("RecibirRecursos", recursos);
        }

        //WebCams
        public async Task EnviarImagen(string imagenU1x, string rol)
        {
            //MANDAR LA ACTUALIZACION
            await Clients.All.SendAsync("RecibirImagen", imagenU1x, rol);
        }

        //Turnero
        public async Task SiguienteTurno(string Turnox)
        {
            //MANDAR LA ACTUALIZACION
            await Clients.All.SendAsync("RecibirTurno",Turnox);
        }

        //Eventos
        public async Task EnviarEvento(string evento)
        {
            //MANDAR LA ACTUALIZACION
            await Clients.All.SendAsync("RecibirEvento", evento);
        }

        //Desicion Capitan
        public async Task EnviarOrden(string orden)
        {
            //MANDAR LA ACTUALIZACION
            await Clients.All.SendAsync("RecibirOrden", orden);
        }

        //Evento Random
        public async Task EnviarEventoRandom(string evento)
        {
            //MANDAR LA ACTUALIZACION
            await Clients.All.SendAsync("RecibirEventoRandom", evento);
        }

        //Votos
        public async Task EnviarVoto(string voto, string rol)
        {
            //MANDAR LA ACTUALIZACION
            await Clients.All.SendAsync("RecibirVoto", voto, rol);
        }

        //Dados
        public async Task EnviarDados(string val1, string val2)
        {
            //MANDAR LA ACTUALIZACION
            await Clients.All.SendAsync("RecibirDados", val1, val2);
        }

        //Barco
        public async Task EnviarBarcos(string barco1, string barco2)
        {
            //MANDAR LA ACTUALIZACION
            await Clients.All.SendAsync("RecibirBarcos", barco1, barco2);
        }
    }
}
