﻿using AutoMapper;
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

            var viewModel = new ProductsVm();

            using (var connection = new SqlConnection(connectionString))
            {
                viewModel.Products = await connection.QueryAsync<ProductDto>(sql);

            }

            return viewModel;




        }
    }

}
