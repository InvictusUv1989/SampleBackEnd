using Microsoft.AspNetCore.Mvc;
using SampleBackEnd.Model;
using SampleBackEnd.Services;

namespace SampleBackEnd.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public List<Customer> GetCustomer()
        {
            return CustomerService.GetCustomer();
        }

        [HttpGet("AliasName", Name = "NotTheMethodName")]
        public Customer GetCustomerById(string customerId)
        {
            return CustomerService.GetCustomerById(customerId);
        }
    }
}
