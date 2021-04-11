using CustomerRelationship.Domain.Common;
using CustomerRelationship.Domain.Entities;

namespace CustomerRelationship.Domain.Events
{
    public class TodoItemCreatedEvent : DomainEvent
    {
        public TodoItemCreatedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
