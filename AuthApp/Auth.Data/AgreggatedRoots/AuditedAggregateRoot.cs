using System;

namespace Auth.Data.AggregatedRoots
{
    public class AuditedAggregateRoot<T> : BasicAggregateRoot<T>
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
