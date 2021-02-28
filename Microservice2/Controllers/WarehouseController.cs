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
    public class WarehouseController : ControllerBase
    {
        Dictionary<string, string> ProdudctWarehose = new Dictionary<string, string>
        {
            {"product1","warehouse1" },
            {"product2","warehouse2" }
        };
        [HttpGet("{productId}")]
        public async Task<IActionResult> Get(string productId)
        {
            return Ok(ProdudctWarehose[productId]);
        }
    }
}
