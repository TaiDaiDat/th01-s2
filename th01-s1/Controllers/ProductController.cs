using Microsoft.AspNetCore.Mvc;
using th01_s1.Models.Interfaces;

namespace th01_s1.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Shop()
        {
            return View(productRepository.GetAllProducts());
        }

    }
}
