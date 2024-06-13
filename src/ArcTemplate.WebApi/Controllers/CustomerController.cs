using Microsoft.AspNetCore.Mvc;
using ArcTemplate.Core.Interfaces;
using ArcTemplate.Application.UseCases.GetCustomer;

namespace ArcTemplate.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {
            var handler = new GetCustomerHandler(_customerRepository);
            var request = new GetCustomerRequest { Id = id };
            var response = handler.Handle(request);
            return Ok(response);
        }
    }
}
