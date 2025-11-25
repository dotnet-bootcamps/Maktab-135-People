using Microsoft.AspNetCore.Mvc;

namespace eShop.Areas.Identity.Controllers
{
    [Area(AreaConstants.Identity)]
    public class ResetPasswordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
