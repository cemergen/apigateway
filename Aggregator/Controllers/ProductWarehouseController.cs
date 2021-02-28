using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Microservice1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductWarehouseController : ControllerBase
    {
        readonly IHttpClientFactory HttpClientFactory;

        public ProductWarehouseController(IHttpClientFactory httpClientFactory)
        {
            HttpClientFactory = httpClientFactory;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var httpClient = HttpClientFactory.CreateClient();
            var prodduct1 =  await httpClient.GetAsync("http://localhost:5001/api/product/" + id);
            var c1 = await prodduct1.Content.ReadAsStringAsync();

            var prodduct2 =  await httpClient.GetAsync("http://localhost:5002/api/warehouse/" + c1);
            var c2 = await prodduct2.Content.ReadAsStringAsync();
            return Ok($"{c2}");
        }
    }
}
