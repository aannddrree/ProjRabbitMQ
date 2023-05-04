namespace ProjRabbitMQ.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime SendDate { get; set; } = DateTime.Now;
    }
}