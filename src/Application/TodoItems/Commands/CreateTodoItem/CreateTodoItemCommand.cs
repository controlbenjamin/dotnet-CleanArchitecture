using sample_ca.Application.Common.Interfaces;
using sample_ca.Domain.Entities;
using MediatR;// esta libreria permite que de webui vaya a aplicacion
using System.Threading;
using System.Threading.Tasks;

namespace sample_ca.Application.TodoItems.Commands.CreateTodoItem
{
    public class CreateTodoItemCommand : IRequest<int>
    {
        public int ListId { get; set; }

        public string Title { get; set; }
    }

    public class CreateTodoItemCommandHandler : IRequestHandler<CreateTodoItemCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateTodoItemCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        //el handle implementa algo con ese comando
        public async Task<int> Handle(CreateTodoItemCommand request, CancellationToken cancellationToken)
        {
            var entity = new TodoItem
            {
                ListId = request.ListId,
                Title = request.Title,
                Done = false
            };

            _context.TodoItems.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);
            // crear el todo y le envia el Id a la web ui (a la api)
            return entity.Id;
        }
    }
}
