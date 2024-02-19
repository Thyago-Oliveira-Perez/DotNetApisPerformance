using ProductEntity = GraphQL.Services.Entities.Product;

namespace GraphQL.Schema.Queries.Product
{
    public class ProductQueries
    {
        [GraphQLDeprecated("Pretty first query")]
        public string HelloWorld => "Hello World!";

        public Task<IQueryable<ProductEntity>> GetFirst1000([Service] ProductService service)
        {
            return service.Get1000();
        }
    }
}
