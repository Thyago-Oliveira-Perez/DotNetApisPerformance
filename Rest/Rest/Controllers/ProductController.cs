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


        [HttpGet("First1000Products")]
        public Task<IQueryable<Product>> GetFirst1000()
        {
            return service.GetFirst1000();
        }

        [HttpGet("First1000FullProducts")]
        public Task<IQueryable<Product>> GetFirstFull1000()
        {
            return service.GetFirstFull1000();
        }
    }
}
