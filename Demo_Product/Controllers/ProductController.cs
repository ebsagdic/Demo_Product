using BusinessLayer.Abstract;
using BusinessLayer.FluentValidation;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo_Product.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;   
        }
        public IActionResult Index()
        {
            var values = _productService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            ProductValidator validationRules = new ProductValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
                _productService.TInsert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorCode);
                }
                return View();
            }
        }

        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.GetById(id);
            _productService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = _productService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product p)
        {
            _productService.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
