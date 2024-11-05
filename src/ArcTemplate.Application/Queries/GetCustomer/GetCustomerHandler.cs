using ArcTemplate.Application.DTOs;
using MediatR;
using ArcTemplate.Core.Interfaces;

namespace ArcTemplate.Application.UseCases.GetCustomer
{
    public class GetCustomerHandler : IRequestHandler<GetCustomerQuery, CustomerDTO>
    {
        private readonly ICustomerRepository _customerRepository;

        public GetCustomerHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Task<CustomerDTO> Handle(GetCustomerQuery query, CancellationToken cancellationToken)
        {
            var customer = _customerRepository.GetCustomerById(query.Id);
            
            if (customer == null)
            {
                throw new KeyNotFoundException($"Customer with ID {query.Id} was not found.");
            }
            
            return Task.FromResult(new CustomerDTO { Id = customer.Id, Name = customer.Name });
        }
    }
}
