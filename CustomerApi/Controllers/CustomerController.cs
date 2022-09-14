using Microsoft.AspNetCore.Mvc;
using CustomerApi.Dtos;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace CustomerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {

        [HttpGet]
        public async Task<List<CustomerDto>> GetCustomers()
        {
            throw new NotImplementedException();
        }


        [HttpGet("{id}")]
       public async Task<CustomerDto> GetCustomer(long id) 
        {
            throw new NotImplementedException();
        }


        [HttpDelete("{id}")]
        public async Task<bool> DeleteCustomer(long id)
        {
            throw new NotImplementedException();
        }


        [HttpPost]
        public async Task<CustomerDto> CreateCustomer(CreateCustomerDto customer)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<CustomerDto> UpdateCustomer(CustomerDto customer)
        {
            throw new NotImplementedException();
        }
    }
}
