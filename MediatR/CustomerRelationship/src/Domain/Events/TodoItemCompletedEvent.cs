using CustomerRelationship.Domain.Common;
using CustomerRelationship.Domain.Entities;

namespace CustomerRelationship.Domain.Events
{
    public class TodoItemCompletedEvent : DomainEvent
    {
        public TodoItemCompletedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
