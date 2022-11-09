using Microsoft.AspNetCore.SignalR;

namespace WebApi_SingalR_Com.Hubs
{
    public class ChatHub : Hub
    {

        public async Task SendMessage(string sala, string user, string msg) 
        {
            await Clients.Group(sala).SendAsync("ReciveMsg", user, msg);
        }
    }
}
