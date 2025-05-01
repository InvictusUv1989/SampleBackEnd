using Microsoft.AspNetCore.Mvc;
using SampleBackEnd.Model;
using SampleBackEnd.Services;

namespace SampleBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("getproducts")]
        public List<Product> GetProducts()
        {
            return ProductService.GetProductData();
        }

        [HttpGet]
        public Product GetProductByCode(string productCode)
        {
            return ProductService.GetProductByCode(productCode);
        }
    }
}
