﻿using APIRESTHITSS.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIRESTHITSS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerRespository _customerRespository;

        public CustomerController(ICustomerRespository customerRespository)
        {
            _customerRespository = customerRespository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var products = _customerRespository.GetListAsync();
            return new OkObjectResult(products);
            //https://morioh.com/p/e5a235c363c9
            //https://www.youtube.com/watch?v=o6iqoPDr-nw&t=234s&ab_channel=hdeleon.net
        }
    }
}
