using ArcTemplate.Application.DTOs;
using MediatR;

namespace ArcTemplate.Application.UseCases.GetCustomer
{
    public class GetCustomerQuery : IRequest<CustomerDTO>
    {
        public int Id { get; set; }
    }
}
