using AutoMapper;
using Dapper;
using MediatR;
using Microsoft.Extensions.Configuration;
using sample_ca.Application.Common.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace sample_ca.Application.Products.Queries.GetProducts
{
    public class GetProductQuery : IRequest<ProductsVm>
    {

        public int ProductId { get; set; }

    }

    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, ProductsVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public GetProductQueryHandler(IApplicationDbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<ProductsVm> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {

            string connectionString = _configuration.GetConnectionString("DefaultConnection");


            var parameter = new { productId = request.ProductId };


            string sql = "SELECT * FROM Products WHERE Id = @productId";
            var viewModel = new ProductsVm();

            using (var connection = new SqlConnection(connectionString))
            {
                viewModel.Product = await connection.QueryFirstOrDefaultAsync<ProductDto>(sql, parameter);

            }

            return viewModel;


        }
    }

}
