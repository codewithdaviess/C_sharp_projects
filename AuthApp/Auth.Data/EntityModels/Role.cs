public class Role
{
    public int Id { get; set; }
    public string RoleName { get; set; } = null!;
    public string Permissions { get; set; } = null!; // Could be JSON string

    public ICollection<User> Users { get; set; } = new List<User>();
}
