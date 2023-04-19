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
            try
            {
                var customers = await _customerRespository.GetListAsync();

                return StatusCode(customers != null ? StatusCodes.Status200OK : StatusCodes.Status204NoContent,
                    new { value = customers == null ? null : customers });
            }
            catch (Exception ex)
            {
                return StatusCode( StatusCodes.Status500InternalServerError, new { value = ex.Message });
            }
          
        }
        [HttpGet("getByCI")]
        public async Task<IActionResult> GetByCI(string CI)
        {
            try
            {
                var customers = await _customerRespository.GetByCIAsync(CI);
                return StatusCode(customers != null ? StatusCodes.Status200OK : StatusCodes.Status204NoContent,
                    new { value = customers == null ? null : customers });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { value = ex.Message });
            }

        }
    }
}
