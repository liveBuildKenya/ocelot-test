using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Product.Microservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {

        public ProductsController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return "Product Microservice";
        }
    }
}
