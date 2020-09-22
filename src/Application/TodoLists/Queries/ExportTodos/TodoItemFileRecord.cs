using sample_ca.Application.Common.Mappings;
using sample_ca.Domain.Entities;

namespace sample_ca.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
