using MediatR;
using ArcTemplate.Core.Interfaces;

namespace ArcTemplate.Application.UseCases.GetCustomer
{
    public class GetCustomerHandler : IRequestHandler<GetCustomerQuery, GetCustomerResponse>
    {
        private readonly ICustomerRepository _customerRepository;

        public GetCustomerHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Task<GetCustomerResponse> Handle(GetCustomerQuery query, CancellationToken cancellationToken)
        {
            var customer = _customerRepository.GetCustomerById(query.Id);
            return Task.FromResult(new GetCustomerResponse { Id = customer.Id, Name = customer.Name });
        }
    }
}
