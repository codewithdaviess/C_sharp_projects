using System;

namespace Auth.Data.AggregatedRoots
{
    public class FullAggregateRoot<T> : AuditedAggregateRoot<T>
    {
        public bool IsDeleted { get; set; }
        public int Version { get; set; }
    }
}
