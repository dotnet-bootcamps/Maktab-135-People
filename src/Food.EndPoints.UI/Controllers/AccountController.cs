using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Food.EndPoints.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser<int>> _signInManager;
        private readonly UserManager<IdentityUser<int>> _userManager;

        public AccountController(
            SignInManager<IdentityUser<int>> signInManager,
            UserManager<IdentityUser<int>> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
