using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        List<string> Data = new List<string>
        {
            "product1",
            "product2"
        };
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(Data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(Data[id]);
        }
    }
}
