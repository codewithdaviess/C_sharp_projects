using System;

namespace TodoApp.Data.AggregateRoots;

public class FullAuditedAggregatedRoot<T> : AuditedAggregatedRoot<T>
{
    public DateTime LastModificationTime { get; set; } = DateTime.Now;
    public int? LastModifiedId { get; set; }
}
