using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI_MVC.Models.ViewModels;
using UI_MVC.Services;

namespace UI_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICalculator _calculator;

        public HomeController(
            ILogger<HomeController> logger,
            ICalculator calculator)
        {
            _logger = logger;
            _calculator = calculator;
        }

        public IActionResult Index()
        {
            var sum = _calculator.Sum(1, 2);
            return View(sum);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
