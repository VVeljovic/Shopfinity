using CatalogAPI.Models;

namespace CatalogAPI.Products.GetProducts
{
    public sealed record GetProductsResponse(List<Product> Products);
}
