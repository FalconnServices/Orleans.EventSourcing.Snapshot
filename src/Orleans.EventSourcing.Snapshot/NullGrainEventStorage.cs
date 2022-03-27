using Orleans.Runtime;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orleans.EventSourcing.Snapshot
{
    public class NullGrainEventStorage : IGrainEventStorage
    {
        public Task<int> EventsCount<TEvent>(string grainTypeName, GrainReference grainReference)
            where TEvent : class
        {
            throw new NotSupportedException();
        }

        public Task<List<TEvent>> ReadEvents<TEvent>(string grainTypeName, GrainReference grainReference, int start, int count)
            where TEvent : class
        {
            throw new NotSupportedException();
        }

        public Task SaveEvents<TEvent>(string grainTypeName, GrainReference grainReference, IEnumerable<TEvent> events, int expectedVersion)
            where TEvent : class
        {
            throw new NotImplementedException();
        }
    }
}
