using System;

namespace Auth.Data.AggregatedRoots
{
    public class BasicAggregateRoot<T>
    {
        public T Id { get; set; } = default!;
    }
}
