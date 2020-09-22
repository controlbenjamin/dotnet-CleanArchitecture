using sample_ca.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace sample_ca.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
