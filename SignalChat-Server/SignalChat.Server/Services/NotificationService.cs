using Microsoft.AspNetCore.SignalR;
using SignalChat.Server.HubConfig;

namespace SignalChat.Server.Services
{
    public class NotificationService : INotificationService
    {
        private readonly IHubContext<ChatHub> _chatHub;

        public NotificationService(IHubContext<ChatHub> chatHub)
        {
            _chatHub = chatHub;
        }

        public async Task PingAllClients()
        {
            await _chatHub.Clients.All.SendAsync("Ping");
        }
    }
}
