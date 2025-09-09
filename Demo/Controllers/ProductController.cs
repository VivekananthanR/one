using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private static readonly List<string> products = new()
        {
            "Laptop",
            "Mobile",
            "Tablet"
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(products);
        }
    }
}
