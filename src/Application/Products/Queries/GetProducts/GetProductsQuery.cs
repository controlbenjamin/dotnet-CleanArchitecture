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
using System.Collections.Generic;
using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace sample_ca.Application.Products.Queries.GetProducts
{
    public class GetProductsQuery : IRequest<ProductsVm>
    {
    }


    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, ProductsVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public GetProductsQueryHandler(IApplicationDbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<ProductsVm> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
           
            string sql = "SELECT * FROM Products";

            var products = new List<ProductDto>();
            using (var connection = new SqlConnection(connectionString))
            {
                products = connection.QueryAsync<ProductDto>(sql).Result.ToList();

            }


            var viewModel = new ProductsVm();

            viewModel.Products = products;

            return viewModel;


        }
    }

}
