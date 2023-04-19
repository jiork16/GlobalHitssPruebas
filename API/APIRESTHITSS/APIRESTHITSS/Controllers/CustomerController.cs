using APIRESTHITSS.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace APIRESTHITSS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRespository _customerRespository;

        public CustomerController(ICustomerRespository customerRespository)
        {
            _customerRespository = customerRespository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var customers =  await _customerRespository.GetListAsync();

            return StatusCode(customers != null ? StatusCodes.Status200OK : StatusCodes.Status204NoContent,
                new { value = customers == null ? null : customers } );
        }
        [HttpGet("getByCI")]
        public async Task<IActionResult> GetByCI(string CI)
        {
            var customers = await _customerRespository.GetByCIAsync(CI);
            return StatusCode(customers != null ? StatusCodes.Status200OK : StatusCodes.Status204NoContent,
                new { value = customers == null ? null : customers });

            //https://morioh.com/p/e5a235c363c9
            //https://www.youtube.com/watch?v=o6iqoPDr-nw&t=234s&ab_channel=hdeleon.net
        }
    }
}
