using Microsoft.AspNetCore.SignalR;
namespace WebApplication1

{
    public class Chathub:Hub
    {
        public async Task Send(string message)
        {
            await this.Clients.All.SendAsync("Receive", message);
        }
    }
}
