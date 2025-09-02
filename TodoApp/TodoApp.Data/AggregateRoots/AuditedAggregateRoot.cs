using System;

namespace TodoApp.Data.AggregateRoots;

public class AuditedAggregatedRoot<T> : BasicAggregateRoot<T>
{
    public DateTime CreationTime { get; set; } = DateTime.Now;
    public int? CreatorId { get; set; }
    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletionTime { get; set; }
}
