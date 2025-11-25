using Microsoft.AspNetCore.Mvc;

namespace eShop.Areas.Identity.Controllers
{
    [Area(AreaConstants.Identity)]
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
