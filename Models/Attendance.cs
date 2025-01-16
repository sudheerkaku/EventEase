namespace EventEase.Models
{
    public class Attendance
    {
        public int EventId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
