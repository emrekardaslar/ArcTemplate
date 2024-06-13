using ArcTemplate.Core.Interfaces;

namespace ArcTemplate.Application.UseCases.GetCustomer
{
    public class GetCustomerHandler
    {
        private readonly ICustomerRepository _customerRepository;

        public GetCustomerHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public GetCustomerResponse Handle(GetCustomerRequest request)
        {
            var customer = _customerRepository.GetCustomerById(request.Id);
            return new GetCustomerResponse { Id = customer.Id, Name = customer.Name };
        }
    }
}
