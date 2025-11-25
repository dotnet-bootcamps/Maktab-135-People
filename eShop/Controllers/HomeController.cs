using eShop.Model;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            new Service1().Calculate(0);
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }
    }
}
