using Lab_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_3.Controllers
{
    public class SupportController : Controller
    {
        [HttpGet]
        public IActionResult Support()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Support(Customer customer)
        {
            var Customer = new Customer();
            return View(customer);
        }
    }
}
