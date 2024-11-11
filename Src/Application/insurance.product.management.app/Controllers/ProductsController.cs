using Microsoft.AspNetCore.Mvc;

namespace insurance.product.management.app.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    { 
        return Ok("Hello World.");
    }
}