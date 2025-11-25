using Microsoft.AspNetCore.Mvc;

namespace eShop.Areas.Admin.Controllers
{
    [Area(AreaConstants.Admin)]
    public class ProductManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult ChangeStatus()
        {
            return View();
        }
    }
}
