using sample_ca.Application.Common.Interfaces;
using sample_ca.Domain.Entities;
using MediatR;// esta libreria permite que de webui vaya a aplicacion
using System.Threading;
using System.Threading.Tasks;
using System;

namespace sample_ca.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<int>
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int Stock { get; set; }

        public DateTime? LastModified { get; set; }
    }

    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateProductCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

       
        //el handle implementa algo con ese comando
        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var entity = new Product
            {
               Description = request.Description,
               Stock = request.Stock,
               LastModified = DateTime.Now
            };

            _context.Products.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);
            // crear el todo y le envia el Id a la web ui (a la api)
            return entity.Id;
        }
    }
}
