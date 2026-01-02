using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Sample2.Models;
using WebAPI_Sample2.Services;

namespace WebAPI_Sample2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var products=_productService.GetAll();
            return Ok(products);    

        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var product= _productService.GetById(id);
            if(product == null)
                return NotFound();
            return Ok(product);
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            _productService.Add(product);
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult Update(int id,Product product)
        {
            if(id!=product.Id)
                return BadRequest("Id Mismatch");
            var existing= _productService.GetById(id);
            if(existing == null)
            {
                return NotFound();
            }
            existing.ProductName = product.ProductName;
            existing.Description = product.Description;
            existing.Price = product.Price;

            _productService.Update(existing);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existing=_productService.GetById(id);
            if (existing == null)
                return NotFound();
            _productService.Delete(id);
            return Ok();
        }
    }
}
