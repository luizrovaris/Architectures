using CustomerRelationship.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace CustomerRelationship.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
