using Orleans.Runtime;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orleans.EventSourcing.Snapshot
{
    public interface IGrainEventStorage
    {
        Task SaveEvents<TEvent>(string grainTypeName, GrainReference grainReference, IEnumerable<TEvent> events, int expectedVersion) where TEvent : class;

        Task<List<TEvent>> ReadEvents<TEvent>(string grainTypeName, GrainReference grainReference, int start, int count) where TEvent : class;

        Task<int> EventsCount<TEvent>(string grainTypeName, GrainReference grainReference) where TEvent : class;
    }
}
