using Microsoft.AspNetCore.Mvc;

namespace eShop.Areas.Admin.Controllers
{
    [Area(AreaConstants.Admin)]
    public class UsersManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
