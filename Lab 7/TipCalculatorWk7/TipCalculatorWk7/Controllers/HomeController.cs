using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TipCalculatorWk7.Models;

namespace TipCalculatorWk7.Controllers
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
         ViewBag.Fifteen = 0;
         ViewBag.Twenty = 0;
         Viewbag.TwentyFive = 0;  
         View();                  

      }

      [HttpPost]
      public IActionResult Index(TipCalculator calc)
      {
         if (ModelState.IsValid)
         {
            ViewBag.Fifteen = calc.CalculateTip(0.15);
            ViewBag.Twenty = calc.CalculateTip(0.20);
            ViewBag.TwentyFive = calc.CalculateTip(0.25);
         }
         else
         {
            ViewBag.Fifteen = 0;
            ViewBag.Twenty = 0;
            ViewBag.TwentyFive = 0;
         }
         return View(calc);
      }
   }
}