public class AuditLog
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public string EventType { get; set; } = null!; // e.g., login_success
    public string IpAddress { get; set; } = null!;
    public string Device { get; set; } = null!;
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}
