using Microsoft.EntityFrameworkCore;

public class TodoDbContext : DbContext
{
    public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Todo> Todos { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Tag> Tags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // User → Todo (1-to-Many)
        modelBuilder.Entity<User>()
            .HasMany(u => u.Todos)
            .WithOne(t => t.User)
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        // Category → Todo (1-to-Many)
        modelBuilder.Entity<Category>()
            .HasMany(c => c.Todos)
            .WithOne(t => t.Category)
            .HasForeignKey(t => t.CategoryId)
            .OnDelete(DeleteBehavior.SetNull);

        // Todo → Tag (Many-to-Many)
        modelBuilder.Entity<Todo>()
            .HasMany(t => t.Tags)
            .WithMany(tg => tg.Todos)
            .UsingEntity<Dictionary<string, object>>(
                "TodoTag",
                tt => tt.HasOne<Tag>().WithMany().HasForeignKey("TagId"),
                tt => tt.HasOne<Todo>().WithMany().HasForeignKey("TodoId"),
                tt => tt.HasKey("TodoId", "TagId") // composite key
            );
    }
}
