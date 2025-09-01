public class PasswordReset
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public string ResetToken { get; set; } = null!;
    public DateTime ExpiresAt { get; set; }
}
