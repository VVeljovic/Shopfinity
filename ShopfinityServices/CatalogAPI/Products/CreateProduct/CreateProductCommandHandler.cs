
using CatalogAPI.Models;

namespace CatalogAPI.Products.CreateProduct
{
    public class CreateProductCommandHandler(IDocumentSession session)
        : IRequestHandler<CreateProductCommand, CreateProductResponse>
    {
        public async Task<CreateProductResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = request.Adapt<Product>();
            product.Id = Guid.NewGuid().ToString();

            session.Store(product);
            await session.SaveChangesAsync();

            return new CreateProductResponse(Id: product.Id);
        }
    }
}
