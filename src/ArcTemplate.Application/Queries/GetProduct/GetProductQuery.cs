using ArcTemplate.Application.DTOs;
using MediatR;

namespace ArcTemplate.Application.UseCases.GetProduct
{
    public class GetProductQuery : IRequest<ProductDTO>
    {
        public int Id { get; set; }
    }
}
