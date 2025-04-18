namespace SignalChat.Server.Models
{
    public class Message
    {
        public string? Id { get; set; }
        public string? Content { get; set; }
        public string? User { get; set; }
        public string? MessageTime { get; set; }
        public int? DisappearAfter { get; set; }
        public int? RemainingTime { get; set; }
        public int? RemainingPercentage { get; set; }
    }
}
