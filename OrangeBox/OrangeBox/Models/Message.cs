namespace OrangeBox.Models
{
    public class Message
    {
        public int MessageId { get; set; } // Primary Key
        public string Username { get; set; }
        public string Text { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow; // Automatically set to current time
    }
}
