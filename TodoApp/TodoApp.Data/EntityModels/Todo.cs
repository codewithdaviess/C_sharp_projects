using System.Collections.Generic;
using TodoApp.Data.AggregateRoots;

public class Todo : FullAuditedAggregatedRoot<int>
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool Completed { get; set; } = false;

    // Relationships
    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public int? CategoryId { get; set; }
    public Category? Category { get; set; }

    public List<Tag> Tags { get; set; } = new();
}
