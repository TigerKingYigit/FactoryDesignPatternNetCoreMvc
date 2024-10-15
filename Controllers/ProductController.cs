using FactoryDesignPattern.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FactoryDesignPattern.Controllers
{
    public class ProductController:Controller
    {
        private readonly IProductFactory _productFactory;
        public ProductController(IProductFactory productFactory)
        {
            _productFactory = productFactory;
        }
        public IActionResult Index()
        {
            var product = _productFactory.CreateOptionalProduct();

            return View(product);
        }
    }
}
