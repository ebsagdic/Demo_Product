using BusinessLayer.Abstract;
using BusinessLayer.FluentValidation;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public IActionResult Index()
        {
            var value = _customerService.TGetList();
            return View(value);
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer c)
        {
            CustomerValidator validationRules = new CustomerValidator();
            ValidationResult result = validationRules.Validate(c);
            if (result.IsValid)
            {
                _customerService.TInsert(c);
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

        public IActionResult DeleteCustomer(int id)
        {
            var value = _customerService.GetById(id);
            _customerService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var value = _customerService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCustomer(Customer c)
        {
            _customerService.TUpdate(c);
            return RedirectToAction("Index");
        }
    }
}
