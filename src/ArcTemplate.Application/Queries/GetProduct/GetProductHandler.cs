using ArcTemplate.Application.DTOs;
using MediatR;
using ArcTemplate.Core.Interfaces;

namespace ArcTemplate.Application.UseCases.GetProduct
{
    public class GetProductHandler : IRequestHandler<GetProductQuery, ProductDTO>
    {
        private readonly IProductRepository _productRepository;

        public GetProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<ProductDTO> Handle(GetProductQuery query, CancellationToken cancellationToken)
        {
            var product = _productRepository.GetProductById(query.Id);
            return Task.FromResult(new ProductDTO { Id = product.Id, Name = product.Name, Price = product.Price });
        }
    }
}
