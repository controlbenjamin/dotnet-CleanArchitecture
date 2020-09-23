using AutoMapper;
using AutoMapper.QueryableExtensions;
using sample_ca.Application.Common.Interfaces;
using sample_ca.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace sample_ca.Application.Products.Queries.GetProducts
{
    public class GetProductsQuery : IRequest<ProductDto>
    {
    }


    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, ProductDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetProductsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductDto> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return new ProductDto
            {
                Id = 99,
                Description = "descripcion producto",
                LastModified = DateTime.Now,
                Stock = 69
            };
        }
    }

}
