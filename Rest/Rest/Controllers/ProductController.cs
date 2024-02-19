using Microsoft.AspNetCore.Mvc;
using Rest.Context.Entities;
using Rest.Services;

namespace Rest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController(ProductService productService) : ControllerBase
    {
        private readonly ProductService service = productService;


        [HttpGet]
        public Task<IQueryable<Product>> GetFirst1000()
        {
            return service.GetFirst1000();
        }
    }
}
