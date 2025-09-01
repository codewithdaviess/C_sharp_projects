public class Verification
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public string Token { get; set; } = null!;
    public string Type { get; set; } = null!; // e.g., "email_confirmation"
    public DateTime ExpiresAt { get; set; }
}
