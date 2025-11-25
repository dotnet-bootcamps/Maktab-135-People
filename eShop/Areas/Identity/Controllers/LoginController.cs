using Microsoft.AspNetCore.Mvc;

namespace eShop.Areas.Identity.Controllers
{
    [Area(AreaConstants.Identity)]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
