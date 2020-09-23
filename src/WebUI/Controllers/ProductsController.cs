using Microsoft.AspNetCore.Mvc;
using sample_ca.Application.Products.Commands.CreateProduct;
using sample_ca.Application.Products.Commands.DeleteProduct;
using sample_ca.Application.Products.Commands.UpdateProduct;
using sample_ca.Application.Products.Queries.GetProducts;
using System.Threading.Tasks;
namespace sample_ca.WebUI.Controllers
{
    public class ProductsController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<ProductsVm>> Get()
        {
            return await Mediator.Send(new GetProductsQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductsVm>> Get(int id)
        {
            var product = await Mediator.Send(new GetProductQuery { ProductId = id });


            return product;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateProductCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateProductCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteProductCommand { Id = id });

            return NoContent();
        }







        /*
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */




    }
}
