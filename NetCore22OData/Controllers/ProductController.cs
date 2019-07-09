using FizzWare.NBuilder;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace NetCore22OData.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [EnableQuery()]
        public IEnumerable<Product> GetProducts()
        {
            var products = Builder<Product>.CreateListOfSize(10).Build();
            return products;
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SmallDescription { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
    }
}