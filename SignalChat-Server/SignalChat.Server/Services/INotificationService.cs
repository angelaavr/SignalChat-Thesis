namespace SignalChat.Server.Services
{
    public interface INotificationService
    {
        Task PingAllClients();
    }
}
