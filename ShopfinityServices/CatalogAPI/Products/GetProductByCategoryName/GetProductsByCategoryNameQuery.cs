using CatalogAPI.Models;

namespace CatalogAPI.Products.GetProducgByCategoryName
{
    public sealed record GetProductsByCategoryNameQuery(string CategoryName)
        : IRequest<List<Product>>;
}
