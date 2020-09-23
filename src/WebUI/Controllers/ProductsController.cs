//using sample_ca.Application.TodoLists.Commands.CreateTodoList;
//using sample_ca.Application.TodoLists.Commands.DeleteTodoList;
//using sample_ca.Application.TodoLists.Commands.UpdateTodoList;
//using sample_ca.Application.TodoLists.Queries.ExportTodos;
using sample_ca.Application.Products.Queries.GetProducts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace sample_ca.WebUI.Controllers
{
    public class ProductsController:ApiController
    {
        [HttpGet]
        public async Task<ActionResult<ProductDto>> Get()
        {
            return await Mediator.Send(new GetProductsQuery());
        }

       
    }
}
