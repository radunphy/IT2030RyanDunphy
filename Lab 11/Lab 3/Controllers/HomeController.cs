using Lab_3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Tools()
        {
            HttpContext.Session.SetString("Course", "IT2030");
            HttpContext.Session.SetString("StudentID", "S01131630");
            HttpContext.Session.SetInt32("CurrentDate", 202212018);

            ViewBag.TaxAmount = 0;
            ViewBag.TotalSalePrice = 0;
            return View();
        }

        [HttpPost]   

        public IActionResult Tools(Sale productSale)
        {
            if (ModelState.IsValid)
            {
                ViewBag.TaxAmount = productSale.TaxAmount();
                ViewBag.TotalSalePrice = productSale.TotalSalePrice();
            }
            else
            {
                ViewBag.TaxAmount = 0;
                ViewBag.TotalSalePrice = 0;
            }
            return View(productSale);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}