using Arithemetic_Calc.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Arithemetic_Calc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly CalculatorService service= new CalculatorService();
        [HttpGet("Add")]
        public IActionResult Add(int a,int b)
        {
            return Ok(service.Add(a, b));
        }
        public IActionResult Difference(int a, int b)
        {
            return Ok(service.Difference(a,b)); 
        }
        public IActionResult Product(int a, int b)
        {
            return Ok(service.Product(a,b));
        }
        public IActionResult Division(int a, int b)
        {
            return Ok(service.Division(a,b));
        }
    }
}
