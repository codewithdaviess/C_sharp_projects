using System.Collections.Generic;
using TodoApp.Data.AggregateRoots;

public class Tag : BasicAggregateRoot<int>
{
    public string Name { get; set; } = string.Empty;

    // Navigation
    public List<Todo> Todos { get; set; } = new();
}
