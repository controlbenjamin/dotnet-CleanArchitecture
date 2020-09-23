using sample_ca.Application.Common.Exceptions;
using sample_ca.Application.Common.Interfaces;
using sample_ca.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace sample_ca.Application.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand: IRequest
    {
        public int Id { get; set; }
    }


    public class DeleteCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            
            var entity = await _context.Products.FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Product), request.Id);
            }

            _context.Products.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }

}
